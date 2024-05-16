namespace Design_Coure_Work
{
    partial class plusForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            color_label = new Label();
            color_textBox = new TextBox();
            save_button = new Button();
            color_pictureBox = new PictureBox();
            search_button = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)color_pictureBox).BeginInit();
            SuspendLayout();
            // 
            // color_label
            // 
            color_label.AutoSize = true;
            color_label.Location = new Point(133, 185);
            color_label.Name = "color_label";
            color_label.Size = new Size(100, 20);
            color_label.TabIndex = 0;
            color_label.Text = "Номер цвета";
            // 
            // color_textBox
            // 
            color_textBox.Location = new Point(133, 221);
            color_textBox.Name = "color_textBox";
            color_textBox.Size = new Size(175, 27);
            color_textBox.TabIndex = 1;
            color_textBox.TextChanged += color_textBox_TextChanged;
            // 
            // save_button
            // 
            save_button.Location = new Point(133, 354);
            save_button.Name = "save_button";
            save_button.Size = new Size(175, 30);
            save_button.TabIndex = 3;
            save_button.Text = "Сохранить";
            save_button.UseVisualStyleBackColor = true;
            save_button.Click += save_button_Click;
            // 
            // color_pictureBox
            // 
            color_pictureBox.Location = new Point(431, 76);
            color_pictureBox.Name = "color_pictureBox";
            color_pictureBox.Size = new Size(252, 259);
            color_pictureBox.TabIndex = 4;
            color_pictureBox.TabStop = false;
            // 
            // search_button
            // 
            search_button.Location = new Point(431, 354);
            search_button.Name = "search_button";
            search_button.Size = new Size(252, 30);
            search_button.TabIndex = 5;
            search_button.Text = "Выбрать из файла ";
            search_button.UseVisualStyleBackColor = true;
            search_button.Click += search_button_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // plusForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(search_button);
            Controls.Add(color_pictureBox);
            Controls.Add(save_button);
            Controls.Add(color_textBox);
            Controls.Add(color_label);
            Name = "plusForm";
            Text = "plusForm";
            Load += plusForm_Load;
            ((System.ComponentModel.ISupportInitialize)color_pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label color_label;
        private TextBox color_textBox;
        private Button save_button;
        private PictureBox color_pictureBox;
        private Button search_button;
        private OpenFileDialog openFileDialog1;
    }
}