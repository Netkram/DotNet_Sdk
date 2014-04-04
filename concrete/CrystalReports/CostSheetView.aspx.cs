using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using CrystalDecisions.Web;
using CrystalDecisions.CrystalReports.Engine;
using concrete.Services;

namespace concrete.Reports
{
    public partial class CostSheetView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ConcreteCardsService CCS = new ConcreteCardsService();
            var rptSource = CCS.Getcarddata().ToString();
            ReportDocument rd = new ReportDocument();
            rd.Load(Server.MapPath("~/CrystalReports/")+"CostSheetReport.rpt");
            if (rptSource != null && rptSource.GetType().ToString() != "System.String")
               // rd.SetDataSource(rptSource);
            CrystalReportViewer1.ReportSource = rd;
        }
        protected void CrystalReportViewer1_Init(object sender, EventArgs e)
        {  
        }

        protected void TextBoxDate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}