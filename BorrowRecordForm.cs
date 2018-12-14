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
    public partial class BorrowRecordForm : Form
    {
        SA47_Team10BCADatabaseEntities context;
        int memID;
        public BorrowRecordForm()
        {
            InitializeComponent();
        }
        public void SetMemberID(int n)
        {
            memID = n;
        }
        private void BorrowRecordForm_Load(object sender, EventArgs e)
        {
            context = new SA47_Team10BCADatabaseEntities();

            Members member = context.Members.Where(x => x.MemberID == memID).First();
            MemberNameLabel.Text = "Borrow Record of " + member.MemberName;

            BorrowRecordDataGridView.DataSource = context.IssueReturn.Where(x => x.MemberID == memID)
                .Select(x => new
                {
                    x.TransactionID,
                    x.MemberID,
                    x.BookID,
                    x.Book.BookName,
                    x.DateIssue,
                    x.DateExpiry,
                    x.DateReturn,
                    x.LoanStatus,
                    x.Remarks
                }).ToList();

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
