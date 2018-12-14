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
    public partial class UpdateMemberForm : Form, IPopulate
    {
        SA47_Team10BCADatabaseEntities context;
        int memID;

        public UpdateMemberForm()
        {
            InitializeComponent();
        }

        private void UpdateMemberForm_Load(object sender, EventArgs e)
        {
            context = new SA47_Team10BCADatabaseEntities();
        }

        public void PopulateMemberDetails(Members m)
        {
            MemberNameTextBox.Text = m.MemberName;
            PhoneMaskedTextBox.Text = m.PhoneNumber;
            AddressTextBox.Text = m.Address;
            QtyBorrowedTextBox.Text = m.NumberOfBooksBorrowed.ToString();
        }
        private void ReturnEmptyValue()
        {
            MemIDNumericUpDown.Value = 0;
            MemberNameTextBox.Text = "";
            PhoneMaskedTextBox.Text = "";
            AddressTextBox.Text = "";
            QtyBorrowedTextBox.Text = "";
            MemberToolStripStatusLabel.Text = "Status";
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
            catch (InvalidOperationException)
            {
                MessageBox.Show("Member record is not found. Please input a correct Member ID.");
                ReturnEmptyValue();
            }
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

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                memID = (int)MemIDNumericUpDown.Value;
                Members m = context.Members.Where(x => x.MemberID == memID).First();
                m.MemberName = MemberNameTextBox.Text;
                m.PhoneNumber = PhoneMaskedTextBox.Text;
                m.Address = AddressTextBox.Text;
                context.SaveChanges();
                MemberToolStripStatusLabel.Text = "Update Successful for Member ID: " + memID.ToString();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Member record is not found. Please input a correct Member ID.");
                ReturnEmptyValue();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Members m = new Members
            {
                MemberName = MemberNameTextBox.Text,
                PhoneNumber = PhoneMaskedTextBox.Text,
                Address = AddressTextBox.Text,
                NumberOfBooksBorrowed = 0
            };
            context.Members.Add(m);
            context.SaveChanges();

            memID = m.MemberID;
            MemberToolStripStatusLabel.Text = "Add Successful for Member ID: " + memID.ToString();
            MemIDNumericUpDown.Value = memID;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                memID = (int)MemIDNumericUpDown.Value;
                Members m = context.Members.Where(x => x.MemberID == memID).First();
                try
                {
                    context.Members.Remove(m);
                    context.SaveChanges();
                    ReturnEmptyValue();
                    MemberToolStripStatusLabel.Text = "Delete Successful for Member ID: " + memID.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Member recorded in Issue-Return Transaction. Member cannot be deleted.");
                }
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Member record is not found. Please input a correct Member ID.");
                ReturnEmptyValue();
            }
        }

    }
}
