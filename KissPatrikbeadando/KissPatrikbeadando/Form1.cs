using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KissPatrikbeadando
{
    public partial class Form1 : Form
    {
        BindingList<Gyumolcslista> gyumolcslista = new BindingList<Gyumolcslista>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Comma Seperated Values (*.csv)|*.csv";
            ofd.DefaultExt = "csv";
            ofd.AddExtension = true;

            if (ofd.ShowDialog() != DialogResult.OK) return;
            using (StreamReader sr = new StreamReader(ofd.FileName, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    string[] sor = sr.ReadLine().Split(';');
                }


            }
        }
    }
}
