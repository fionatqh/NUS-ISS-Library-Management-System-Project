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
    public partial class ListOfBooksForm : Form
    {
        public ListOfBooksForm()
        {
            InitializeComponent();
        }

        private void ListOfBooksForm_Load(object sender, EventArgs e)
        {
            Team10bDS context = new Team10bDS();
            Team10bDSTableAdapters.BooksTableAdapter ta = new Team10bDSTableAdapters.BooksTableAdapter();
            ta.Fill(context.Books);
            ListOfBooks cr = new ListOfBooks();
            cr.SetDataSource(context);
            ListOfBookCRViewer.ReportSource = cr;
        }
    }
}
