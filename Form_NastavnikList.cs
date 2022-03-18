using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom_Start_v_budushee
{
    public partial class Form_NastavnikList : Form
    {
        //Код под постраничный просмотр
        int pageSize = 5;
        int pageNumber = 0; //Текущая страница
        SqlDataAdapter adapter; //Я не знаю что такое SqlDataAdapter
        string connectionString = @"Data Source=DESKTOP-6DFE16M\SQLEXPRESS;Initial Catalog=Старт_в_будущее_КП;Integrated Security=True"; //Строка подключения к базе данных
        DataSet ds; //И как этой дичью пользоваться я тоже не знаю
        //конец кода под постраничный просмотр
        public void ListViewFill()
        {
            listViewNastavnik.Items.Clear();
            DataRow ConRow;
            string[] items = new string[7];
            наставникTableAdapter1.Fill(старт_в_будущее_КПDataSet1.НАСТАВНИК);
            участникTableAdapter1.Fill(старт_в_будущее_КПDataSet1.УЧАСТНИК);
            foreach (DataRow row in this.старт_в_будущее_КПDataSet1.НАСТАВНИК.Rows)
            {
                ConRow = row.GetParentRow("FK_НАСТАВНИК_УЧАСТНИК1");

                items[1] = row["Время регистрации"].ToString();
                items[2] = row["Основные компетенции"].ToString();
                items[3] = row["Достижения наставника"].ToString();
                items[4] = row["Интересы наставника"].ToString();
                items[5] = row["Желаемый возраст наставляемых"].ToString();
                items[6] = row["Ресурс времени на наставничество"].ToString();

                ListViewItem ItemRow = new ListViewItem();
                ItemRow.Text = ConRow["ФИО"].ToString();
                ItemRow.SubItems.AddRange(items);
                listViewNastavnik.Items.Add(ItemRow);
            }
            string FIOitem;
            foreach (DataRow FIOrow in this.старт_в_будущее_КПDataSet1.УЧАСТНИК)
            {
                FIOitem = FIOrow["ФИО"].ToString();
                comboBoxFIO.Items.Add(FIOitem);
            }

        }
        private string GetSql() //Функция для отправления запроса в таблицу НАСТАВНИК. Нужно для реализации постраничного вывода
        {
            return "SELECT * FROM НАСТАВНИК ORDER BY [ID участника] OFFSET ((" + pageNumber + ") * " + pageSize + ") " +
                "ROWS FETCH NEXT " + pageSize + "ROWS ONLY";
        }
        public Form_NastavnikList()
        {
            InitializeComponent();
            ListViewFill();

            //Постраничный просмотр
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                adapter = new SqlDataAdapter(GetSql(), connection);

                ds = new DataSet();
                adapter.Fill(ds, "НАСТАВНИК"); //Я не понимаю че там заполняется в датасет и как из строки справа это делается
                dataGridViewNastavnik.DataSource = ds.Tables[0];
                dataGridViewNastavnik.Columns["ID участника"].ReadOnly = true;
            }

            labelPageCount.Text = "0 страница";

        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DataRow[] MemberDataRow = старт_в_будущее_КПDataSet1.УЧАСТНИК.Select("ФИО='" + comboBoxFIO.Text + "'");
            if (comboBoxFIO.Text.Length > 150 || MemberDataRow.Length == 0)
            {
                throw new Exception("Строка ФИО: Количество символов больше 150 либо данное ФИО отсутствует в списке участников!");
            }
            if (richTextBox_Achievements.Text.Length > 300 || richTextBox_Competence.Text.Length > 300 || richTextBox_Interests.Text.Length > 300)
            {
                int scenario = 0;
                if (richTextBox_Achievements.Text.Length > 300)
                    scenario += 1;
                if (richTextBox_Competence.Text.Length > 300)
                    scenario += 2;
                if (richTextBox_Interests.Text.Length > 300)
                    scenario += 3;

                switch (scenario)
                {
                    case 0:
                        throw new Exception(@"Этого не должно было произойти.");

                    case 1:
                        throw new Exception(@"Поле ""Достижения"" имеет больше чем 300 символов! Уменьшите количество символов.");

                    case 2:
                        throw new Exception(@"Поле ""Компетенции"" имеет больше чем 300 символов! Уменьшите количество символов.");

                    case 3:
                        throw new Exception(@"Поле ""Интересы"" имеет больше чем 300 символов! Уменьшите количество символов.");

                    case 4:
                        throw new Exception(@"Поля ""Достижения"" и ""Интересы"" имеют больше чем 300 символов! Уменьшите количество символов.");

                    case 5:
                        throw new Exception(@"Поля ""Интересы"" и ""Компетенции"" имеет больше чем 300 символов! Уменьшите количество символов.");

                    case 6:
                        throw new Exception(@"Поля ""Достижения"", ""Интересы"" и ""Компетенции"" имеют больше чем 300 символов! Уменьшите количество символов.");

                    default:
                        throw new Exception(@"Почему?");
                }
            }
            if (textBox_AgePreferable.Text.Length > 20 || textBox_TimeNastavnichestvo.Text.Length > 20)
            {
                int scenario = 0;
                if (textBox_AgePreferable.Text.Length > 20)
                    scenario += 1;
                if (textBox_TimeNastavnichestvo.Text.Length > 20)
                    scenario += 2;

                switch (scenario)
                {
                    case 0:
                        throw new Exception(@"Каким образом?");
                    case 1:
                        throw new Exception(@"Поле ""Желаемый возраст наставляемых"" имеет больше чем 20 символов! Уменьшите количество символов.");
                    case 2:
                        throw new Exception(@"Поле ""Ресурс времени на наставничество"" имеет больше чем 20 символов! Уменьшите количество символов.");
                    case 3:
                        throw new Exception(@"Поля ""Желаемый возраст наставляемых"" и ""Ресурс времени на наставничество"" имеет больше чем 20 символов! Уменьшите количество символов.");
                }
            }

            Guid IDfio = (Guid)MemberDataRow[0]["ID"];
            наставникTableAdapter1.Insert(DateTime.Now, IDfio, richTextBox_Competence.Text,
                richTextBox_Achievements.Text, richTextBox_Interests.Text, textBox_AgePreferable.Text
                , textBox_TimeNastavnichestvo.Text);
            ListViewFill();
            MessageBox.Show("Добавление выполнено успешно!");
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox_FIOfilter.Text != "")
            {
                DataRow ConRow;
                string[] items = new string[7];
                listViewNastavnik.Items.Clear();
                наставникTableAdapter1.FillNastavnik(старт_в_будущее_КПDataSet1.НАСТАВНИК, textBox_FIOfilter.Text);
                участникTableAdapter1.Fill(старт_в_будущее_КПDataSet1.УЧАСТНИК);
                foreach (DataRow row in this.старт_в_будущее_КПDataSet1.НАСТАВНИК.Rows)
                {
                    ConRow = row.GetParentRow("FK_НАСТАВНИК_УЧАСТНИК1");

                    items[1] = row["Время регистрации"].ToString();
                    items[2] = row["Основные компетенции"].ToString();
                    items[3] = row["Достижения наставника"].ToString();
                    items[4] = row["Интересы наставника"].ToString();
                    items[5] = row["Желаемый возраст наставляемых"].ToString();
                    items[6] = row["Ресурс времени на наставничество"].ToString();

                    ListViewItem ItemRow = new ListViewItem();
                    ItemRow.Text = ConRow["ФИО"].ToString();
                    ItemRow.SubItems.AddRange(items);
                    listViewNastavnik.Items.Add(ItemRow);
                }
            }
            else
                ListViewFill();

        }
        private void button_AddPhoto_Click(object sender, EventArgs e)
        {
            Form_AddPhoto form_AddPhoto = new Form_AddPhoto();
            form_AddPhoto.Show();
            this.Close();
        }

        private void buttonPageNext_Click(object sender, EventArgs e)
        {
            if (ds.Tables["НАСТАВНИК"].Rows.Count < pageSize) return;

            pageNumber++;
            labelPageCount.Text = pageNumber.ToString() + " страница";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                adapter = new SqlDataAdapter(GetSql(), connection);

                ds.Tables["НАСТАВНИК"].Rows.Clear();

                adapter.Fill(ds, "НАСТАВНИК");
            }
        }

        private void buttonPagePrev_Click(object sender, EventArgs e)
        {
            if (pageNumber == 0) return;
            pageNumber--;
            labelPageCount.Text = pageNumber.ToString() + " страница";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                adapter = new SqlDataAdapter(GetSql(), connection);

                ds.Tables["НАСТАВНИК"].Rows.Clear();

                adapter.Fill(ds, "НАСТАВНИК");
            }
        }
    }
}