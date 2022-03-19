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
    public partial class Form_rukovodstvo : Form
    {
        public Form_rukovodstvo()
        {
            InitializeComponent();
        }

        private void listViewOverview_MouseClick(object sender, MouseEventArgs e)
        {
            if (listViewOverview.Items[0].Selected == true )
            {
                richTextBoxRTF.Rtf = Properties.Resources.Руководство_оператора_Старт_в_будущее;
            }

        }
    }
}
