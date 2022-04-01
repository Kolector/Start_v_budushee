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
    public partial class Form_reporttest : Form
    {
        public Form_reporttest()
        {
            InitializeComponent();
        }

        private void Form_reporttest_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
