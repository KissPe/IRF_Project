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
    public partial class Kezdolap : Form
    {
        BindingList<Gyumolcslista> gyumolcslista = new BindingList<Gyumolcslista>();
        public Kezdolap()
        {
            InitializeComponent();
            dgw.DataSource = gyumolcslista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Application.StartupPath;
            ofd.Filter = "Comma Seperated Values (*.csv)|*.csv";
            ofd.DefaultExt = "csv";
            ofd.AddExtension = true;

            if (ofd.ShowDialog() != DialogResult.OK) return;
            using (StreamReader sr = new StreamReader(ofd.FileName, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    string[] sor = sr.ReadLine().Split(';');
                    Gyumolcslista gy = new Gyumolcslista();
                    try
                    {
                        gy.Index = Convert.ToInt32(sor[0]);
                    }
                    catch { }
                    gy.Név = sor[1];
                    try
                    {
                        gy.Nettóár = Convert.ToInt32(sor[2]);
                    }
                    catch { }
                    try
                    {
                        gy.ÁFA = Convert.ToInt32(sor[3]);
                    }
                    catch { }
                    try
                    {
                        gy.Összesen = Convert.ToInt32(sor[4]);
                    }
                    catch { }
                    gyumolcslista.Add(gy);
                }


            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Rendeles r = new Rendeles();
            r.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Nyeremenyjatek ny = new Nyeremenyjatek();
            ny.ShowDialog();

        }
    }
}
