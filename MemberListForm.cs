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
    public partial class MemberListForm : Form
    {
        SA47_Team10BCADatabaseEntities context;
        Members member;
        public MemberListForm()
        {
            InitializeComponent();
        }
        public Members Member
        {
            get { return member; }
        }

        private void MemberListForm_Load(object sender, EventArgs e)
        {
            context = new SA47_Team10BCADatabaseEntities();
            MemListDataGridView.DataSource = context.Members.Select(x => new { x.MemberID, x.MemberName, x.PhoneNumber }).ToList();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = MemListDataGridView.SelectedRows[0];
            int n = (int)selectedRow.Cells["MemberID"].Value;
            member = context.Members.Where(x => x.MemberID == n).First();
            DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
