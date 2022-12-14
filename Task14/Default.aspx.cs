using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task14
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlCountry.DataSource = GetCountry();
                ddlCountry.DataBind();
                ddlCountry.Items.Insert(0, "--Select--");
            }
            txtDate.Attributes["max"] = "2090-01-01";
            txtDate.Attributes["min"] = "1900-01-01";
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            AddCookie();

            string strScript = "alert('The Cookie stored in the browser is "+ ReadCookie() +"')";

            ScriptManager.RegisterStartupScript(this.Page,typeof(Page),"ScriptKey",strScript,true);
        }

        public void AddCookie()
        {
            HttpCookie usernameCookie = new HttpCookie("name");

            usernameCookie.Values["name"] = txtUsername.Text;

            usernameCookie.Expires = DateTime.Now.AddDays(1);

            Response.Cookies.Add(usernameCookie);
        }

        public string ReadCookie()
        {
            HttpCookie userCookie = Request.Cookies["name"];

            string userName = userCookie != null ? userCookie.Value.Split('=')[1] : "undefined";

            return userName;
        }

        public List<string> GetCountry()
        {
            List<string> list = new List<string>();
            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            foreach (CultureInfo info in cultures)
            {
                RegionInfo info2 = new RegionInfo(info.LCID);
                if (!list.Contains(info2.EnglishName))
                {
                    list.Add(info2.EnglishName);
                }
            }
            return list;
        }
    }
}