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
    public partial class SearchMemberForm : Form, IPopulate
    {
        SA47_Team10BCADatabaseEntities context;
        int memID;
        public SearchMemberForm()
        {
            InitializeComponent();
        }
        public int MemID
        {
            get { return memID; }
        }

        private void SearchMemberForm_Load(object sender, EventArgs e)
        {
            context = new SA47_Team10BCADatabaseEntities();
        }
        public void RetrieveMemberDetails()
        {
            try
            {
                memID = (int)MemIDNumericUpDown.Value;
                Members m = context.Members.Where(x => x.MemberID == memID).First();
                PopulateMemberDetails(m);
                MemberToolStripStatusLabel.Text = "Loaded Member ID: " + memID.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Member record is not found. Please input a correct Member ID.");
                MemIDNumericUpDown.Value = 0;
                MemberNameTextBox.Text = "";
                PhoneNumberTextBox.Text = "";
                AddressTextBox.Text = "";
                QtyBorrowedTextBox.Text = "";
                MemberToolStripStatusLabel.Text = "Status";
            }
        }
        public void PopulateMemberDetails(Members m)
        {
            MemberNameTextBox.Text = m.MemberName;
            PhoneNumberTextBox.Text = m.PhoneNumber;
            AddressTextBox.Text = m.Address;
            QtyBorrowedTextBox.Text = m.NumberOfBooksBorrowed.ToString();
        }

        private void RetrieveButton_Click(object sender, EventArgs e)
        {
            RetrieveMemberDetails();
        }

        private void MemIDNumericUpDown_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter || e.KeyValue == (char)Keys.Space)
            {
                RetrieveMemberDetails();
            }
        }

        private void MemListButton_Click(object sender, EventArgs e)
        {
            MemberListForm f = new MemberListForm();
            DialogResult r = f.ShowDialog();
            if (r == DialogResult.OK)
            {
                Members m = f.Member;
                memID = m.MemberID;
                MemIDNumericUpDown.Value = memID;
                PopulateMemberDetails(m);
                MemberToolStripStatusLabel.Text = "Loaded Member ID: " + memID.ToString();
            }
        }

        private void BorrowRecButton_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(QtyBorrowedTextBox.Text);
            if (n > 0)
            {
                BorrowRecordForm f = new BorrowRecordForm();
                f.SetMemberID(MemID);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("This member has no borrow record.");
            }
        }

    }
}
