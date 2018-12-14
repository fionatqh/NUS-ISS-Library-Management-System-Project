using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Transactions;

namespace SA_Team10bCAProject
{
    public partial class Issue_Book : Form
    {
        SA47_Team10BCADatabaseEntities context = new SA47_Team10BCADatabaseEntities();
        public Issue_Book()
        {
            InitializeComponent();
        }

        private void btn_iss_book_Click(object sender, EventArgs e)
        {
            try
            {
                int memID = Convert.ToInt32(txtmemid.Text);
                Members m = context.Members.Where(x => x.MemberID == memID).First();
                try
                {
                    int bookID = Convert.ToInt32(txtbookid.Text);
                    Books b = context.Books.Where(x => x.BookID == bookID).First();

                    if (b.TotalQuantity > b.NumberBorrowed)
                    {
                        if (dateTimePicker1.Value.Date > DateTime.Now.Date)
                        {
                            using (TransactionScope ts = new TransactionScope())
                            {
                                IssueReturn ir = new IssueReturn();
                                ir.MemberID = memID;
                                ir.BookID = bookID;
                                ir.DateIssue = DateTime.Now.Date;
                                ir.DateExpiry = dateTimePicker1.Value.Date;
                                ir.Remarks = txtremk.Text;
                                ir.LoanStatus = "OUT";
                                context.IssueReturn.Add(ir);

                                b.NumberBorrowed += 1;

                                m.NumberOfBooksBorrowed += 1;

                                context.SaveChanges();
                                MessageBox.Show("Issue successful.");

                                IssueDateTextBox.Text = ir.DateIssue.ToShortDateString();
                                toolStripStatusLabel2.Text = "Transaction ID: " + ir.TransactionID.ToString();

                                ts.Complete();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Expiry Date is invalid.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Book is not available.");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please input correct Book ID.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please input correct Member ID.");
            }
        }

        private void btn_mem_Click(object sender, EventArgs e)
        {
            MemberListForm mem = new MemberListForm();
            DialogResult r = mem.ShowDialog();
            if (r == DialogResult.OK)
            {
                txtmemid.Text = mem.Member.MemberID.ToString();
            }

        }

        private void btn_iss_book_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click to Issue Book";
        }

        private void btn_iss_book_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void btn_bookid_Click(object sender, EventArgs e)
        {
            BooksSearchList bs = new BooksSearchList();
            DialogResult r = bs.ShowDialog();
            if (r == DialogResult.OK)
            {
                txtbookid.Text = bs.Book_ID1.ToString();
                txtbooktitle.Text = bs.Book_Name1.ToString();
            }
        }

        private void btn_can_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbookid_Leave(object sender, EventArgs e)
        {
            try
            {
                int bookID = Convert.ToInt32(txtbookid.Text);
                Books b = context.Books.Where(x => x.BookID == bookID).First();
                txtbooktitle.Text = b.BookName;
            }
            catch (Exception)
            {
                MessageBox.Show("Please input correct Book ID.");
                txtbooktitle.Text = "";
            }
        }
    }
}
