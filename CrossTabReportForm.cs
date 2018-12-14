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
    public partial class CrossTabReportForm : Form
    {
        public CrossTabReportForm()
        {
            InitializeComponent();
        }

        private void CrossTabReportForm_Load(object sender, EventArgs e)
        {
            Team10bDS ds = new Team10bDS();
            Team10bDSTableAdapters.BooksTableAdapter bta = new Team10bDSTableAdapters.BooksTableAdapter();
            bta.Fill(ds.Books);
            CrossTabReport cr = new CrossTabReport();
            cr.SetDataSource(ds);
            CrossTabCRViewer.ReportSource = cr;
        }
    }
}
