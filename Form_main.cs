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
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }

        private void наставникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_NastavnikList form_NastavnikList = new Form_NastavnikList();
            form_NastavnikList.Show();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_auth form_Auth = new Form_auth();
            form_Auth.Show();
        }

        private void имяОтчёта1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Требуется ли добавить фото?", "Добавление фотографии", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                Form_AddPhoto form_AddPhoto = new Form_AddPhoto();
                form_AddPhoto.Show();
            }
            //this.Close();
            //Form_ReportNastavniki form_ReportNastavniki = new Form_ReportNastavniki();
            //form_ReportNastavniki.Show();
        }

        private void Form_main_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "старт_в_будущее_КПDataSet1.НАСТАВНИК". При необходимости она может быть перемещена или удалена.
            this.нАСТАВНИКTableAdapter.Fill(this.старт_в_будущее_КПDataSet1.НАСТАВНИК);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "старт_в_будущее_КПDataSet1.ПРЕДМЕТ_НАСТАВНИЧЕСТВА". При необходимости она может быть перемещена или удалена.
            this.пРЕДМЕТ_НАСТАВНИЧЕСТВАTableAdapter.Fill(this.старт_в_будущее_КПDataSet1.ПРЕДМЕТ_НАСТАВНИЧЕСТВА);
            using (Старт_в_будущее_КПDataSet db = new Старт_в_будущее_КПDataSet())
            {
                //chartPosts.DataSource = db.УЧАСТНИК.ToList();
                //chartPosts.Series["Posts"].XValueMember = "Должность/специальность";
                //chartPosts.Series["Posts"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;

                int[] RowAmmount = new int[2];

                //Диаграмма количества записей в таблицах.
                chartPosts.Series["Наставники"].Points.AddY(старт_в_будущее_КПDataSet1.НАСТАВНИК.Count());
                chartPosts.Series["Наставляемые"].Points.AddY(старт_в_будущее_КПDataSet1.НАСТАВЛЯЕМЫЙ.Count());
                chartPosts.Series["Координаторы"].Points.AddY(старт_в_будущее_КПDataSet1.КООРДИНАТОР.Count());

            }
        }

        private void просмотрФайловExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ExcelViewer form_ExcelViewer = new Form_ExcelViewer();
            form_ExcelViewer.Show();
        }

        private void radioButtonPredmet_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPredmet.Checked == true)
            {
                radioButtonModule.Checked = false;
            }
        }

        private void radioButtonModule_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonModule.Checked == true)
            {
                radioButtonPredmet.Checked = false;
            }
        }

        private void buttonSaveMNorPN_Click(object sender, EventArgs e)
        {
            if(radioButtonModule.Checked == true)
            {
                модулЬ_НАСТАВНИЧЕСТВАTableAdapter1.Insert(textBoxName.Text);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "старт_в_будущее_КПDataSet1.ПРЕДМЕТ_НАСТАВНИЧЕСТВА". При необходимости она может быть перемещена или удалена.
                this.пРЕДМЕТ_НАСТАВНИЧЕСТВАTableAdapter.Fill(this.старт_в_будущее_КПDataSet1.ПРЕДМЕТ_НАСТАВНИЧЕСТВА);
            }
            else if (radioButtonPredmet.Checked == true)
            {
                пРЕДМЕТ_НАСТАВНИЧЕСТВАTableAdapter.Insert(textBoxName.Text);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "старт_в_будущее_КПDataSet1.ПРЕДМЕТ_НАСТАВНИЧЕСТВА". При необходимости она может быть перемещена или удалена.
                this.модулЬ_НАСТАВНИЧЕСТВАTableAdapter1.Fill(this.старт_в_будущее_КПDataSet1.МОДУЛЬ_НАСТАВНИЧЕСТВА);
            }
        }

        private void наставляемыеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_NastavlayemiyList form = new Form_NastavlayemiyList();
            form.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
