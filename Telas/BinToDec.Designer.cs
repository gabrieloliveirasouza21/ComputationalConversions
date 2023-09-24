namespace ComputationalConversions {
    partial class BinToDec {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            panel1 = new Panel();
            button2 = new Button();
            textBoxDecimal = new TextBox();
            label2 = new Label();
            textBoxBin = new TextBox();
            label1 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 22, 25);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(textBoxDecimal);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxBin);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(411, 535);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe Script", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(117, 272);
            button2.Name = "button2";
            button2.Size = new Size(140, 41);
            button2.TabIndex = 5;
            button2.Text = "Converter";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBoxDecimal
            // 
            textBoxDecimal.Location = new Point(117, 420);
            textBoxDecimal.Name = "textBoxDecimal";
            textBoxDecimal.ReadOnly = true;
            textBoxDecimal.Size = new Size(140, 23);
            textBoxDecimal.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Script", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(117, 117);
            label2.Name = "label2";
            label2.Size = new Size(133, 38);
            label2.TabIndex = 3;
            label2.Text = "Binário :";
            label2.Click += label2_Click;
            // 
            // textBoxBin
            // 
            textBoxBin.Location = new Point(117, 200);
            textBoxBin.Name = "textBoxBin";
            textBoxBin.Size = new Size(140, 23);
            textBoxBin.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(117, 351);
            label1.Name = "label1";
            label1.Size = new Size(140, 38);
            label1.TabIndex = 1;
            label1.Text = "Decimal :";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(13, 12);
            button1.Name = "button1";
            button1.Size = new Size(65, 36);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            // 
            // BinToDec
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 533);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "BinToDec";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label2;
        private TextBox textBoxBin;
        private Label label1;
        private TextBox textBoxDecimal;
        private Button button2;
    }
}