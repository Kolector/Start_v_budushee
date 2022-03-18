
namespace Diplom_Start_v_budushee
{
    partial class Form_ReportNastavniki
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ReportNastavnikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Старт_в_будущее_КПDataSet = new Diplom_Start_v_budushee.Старт_в_будущее_КПDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.НАСТАВНИКBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.НАСТАВНИКTableAdapter = new Diplom_Start_v_budushee.Старт_в_будущее_КПDataSetTableAdapters.НАСТАВНИКTableAdapter();
            this.ReportNastavnikiTableAdapter = new Diplom_Start_v_budushee.Старт_в_будущее_КПDataSetTableAdapters.ReportNastavnikiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ReportNastavnikiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Старт_в_будущее_КПDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.НАСТАВНИКBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportNastavnikiBindingSource
            // 
            this.ReportNastavnikiBindingSource.DataMember = "ReportNastavniki";
            this.ReportNastavnikiBindingSource.DataSource = this.Старт_в_будущее_КПDataSet;
            // 
            // Старт_в_будущее_КПDataSet
            // 
            this.Старт_в_будущее_КПDataSet.DataSetName = "Старт_в_будущее_КПDataSet";
            this.Старт_в_будущее_КПDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_nastavniki";
            reportDataSource1.Value = this.ReportNastavnikiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Diplom_Start_v_budushee.Report_Nastavniki.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // НАСТАВНИКBindingSource
            // 
            this.НАСТАВНИКBindingSource.DataMember = "НАСТАВНИК";
            this.НАСТАВНИКBindingSource.DataSource = this.Старт_в_будущее_КПDataSet;
            // 
            // НАСТАВНИКTableAdapter
            // 
            this.НАСТАВНИКTableAdapter.ClearBeforeFill = true;
            // 
            // ReportNastavnikiTableAdapter
            // 
            this.ReportNastavnikiTableAdapter.ClearBeforeFill = true;
            // 
            // Form_ReportNastavniki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form_ReportNastavniki";
            this.Text = "Отчёт о наставниках";
            this.Load += new System.EventHandler(this.Form_ReportNastavniki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportNastavnikiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Старт_в_будущее_КПDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.НАСТАВНИКBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource НАСТАВНИКBindingSource;
        private Старт_в_будущее_КПDataSet Старт_в_будущее_КПDataSet;
        private Старт_в_будущее_КПDataSetTableAdapters.НАСТАВНИКTableAdapter НАСТАВНИКTableAdapter;
        private System.Windows.Forms.BindingSource ReportNastavnikiBindingSource;
        private Старт_в_будущее_КПDataSetTableAdapters.ReportNastavnikiTableAdapter ReportNastavnikiTableAdapter;
    }
}