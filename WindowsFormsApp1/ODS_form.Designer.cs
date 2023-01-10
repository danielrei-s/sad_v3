namespace WindowsFormsApp1
{
    partial class ODS_form
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtods = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.label1_ods = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsupp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(616, 413);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtods
            // 
            this.txtods.Location = new System.Drawing.Point(157, 420);
            this.txtods.Name = "txtods";
            this.txtods.Size = new System.Drawing.Size(90, 20);
            this.txtods.TabIndex = 1;
            this.txtods.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(509, 420);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(75, 20);
            this.search_button.TabIndex = 2;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // label1_ods
            // 
            this.label1_ods.AutoSize = true;
            this.label1_ods.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_ods.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1_ods.Location = new System.Drawing.Point(33, 418);
            this.label1_ods.Name = "label1_ods";
            this.label1_ods.Size = new System.Drawing.Size(123, 24);
            this.label1_ods.TabIndex = 3;
            this.label1_ods.Text = "Inserir ODS:";
            this.label1_ods.Click += new System.EventHandler(this.label1_ods_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(298, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Support:";
            // 
            // txtsupp
            // 
            this.txtsupp.Location = new System.Drawing.Point(393, 420);
            this.txtsupp.Name = "txtsupp";
            this.txtsupp.Size = new System.Drawing.Size(90, 20);
            this.txtsupp.TabIndex = 5;
            // 
            // ODS_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(615, 450);
            this.ControlBox = false;
            this.Controls.Add(this.txtsupp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label1_ods);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.txtods);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ODS_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ODS_form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtods;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Label label1_ods;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsupp;
    }
}