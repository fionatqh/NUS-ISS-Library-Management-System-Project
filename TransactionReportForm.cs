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
    public partial class TransactionReportForm : Form
    {
        public TransactionReportForm()
        {
            InitializeComponent();
        }

        private void TransactionReportForm_Load(object sender, EventArgs e)
        {
            Team10bDS ds = new Team10bDS();
            Team10bDSTableAdapters.IssueReturnTableAdapter irta = new Team10bDSTableAdapters.IssueReturnTableAdapter();
            irta.Fill(ds.IssueReturn);
            TransactionReport tr = new TransactionReport();
            tr.SetDataSource(ds);
            TransactionReportCRViewer.ReportSource = tr;
        }
    }
}
