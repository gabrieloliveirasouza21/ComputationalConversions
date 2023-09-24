namespace ComputationalConversions {
    partial class TelaMenuPrincipal {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            Button buttonDecimalBinario;
            Button button1;
            Button button2;
            Button button3;
            panel1 = new Panel();
            label1 = new Label();
            buttonDecimalBinario = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDecimalBinario
            // 
            buttonDecimalBinario.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDecimalBinario.Location = new Point(97, 244);
            buttonDecimalBinario.Name = "buttonDecimalBinario";
            buttonDecimalBinario.Size = new Size(151, 55);
            buttonDecimalBinario.TabIndex = 1;
            buttonDecimalBinario.Text = "Decimal para Binário";
            buttonDecimalBinario.UseVisualStyleBackColor = true;
            buttonDecimalBinario.Click += button1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(411, 244);
            button1.Name = "button1";
            button1.Size = new Size(151, 55);
            button1.TabIndex = 2;
            button1.Text = "Binário para Decimal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(97, 393);
            button2.Name = "button2";
            button2.Size = new Size(151, 55);
            button2.TabIndex = 3;
            button2.Text = "Hexadecimal para Decimal";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(411, 393);
            button3.Name = "button3";
            button3.Size = new Size(151, 55);
            button3.TabIndex = 4;
            button3.Text = "Decimal para Hexadecimal";
            button3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 22, 25);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(buttonDecimalBinario);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(667, 500);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(97, 58);
            label1.Name = "label1";
            label1.Size = new Size(465, 53);
            label1.TabIndex = 0;
            label1.Text = "Computational Conversor";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(663, 491);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Computational Conversor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonDecimalBinario;
        private Label label1;
    }
}