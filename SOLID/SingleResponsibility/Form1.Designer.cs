namespace SingleResponsibility
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
            textBoxName = new TextBox();
            textBoxPrice = new TextBox();
            button1 = new Button();
            buttonBackColor = new Button();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(43, 42);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(218, 27);
            textBoxName.TabIndex = 0;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(43, 75);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(218, 27);
            textBoxPrice.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(206, 122);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Ürün Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonBackColor
            // 
            buttonBackColor.Location = new Point(128, 355);
            buttonBackColor.Name = "buttonBackColor";
            buttonBackColor.Size = new Size(172, 29);
            buttonBackColor.TabIndex = 3;
            buttonBackColor.Text = "Renk Değiştir";
            buttonBackColor.UseVisualStyleBackColor = true;
            buttonBackColor.Click += buttonBackColor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 396);
            Controls.Add(buttonBackColor);
            Controls.Add(button1);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxPrice;
        private Button button1;
        private Button buttonBackColor;
    }
}
