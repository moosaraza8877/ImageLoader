using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageLoader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            lblImagePath.Text = openFileDialog1.FileName;
            pictureBox1.Image = System.Drawing.Bitmap.FromFile(lblImagePath.Text);
            pictureBox1.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblImagePath.Text = "";
            pictureBox1.Visible = false;
        }
    }
}
