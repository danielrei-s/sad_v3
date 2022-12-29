namespace WindowsFormsApp1
{
    partial class main_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_mapa = new System.Windows.Forms.Button();
            this.button_nuts = new System.Windows.Forms.Button();
            this.button_local = new System.Windows.Forms.Button();
            this.button_ODS = new System.Windows.Forms.Button();
            this.button_nome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mapa_form_UC1 = new WindowsFormsApp1.mapa_form_UC();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_mapa);
            this.panel1.Controls.Add(this.button_nuts);
            this.panel1.Controls.Add(this.button_local);
            this.panel1.Controls.Add(this.button_ODS);
            this.panel1.Controls.Add(this.button_nome);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 450);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Procurar projecto por: ";
            // 
            // button_mapa
            // 
            this.button_mapa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_mapa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_mapa.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.button_mapa.FlatAppearance.BorderSize = 0;
            this.button_mapa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button_mapa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button_mapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_mapa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button_mapa.ForeColor = System.Drawing.Color.White;
            this.button_mapa.Location = new System.Drawing.Point(0, 387);
            this.button_mapa.Name = "button_mapa";
            this.button_mapa.Size = new System.Drawing.Size(185, 63);
            this.button_mapa.TabIndex = 7;
            this.button_mapa.Text = "Mapa";
            this.button_mapa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_mapa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_mapa.UseVisualStyleBackColor = false;
            this.button_mapa.Click += new System.EventHandler(this.button_mapa_Click);
            // 
            // button_nuts
            // 
            this.button_nuts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_nuts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_nuts.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.button_nuts.FlatAppearance.BorderSize = 0;
            this.button_nuts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button_nuts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button_nuts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_nuts.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button_nuts.ForeColor = System.Drawing.Color.White;
            this.button_nuts.Location = new System.Drawing.Point(0, 322);
            this.button_nuts.Name = "button_nuts";
            this.button_nuts.Size = new System.Drawing.Size(185, 63);
            this.button_nuts.TabIndex = 6;
            this.button_nuts.Text = "NUTs";
            this.button_nuts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_nuts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_nuts.UseVisualStyleBackColor = false;
            // 
            // button_local
            // 
            this.button_local.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_local.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_local.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.button_local.FlatAppearance.BorderSize = 0;
            this.button_local.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button_local.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button_local.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_local.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button_local.ForeColor = System.Drawing.Color.White;
            this.button_local.Location = new System.Drawing.Point(0, 257);
            this.button_local.Name = "button_local";
            this.button_local.Size = new System.Drawing.Size(185, 63);
            this.button_local.TabIndex = 5;
            this.button_local.Text = "Localidade";
            this.button_local.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_local.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_local.UseVisualStyleBackColor = false;
            // 
            // button_ODS
            // 
            this.button_ODS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_ODS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ODS.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.button_ODS.FlatAppearance.BorderSize = 0;
            this.button_ODS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button_ODS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button_ODS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ODS.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button_ODS.ForeColor = System.Drawing.Color.White;
            this.button_ODS.Location = new System.Drawing.Point(0, 192);
            this.button_ODS.Name = "button_ODS";
            this.button_ODS.Size = new System.Drawing.Size(185, 63);
            this.button_ODS.TabIndex = 4;
            this.button_ODS.Text = "ODS";
            this.button_ODS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ODS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_ODS.UseVisualStyleBackColor = false;
            // 
            // button_nome
            // 
            this.button_nome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_nome.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.button_nome.FlatAppearance.BorderSize = 0;
            this.button_nome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button_nome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button_nome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_nome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button_nome.ForeColor = System.Drawing.Color.White;
            this.button_nome.Location = new System.Drawing.Point(0, 127);
            this.button_nome.Name = "button_nome";
            this.button_nome.Size = new System.Drawing.Size(185, 63);
            this.button_nome.TabIndex = 3;
            this.button_nome.Text = "Nome";
            this.button_nome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_nome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_nome.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.mapa_form_UC1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(185, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 450);
            this.panel2.TabIndex = 1;
            // 
            // mapa_form_UC1
            // 
            this.mapa_form_UC1.Location = new System.Drawing.Point(0, 0);
            this.mapa_form_UC1.Name = "mapa_form_UC1";
            this.mapa_form_UC1.Size = new System.Drawing.Size(615, 450);
            this.mapa_form_UC1.TabIndex = 0;
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "main_form";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_mapa;
        private System.Windows.Forms.Button button_nuts;
        private System.Windows.Forms.Button button_local;
        private System.Windows.Forms.Button button_ODS;
        private System.Windows.Forms.Button button_nome;
        private System.Windows.Forms.Panel panel2;
        private mapa_form_UC mapa_form_UC1;
    }
}

