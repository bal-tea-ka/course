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
    public partial class collectionForm : Form
    {
        public collectionForm()
        {
            InitializeComponent();
            
        }

        private void collectionForm_Load(object sender, EventArgs e)
        {
            FlowLayoutPanel fl = new FlowLayoutPanel { Dock = DockStyle.Fill };
            fl.Location = new Point(10, 10);
            fl.FlowDirection = FlowDirection.LeftToRight;
            fl.Visible = true;
            fl.AutoScroll = true; // Добавляем панель в форму
            this.Controls.Add(fl);
            int count = 0;
            try
            {
                DirectoryInfo d = new DirectoryInfo(@".\Colors"); // your Folder
                FileInfo[] Files = d.GetFiles("*.png"); //Getting files
                string str = "";
                int k = 0;
                Dictionary<int, string> myDict = new Dictionary<int, string>();
                foreach (FileInfo file in Files)
                {
                    str = str + file.Name + "\n";
                    myDict.Add(k, file.Name);
                    k++;
                }
                //List of files
                string s = "";
                foreach (KeyValuePair<int, string> x in myDict)
                {
                    s = s + x.Key + " " + x.Value + "\n";
                }
                MessageBox.Show(s);
                count = myDict.Count;
                List<PictureBox> pics = new List<PictureBox>();
                for (int i = 0; i < count; i++)
                {
                    PictureBox p = new PictureBox();
                    pics.Add(p);
                    pics[i].MouseHover += new EventHandler(pictureBox_MouseHover);
                    pics[i].MouseLeave += new EventHandler(pictureBox_MouseLeave);
                    pics[i].Width = 200;
                    pics[i].Height = 200;
                    pics[i].Image = Image.FromFile(@".Colors\" + myDict[i]);
                    pics[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    pics[i].BorderStyle = BorderStyle.Fixed3D;
                    fl.Controls.Add(pics[i]); // Добавляем PictureBox на панель
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            fl.Show();


        }
        private void pictureBox_MouseHover(object sender, EventArgs e)
        {
            PictureBox currentPicBox = (PictureBox)sender;
            if (currentPicBox.Left + currentPicBox.Width + 100 > this.Width)
            { MessageBox.Show(currentPicBox.Name); }
            else
            {
                currentPicBox.Width = 350;
                currentPicBox.Height = 350;
            }
        }
        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            PictureBox currentPicBox = (PictureBox)sender;
            currentPicBox.Width = 200;
            currentPicBox.Height = 200;
        }
    }
}
