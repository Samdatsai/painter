namespace Painter
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
            menuStrip1 = new MenuStrip();
            畫筆色彩ToolStripMenuItem = new ToolStripMenuItem();
            藍ToolStripMenuItem = new ToolStripMenuItem();
            黑ToolStripMenuItem = new ToolStripMenuItem();
            紅ToolStripMenuItem = new ToolStripMenuItem();
            灰ToolStripMenuItem = new ToolStripMenuItem();
            線條粗細ToolStripMenuItem = new ToolStripMenuItem();
            細ToolStripMenuItem = new ToolStripMenuItem();
            中ToolStripMenuItem = new ToolStripMenuItem();
            粗ToolStripMenuItem = new ToolStripMenuItem();
            線條模式ToolStripMenuItem = new ToolStripMenuItem();
            直線ToolStripMenuItem = new ToolStripMenuItem();
            點短粗線ToolStripMenuItem = new ToolStripMenuItem();
            長短虛線ToolStripMenuItem = new ToolStripMenuItem();
            储存檔案ToolStripMenuItem = new ToolStripMenuItem();
            橡皮擦ToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            panel1 = new Panel();
            button3 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 畫筆色彩ToolStripMenuItem, 線條粗細ToolStripMenuItem, 線條模式ToolStripMenuItem, 储存檔案ToolStripMenuItem, 橡皮擦ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 畫筆色彩ToolStripMenuItem
            // 
            畫筆色彩ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 藍ToolStripMenuItem, 黑ToolStripMenuItem, 紅ToolStripMenuItem, 灰ToolStripMenuItem });
            畫筆色彩ToolStripMenuItem.Name = "畫筆色彩ToolStripMenuItem";
            畫筆色彩ToolStripMenuItem.Size = new Size(67, 20);
            畫筆色彩ToolStripMenuItem.Text = "畫筆色彩";
            // 
            // 藍ToolStripMenuItem
            // 
            藍ToolStripMenuItem.Name = "藍ToolStripMenuItem";
            藍ToolStripMenuItem.Size = new Size(86, 22);
            藍ToolStripMenuItem.Text = "藍";
            藍ToolStripMenuItem.Click += 藍ToolStripMenuItem_Click;
            // 
            // 黑ToolStripMenuItem
            // 
            黑ToolStripMenuItem.Name = "黑ToolStripMenuItem";
            黑ToolStripMenuItem.Size = new Size(86, 22);
            黑ToolStripMenuItem.Text = "黑";
            黑ToolStripMenuItem.Click += 黑ToolStripMenuItem_Click;
            // 
            // 紅ToolStripMenuItem
            // 
            紅ToolStripMenuItem.Name = "紅ToolStripMenuItem";
            紅ToolStripMenuItem.Size = new Size(86, 22);
            紅ToolStripMenuItem.Text = "紅";
            紅ToolStripMenuItem.Click += 紅ToolStripMenuItem_Click;
            // 
            // 灰ToolStripMenuItem
            // 
            灰ToolStripMenuItem.Name = "灰ToolStripMenuItem";
            灰ToolStripMenuItem.Size = new Size(86, 22);
            灰ToolStripMenuItem.Text = "灰";
            灰ToolStripMenuItem.Click += 灰ToolStripMenuItem_Click;
            // 
            // 線條粗細ToolStripMenuItem
            // 
            線條粗細ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 細ToolStripMenuItem, 中ToolStripMenuItem, 粗ToolStripMenuItem });
            線條粗細ToolStripMenuItem.Name = "線條粗細ToolStripMenuItem";
            線條粗細ToolStripMenuItem.Size = new Size(67, 20);
            線條粗細ToolStripMenuItem.Text = "線條粗細";
            // 
            // 細ToolStripMenuItem
            // 
            細ToolStripMenuItem.Name = "細ToolStripMenuItem";
            細ToolStripMenuItem.Size = new Size(86, 22);
            細ToolStripMenuItem.Text = "細";
            細ToolStripMenuItem.Click += 細ToolStripMenuItem_Click;
            // 
            // 中ToolStripMenuItem
            // 
            中ToolStripMenuItem.Name = "中ToolStripMenuItem";
            中ToolStripMenuItem.Size = new Size(86, 22);
            中ToolStripMenuItem.Text = "中";
            中ToolStripMenuItem.Click += 中ToolStripMenuItem_Click;
            // 
            // 粗ToolStripMenuItem
            // 
            粗ToolStripMenuItem.Name = "粗ToolStripMenuItem";
            粗ToolStripMenuItem.Size = new Size(86, 22);
            粗ToolStripMenuItem.Text = "粗";
            粗ToolStripMenuItem.Click += 粗ToolStripMenuItem_Click;
            // 
            // 線條模式ToolStripMenuItem
            // 
            線條模式ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 直線ToolStripMenuItem, 點短粗線ToolStripMenuItem, 長短虛線ToolStripMenuItem });
            線條模式ToolStripMenuItem.Name = "線條模式ToolStripMenuItem";
            線條模式ToolStripMenuItem.Size = new Size(67, 20);
            線條模式ToolStripMenuItem.Text = "線條模式";
            // 
            // 直線ToolStripMenuItem
            // 
            直線ToolStripMenuItem.Name = "直線ToolStripMenuItem";
            直線ToolStripMenuItem.Size = new Size(134, 22);
            直線ToolStripMenuItem.Text = "直線";
            直線ToolStripMenuItem.Click += 直線ToolStripMenuItem_Click;
            // 
            // 點短粗線ToolStripMenuItem
            // 
            點短粗線ToolStripMenuItem.Name = "點短粗線ToolStripMenuItem";
            點短粗線ToolStripMenuItem.Size = new Size(134, 22);
            點短粗線ToolStripMenuItem.Text = "點、短粗線";
            點短粗線ToolStripMenuItem.Click += 點短粗線ToolStripMenuItem_Click;
            // 
            // 長短虛線ToolStripMenuItem
            // 
            長短虛線ToolStripMenuItem.Name = "長短虛線ToolStripMenuItem";
            長短虛線ToolStripMenuItem.Size = new Size(134, 22);
            長短虛線ToolStripMenuItem.Text = "長短虛線";
            長短虛線ToolStripMenuItem.Click += 長短虛線ToolStripMenuItem_Click;
            // 
            // 储存檔案ToolStripMenuItem
            // 
            储存檔案ToolStripMenuItem.Name = "储存檔案ToolStripMenuItem";
            储存檔案ToolStripMenuItem.Size = new Size(67, 20);
            储存檔案ToolStripMenuItem.Text = "储存檔案";
            储存檔案ToolStripMenuItem.Click += 储存檔案ToolStripMenuItem_Click;
            // 
            // 橡皮擦ToolStripMenuItem
            // 
            橡皮擦ToolStripMenuItem.Name = "橡皮擦ToolStripMenuItem";
            橡皮擦ToolStripMenuItem.Size = new Size(55, 20);
            橡皮擦ToolStripMenuItem.Text = "橡皮擦";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.Location = new Point(0, 157);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(636, 306);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            // 
            // button1
            // 
            button1.Location = new Point(693, 169);
            button1.Name = "button1";
            button1.Size = new Size(75, 132);
            button1.TabIndex = 2;
            button1.Text = "清除";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(136, 129);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.下載;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(3, 0);
            button2.Name = "button2";
            button2.Size = new Size(136, 129);
            button2.TabIndex = 4;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(0, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(529, 129);
            panel1.TabIndex = 5;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.pencil;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Location = new Point(159, 8);
            button3.Name = "button3";
            button3.Size = new Size(113, 118);
            button3.TabIndex = 5;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "小畫家";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 畫筆色彩ToolStripMenuItem;
        private ToolStripMenuItem 藍ToolStripMenuItem;
        private ToolStripMenuItem 黑ToolStripMenuItem;
        private ToolStripMenuItem 紅ToolStripMenuItem;
        private ToolStripMenuItem 線條粗細ToolStripMenuItem;
        private ToolStripMenuItem 細ToolStripMenuItem;
        private ToolStripMenuItem 中ToolStripMenuItem;
        private ToolStripMenuItem 粗ToolStripMenuItem;
        private ToolStripMenuItem 線條模式ToolStripMenuItem;
        private ToolStripMenuItem 直線ToolStripMenuItem;
        private ToolStripMenuItem 點短粗線ToolStripMenuItem;
        private ToolStripMenuItem 長短虛線ToolStripMenuItem;
        private ToolStripMenuItem 储存檔案ToolStripMenuItem;
        private PictureBox pictureBox1;
        private Button button1;
        private ToolStripMenuItem 灰ToolStripMenuItem;
        private ToolStripMenuItem 橡皮擦ToolStripMenuItem;
        private PictureBox pictureBox2;
        private Button button2;
        private Panel panel1;
        private Button button3;
    }
}