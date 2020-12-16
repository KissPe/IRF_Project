
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
    public partial class Nyeremenyjatek : Form
    {
        Graphics g = null;
        public Nyeremenyjatek()
        {
            InitializeComponent();
            g = Graphics.FromHwnd(Handle);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(myBrush, new Rectangle(0, 50, 200, 100));
            formGraphics.FillRectangle(myBrush, new Rectangle(200, 100, 400, 200));
            formGraphics.FillRectangle(myBrush, new Rectangle(600, 250, 200, 100));
            myBrush.Dispose();
            formGraphics.Dispose();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

