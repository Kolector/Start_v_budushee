using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom_Start_v_budushee
{
    public partial class Form_AddPhoto : Form
    {
        string filepath;
        public Form_AddPhoto()
        {
            InitializeComponent();
        }
        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
        private void Form_AddPhoto_Load(object sender, EventArgs e)
        {

        }
        private void button_LoadPhoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.ImageLocation = openFileDialog1.FileName;

            filepath = openFileDialog1.FileName;
            //filename = Path.GetFileName(filename);

            label_FileNameOutput.Text = Path.GetFileName(openFileDialog1.FileName);
            label_FilePathOutput.Text = openFileDialog1.FileName;

            Class_Photo Photo = new Class_Photo();
           // Photo.PhotoPath = filepath;

            
        }
        private void button_SavePhoto_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_NastavnikList form_NastavnikList = new Form_NastavnikList();
            form_NastavnikList.Show();
        }
        private void button_AddToReport_Click(object sender, EventArgs e)
        {
            if (filepath != "")
            {
                this.Close();
                Form_ReportNastavniki Report = new Form_ReportNastavniki(filepath);
                Report.Show();
            }
           
        }
    }
}