using ClosedXML.Excel;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;

namespace Diplom_Start_v_budushee
{
    public partial class Form_ExcelViewer : Form
    {
        public Form_ExcelViewer()
        {
            InitializeComponent();
        }
        void SaveDataGridViewToCSV(string filename)
        {
            // Choose whether to write header. Use EnableWithoutHeaderText instead to omit header.
            dataGridViewCSVviewer.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            // Select all the cells
            dataGridViewCSVviewer.SelectAll();
            // Copy selected cells to DataObject
            DataObject dataObject = dataGridViewCSVviewer.GetClipboardContent();
            // Get the text of the DataObject, and serialize it to a file
            File.WriteAllText(filename, dataObject.GetText(TextDataFormat.CommaSeparatedValue));
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx", Multiselect = false})
            {
                if(ofd.ShowDialog()==DialogResult.OK)
                {
                    DataTable dt = new DataTable();
                    using(XLWorkbook workbook = new XLWorkbook(ofd.FileName))
                    {
                        bool IsFirstRow = true;
                        var rows = workbook.Worksheet(1).RowsUsed();
                        foreach(var row in rows)
                        {
                            if(IsFirstRow)
                            {
                                foreach (IXLCell cell in row.Cells())
                                    dt.Columns.Add(cell.Value.ToString());
                                IsFirstRow = false;
                            }
                            else
                            {
                                dt.Rows.Add();
                                int i = 0;
                                foreach (IXLCell cell in row.Cells())
                                    dt.Rows[dt.Rows.Count - 1][i++] = cell.Value.ToString();
                            }
                        }
                        dataGridView1.DataSource = dt.DefaultView;
                        label_ReportAmmount.Text = $"Total records: {dataGridView1.RowCount}";
                    }
                }
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            try
            {
                DataView dv = dataGridView1.DataSource as DataView;
                if (dv != null)
                    dv.RowFilter = textBox_search.Text;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                button_search.PerformClick();
        }
        private void button_write_Click(object sender, EventArgs e)
        {
            //using(SaveFileDialog sfd = new SaveFileDialog() { Filter="CSV|.csv",ValidateNames=true})
            //{
            //    if(sfd.ShowDialog() == DialogResult.OK)
            //    {
            //        using(var sw = new StreamWriter(sfd.FileName))
            //        {
            //            var writer = new CsvWriter(sw, System.Globalization.CultureInfo.CurrentCulture);
            //            writer.WriteHeader(typeof(Student));
            //            foreach(Student s in studentBindingSource.DataSource as List<Student>)
            //            {
            //                writer.WriteRecord(s);
            //            }
            //        }
            //        MessageBox.Show("Ваши данные были успешно сохранены.", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            //    }
            //}

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|.csv", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    SaveDataGridViewToCSV(sfd.FileName);
                }
            }
        }
        private void button_read_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|*.csv", ValidateNames=true})
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    var sr = new StreamReader(new FileStream(ofd.FileName, FileMode.Open));
                    var csv = new CsvReader(sr, System.Globalization.CultureInfo.CurrentCulture);
                    studentBindingSource2.DataSource = csv.GetRecord<Student>().ToString();
                }
            }
        }

        private void Form_ExcelViewer_Load(object sender, EventArgs e)
        {
            studentBindingSource2.DataSource = new List<Student>();
        }
    }
}
