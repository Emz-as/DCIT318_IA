namespace WindowsFormsApp1
{
    partial class TransactionForm
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
            this.button9 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.Pricetext = new System.Windows.Forms.Panel();
            this.ItemText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Quantitytext = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.QtyText = new System.Windows.Forms.Label();
            this.DateText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PriceTextt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.AmtText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.transData = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pricetext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transData)).BeginInit();
            this.SuspendLayout();
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(131, 153);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(159, 37);
            this.button9.TabIndex = 55;
            this.button9.Text = "TILL";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(131, 296);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(156, 40);
            this.button11.TabIndex = 57;
            this.button11.Text = "Receipt";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // Pricetext
            // 
            this.Pricetext.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Pricetext.Controls.Add(this.transData);
            this.Pricetext.Controls.Add(this.AmtText);
            this.Pricetext.Controls.Add(this.label3);
            this.Pricetext.Controls.Add(this.button4);
            this.Pricetext.Controls.Add(this.PriceTextt);
            this.Pricetext.Controls.Add(this.label5);
            this.Pricetext.Controls.Add(this.ItemText);
            this.Pricetext.Controls.Add(this.label4);
            this.Pricetext.Controls.Add(this.label1);
            this.Pricetext.Controls.Add(this.button7);
            this.Pricetext.Controls.Add(this.pictureBox2);
            this.Pricetext.Controls.Add(this.label6);
            this.Pricetext.Controls.Add(this.Quantitytext);
            this.Pricetext.Controls.Add(this.QtyText);
            this.Pricetext.Controls.Add(this.DateText);
            this.Pricetext.Controls.Add(this.label2);
            this.Pricetext.Location = new System.Drawing.Point(313, 49);
            this.Pricetext.Name = "Pricetext";
            this.Pricetext.Size = new System.Drawing.Size(1045, 595);
            this.Pricetext.TabIndex = 54;
            this.Pricetext.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ItemText
            // 
            this.ItemText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ItemText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ItemText.HintForeColor = System.Drawing.Color.Empty;
            this.ItemText.HintText = "";
            this.ItemText.isPassword = false;
            this.ItemText.LineFocusedColor = System.Drawing.Color.White;
            this.ItemText.LineIdleColor = System.Drawing.Color.White;
            this.ItemText.LineMouseHoverColor = System.Drawing.Color.White;
            this.ItemText.LineThickness = 3;
            this.ItemText.Location = new System.Drawing.Point(155, 313);
            this.ItemText.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ItemText.Name = "ItemText";
            this.ItemText.Size = new System.Drawing.Size(190, 30);
            this.ItemText.TabIndex = 22;
            this.ItemText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(32, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(149, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 35);
            this.label1.TabIndex = 19;
            this.label1.Text = "Transaction";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button7.Location = new System.Drawing.Point(103, 450);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(143, 37);
            this.button7.TabIndex = 14;
            this.button7.Text = "Record";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.lending;
            this.pictureBox2.Location = new System.Drawing.Point(0, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(143, 118);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 23);
            this.label6.TabIndex = 9;
            // 
            // Quantitytext
            // 
            this.Quantitytext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Quantitytext.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantitytext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Quantitytext.HintForeColor = System.Drawing.Color.Empty;
            this.Quantitytext.HintText = "";
            this.Quantitytext.isPassword = false;
            this.Quantitytext.LineFocusedColor = System.Drawing.Color.White;
            this.Quantitytext.LineIdleColor = System.Drawing.Color.White;
            this.Quantitytext.LineMouseHoverColor = System.Drawing.Color.White;
            this.Quantitytext.LineThickness = 3;
            this.Quantitytext.Location = new System.Drawing.Point(155, 247);
            this.Quantitytext.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Quantitytext.Name = "Quantitytext";
            this.Quantitytext.Size = new System.Drawing.Size(190, 30);
            this.Quantitytext.TabIndex = 4;
            this.Quantitytext.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // QtyText
            // 
            this.QtyText.AutoSize = true;
            this.QtyText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.QtyText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtyText.ForeColor = System.Drawing.Color.White;
            this.QtyText.Location = new System.Drawing.Point(19, 252);
            this.QtyText.Name = "QtyText";
            this.QtyText.Size = new System.Drawing.Size(89, 25);
            this.QtyText.TabIndex = 3;
            this.QtyText.Text = "Quanity";
            // 
            // DateText
            // 
            this.DateText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DateText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DateText.HintForeColor = System.Drawing.Color.Empty;
            this.DateText.HintText = "";
            this.DateText.isPassword = false;
            this.DateText.LineFocusedColor = System.Drawing.Color.White;
            this.DateText.LineIdleColor = System.Drawing.Color.White;
            this.DateText.LineMouseHoverColor = System.Drawing.Color.White;
            this.DateText.LineThickness = 3;
            this.DateText.Location = new System.Drawing.Point(155, 174);
            this.DateText.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DateText.Name = "DateText";
            this.DateText.Size = new System.Drawing.Size(183, 36);
            this.DateText.TabIndex = 2;
            this.DateText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(131, 458);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 39);
            this.button3.TabIndex = 58;
            this.button3.Text = "Stock";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button2.Location = new System.Drawing.Point(1298, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 38);
            this.button2.TabIndex = 59;
            this.button2.Text = "x";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.reception1;
            this.pictureBox4.Location = new System.Drawing.Point(11, 88);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(114, 102);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 62;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.inventory__3_;
            this.pictureBox3.Location = new System.Drawing.Point(11, 407);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(114, 90);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 61;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.bill;
            this.pictureBox1.Location = new System.Drawing.Point(19, 239);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // PriceTextt
            // 
            this.PriceTextt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PriceTextt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTextt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PriceTextt.HintForeColor = System.Drawing.Color.Empty;
            this.PriceTextt.HintText = "";
            this.PriceTextt.isPassword = false;
            this.PriceTextt.LineFocusedColor = System.Drawing.Color.White;
            this.PriceTextt.LineIdleColor = System.Drawing.Color.White;
            this.PriceTextt.LineMouseHoverColor = System.Drawing.Color.White;
            this.PriceTextt.LineThickness = 3;
            this.PriceTextt.Location = new System.Drawing.Point(155, 365);
            this.PriceTextt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PriceTextt.Name = "PriceTextt";
            this.PriceTextt.Size = new System.Drawing.Size(190, 30);
            this.PriceTextt.TabIndex = 24;
            this.PriceTextt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(32, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Price";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button4.Location = new System.Drawing.Point(60, 517);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(246, 37);
            this.button4.TabIndex = 25;
            this.button4.Text = "Record Receipt";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // AmtText
            // 
            this.AmtText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AmtText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmtText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AmtText.HintForeColor = System.Drawing.Color.Empty;
            this.AmtText.HintText = "";
            this.AmtText.isPassword = false;
            this.AmtText.LineFocusedColor = System.Drawing.Color.White;
            this.AmtText.LineIdleColor = System.Drawing.Color.White;
            this.AmtText.LineMouseHoverColor = System.Drawing.Color.White;
            this.AmtText.LineThickness = 3;
            this.AmtText.Location = new System.Drawing.Point(496, 418);
            this.AmtText.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.AmtText.Name = "AmtText";
            this.AmtText.Size = new System.Drawing.Size(190, 30);
            this.AmtText.TabIndex = 27;
            this.AmtText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(373, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Amount";
            // 
            // transData
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.transData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.transData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Quantity,
            this.Item,
            this.Price,
            this.Total});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.transData.DefaultCellStyle = dataGridViewCellStyle3;
            this.transData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.transData.Location = new System.Drawing.Point(401, 3);
            this.transData.Name = "transData";
            this.transData.RowHeadersVisible = false;
            this.transData.RowHeadersWidth = 51;
            this.transData.RowTemplate.Height = 24;
            this.transData.Size = new System.Drawing.Size(641, 396);
            this.transData.TabIndex = 28;
            this.transData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.transData.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.transData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.transData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.transData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.transData.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.transData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.transData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.transData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.transData.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.transData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transData.ThemeStyle.HeaderStyle.Height = 18;
            this.transData.ThemeStyle.ReadOnly = false;
            this.transData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.transData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.transData.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.transData.ThemeStyle.RowsStyle.Height = 24;
            this.transData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.transData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.MinimumWidth = 6;
            this.Item.Name = "Item";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1359, 644);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.Pricetext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransactionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.Pricetext.ResumeLayout(false);
            this.Pricetext.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Panel Pricetext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Quantitytext;
        private System.Windows.Forms.Label QtyText;
        private Bunifu.Framework.UI.BunifuMaterialTextbox DateText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ItemText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PriceTextt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox AmtText;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView transData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}