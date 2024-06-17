namespace Service_Dog
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(321, 37);
            label1.TabIndex = 0;
            label1.Text = "Encontre sua raça favorita";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 46);
            label2.Name = "label2";
            label2.Size = new Size(358, 21);
            label2.TabIndex = 1;
            label2.Text = "Abaixo selecione sua raça e saiba as caracterisitcas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(358, 159);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 2;
            label3.Text = "Raças do Dog";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(349, 229);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 3;
            label4.Text = "Temperamento";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(392, 299);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 4;
            label5.Text = "Origem";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(381, 364);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 5;
            label6.Text = "Tamanho";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, 151);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(354, 228);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(447, 151);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(204, 23);
            comboBox1.TabIndex = 7;
            comboBox1.Text = "Selecione uma Raça";
            // 
            // button1
            // 
            button1.Location = new Point(632, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(713, 415);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "Favoritar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(447, 229);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 10;
            label7.Text = "Resultado";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(447, 299);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 11;
            label8.Text = "Resultado";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(447, 364);
            label9.Name = "label9";
            label9.Size = new Size(59, 15);
            label9.TabIndex = 12;
            label9.Text = "Resultado";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Buscar Raças";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}