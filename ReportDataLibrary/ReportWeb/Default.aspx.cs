using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Reporting.WebForms;

namespace ReportWeb
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ReportParameter maxAgeParameter = new ReportParameter("MaxAge", "55");
                this.ReportViewer1.ServerReport.SetParameters(new ReportParameter[] {maxAgeParameter});
                this.ReportViewer1.ShowParameterPrompts = false;
            }
        }
    }
}
