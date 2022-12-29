namespace SAD_TEST
{
    partial class Menuregisto
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
            this.label1 = new System.Windows.Forms.Label();
            this.username_registo = new System.Windows.Forms.Label();
            this.email_registo = new System.Windows.Forms.Label();
            this.password_registo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button_registar = new System.Windows.Forms.Button();
            this.button_sair = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(182, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem-vindo ao menu de registo";
            // 
            // username_registo
            // 
            this.username_registo.AutoSize = true;
            this.username_registo.Location = new System.Drawing.Point(161, 179);
            this.username_registo.Name = "username_registo";
            this.username_registo.Size = new System.Drawing.Size(68, 15);
            this.username_registo.TabIndex = 1;
            this.username_registo.Text = "User Name:";
            // 
            // email_registo
            // 
            this.email_registo.AutoSize = true;
            this.email_registo.Location = new System.Drawing.Point(161, 223);
            this.email_registo.Name = "email_registo";
            this.email_registo.Size = new System.Drawing.Size(44, 15);
            this.email_registo.TabIndex = 2;
            this.email_registo.Text = "E-mail:";
            // 
            // password_registo
            // 
            this.password_registo.AutoSize = true;
            this.password_registo.Location = new System.Drawing.Point(161, 265);
            this.password_registo.Name = "password_registo";
            this.password_registo.Size = new System.Drawing.Size(60, 15);
            this.password_registo.TabIndex = 3;
            this.password_registo.Text = "Password:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(267, 171);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 23);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(267, 215);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(233, 23);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(267, 257);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(233, 23);
            this.textBox3.TabIndex = 6;
            // 
            // button_registar
            // 
            this.button_registar.Location = new System.Drawing.Point(425, 309);
            this.button_registar.Name = "button_registar";
            this.button_registar.Size = new System.Drawing.Size(75, 23);
            this.button_registar.TabIndex = 7;
            this.button_registar.Text = "&Registar";
            this.button_registar.UseVisualStyleBackColor = true;
            // 
            // button_sair
            // 
            this.button_sair.Location = new System.Drawing.Point(713, 415);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(75, 23);
            this.button_sair.TabIndex = 8;
            this.button_sair.Text = "&Sair";
            this.button_sair.UseVisualStyleBackColor = true;
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(267, 309);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 23);
            this.button_clear.TabIndex = 9;
            this.button_clear.Text = "&Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            // 
            // Menuregisto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_sair);
            this.Controls.Add(this.button_registar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.password_registo);
            this.Controls.Add(this.email_registo);
            this.Controls.Add(this.username_registo);
            this.Controls.Add(this.label1);
            this.Name = "Menuregisto";
            this.Text = "Menuregisto";
            this.Load += new System.EventHandler(this.Menuregisto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label username_registo;
        private Label email_registo;
        private Label password_registo;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button_registar;
        private Button button_sair;
        private Button button_clear;
    }
}