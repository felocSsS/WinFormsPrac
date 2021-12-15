namespace Prac
{
    partial class singn
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
            this.p_top = new System.Windows.Forms.Panel();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.t = new System.Windows.Forms.Label();
            this.hhh = new System.Windows.Forms.Label();
            this.btn_enter = new System.Windows.Forms.Button();
            this.cb_password = new System.Windows.Forms.CheckBox();
            this.l_captchatext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // p_top
            // 
            this.p_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.p_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_top.Location = new System.Drawing.Point(0, 0);
            this.p_top.Name = "p_top";
            this.p_top.Size = new System.Drawing.Size(784, 100);
            this.p_top.TabIndex = 0;
            // 
            // tb_login
            // 
            this.tb_login.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_login.Location = new System.Drawing.Point(376, 203);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(188, 37);
            this.tb_login.TabIndex = 1;
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_password.Location = new System.Drawing.Point(376, 266);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(188, 37);
            this.tb_password.TabIndex = 2;
            this.tb_password.UseSystemPasswordChar = true;
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.t.Location = new System.Drawing.Point(292, 206);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(82, 29);
            this.t.TabIndex = 3;
            this.t.Text = "Логин:";
            // 
            // hhh
            // 
            this.hhh.AutoSize = true;
            this.hhh.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hhh.Location = new System.Drawing.Point(278, 269);
            this.hhh.Name = "hhh";
            this.hhh.Size = new System.Drawing.Size(96, 29);
            this.hhh.TabIndex = 4;
            this.hhh.Text = "Пароль:";
            // 
            // btn_enter
            // 
            this.btn_enter.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_enter.Location = new System.Drawing.Point(410, 323);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(117, 38);
            this.btn_enter.TabIndex = 5;
            this.btn_enter.Text = "Войти";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // cb_password
            // 
            this.cb_password.AutoSize = true;
            this.cb_password.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_password.Location = new System.Drawing.Point(580, 269);
            this.cb_password.Name = "cb_password";
            this.cb_password.Size = new System.Drawing.Size(159, 27);
            this.cb_password.TabIndex = 6;
            this.cb_password.Text = "Показать пароль";
            this.cb_password.UseVisualStyleBackColor = true;
            this.cb_password.CheckedChanged += new System.EventHandler(this.cp_password_CheckedChanged);
            // 
            // l_captchatext
            // 
            this.l_captchatext.AutoSize = true;
            this.l_captchatext.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_captchatext.Location = new System.Drawing.Point(410, 404);
            this.l_captchatext.Name = "l_captchatext";
            this.l_captchatext.Size = new System.Drawing.Size(0, 26);
            this.l_captchatext.TabIndex = 7;
            // 
            // singn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.l_captchatext);
            this.Controls.Add(this.cb_password);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.hhh);
            this.Controls.Add(this.t);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.p_top);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "singn";
            this.Text = "Форма авторизации";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel p_top;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.Label hhh;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.CheckBox cb_password;
        private System.Windows.Forms.Label l_captchatext;
    }
}

