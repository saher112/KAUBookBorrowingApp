using System;
using System.Windows.Forms;

namespace KAUBookBorrowingApp
{
    public partial class SummaryForm : Form
    {
        public SummaryForm()
        {
            InitializeComponent();
        }

        // Safe setter to update the summary at runtime
        public void SetSummary(string summaryText)
        {
            if (txtSummary != null)
            {
                txtSummary.Text = summaryText;
            }
        }

        private void txtSummary_TextChanged(object sender, EventArgs e)
        {
            // You can leave this empty
        }
    }
}
