using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _011_DataBindingConcept
{
    public partial class _2BindGrid : System.Web.UI.Page
    {
        protected System.Data.DataSet dataSet1;

        protected void Page_Load(object sender, EventArgs e)
        {
            dataSet1 = new DataSet();
            string path = Server.MapPath("~/App_Data");
            dataSet1.ReadXmlSchema(path + "\\XMLFile1.xsd");
            dataSet1.ReadXml(path + "\\XMLFile1.xml");
            Page.DataBind();
        }
    }
}