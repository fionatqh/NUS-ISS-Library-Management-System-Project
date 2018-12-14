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
    public partial class IssueReturnList : Form
    {
        public IssueReturnList()
        {
            InitializeComponent();
        }

        private void IssueReturnList_Load(object sender, EventArgs e)
        {
            SA47_Team10BCADatabaseEntities context = new SA47_Team10BCADatabaseEntities();
            dataGridView2.DataSource = context.IssueReturn.Select
                (x => new
                {
                    x.TransactionID,
                    x.MemberID,
                    x.BookID,
                    x.DateExpiry,
                    x.DateIssue,
                    x.DateReturn,
                    x.LoanStatus,
                    x.Remarks
                }).ToList();
        }
    }
}
