
namespace Diplom_Start_v_budushee
{
    partial class Form_NastavnikList
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
            this.listViewNastavnik = new System.Windows.Forms.ListView();
            this.columnHeaderFIO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRegTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCompetencies = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAchievement = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderInterests = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAgeWanted = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTimeNeeded = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFIO = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox_Competence = new System.Windows.Forms.RichTextBox();
            this.richTextBox_Achievements = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox_Interests = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_AgePreferable = new System.Windows.Forms.TextBox();
            this.textBox_TimeNastavnichestvo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_FIOfilter = new System.Windows.Forms.TextBox();
            this.старт_в_будущее_КПDataSet1 = new Diplom_Start_v_budushee.Старт_в_будущее_КПDataSet();
            this.наставникTableAdapter1 = new Diplom_Start_v_budushee.Старт_в_будущее_КПDataSetTableAdapters.НАСТАВНИКTableAdapter();
            this.участникTableAdapter1 = new Diplom_Start_v_budushee.Старт_в_будущее_КПDataSetTableAdapters.УЧАСТНИКTableAdapter();
            this.button_AddPhoto = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.старт_в_будущее_КПDataSet1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Wheat;
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(343, 595);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(343, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(1233, 92);
            this.splitter2.TabIndex = 1;
            this.splitter2.TabStop = false;
            // 
            // listViewNastavnik
            // 
            this.listViewNastavnik.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFIO,
            this.columnHeaderRegTime,
            this.columnHeaderCompetencies,
            this.columnHeaderAchievement,
            this.columnHeaderInterests,
            this.columnHeaderAgeWanted,
            this.columnHeaderTimeNeeded});
            this.listViewNastavnik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewNastavnik.GridLines = true;
            this.listViewNastavnik.HideSelection = false;
            this.listViewNastavnik.Location = new System.Drawing.Point(3, 3);
            this.listViewNastavnik.Name = "listViewNastavnik";
            this.listViewNastavnik.Size = new System.Drawing.Size(1219, 471);
            this.listViewNastavnik.TabIndex = 2;
            this.listViewNastavnik.UseCompatibleStateImageBehavior = false;
            this.listViewNastavnik.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderFIO
            // 
            this.columnHeaderFIO.Text = "Имя наставника";
            this.columnHeaderFIO.Width = 162;
            // 
            // columnHeaderRegTime
            // 
            this.columnHeaderRegTime.Text = "Время регистрации";
            this.columnHeaderRegTime.Width = 145;
            // 
            // columnHeaderCompetencies
            // 
            this.columnHeaderCompetencies.Text = "Основные компетенции";
            this.columnHeaderCompetencies.Width = 239;
            // 
            // columnHeaderAchievement
            // 
            this.columnHeaderAchievement.Text = "Достижения";
            this.columnHeaderAchievement.Width = 244;
            // 
            // columnHeaderInterests
            // 
            this.columnHeaderInterests.Text = "Интересы";
            this.columnHeaderInterests.Width = 241;
            // 
            // columnHeaderAgeWanted
            // 
            this.columnHeaderAgeWanted.Text = "Возраст наставляемых";
            this.columnHeaderAgeWanted.Width = 94;
            // 
            // columnHeaderTimeNeeded
            // 
            this.columnHeaderTimeNeeded.Text = "Ресурс времени";
            this.columnHeaderTimeNeeded.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Wheat;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Панель добавления\r\n и редактирования наставника";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // comboBoxFIO
            // 
            this.comboBoxFIO.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxFIO.FormattingEnabled = true;
            this.comboBoxFIO.Location = new System.Drawing.Point(104, 92);
            this.comboBoxFIO.Name = "comboBoxFIO";
            this.comboBoxFIO.Size = new System.Drawing.Size(223, 27);
            this.comboBoxFIO.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Wheat;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "Имя\r\nучастника\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Wheat;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Компетенции";
            // 
            // richTextBox_Competence
            // 
            this.richTextBox_Competence.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_Competence.Location = new System.Drawing.Point(17, 180);
            this.richTextBox_Competence.Name = "richTextBox_Competence";
            this.richTextBox_Competence.Size = new System.Drawing.Size(310, 68);
            this.richTextBox_Competence.TabIndex = 7;
            this.richTextBox_Competence.Text = "";
            // 
            // richTextBox_Achievements
            // 
            this.richTextBox_Achievements.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_Achievements.Location = new System.Drawing.Point(17, 273);
            this.richTextBox_Achievements.Name = "richTextBox_Achievements";
            this.richTextBox_Achievements.Size = new System.Drawing.Size(310, 68);
            this.richTextBox_Achievements.TabIndex = 9;
            this.richTextBox_Achievements.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Wheat;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Достижения";
            // 
            // richTextBox_Interests
            // 
            this.richTextBox_Interests.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_Interests.Location = new System.Drawing.Point(17, 366);
            this.richTextBox_Interests.Name = "richTextBox_Interests";
            this.richTextBox_Interests.Size = new System.Drawing.Size(310, 68);
            this.richTextBox_Interests.TabIndex = 11;
            this.richTextBox_Interests.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Wheat;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(13, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Интересы";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Wheat;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(13, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(264, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Желаемый возраст наставляемых";
            // 
            // textBox_AgePreferable
            // 
            this.textBox_AgePreferable.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_AgePreferable.Location = new System.Drawing.Point(17, 459);
            this.textBox_AgePreferable.Name = "textBox_AgePreferable";
            this.textBox_AgePreferable.Size = new System.Drawing.Size(310, 27);
            this.textBox_AgePreferable.TabIndex = 13;
            // 
            // textBox_TimeNastavnichestvo
            // 
            this.textBox_TimeNastavnichestvo.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_TimeNastavnichestvo.Location = new System.Drawing.Point(17, 514);
            this.textBox_TimeNastavnichestvo.Name = "textBox_TimeNastavnichestvo";
            this.textBox_TimeNastavnichestvo.Size = new System.Drawing.Size(310, 27);
            this.textBox_TimeNastavnichestvo.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Wheat;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(13, 492);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(274, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ресурс времени на наставничество";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.LightGreen;
            this.buttonAdd.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(17, 552);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(310, 30);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "Сохранить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(358, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "Фильтрация и поиск";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(358, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 38);
            this.label9.TabIndex = 18;
            this.label9.Text = "Имя\r\nучастника\r\n";
            // 
            // textBox_FIOfilter
            // 
            this.textBox_FIOfilter.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_FIOfilter.Location = new System.Drawing.Point(460, 49);
            this.textBox_FIOfilter.Name = "textBox_FIOfilter";
            this.textBox_FIOfilter.Size = new System.Drawing.Size(364, 27);
            this.textBox_FIOfilter.TabIndex = 19;
            this.textBox_FIOfilter.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // старт_в_будущее_КПDataSet1
            // 
            this.старт_в_будущее_КПDataSet1.DataSetName = "Старт_в_будущее_КПDataSet";
            this.старт_в_будущее_КПDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // наставникTableAdapter1
            // 
            this.наставникTableAdapter1.ClearBeforeFill = true;
            // 
            // участникTableAdapter1
            // 
            this.участникTableAdapter1.ClearBeforeFill = true;
            // 
            // button_AddPhoto
            // 
            this.button_AddPhoto.BackColor = System.Drawing.Color.FloralWhite;
            this.button_AddPhoto.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_AddPhoto.Location = new System.Drawing.Point(17, 125);
            this.button_AddPhoto.Name = "button_AddPhoto";
            this.button_AddPhoto.Size = new System.Drawing.Size(310, 30);
            this.button_AddPhoto.TabIndex = 20;
            this.button_AddPhoto.Text = "Загрузить фото участника";
            this.button_AddPhoto.UseVisualStyleBackColor = false;
            this.button_AddPhoto.Click += new System.EventHandler(this.button_AddPhoto_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(343, 92);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1233, 503);
            this.tabControl1.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listViewNastavnik);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1225, 477);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Просмотр всех записей";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1225, 477);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Постраничный просмотр";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form_NastavnikList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1576, 595);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button_AddPhoto);
            this.Controls.Add(this.textBox_FIOfilter);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBox_TimeNastavnichestvo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_AgePreferable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBox_Interests);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBox_Achievements);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox_Competence);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxFIO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Name = "Form_NastavnikList";
            this.Text = "Список наставников";
            ((System.ComponentModel.ISupportInitialize)(this.старт_в_будущее_КПDataSet1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.ListView listViewNastavnik;
        private System.Windows.Forms.ColumnHeader columnHeaderFIO;
        private System.Windows.Forms.ColumnHeader columnHeaderRegTime;
        private System.Windows.Forms.ColumnHeader columnHeaderCompetencies;
        private System.Windows.Forms.ColumnHeader columnHeaderAchievement;
        private System.Windows.Forms.ColumnHeader columnHeaderInterests;
        private System.Windows.Forms.ColumnHeader columnHeaderAgeWanted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFIO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox_Competence;
        private System.Windows.Forms.RichTextBox richTextBox_Achievements;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox_Interests;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_AgePreferable;
        private System.Windows.Forms.TextBox textBox_TimeNastavnichestvo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ColumnHeader columnHeaderTimeNeeded;
        private Старт_в_будущее_КПDataSet старт_в_будущее_КПDataSet1;
        private Старт_в_будущее_КПDataSetTableAdapters.НАСТАВНИКTableAdapter наставникTableAdapter1;
        private Старт_в_будущее_КПDataSetTableAdapters.УЧАСТНИКTableAdapter участникTableAdapter1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_FIOfilter;
        private System.Windows.Forms.Button button_AddPhoto;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}