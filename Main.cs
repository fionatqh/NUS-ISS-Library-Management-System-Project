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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            dateTimeLabel.Text = DateTime.Now.ToString();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            DialogResult a = login.ShowDialog();
            if (a == DialogResult.OK)
            {
                Home f = new Home();
                f.ShowDialog();
            }
        }

        private void guestLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BooksSearch booksSearch = new BooksSearch();
            booksSearch.ShowDialog();
        }
    }
}
