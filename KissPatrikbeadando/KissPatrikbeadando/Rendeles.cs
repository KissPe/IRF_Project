using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace KissPatrikbeadando
{
    public partial class Rendeles : Form
    {
        public Rendeles()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<object> _selecteditems = new List<object>();
            foreach (var item in listBoxMegrendelheto.SelectedItems)
            {
                _selecteditems.Add(item);
            }
            foreach (var item in _selecteditems)
            {
                listBoxMegrendelt.Items.Add(item);
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBoxMegrendelt.Items.Remove(listBoxMegrendelt.SelectedItem);

        }
        Excel.Application xlApp; 
        Excel.Workbook xlWB; 
        Excel.Worksheet xlSheet;

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                
                xlApp = new Excel.Application();

               
                xlWB = xlApp.Workbooks.Add(Missing.Value);

                
                xlSheet = xlWB.ActiveSheet;



                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex) 
            {
                string errMsg = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(errMsg, "Error");

                
                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;
            }
        }

    }
}
