
namespace Diplom_Start_v_budushee
{
    partial class Form_AddPhoto
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
            this.button_SavePhoto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_LoadPhoto = new System.Windows.Forms.Button();
            this.label_info = new System.Windows.Forms.Label();
            this.label_fileName = new System.Windows.Forms.Label();
            this.label_FilePath = new System.Windows.Forms.Label();
            this.label_FileNameOutput = new System.Windows.Forms.Label();
            this.label_FilePathOutput = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button_AddToReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.BurlyWood;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 560);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(723, 69);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            this.splitter1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitter1_SplitterMoved);
            // 
            // button_SavePhoto
            // 
            this.button_SavePhoto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_SavePhoto.BackColor = System.Drawing.Color.LightGreen;
            this.button_SavePhoto.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_SavePhoto.Location = new System.Drawing.Point(55, 568);
            this.button_SavePhoto.Name = "button_SavePhoto";
            this.button_SavePhoto.Size = new System.Drawing.Size(608, 49);
            this.button_SavePhoto.TabIndex = 1;
            this.button_SavePhoto.Text = "Сохранить";
            this.button_SavePhoto.UseVisualStyleBackColor = false;
            this.button_SavePhoto.Click += new System.EventHandler(this.button_SavePhoto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(55, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(608, 404);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button_LoadPhoto
            // 
            this.button_LoadPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_LoadPhoto.BackColor = System.Drawing.Color.FloralWhite;
            this.button_LoadPhoto.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_LoadPhoto.Location = new System.Drawing.Point(55, 422);
            this.button_LoadPhoto.Name = "button_LoadPhoto";
            this.button_LoadPhoto.Size = new System.Drawing.Size(608, 37);
            this.button_LoadPhoto.TabIndex = 3;
            this.button_LoadPhoto.Text = "Загрузить фото";
            this.button_LoadPhoto.UseVisualStyleBackColor = false;
            this.button_LoadPhoto.Click += new System.EventHandler(this.button_LoadPhoto_Click);
            // 
            // label_info
            // 
            this.label_info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_info.AutoSize = true;
            this.label_info.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_info.Location = new System.Drawing.Point(51, 462);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(173, 19);
            this.label_info.TabIndex = 4;
            this.label_info.Text = "Информация о файле:";
            // 
            // label_fileName
            // 
            this.label_fileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_fileName.AutoSize = true;
            this.label_fileName.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_fileName.Location = new System.Drawing.Point(52, 481);
            this.label_fileName.Name = "label_fileName";
            this.label_fileName.Size = new System.Drawing.Size(75, 16);
            this.label_fileName.TabIndex = 5;
            this.label_fileName.Text = "Имя файла:";
            // 
            // label_FilePath
            // 
            this.label_FilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_FilePath.AutoSize = true;
            this.label_FilePath.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_FilePath.Location = new System.Drawing.Point(52, 497);
            this.label_FilePath.Name = "label_FilePath";
            this.label_FilePath.Size = new System.Drawing.Size(80, 16);
            this.label_FilePath.TabIndex = 6;
            this.label_FilePath.Text = "Путь файла:";
            // 
            // label_FileNameOutput
            // 
            this.label_FileNameOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_FileNameOutput.AutoSize = true;
            this.label_FileNameOutput.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_FileNameOutput.Location = new System.Drawing.Point(133, 481);
            this.label_FileNameOutput.Name = "label_FileNameOutput";
            this.label_FileNameOutput.Size = new System.Drawing.Size(0, 16);
            this.label_FileNameOutput.TabIndex = 7;
            // 
            // label_FilePathOutput
            // 
            this.label_FilePathOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_FilePathOutput.AutoSize = true;
            this.label_FilePathOutput.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_FilePathOutput.Location = new System.Drawing.Point(133, 497);
            this.label_FilePathOutput.Name = "label_FilePathOutput";
            this.label_FilePathOutput.Size = new System.Drawing.Size(0, 16);
            this.label_FilePathOutput.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button_AddToReport
            // 
            this.button_AddToReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_AddToReport.BackColor = System.Drawing.Color.FloralWhite;
            this.button_AddToReport.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_AddToReport.Location = new System.Drawing.Point(55, 517);
            this.button_AddToReport.Name = "button_AddToReport";
            this.button_AddToReport.Size = new System.Drawing.Size(608, 37);
            this.button_AddToReport.TabIndex = 3;
            this.button_AddToReport.Text = "Использовать в отчёте";
            this.button_AddToReport.UseVisualStyleBackColor = false;
            this.button_AddToReport.Click += new System.EventHandler(this.button_AddToReport_Click);
            // 
            // Form_AddPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(723, 629);
            this.Controls.Add(this.label_FilePathOutput);
            this.Controls.Add(this.label_FileNameOutput);
            this.Controls.Add(this.label_FilePath);
            this.Controls.Add(this.label_fileName);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.button_AddToReport);
            this.Controls.Add(this.button_LoadPhoto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_SavePhoto);
            this.Controls.Add(this.splitter1);
            this.Name = "Form_AddPhoto";
            this.Text = "Добавить фото";
            this.Load += new System.EventHandler(this.Form_AddPhoto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button button_SavePhoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_LoadPhoto;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Label label_fileName;
        private System.Windows.Forms.Label label_FilePath;
        private System.Windows.Forms.Label label_FileNameOutput;
        private System.Windows.Forms.Label label_FilePathOutput;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button_AddToReport;
    }
}