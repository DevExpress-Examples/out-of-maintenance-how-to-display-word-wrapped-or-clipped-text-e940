using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace WordWrapClippingAndEllipsis {
    public partial class _Default : System.Web.UI.Page {
        protected void Page_Init(object sender, EventArgs e) {
            ASPxGridView1.DataSource = GetData();
            ASPxGridView1.DataBind();
        }

        private DataTable GetData() {
            const string text1 = "The ASPxGridView is a data bound control that provides a two-dimensional representation of data from a data source in grid format.";
            const string text2 = "The ASPxGridView's appearance can be customized by setting the style properties for different visual elements.\r\n\r\nVarious visual elements display images.";

            DataTable table = new DataTable();
            table.Columns.Add("WordWrap");
            table.Columns.Add("Clipped");
            table.Columns.Add("Ellipsis");
            table.Rows.Add(text1, text1, text1);
            table.Rows.Add(text2, text2, text2);
            return table;
        }

        protected void Page_Load(object sender, EventArgs e) {

        }
    }
}
