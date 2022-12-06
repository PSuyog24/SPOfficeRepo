using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task11
{
    public partial class _Default : Page
    {
        private List<string> lsOperations = new String[] { "Addition","Subtraction" }.ToList();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlOperation.Items.Insert(1, lsOperations[0]);
                ddlOperation.Items.Insert(2, lsOperations[1]);
            }
        }

        protected void btnResult_Click(object sender, EventArgs e)
        {
            if(ddlOperation.SelectedIndex == 1)
            {
                txtResult.Text = Convert.ToString(Convert.ToInt64(txtDigit1.Text) + Convert.ToInt64(txtDigit2.Text));
            }
            else if(ddlOperation.SelectedIndex == 2)
            {
                txtResult.Text = Convert.ToString(Convert.ToInt64(txtDigit1.Text) - Convert.ToInt64(txtDigit2.Text));
            }
        }
    }
}