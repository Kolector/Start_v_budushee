
namespace Diplom_Start_v_budushee
{
    partial class Form_rukovodstvo
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
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "Обзор приложения"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))));
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "- Открытие списков"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))));
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "- Добавление записей"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))));
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "- Удаление записей "}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))));
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "- Редактирование записей"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.listViewOverview = new System.Windows.Forms.ListView();
            this.richTextBoxRTF = new System.Windows.Forms.RichTextBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(178, 450);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // listViewOverview
            // 
            this.listViewOverview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewOverview.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewOverview.HideSelection = false;
            this.listViewOverview.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10});
            this.listViewOverview.Location = new System.Drawing.Point(0, 0);
            this.listViewOverview.Name = "listViewOverview";
            this.listViewOverview.Size = new System.Drawing.Size(178, 450);
            this.listViewOverview.TabIndex = 2;
            this.listViewOverview.UseCompatibleStateImageBehavior = false;
            this.listViewOverview.View = System.Windows.Forms.View.List;
            this.listViewOverview.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewOverview_MouseClick);
            // 
            // richTextBoxRTF
            // 
            this.richTextBoxRTF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxRTF.Location = new System.Drawing.Point(178, 0);
            this.richTextBoxRTF.Name = "richTextBoxRTF";
            this.richTextBoxRTF.Size = new System.Drawing.Size(622, 450);
            this.richTextBoxRTF.TabIndex = 3;
            this.richTextBoxRTF.Text = "";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 3000;
            // 
            // Form_rukovodstvo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxRTF);
            this.Controls.Add(this.listViewOverview);
            this.Controls.Add(this.splitter1);
            this.Name = "Form_rukovodstvo";
            this.Text = "Руководство по пользованию приложением";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ListView listViewOverview;
        private System.Windows.Forms.RichTextBox richTextBoxRTF;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}