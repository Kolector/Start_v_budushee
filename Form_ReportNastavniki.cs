using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom_Start_v_budushee
{
    public partial class Form_ReportNastavniki : Form
    {
        public Form_ReportNastavniki()
        {
            InitializeComponent();
        }

        private void Form_ReportNastavniki_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Старт_в_будущее_КПDataSet.ReportNastavniki". При необходимости она может быть перемещена или удалена.
            this.ReportNastavnikiTableAdapter.FillReportNastavniki(this.Старт_в_будущее_КПDataSet.ReportNastavniki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Старт_в_будущее_КПDataSet.НАСТАВНИК". При необходимости она может быть перемещена или удалена.
            this.НАСТАВНИКTableAdapter.Fill(this.Старт_в_будущее_КПDataSet.НАСТАВНИК);
            Class_Photo photo = new Class_Photo();

            ReportParameter pImagePath = new ReportParameter("pImagePath", photo.PhotoPath);
            this.reportViewer1.LocalReport.SetParameters(pImagePath);
            this.reportViewer1.RefreshReport();
            
            photo.PhotoPath = "";
        }
    }
}
