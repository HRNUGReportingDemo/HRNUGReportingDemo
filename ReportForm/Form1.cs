using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using ReportDataLibrary;

namespace ReportForm
{
    public partial class Form1 : Form
    {
        public ReportData MyReportData { get; set; }
        public Form1()
        {
            MyReportData = new ReportData();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MyReportData = new ReportData();
            this.ReportDataBindingSource.DataSource = this.MyReportData;
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string filenameExtension;

            byte[] bytes = this.reportViewer1.LocalReport.Render(
                "Word", null, out mimeType, out encoding, out filenameExtension,
                out streamids, out warnings);

            using (FileStream fs = new FileStream("output.doc", FileMode.Create))
            {
                fs.Write(bytes, 0, bytes.Length);
            }

            MessageBox.Show("Report exported to output.xls", "Info");
        }
    }
}
