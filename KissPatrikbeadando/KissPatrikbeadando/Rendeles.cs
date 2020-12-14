using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

    }
}
