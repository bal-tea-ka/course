namespace Design_Coure_Work
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void searh_button_Click(object sender, EventArgs e)
        {
            colorForm form2 = new colorForm();
            form2.Show();
        }

        private void plus_button_Click(object sender, EventArgs e)
        {
            plusForm form4 = new plusForm();
            form4.Show();
        }

        private void collection_button_Click(object sender, EventArgs e)
        {
            collectionForm form3 = new collectionForm();
            form3.Show();
        }
    }
}
