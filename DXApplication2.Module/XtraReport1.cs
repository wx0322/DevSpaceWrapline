using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace DXApplication2.Module
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport1()
        {
            InitializeComponent();
            XRLabel xRPageInfo =  this.FindControl("xrLabel3", true) as XRLabel;
            xRPageInfo.PrintOnPage += xrLabel3_PrintOnPage;
        }

       
        private void xrLabel3_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
             int pagecount = e.PageCount;
            int pageindex = e.PageIndex;
            if (pageindex < 2)
            {
                this.xrLabel3.Visible = false;
            }
            else
            {
                this.xrLabel3.Visible = true;
                this.xrLabel3.Text = string.Format("第{0}页，共{1}页", pageindex - 1, pagecount - 2);
            }
        }
    }
}
