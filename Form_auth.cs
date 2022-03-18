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
    public partial class Form_auth : Form
    {
        public Form_auth()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (textBox_login.Text == "admin" && textBox_password.Text == "admin")
            {
                Form_main form_Main = new Form_main();
                form_Main.Show();
                this.Hide();
            }
        }

        private void label_registeruser_Click(object sender, EventArgs e)
        {
            Form_registration form_Registration = new Form_registration();
            form_Registration.Show();
            this.Hide();
        }
    }
}
