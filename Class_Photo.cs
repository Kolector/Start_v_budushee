using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom_Start_v_budushee
{
    public class Class_Photo
    {
        public string PhotoName { get; set; }
        private string PhotoPath { get; set; }
        private string PhotoExtension { get; set; }
        public Class_Photo()
        {
            Console.WriteLine("!!! Класс Class_Photo создан.");

            OpenFileDialog dialog = new OpenFileDialog();

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo file = new FileInfo(dialog.FileName);

                PhotoName = file.Name;
                PhotoPath = file.FullName;
                PhotoExtension = file.Extension;
            }
        }
    }
}
