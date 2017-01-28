namespace SharpProject
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.лабораторныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.одномерныеМассивыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.строкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.курсоваяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.базаДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.лабораторныеToolStripMenuItem,
            this.курсоваяToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(558, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // лабораторныеToolStripMenuItem
            // 
            this.лабораторныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.одномерныеМассивыToolStripMenuItem,
            this.строкиToolStripMenuItem});
            this.лабораторныеToolStripMenuItem.Name = "лабораторныеToolStripMenuItem";
            this.лабораторныеToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.лабораторныеToolStripMenuItem.Text = "Лабораторные";
            // 
            // одномерныеМассивыToolStripMenuItem
            // 
            this.одномерныеМассивыToolStripMenuItem.Name = "одномерныеМассивыToolStripMenuItem";
            this.одномерныеМассивыToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.одномерныеМассивыToolStripMenuItem.Text = "Одномерные массивы";
            this.одномерныеМассивыToolStripMenuItem.Click += new System.EventHandler(this.одномерныеМассивыToolStripMenuItem_Click);
            // 
            // строкиToolStripMenuItem
            // 
            this.строкиToolStripMenuItem.Name = "строкиToolStripMenuItem";
            this.строкиToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.строкиToolStripMenuItem.Text = "Строки";
            this.строкиToolStripMenuItem.Click += new System.EventHandler(this.строкиToolStripMenuItem_Click);
            // 
            // курсоваяToolStripMenuItem
            // 
            this.курсоваяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.базаДанныхToolStripMenuItem});
            this.курсоваяToolStripMenuItem.Name = "курсоваяToolStripMenuItem";
            this.курсоваяToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.курсоваяToolStripMenuItem.Text = "Курсовая";
            // 
            // базаДанныхToolStripMenuItem
            // 
            this.базаДанныхToolStripMenuItem.Name = "базаДанныхToolStripMenuItem";
            this.базаДанныхToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.базаДанныхToolStripMenuItem.Text = "База Данных";
            this.базаДанныхToolStripMenuItem.Click += new System.EventHandler(this.базаДанныхToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(558, 395);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Лабораторные C#";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem лабораторныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem одномерныеМассивыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem строкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem курсоваяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem базаДанныхToolStripMenuItem;
    }
}

