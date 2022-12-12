using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task13
{
    public partial class _Default : Page
    {
        private List<string> lsOperations = new List<string>()
        {
            "Credit Card","UPI","Net Banking"
        };

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                for(int i = 1; i <= lsOperations.Count; i++)
                {
                    ddlPaymentMode.Items.Insert(i, lsOperations[i-1]);
                }
                lblPaymentDtls.Text = "--";
                txtPaymentDtls.Enabled = false;
            }
        }

        protected void btnGetResult_Click(object sender, EventArgs e)
        {
            Response.Redirect("PaymentPage.aspx");
        }

        protected void ddlPaymentMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlPaymentMode.SelectedIndex == 0)
            {
                lblPaymentDtls.Text = "--";
                txtPaymentDtls.Enabled = false;
            }
            else if(ddlPaymentMode.SelectedIndex == 1)
            {
                lblPaymentDtls.Text = "Enter Credit Card Number";
                txtPaymentDtls.Enabled = true;
                regPaymentValidate.ValidationExpression = "/^(?:4[0-9]{12}(?:[0-9]{3})?)$/";
                regPaymentValidate.ErrorMessage = "Invalid Credit Card Number";
            }
            else if(ddlPaymentMode.SelectedIndex == 2)
            {
                lblPaymentDtls.Text = "Enter UPI Id";
                txtPaymentDtls.Enabled = true;
            }
            else if(ddlPaymentMode.SelectedIndex == 3)
            {
                lblPaymentDtls.Text = "Enter Card Number";
                txtPaymentDtls.Enabled = true;
            }
        }
    }
}