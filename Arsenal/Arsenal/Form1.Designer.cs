namespace Arsenal
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
            this.ViewPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Hello_label = new System.Windows.Forms.Label();
            this.Aut_Button = new System.Windows.Forms.Button();
            this.Filtrpanel = new System.Windows.Forms.Panel();
            this.Reg_Button = new System.Windows.Forms.Button();
            this.FiltrButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.Filtrpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewPanel
            // 
            this.ViewPanel.AutoScroll = true;
            this.ViewPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ViewPanel.Location = new System.Drawing.Point(0, 167);
            this.ViewPanel.Name = "ViewPanel";
            this.ViewPanel.Size = new System.Drawing.Size(1278, 404);
            this.ViewPanel.TabIndex = 8;
            this.ViewPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPanel_Paint);
            this.ViewPanel.Resize += new System.EventHandler(this.ViewPanel_Resize);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.Reg_Button);
            this.panel1.Controls.Add(this.Hello_label);
            this.panel1.Controls.Add(this.Aut_Button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1278, 73);
            this.panel1.TabIndex = 9;
            // 
            // Hello_label
            // 
            this.Hello_label.AutoSize = true;
            this.Hello_label.Location = new System.Drawing.Point(213, 27);
            this.Hello_label.Name = "Hello_label";
            this.Hello_label.Size = new System.Drawing.Size(64, 25);
            this.Hello_label.TabIndex = 1;
            this.Hello_label.Text = "label1";
            // 
            // Aut_Button
            // 
            this.Aut_Button.Location = new System.Drawing.Point(23, 20);
            this.Aut_Button.Name = "Aut_Button";
            this.Aut_Button.Size = new System.Drawing.Size(159, 39);
            this.Aut_Button.TabIndex = 0;
            this.Aut_Button.Text = "Вход";
            this.Aut_Button.UseVisualStyleBackColor = true;
            this.Aut_Button.Click += new System.EventHandler(this.Aut_Button_Click);
            // 
            // Filtrpanel
            // 
            this.Filtrpanel.BackColor = System.Drawing.Color.DarkSalmon;
            this.Filtrpanel.Controls.Add(this.FiltrButton);
            this.Filtrpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Filtrpanel.Location = new System.Drawing.Point(0, 73);
            this.Filtrpanel.Name = "Filtrpanel";
            this.Filtrpanel.Size = new System.Drawing.Size(1278, 94);
            this.Filtrpanel.TabIndex = 10;
            // 
            // Reg_Button
            // 
            this.Reg_Button.Location = new System.Drawing.Point(1045, 25);
            this.Reg_Button.Name = "Reg_Button";
            this.Reg_Button.Size = new System.Drawing.Size(192, 33);
            this.Reg_Button.TabIndex = 2;
            this.Reg_Button.Text = "Регистрация";
            this.Reg_Button.UseVisualStyleBackColor = true;
            this.Reg_Button.Click += new System.EventHandler(this.Reg_Button_Click);
            // 
            // FiltrButton
            // 
            this.FiltrButton.Location = new System.Drawing.Point(0, 0);
            this.FiltrButton.Name = "FiltrButton";
            this.FiltrButton.Size = new System.Drawing.Size(161, 31);
            this.FiltrButton.TabIndex = 0;
            this.FiltrButton.Text = "Фильтр";
            this.FiltrButton.UseVisualStyleBackColor = true;
            this.FiltrButton.Click += new System.EventHandler(this.FiltrButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 571);
            this.Controls.Add(this.Filtrpanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ViewPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Filtrpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ViewPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Filtrpanel;
        private System.Windows.Forms.Button Aut_Button;
        private System.Windows.Forms.Label Hello_label;
        private System.Windows.Forms.Button Reg_Button;
        private System.Windows.Forms.Button FiltrButton;
    }
}

