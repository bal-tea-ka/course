using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Coure_Work
{
    public partial class colorForm : Form
    {
        bool text_change = false; string color_number;
        public colorForm()
        {
            InitializeComponent();
        }

        private void colorForm_Load(object sender, EventArgs e)
        {
            color_textBox.Text = "#ffffff";
            color_pictureBox.BackColor = Color.White;
        }

        private void color_textBox_TextChanged(object sender, EventArgs e)
        {
            text_change = true;
        }

        private void searh_button_Click(object sender, EventArgs e)
        {
            color_number = color_textBox.Text;
            color_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            color_pictureBox.Image = Image.FromFile(@".\Colors\" + color_number + ".png");
        }
    }
}
