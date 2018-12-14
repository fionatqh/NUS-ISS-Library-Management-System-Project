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
    public partial class BooksSearch : Form
    {
        SA47_Team10BCADatabaseEntities context = new SA47_Team10BCADatabaseEntities();
        public BooksSearch()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BooksSearchList a = new BooksSearchList();
            DialogResult b = a.ShowDialog();
            if(b==DialogResult.OK)
            {
                Book_NameBox.Text = a.Book_Name1;
                AuthorBox.Text =a.Author1;
                publisherBox.Text =a.Publisher1;
                EditionBox.Text =a.Edition1;
                CategoryBox.Text = a.Category1;
                Total_QuantityBox.Text =a.Total_Quantity1;
                Number_BorrowedBox.Text =a.Number_Borrowed1;
                Retrieve_BookNumeric.Value = a.Book_ID1;
                if(Total_QuantityBox.Text==Number_BorrowedBox.Text)
                {
                    IssueReturn c = context.IssueReturn.Where(x => x.BookID == Retrieve_BookNumeric.Value).OrderBy(x => x.DateExpiry).First();
                    Can_Borrow_DateBox.Text = c.DateExpiry.ToLongDateString();
                }
                else
                {
                    Can_Borrow_DateBox.Text = "now";
                }
            }
        }

        private void Retrieve_Book_Click(object sender, EventArgs e)
        {
            var BID = from x in context.Books where x.BookID == Retrieve_BookNumeric.Value select x;
            List<Books> b = BID.ToList<Books>();
            if (b.Count != 0)
            {
                Books c = context.Books.Where(x => x.BookID == Retrieve_BookNumeric.Value).First();
                Book_NameBox.Text = c.BookName;
                AuthorBox.Text = c.Author;
                publisherBox.Text = c.Publisher;
                EditionBox.Text = c.Edition;
                CategoryBox.Text = c.Category;
                Total_QuantityBox.Text = c.TotalQuantity.ToString();
                Number_BorrowedBox.Text = c.NumberBorrowed.ToString();
                if (Total_QuantityBox.Text == Number_BorrowedBox.Text)
                {
                    IssueReturn q = context.IssueReturn.Where(x => x.BookID == Retrieve_BookNumeric.Value).OrderBy(x => x.DateExpiry).First();
                    Can_Borrow_DateBox.Text = q.DateExpiry.ToLongDateString();
                }
                else
                {
                    Can_Borrow_DateBox.Text = "Now";
                }
            }
            else
            {
                Book_NameBox.Text = "";
                AuthorBox.Text = "";
                publisherBox.Text = "";
                EditionBox.Text = "";
                CategoryBox.Text = "";
                Total_QuantityBox.Text = "";
                Number_BorrowedBox.Text = "";
                Can_Borrow_DateBox.Text = "";
                MessageBox.Show("Please re-enter BookID.");
            }
        }
    }
}
