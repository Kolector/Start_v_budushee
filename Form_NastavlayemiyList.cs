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
    public partial class Form_NastavlayemiyList : Form 
    {
        public void FillNastavlayemiyList()
        {
            listViewNastavlayemiy.Items.Clear();
            DataRow ConRow;
            string[] items = new string[4];
            
            наставляемыйTableAdapter1.Fill(старт_в_будущее_КПDataSet1.НАСТАВЛЯЕМЫЙ);
            участникTableAdapter1.Fill(старт_в_будущее_КПDataSet1.УЧАСТНИК);

            foreach (DataRow row in this.старт_в_будущее_КПDataSet1.НАСТАВЛЯЕМЫЙ.Rows)
            {
                ConRow = row.GetParentRow("FK_НАСТАВЛЯЕМЫЙ_УЧАСТНИК1");

                items[1] = row["Запрос наставляемого от программы"].ToString();
                items[2] = row["Время регистрации"].ToString();
                items[3] = row["Дата вхождения в программу"].ToString();

                ListViewItem ItemRow = new ListViewItem
                {
                    Text = ConRow["ФИО"].ToString()
                };
                ItemRow.SubItems.AddRange(items);
                listViewNastavlayemiy.Items.Add(ItemRow);
            }

            UpdateComboboxFIOItem();
        }
        public Form_NastavlayemiyList()
        {
            InitializeComponent();
        }

        public void UpdateComboboxFIOItem()
        {
            //Очистка элемента от записей
            comboBoxFIO.Items.Clear();
            comboBoxFIO.Text = "";

            //Запрос на заполнение таблицы записями, отсутствующими в таблицах НАСТАВНИК, НАСТАВЛЯЕМЫЙ, КООРДИНАТОР
            сВОБОДНЫЙ_УЧАСТНИКTableAdapter.Fill(this.старт_в_будущее_КПDataSet1.СВОБОДНЫЙ_УЧАСТНИК);

            //Заполнение элемента

            ComboboxFIOByAlphabeticalOrder(true);

            //string FIOitem;
            //foreach (DataRow FIOrow in this.старт_в_будущее_КПDataSet1.СВОБОДНЫЙ_УЧАСТНИК)
            //{
            //    FIOitem = FIOrow["ФИО"].ToString();
            //    comboBoxFIO.Items.Add(FIOitem);
            //}


        }

        private void ComboboxFIOByAlphabeticalOrder(bool DirectionAsc) //true - ByAsc, false - ByDesc
        {
            if (DirectionAsc)
            {
                сВОБОДНЫЙ_УЧАСТНИКTableAdapter.FillByAsc(this.старт_в_будущее_КПDataSet1.СВОБОДНЫЙ_УЧАСТНИК);
            }
            else
            {
                сВОБОДНЫЙ_УЧАСТНИКTableAdapter.FillByDesc(this.старт_в_будущее_КПDataSet1.СВОБОДНЫЙ_УЧАСТНИК);
            }
            
            foreach (DataRow row in this.старт_в_будущее_КПDataSet1.СВОБОДНЫЙ_УЧАСТНИК.Rows)
            {
                comboBoxFIO.Items.Add(row["ФИО"].ToString());
            }
        }

        private void buttonSaveNastavlayemiy_Click(object sender, EventArgs e)
        {
            DataRow[] MemberDataRow = старт_в_будущее_КПDataSet1.УЧАСТНИК.Select("ФИО='" + comboBoxFIO.Text + "'");

            //Получение ID УЧАСТНИКа для его добавления в таблицу НАСТАВЛЯЕМЫЙ
            Guid IDfio = (Guid)MemberDataRow[0]["ID"];
            наставляемыйTableAdapter1.Insert(DateTime.Now, IDfio, richTextBoxExpectations.Text, DateTime.Now);

            //заполнение таблицы на форме
            FillNastavlayemiyList();

            //Обратная связь с пользователем
            MessageBox.Show("Добавление выполнено успешно!");
        }

        private void Form_NastavlayemiyList_Load(object sender, EventArgs e)
        {
            //NamesByAlphabeticalOrder();
            FillNastavlayemiyList();
        }
    }
}
