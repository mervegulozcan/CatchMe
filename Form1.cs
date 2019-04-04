using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeniYakala
{
    public partial class Form1 : Form
    {
        int hamle;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnHedef.Image = ımageList1.Images[0];

        }

        private void btnHedef_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(string.Format($"Tebrikler {hamle}. hamlede tıkladınız"));
            hamle = 0;
            Text = hamle.ToString();
        }

        private void btnHedef_MouseEnter(object sender, EventArgs e)
        {
            Random rnd = new Random();

            btnHedef.Left = rnd.Next(0, this.ClientSize.Width - btnHedef.ClientSize.Width);
            btnHedef.Top = rnd.Next(0, this.ClientSize.Height - btnHedef.ClientSize.Height);


        }

        private void Form1_Click(object sender, EventArgs e)
        {
            hamle++;
            Text = hamle.ToString();
        }
    }
}
