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
            string[] items = new string[7];
            наставляемыйTableAdapter1.Fill(старт_в_будущее_КПDataSet1.НАСТАВЛЯЕМЫЙ);
            участникTableAdapter1.Fill(старт_в_будущее_КПDataSet1.УЧАСТНИК);
            foreach (DataRow row in this.старт_в_будущее_КПDataSet1.НАСТАВЛЯЕМЫЙ.Rows)
            {
                ConRow = row.GetParentRow("FK_НАСТАВНИК_УЧАСТНИК1");

                items[1] = row["Запрос наставляемого от программы"].ToString();
                items[2] = row["Время регистрации"].ToString();
                items[3] = row["Дата вхождения в программу"].ToString();

                ListViewItem ItemRow = new ListViewItem();
                ItemRow.Text = ConRow["ФИО"].ToString();
                ItemRow.SubItems.AddRange(items);
                listViewNastavlayemiy.Items.Add(ItemRow);
            }
            string FIOitem;
            foreach (DataRow FIOrow in this.старт_в_будущее_КПDataSet1.УЧАСТНИК)
            {
                FIOitem = FIOrow["ФИО"].ToString();
                comboBoxFIO.Items.Add(FIOitem);
            }
        }
        public Form_NastavlayemiyList()
        {
            InitializeComponent();
        }

        private void buttonSaveNastavlayemiy_Click(object sender, EventArgs e)
        {
            DataRow[] MemberDataRow = старт_в_будущее_КПDataSet1.УЧАСТНИК.Select("ФИО='" + comboBoxFIO.Text + "'");

            Guid IDfio = (Guid)MemberDataRow[0]["ID"];
            наставляемыйTableAdapter1.Insert(DateTime.Now, IDfio, richTextBoxExpectations.Text, DateTime.Now);
            FillNastavlayemiyList();
            MessageBox.Show("Добавление выполнено успешно!");
        }
    }
}
