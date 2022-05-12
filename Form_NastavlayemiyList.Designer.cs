
namespace Diplom_Start_v_budushee
{
    partial class Form_NastavlayemiyList
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.listViewNastavlayemiy = new System.Windows.Forms.ListView();
            this.FIOColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExpectationsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateOfRegistration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateOfEntrProgram = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxFIO = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBoxExpectations = new System.Windows.Forms.RichTextBox();
            this.buttonSaveNastavlayemiy = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.участникTableAdapter1 = new Diplom_Start_v_budushee.Старт_в_будущее_КПDataSetTableAdapters.УЧАСТНИКTableAdapter();
            this.наставляемыйTableAdapter1 = new Diplom_Start_v_budushee.Старт_в_будущее_КПDataSetTableAdapters.НАСТАВЛЯЕМЫЙTableAdapter();
            this.старт_в_будущее_КПDataSet1 = new Diplom_Start_v_budushee.Старт_в_будущее_КПDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.старт_в_будущее_КПDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Wheat;
            this.splitter1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(322, 423);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(322, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(753, 96);
            this.splitter2.TabIndex = 1;
            this.splitter2.TabStop = false;
            // 
            // listViewNastavlayemiy
            // 
            this.listViewNastavlayemiy.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FIOColumn,
            this.ExpectationsColumn,
            this.DateOfRegistration,
            this.DateOfEntrProgram});
            this.listViewNastavlayemiy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewNastavlayemiy.GridLines = true;
            this.listViewNastavlayemiy.HideSelection = false;
            this.listViewNastavlayemiy.Location = new System.Drawing.Point(322, 96);
            this.listViewNastavlayemiy.Name = "listViewNastavlayemiy";
            this.listViewNastavlayemiy.Size = new System.Drawing.Size(753, 327);
            this.listViewNastavlayemiy.TabIndex = 2;
            this.listViewNastavlayemiy.UseCompatibleStateImageBehavior = false;
            this.listViewNastavlayemiy.View = System.Windows.Forms.View.Details;
            // 
            // FIOColumn
            // 
            this.FIOColumn.Text = "ФИО участника";
            this.FIOColumn.Width = 171;
            // 
            // ExpectationsColumn
            // 
            this.ExpectationsColumn.Text = "Ожидания наставляемого";
            this.ExpectationsColumn.Width = 302;
            // 
            // DateOfRegistration
            // 
            this.DateOfRegistration.Text = "Дата регистрации";
            this.DateOfRegistration.Width = 111;
            // 
            // DateOfEntrProgram
            // 
            this.DateOfEntrProgram.Text = "Дата вхождения в программу";
            this.DateOfEntrProgram.Width = 165;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Wheat;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Панель добавления\r\nи редактирования наставляемого\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Wheat;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Имя\r\nучастника";
            // 
            // comboBoxFIO
            // 
            this.comboBoxFIO.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxFIO.FormattingEnabled = true;
            this.comboBoxFIO.Location = new System.Drawing.Point(97, 87);
            this.comboBoxFIO.Name = "comboBoxFIO";
            this.comboBoxFIO.Size = new System.Drawing.Size(214, 24);
            this.comboBoxFIO.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Wheat;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 38);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ожидания наставляемого \r\nот программы";
            // 
            // richTextBoxExpectations
            // 
            this.richTextBoxExpectations.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxExpectations.Location = new System.Drawing.Point(10, 170);
            this.richTextBoxExpectations.Name = "richTextBoxExpectations";
            this.richTextBoxExpectations.Size = new System.Drawing.Size(301, 169);
            this.richTextBoxExpectations.TabIndex = 7;
            this.richTextBoxExpectations.Text = "";
            // 
            // buttonSaveNastavlayemiy
            // 
            this.buttonSaveNastavlayemiy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSaveNastavlayemiy.BackColor = System.Drawing.Color.LightGreen;
            this.buttonSaveNastavlayemiy.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveNastavlayemiy.Location = new System.Drawing.Point(10, 367);
            this.buttonSaveNastavlayemiy.Name = "buttonSaveNastavlayemiy";
            this.buttonSaveNastavlayemiy.Size = new System.Drawing.Size(301, 46);
            this.buttonSaveNastavlayemiy.TabIndex = 8;
            this.buttonSaveNastavlayemiy.Text = "Сохранить";
            this.buttonSaveNastavlayemiy.UseVisualStyleBackColor = false;
            this.buttonSaveNastavlayemiy.Click += new System.EventHandler(this.buttonSaveNastavlayemiy_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(339, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Фильтрация и поиск";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(339, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Имя участника";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(464, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 26);
            this.textBox1.TabIndex = 11;
            // 
            // участникTableAdapter1
            // 
            this.участникTableAdapter1.ClearBeforeFill = true;
            // 
            // наставляемыйTableAdapter1
            // 
            this.наставляемыйTableAdapter1.ClearBeforeFill = true;
            // 
            // старт_в_будущее_КПDataSet1
            // 
            this.старт_в_будущее_КПDataSet1.DataSetName = "Старт_в_будущее_КПDataSet";
            this.старт_в_будущее_КПDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form_NastavlayemiyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1075, 423);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonSaveNastavlayemiy);
            this.Controls.Add(this.richTextBoxExpectations);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxFIO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewNastavlayemiy);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Name = "Form_NastavlayemiyList";
            this.Text = "Просмотр наставляемых";
            this.Load += new System.EventHandler(this.Form_NastavlayemiyList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.старт_в_будущее_КПDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.ListView listViewNastavlayemiy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxFIO;
        private System.Windows.Forms.ColumnHeader FIOColumn;
        private System.Windows.Forms.ColumnHeader ExpectationsColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBoxExpectations;
        private System.Windows.Forms.Button buttonSaveNastavlayemiy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColumnHeader DateOfRegistration;
        private System.Windows.Forms.ColumnHeader DateOfEntrProgram;
        private Старт_в_будущее_КПDataSetTableAdapters.УЧАСТНИКTableAdapter участникTableAdapter1;
        private Старт_в_будущее_КПDataSetTableAdapters.НАСТАВЛЯЕМЫЙTableAdapter наставляемыйTableAdapter1;
        private Старт_в_будущее_КПDataSet старт_в_будущее_КПDataSet1;
    }
}