namespace SOFiaT
{
    partial class entryinvoice
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txttotalcost = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtcost = new System.Windows.Forms.TextBox();
            this.cbproducts = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.btnaction = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcomentary = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsupplier = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtref = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtunid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcodeprod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbillcode = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 230);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(1076, 378);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentDoubleClick);
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Control de Facturas Recibidas";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txttotalcost);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtcost);
            this.groupBox1.Controls.Add(this.cbproducts);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtpdate);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnaction);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtcomentary);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtsupplier);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtref);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtunid);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtqty);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtcodeprod);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtbillcode);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1075, 128);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrada de Factura";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(208, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 14);
            this.label12.TabIndex = 23;
            this.label12.Text = "Costo Total:";
            // 
            // txttotalcost
            // 
            this.txttotalcost.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txttotalcost.Enabled = false;
            this.txttotalcost.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalcost.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txttotalcost.Location = new System.Drawing.Point(286, 95);
            this.txttotalcost.Name = "txttotalcost";
            this.txttotalcost.Size = new System.Drawing.Size(145, 20);
            this.txttotalcost.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 14);
            this.label11.TabIndex = 21;
            this.label11.Text = "Costo:";
            // 
            // txtcost
            // 
            this.txtcost.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtcost.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtcost.Location = new System.Drawing.Point(58, 95);
            this.txtcost.Name = "txtcost";
            this.txtcost.Size = new System.Drawing.Size(98, 20);
            this.txtcost.TabIndex = 20;
            this.txtcost.TextChanged += new System.EventHandler(this.txtqty_TextChanged);
            this.txtcost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcost_KeyPress);
            // 
            // cbproducts
            // 
            this.cbproducts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbproducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbproducts.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cbproducts.FormattingEnabled = true;
            this.cbproducts.Items.AddRange(new object[] {
            ""});
            this.cbproducts.Location = new System.Drawing.Point(128, 43);
            this.cbproducts.Name = "cbproducts";
            this.cbproducts.Size = new System.Drawing.Size(303, 22);
            this.cbproducts.TabIndex = 19;
            this.cbproducts.TextChanged += new System.EventHandler(this.cbproducts_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(437, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 14);
            this.label9.TabIndex = 18;
            this.label9.Text = "Fecha:";
            // 
            // dtpdate
            // 
            this.dtpdate.CalendarForeColor = System.Drawing.Color.DodgerBlue;
            this.dtpdate.CalendarTitleForeColor = System.Drawing.Color.DodgerBlue;
            this.dtpdate.CustomFormat = "MM/dd/yyyy";
            this.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdate.Location = new System.Drawing.Point(485, 43);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(101, 20);
            this.dtpdate.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(994, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnaction
            // 
            this.btnaction.Location = new System.Drawing.Point(994, 20);
            this.btnaction.Name = "btnaction";
            this.btnaction.Size = new System.Drawing.Size(75, 23);
            this.btnaction.TabIndex = 15;
            this.btnaction.Text = "button1";
            this.btnaction.UseVisualStyleBackColor = true;
            this.btnaction.Click += new System.EventHandler(this.btnaction_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(674, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 14);
            this.label8.TabIndex = 14;
            this.label8.Text = "Comentario:";
            // 
            // txtcomentary
            // 
            this.txtcomentary.AcceptsTab = true;
            this.txtcomentary.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtcomentary.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtcomentary.Location = new System.Drawing.Point(755, 17);
            this.txtcomentary.Multiline = true;
            this.txtcomentary.Name = "txtcomentary";
            this.txtcomentary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtcomentary.Size = new System.Drawing.Size(208, 66);
            this.txtcomentary.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(437, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 14);
            this.label7.TabIndex = 12;
            this.label7.Text = "Suplidor:";
            // 
            // txtsupplier
            // 
            this.txtsupplier.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtsupplier.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtsupplier.Location = new System.Drawing.Point(499, 66);
            this.txtsupplier.Name = "txtsupplier";
            this.txtsupplier.Size = new System.Drawing.Size(156, 20);
            this.txtsupplier.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(437, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "Referencia:";
            // 
            // txtref
            // 
            this.txtref.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtref.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtref.Location = new System.Drawing.Point(512, 17);
            this.txtref.Name = "txtref";
            this.txtref.Size = new System.Drawing.Size(156, 20);
            this.txtref.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "Unidad:";
            // 
            // txtunid
            // 
            this.txtunid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtunid.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtunid.Location = new System.Drawing.Point(196, 69);
            this.txtunid.Name = "txtunid";
            this.txtunid.Size = new System.Drawing.Size(61, 20);
            this.txtunid.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cantidad:";
            // 
            // txtqty
            // 
            this.txtqty.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtqty.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtqty.Location = new System.Drawing.Point(71, 69);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(61, 20);
            this.txtqty.TabIndex = 5;
            this.txtqty.TextChanged += new System.EventHandler(this.txtqty_TextChanged);
            this.txtqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Producto:";
            // 
            // txtcodeprod
            // 
            this.txtcodeprod.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtcodeprod.Enabled = false;
            this.txtcodeprod.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtcodeprod.Location = new System.Drawing.Point(73, 43);
            this.txtcodeprod.Name = "txtcodeprod";
            this.txtcodeprod.Size = new System.Drawing.Size(49, 20);
            this.txtcodeprod.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Code:";
            // 
            // txtbillcode
            // 
            this.txtbillcode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtbillcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbillcode.Enabled = false;
            this.txtbillcode.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtbillcode.Location = new System.Drawing.Point(52, 17);
            this.txtbillcode.Name = "txtbillcode";
            this.txtbillcode.Size = new System.Drawing.Size(70, 20);
            this.txtbillcode.TabIndex = 0;
            // 
            // textBox9
            // 
            this.textBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox9.Location = new System.Drawing.Point(290, 204);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(440, 20);
            this.textBox9.TabIndex = 19;
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(13, 205);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 19);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Code";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(66, 205);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(86, 19);
            this.radioButton2.TabIndex = 21;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Code Producto";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(159, 205);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(61, 19);
            this.radioButton3.TabIndex = 22;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Producto";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(226, 205);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(51, 19);
            this.radioButton4.TabIndex = 23;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Fecha";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1085, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "X";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // entryinvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1100, 620);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "entryinvoice";
            this.Text = "entryinvoice";
            this.Load += new System.EventHandler(this.entryinvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnaction;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcomentary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsupplier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtref;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtunid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcodeprod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbillcode;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbproducts;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtcost;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txttotalcost;
    }
}