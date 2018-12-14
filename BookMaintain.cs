using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA_Team10bCAProject
{
    public partial class BookMaintain : Form
    {
        SA47_Team10BCADatabaseEntities context = new SA47_Team10BCADatabaseEntities();
        public BookMaintain()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BookMaintainList a = new BookMaintainList();
            DialogResult b = a.ShowDialog();
            if (b == DialogResult.OK)
            {
                Book_NameBox.Text = a.Book_Name1;
                AuthorBox.Text = a.Author1;
                publisherBox.Text = a.Publisher1;
                EditionBox.Text = a.Edition1;
                CategoryBox.Text = a.Category1;
                Total_QuantityNumeric.Value = a.Total_Quantity1;
                Number_BorrowedNumeric.Value = a.Number_Borrowed1;
                BookRetrieveNumeric.Value = a.Book_ID1;
            }
        }

        private void Retrieve_Book_Click(object sender, EventArgs e)
        {
            var BID = from x in context.Books where x.BookID == BookRetrieveNumeric.Value select x;
            List<Books> b = BID.ToList<Books>();
            if (b.Count != 0)
            {
                Books c = context.Books.Where(y => y.BookID == BookRetrieveNumeric.Value).First();
                Book_NameBox.Text = c.BookName;
                AuthorBox.Text = c.Author;
                publisherBox.Text = c.Publisher;
                EditionBox.Text = c.Edition;
                CategoryBox.Text = c.Category;
                Total_QuantityNumeric.Value = Convert.ToDecimal(c.TotalQuantity);
                Number_BorrowedNumeric.Value = Convert.ToDecimal(c.NumberBorrowed);
            }
            else
            {
                Book_NameBox.Text = "";
                AuthorBox.Text ="";
                publisherBox.Text = "";
                EditionBox.Text = "";
                CategoryBox.Text = "";
                Total_QuantityNumeric.Value = 0;
                Number_BorrowedNumeric.Value = 0;
                MessageBox.Show("BookID does not exist. Please re-enter.");
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            var BID = from x in context.Books where x.BookID == BookRetrieveNumeric.Value select x;
            List<Books> b = BID.ToList<Books>();
            if (b.Count != 0)
            {
                Books c = context.Books.Where(x => x.BookID == BookRetrieveNumeric.Value).First();
                c.BookName = Book_NameBox.Text;
                c.Author = AuthorBox.Text;
                c.Publisher = publisherBox.Text;
                c.Edition = EditionBox.Text;
                c.Category = CategoryBox.Text;
                c.TotalQuantity = (int)Total_QuantityNumeric.Value;
                context.SaveChanges();
                MessageBox.Show("Update succeed");
            }
            else
            {
                MessageBox.Show("BookID does not exist. Please re-enter.");
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            
            Books c = new Books();
            c.BookName = Book_NameBox.Text;
            c.Author = AuthorBox.Text;
            c.Publisher = publisherBox.Text;
            c.Edition = EditionBox.Text;
            c.Category = CategoryBox.Text;
            c.TotalQuantity = (int)Total_QuantityNumeric.Value;
            context.Books.Add(c);
            context.SaveChanges();
            int k = c.BookID;
            MessageBox.Show("Add succeed,BookID is "+k);
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            var BID = from x in context.Books where x.BookID == BookRetrieveNumeric.Value select x;
            List<Books> b = BID.ToList<Books>();
            var BID2 = from x in context.IssueReturn where x.BookID == BookRetrieveNumeric.Value select x;
            List<IssueReturn> d = BID2.ToList<IssueReturn>();
            if (b.Count != 0)
            {
                if (d.Count == 0)
                {
                    Books c = context.Books.Where(x => x.BookID == BookRetrieveNumeric.Value).First();
                    context.Books.Remove(c);
                    context.SaveChanges();
                    MessageBox.Show("Delete succeed");
                }
                else
                {
                    MessageBox.Show("Book recorded in Issue-Return Transaction. Book cannot be deleted.");
                }
            }
            else
            {
                MessageBox.Show("BookID does not exist. Please re-enter.");
            }
        }
    }
}
