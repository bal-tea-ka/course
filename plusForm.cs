using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace Design_Coure_Work
{
    public partial class plusForm : Form
    {
        bool text_change = false; string filename = ""; string name = "";
        public plusForm()
        {
            InitializeComponent();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (text_change) name = color_textBox.Text;
            Image img = color_pictureBox.Image;
            img.Save(@".\Colors\" + name + ".png");
            img.Dispose();
            MessageBox.Show("Сохранено");
            Close();

        }

        private void color_textBox_TextChanged(object sender, EventArgs e)
        {
            text_change = true;
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            filename = openFileDialog1.FileName;
            Image img = Image.FromFile(filename);
            color_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            color_pictureBox.Image = img;
        }

        private void plusForm_Load(object sender, EventArgs e)
        {

        }
    }
}
