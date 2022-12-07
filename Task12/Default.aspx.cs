using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task12
{
    public class StoreItems
    {
        public string ItemName { get; set; }
        public string ItemCost { get; set; }
        public string ItemURL { get; set; }
    }

    public partial class _Default : Page
    {
        private List<StoreItems> lsItems = new List<StoreItems>()
        {
            new StoreItems{ItemName="Rose",ItemCost="INR. 100",ItemURL="~/App_LocalResources/Rose.jpg" },
            new StoreItems{ItemName="Crocuses",ItemCost="INR. 120",ItemURL="~/App_LocalResources/Crocuses.jpg" },
            new StoreItems{ItemName="Marigold",ItemCost="INR. 90",ItemURL="~/App_LocalResources/Marigold.jpg" }
        };

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                foreach (var item in lsItems)
                {
                    lstItemBox.Items.Add(item.ItemName);
                }
            }
        }

        protected void btnSelect_Click(object sender, EventArgs e)
        {
            foreach(var item in lsItems)
            {
                if (lstItemBox.SelectedItem.Text == item.ItemName)
                {
                    lblCost.Text = item.ItemCost;
                }
            }
        }

        protected void lstItemBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in lsItems)
            {
                if (item.ItemName == lstItemBox.SelectedItem.Text)
                {
                    imgShow.ImageUrl = item.ItemURL;
                }
            }
        }
    }
}