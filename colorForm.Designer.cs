namespace Design_Coure_Work
{
    partial class colorForm
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
            color_pictureBox = new PictureBox();
            searh_button = new Button();
            ((System.ComponentModel.ISupportInitialize)color_pictureBox).BeginInit();
            SuspendLayout();
            // 
            // color_label
            // 
            color_label.AutoSize = true;
            color_label.Location = new Point(128, 174);
            color_label.Name = "color_label";
            color_label.Size = new Size(100, 20);
            color_label.TabIndex = 0;
            color_label.Text = "Номер цвета";
            // 
            // color_textBox
            // 
            color_textBox.Location = new Point(128, 210);
            color_textBox.Name = "color_textBox";
            color_textBox.Size = new Size(175, 27);
            color_textBox.TabIndex = 1;
            color_textBox.TextChanged += color_textBox_TextChanged;
            // 
            // color_pictureBox
            // 
            color_pictureBox.Location = new Point(417, 86);
            color_pictureBox.Name = "color_pictureBox";
            color_pictureBox.Size = new Size(278, 273);
            color_pictureBox.TabIndex = 2;
            color_pictureBox.TabStop = false;
            // 
            // searh_button
            // 
            searh_button.Location = new Point(128, 330);
            searh_button.Name = "searh_button";
            searh_button.Size = new Size(175, 29);
            searh_button.TabIndex = 3;
            searh_button.Text = "Найти";
            searh_button.UseVisualStyleBackColor = true;
            searh_button.Click += searh_button_Click;
            // 
            // colorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(searh_button);
            Controls.Add(color_pictureBox);
            Controls.Add(color_textBox);
            Controls.Add(color_label);
            Name = "colorForm";
            Text = "colorForm";
            Load += colorForm_Load;
            ((System.ComponentModel.ISupportInitialize)color_pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label color_label;
        private TextBox color_textBox;
        private PictureBox color_pictureBox;
        private Button searh_button;
    }
}