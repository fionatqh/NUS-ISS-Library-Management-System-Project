using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;

namespace SA_Team10bCAProject
{
    public partial class Return_Book : Form
    {
        SA47_Team10BCADatabaseEntities context = new SA47_Team10BCADatabaseEntities();
        public Return_Book()
        {
            InitializeComponent();
        }

        private void btn_mem1_Click(object sender, EventArgs e)
        {
            MemberListForm mem = new MemberListForm();
            DialogResult r = mem.ShowDialog();
            if (r == DialogResult.OK)
            {
                txtmemid1.Text = mem.Member.MemberID.ToString();
            }
        }

        private void btn_ret_book_Click(object sender, EventArgs e)
        {
            try
            {
                int tranID = Convert.ToInt32(TransIDnumericUpDown.Value);
                IssueReturn ir = context.IssueReturn.Where(x => x.TransactionID == tranID).First();

                txtmemid1.Text = ir.MemberID.ToString();
                txtbookid1.Text = ir.BookID.ToString();
                txtbooktile1.Text = ir.Book.BookName;

                if (ir.Book.NumberBorrowed > 0 && ir.Member.NumberOfBooksBorrowed > 0)
                {
                    using (TransactionScope ts = new TransactionScope())
                    {
                        ir.DateReturn = DateTime.Now.Date;
                        ir.LoanStatus = "IN";

                        ir.Book.NumberBorrowed -= 1;

                        ir.Member.NumberOfBooksBorrowed -= 1;

                        context.SaveChanges();

                        MessageBox.Show("Return successful.");

                        ReturnDateTextBox.Text = ir.DateReturn.Value.ToShortDateString();

                        ts.Complete();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please input correct Transaction ID.");
                txtmemid1.Text = "";
                txtbookid1.Text = "";
                txtbooktile1.Text = "";
                ReturnDateTextBox.Text = "";
            }

        }
        private void btncan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

