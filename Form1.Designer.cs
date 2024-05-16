namespace Design_Coure_Work
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            searh_button = new Button();
            plus_button = new Button();
            collection_button = new Button();
            SuspendLayout();
            // 
            // searh_button
            // 
            searh_button.Location = new Point(288, 200);
            searh_button.Name = "searh_button";
            searh_button.Size = new Size(232, 77);
            searh_button.TabIndex = 0;
            searh_button.Text = "Поиск по номеру";
            searh_button.UseVisualStyleBackColor = true;
            searh_button.Click += searh_button_Click;
            // 
            // plus_button
            // 
            plus_button.Location = new Point(289, 296);
            plus_button.Name = "plus_button";
            plus_button.Size = new Size(231, 69);
            plus_button.TabIndex = 2;
            plus_button.Text = "Добавить цвет в коллекцию";
            plus_button.UseVisualStyleBackColor = true;
            plus_button.Click += plus_button_Click;
            // 
            // collection_button
            // 
            collection_button.Location = new Point(289, 107);
            collection_button.Name = "collection_button";
            collection_button.Size = new Size(231, 73);
            collection_button.TabIndex = 3;
            collection_button.Text = "Коллекция";
            collection_button.UseVisualStyleBackColor = true;
            collection_button.Click += collection_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(collection_button);
            Controls.Add(plus_button);
            Controls.Add(searh_button);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button searh_button;
        private Button plus_button;
        private Button collection_button;
    }
}
