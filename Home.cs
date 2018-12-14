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
    public partial class Home : Form
    {
        Form mainPage;
        SA47_Team10BCADatabaseEntities context;
        public Home()
        {
            InitializeComponent();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            context = new SA47_Team10BCADatabaseEntities();
            dateTimeLabel.Text = DateTime.Now.ToString();
            IssuedQtyLabel.Text = context.Books.Sum(x => x.NumberBorrowed).ToString();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string message = "Exit Program?";
            const string caption = "Program Closing";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void searchBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool formfound = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "BooksSearch")
                {
                    frm.Focus();
                    formfound = true;
                }
            }
            if (formfound == false)
            {
                BooksSearch f = new BooksSearch();
                f.MdiParent = this;
                f.Show();
            }
            groupBox1.SendToBack();
        }

        private void searchMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool formfound = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "SearchMemberForm")
                {
                    frm.Focus();
                    formfound = true;
                }
            }
            if (formfound == false)
            {
                SearchMemberForm f = new SearchMemberForm();
                f.MdiParent = this;
                f.Show();
            }
            groupBox1.SendToBack();
        }


        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool formfound = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "BookMaintain")
                {
                    frm.Focus();
                    formfound = true;
                }
            }
            if (formfound == false)
            {
                BookMaintain f = new BookMaintain();
                f.MdiParent = this;
                f.Show();
            }
            groupBox1.SendToBack();
        }

        private void updateMemberToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool formfound = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "UpdateMemberForm")
                {
                    frm.Focus();
                    formfound = true;
                }
            }
            if (formfound == false)
            {
                UpdateMemberForm f = new UpdateMemberForm();
                f.MdiParent = this;
                f.Show();
            }
            groupBox1.SendToBack();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool formfound = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "Return_Book")
                {
                    frm.Focus();
                    formfound = true;
                }
            }
            if (formfound == false)
            {
                Return_Book f = new Return_Book();
                f.MdiParent = this;
                f.Show();
            }
            groupBox1.SendToBack();
        }

        private void issueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool formfound = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "Issue_Book")
                {
                    frm.Focus();
                    formfound = true;
                }
            }
            if (formfound == false)
            {
                Issue_Book f = new Issue_Book();
                f.MdiParent = this;
                f.Show();
            }
            groupBox1.SendToBack();
        }

        private void listOfBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool formfound = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "ListOfBooksForm")
                {
                    frm.Focus();
                    formfound = true;
                }
            }
            if (formfound == false)
            {
                ListOfBooksForm f = new ListOfBooksForm();
                f.MdiParent = this;
                f.Show();
            }
            groupBox1.SendToBack();
        }

        private void crossTabReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool formfound = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "CrossTabReportForm")
                {
                    frm.Focus();
                    formfound = true;
                }
            }
            if (formfound == false)
            {
                CrossTabReportForm f = new CrossTabReportForm();
                f.MdiParent = this;
                f.Show();
            }
            groupBox1.SendToBack();
        }

        private void TransactionRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool formfound = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "TransactionReportForm")
                {
                    frm.Focus();
                    formfound = true;
                }
            }
            if (formfound == false)
            {
                TransactionReportForm f = new TransactionReportForm();
                f.MdiParent = this;
                f.Show();
            }
            groupBox1.SendToBack();
        }

        private void issueReturnRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool formfound = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "IssueReturnList")
                {
                    frm.Focus();
                    formfound = true;
                }
            }
            if (formfound == false)
            {
                IssueReturnList f = new IssueReturnList();
                f.MdiParent = this;
                f.Show();
            }
            groupBox1.SendToBack();
        }

    }
}
