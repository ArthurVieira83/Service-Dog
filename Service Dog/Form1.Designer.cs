namespace Service_Dog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            buscarRaçasToolStripMenuItem = new ToolStripMenuItem();
            raçasFavotirasToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(323, 130);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 129);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(253, 279);
            label1.Name = "label1";
            label1.Size = new Size(274, 27);
            label1.TabIndex = 1;
            label1.Text = "Bem vindo ao  Service Dog";
            label1.Click += label1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { buscarRaçasToolStripMenuItem, raçasFavotirasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // buscarRaçasToolStripMenuItem
            // 
            buscarRaçasToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buscarRaçasToolStripMenuItem.Name = "buscarRaçasToolStripMenuItem";
            buscarRaçasToolStripMenuItem.Size = new Size(90, 20);
            buscarRaçasToolStripMenuItem.Text = "Buscar Raças";
            // 
            // raçasFavotirasToolStripMenuItem
            // 
            raçasFavotirasToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            raçasFavotirasToolStripMenuItem.Name = "raçasFavotirasToolStripMenuItem";
            raçasFavotirasToolStripMenuItem.Size = new Size(103, 20);
            raçasFavotirasToolStripMenuItem.Text = "Raças Favotiras";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Service Dog";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem buscarRaçasToolStripMenuItem;
        private ToolStripMenuItem raçasFavotirasToolStripMenuItem;
    }
}
