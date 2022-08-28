namespace WindowsFormsApp1
{
    partial class CategoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CatDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.CatDescTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.CatNameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.CatIDTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CatDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.CatDGV);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.CatDescTb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.CatNameTb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CatIDTb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(158, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 631);
            this.panel1.TabIndex = 23;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // CatDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.CatDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CatDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CatDGV.ColumnHeadersHeight = 4;
            this.CatDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CatDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.CatDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CatDGV.Location = new System.Drawing.Point(378, 138);
            this.CatDGV.Name = "CatDGV";
            this.CatDGV.RowHeadersVisible = false;
            this.CatDGV.RowHeadersWidth = 51;
            this.CatDGV.RowTemplate.Height = 24;
            this.CatDGV.Size = new System.Drawing.Size(603, 475);
            this.CatDGV.TabIndex = 29;
            this.CatDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CatDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CatDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CatDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CatDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CatDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CatDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CatDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CatDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CatDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CatDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CatDGV.ThemeStyle.HeaderStyle.Height = 4;
            this.CatDGV.ThemeStyle.ReadOnly = false;
            this.CatDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CatDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CatDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CatDGV.ThemeStyle.RowsStyle.Height = 24;
            this.CatDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CatDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CatDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CatDGV_CellContentClick);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button7.Location = new System.Drawing.Point(186, 399);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(126, 37);
            this.button7.TabIndex = 14;
            this.button7.Text = "DELETE";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(922, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(59, 48);
            this.button5.TabIndex = 28;
            this.button5.Text = "x";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button6.Location = new System.Drawing.Point(92, 399);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(88, 37);
            this.button6.TabIndex = 13;
            this.button6.Text = "EDIT";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button4.Location = new System.Drawing.Point(4, 399);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 37);
            this.button4.TabIndex = 12;
            this.button4.Text = "ADD";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // CatDescTb
            // 
            this.CatDescTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CatDescTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatDescTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CatDescTb.HintForeColor = System.Drawing.Color.Empty;
            this.CatDescTb.HintText = "";
            this.CatDescTb.isPassword = false;
            this.CatDescTb.LineFocusedColor = System.Drawing.Color.White;
            this.CatDescTb.LineIdleColor = System.Drawing.Color.White;
            this.CatDescTb.LineMouseHoverColor = System.Drawing.Color.White;
            this.CatDescTb.LineThickness = 3;
            this.CatDescTb.Location = new System.Drawing.Point(146, 326);
            this.CatDescTb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CatDescTb.Name = "CatDescTb";
            this.CatDescTb.Size = new System.Drawing.Size(177, 48);
            this.CatDescTb.TabIndex = 6;
            this.CatDescTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CatDescTb.OnValueChanged += new System.EventHandler(this.CatDescTb_OnValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "DESCRIPTION";
            // 
            // CatNameTb
            // 
            this.CatNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CatNameTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatNameTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CatNameTb.HintForeColor = System.Drawing.Color.Empty;
            this.CatNameTb.HintText = "";
            this.CatNameTb.isPassword = false;
            this.CatNameTb.LineFocusedColor = System.Drawing.Color.White;
            this.CatNameTb.LineIdleColor = System.Drawing.Color.White;
            this.CatNameTb.LineMouseHoverColor = System.Drawing.Color.White;
            this.CatNameTb.LineThickness = 3;
            this.CatNameTb.Location = new System.Drawing.Point(146, 269);
            this.CatNameTb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CatNameTb.Name = "CatNameTb";
            this.CatNameTb.Size = new System.Drawing.Size(177, 49);
            this.CatNameTb.TabIndex = 4;
            this.CatNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CatNameTb.OnValueChanged += new System.EventHandler(this.CatNameTb_OnValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "NAME";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // CatIDTb
            // 
            this.CatIDTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CatIDTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatIDTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CatIDTb.HintForeColor = System.Drawing.Color.Empty;
            this.CatIDTb.HintText = "";
            this.CatIDTb.isPassword = false;
            this.CatIDTb.LineFocusedColor = System.Drawing.Color.White;
            this.CatIDTb.LineIdleColor = System.Drawing.Color.White;
            this.CatIDTb.LineMouseHoverColor = System.Drawing.Color.White;
            this.CatIDTb.LineThickness = 3;
            this.CatIDTb.Location = new System.Drawing.Point(146, 217);
            this.CatIDTb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CatIDTb.Name = "CatIDTb";
            this.CatIDTb.Size = new System.Drawing.Size(177, 44);
            this.CatIDTb.TabIndex = 2;
            this.CatIDTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CatIDTb.OnValueChanged += new System.EventHandler(this.CatIDTb_OnValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGE CATEGORIES";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(5, 147);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(150, 35);
            this.button9.TabIndex = 29;
            this.button9.Text = "Retailers";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(5, 281);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(153, 36);
            this.button10.TabIndex = 30;
            this.button10.Text = "Products";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(5, 442);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(147, 36);
            this.button11.TabIndex = 31;
            this.button11.Text = "Selling";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.align;
            this.pictureBox1.Location = new System.Drawing.Point(4, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 615);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CatDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CatDescTb;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CatNameTb;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CatIDTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2DataGridView CatDGV;
    }
}