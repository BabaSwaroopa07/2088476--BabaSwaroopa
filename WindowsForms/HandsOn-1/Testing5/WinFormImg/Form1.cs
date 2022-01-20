using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormImg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            var ba = new OpenFileDialog();
            var Ans = ba.ShowDialog();
            if (Ans == DialogResult.OK)
            {
                var path = ba.FileName;
                imgBox.Image = new Bitmap(path);
            }

        }
    }
}
