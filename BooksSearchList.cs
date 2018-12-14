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
    public partial class BooksSearchList : Form
    {
        string Book_Name, Author, publisher, Edition,Category, Total_Quantity, Number_Borrowed;
        int Book_ID;
        public string Book_Name1
        {
            get { return Book_Name; }
        }
        public string Author1
        {
            get { return Author; }
        }
        public string Publisher1
        {
            get { return publisher; }
        }
        public string Edition1
        {
            get { return Edition; }
        }
        public string Category1
        {
            get { return Category; }
        }
        public string Total_Quantity1
        {
            get { return Total_Quantity; }
        }
        public string Number_Borrowed1
        {
            get { return Number_Borrowed; }
        }
        public int Book_ID1
        {
            get { return Book_ID; }
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public BooksSearchList()
        {
            InitializeComponent();
        }

        private void MemberSearchList_Load(object sender, EventArgs e)
        {
            SA47_Team10BCADatabaseEntities context = new SA47_Team10BCADatabaseEntities();
            dataGridView1.DataSource = context.Books.ToList();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            Book_Name = row.Cells["BookName"].Value.ToString();
            Author= row.Cells["Author"].Value.ToString();
            publisher = row.Cells["Publisher"].Value.ToString();
            Edition = row.Cells["Edition"].Value.ToString();
            Category = row.Cells["Category"].Value.ToString();
            Total_Quantity = row.Cells["TotalQuantity"].Value.ToString();
            Number_Borrowed = row.Cells["NumberBorrowed"].Value.ToString();
            Book_ID = Convert.ToInt32(row.Cells["BookID"].Value);
            DialogResult = DialogResult.OK;
        }
    }
}
