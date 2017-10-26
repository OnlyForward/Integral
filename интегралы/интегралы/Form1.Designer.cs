namespace курсовая1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.спарвкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.highpredel = new System.Windows.Forms.TextBox();
            this.lowpredel = new System.Windows.Forms.TextBox();
            this.diferencal = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.parabol = new System.Windows.Forms.RadioButton();
            this.trap = new System.Windows.Forms.RadioButton();
            this.primoug = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "введите подинтегральное выражение";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "решить определенный интеграл";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(363, 75);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(360, 24);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(997, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.спарвкаToolStripMenuItem,
            this.закрытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // спарвкаToolStripMenuItem
            // 
            this.спарвкаToolStripMenuItem.Name = "спарвкаToolStripMenuItem";
            this.спарвкаToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.спарвкаToolStripMenuItem.Text = "Спарвка";
            this.спарвкаToolStripMenuItem.Click += new System.EventHandler(this.спарвкаToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(306, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // highpredel
            // 
            this.highpredel.Location = new System.Drawing.Point(272, 38);
            this.highpredel.Name = "highpredel";
            this.highpredel.Size = new System.Drawing.Size(100, 22);
            this.highpredel.TabIndex = 6;
            this.highpredel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.highpredel_KeyPress);
            // 
            // lowpredel
            // 
            this.lowpredel.Location = new System.Drawing.Point(272, 121);
            this.lowpredel.Name = "lowpredel";
            this.lowpredel.Size = new System.Drawing.Size(100, 22);
            this.lowpredel.TabIndex = 7;
            this.lowpredel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lowpredel_KeyPress);
            // 
            // diferencal
            // 
            this.diferencal.AutoSize = true;
            this.diferencal.Location = new System.Drawing.Point(729, 79);
            this.diferencal.Name = "diferencal";
            this.diferencal.Size = new System.Drawing.Size(38, 17);
            this.diferencal.TabIndex = 8;
            this.diferencal.Text = "dx = ";
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox2.Location = new System.Drawing.Point(770, 76);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(215, 22);
            this.textBox2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Введите количество разбиений ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(277, 182);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(101, 22);
            this.textBox3.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.parabol);
            this.panel1.Controls.Add(this.trap);
            this.panel1.Controls.Add(this.primoug);
            this.panel1.Location = new System.Drawing.Point(770, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 104);
            this.panel1.TabIndex = 12;
            // 
            // parabol
            // 
            this.parabol.AutoSize = true;
            this.parabol.Location = new System.Drawing.Point(3, 57);
            this.parabol.Name = "parabol";
            this.parabol.Size = new System.Drawing.Size(129, 21);
            this.parabol.TabIndex = 2;
            this.parabol.TabStop = true;
            this.parabol.Text = "метод порабол";
            this.parabol.UseVisualStyleBackColor = true;
            // 
            // trap
            // 
            this.trap.AutoSize = true;
            this.trap.Location = new System.Drawing.Point(3, 30);
            this.trap.Name = "trap";
            this.trap.Size = new System.Drawing.Size(136, 21);
            this.trap.TabIndex = 1;
            this.trap.TabStop = true;
            this.trap.Text = "метод трапеций";
            this.trap.UseVisualStyleBackColor = true;
            // 
            // primoug
            // 
            this.primoug.AutoSize = true;
            this.primoug.Location = new System.Drawing.Point(3, 3);
            this.primoug.Name = "primoug";
            this.primoug.Size = new System.Drawing.Size(187, 21);
            this.primoug.TabIndex = 0;
            this.primoug.Text = "метод прямоугольников";
            this.primoug.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 353);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.diferencal);
            this.Controls.Add(this.lowpredel);
            this.Controls.Add(this.highpredel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Определенный интеграл";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem спарвкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox highpredel;
        private System.Windows.Forms.TextBox lowpredel;
        private System.Windows.Forms.Label diferencal;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton parabol;
        private System.Windows.Forms.RadioButton trap;
        private System.Windows.Forms.RadioButton primoug;
    }
}

