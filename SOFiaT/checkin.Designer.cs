namespace SOFiaT
{
    partial class checkin
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtidcheckin = new System.Windows.Forms.TextBox();
            this.txtidprod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnameprod = new System.Windows.Forms.TextBox();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.txtunid = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnnueva = new System.Windows.Forms.Button();
            this.txtlastid = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtqtyavailable = new System.Windows.Forms.TextBox();
            this.dtpdatecheckin = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtprodprice = new System.Windows.Forms.TextBox();
            this.txtpriceqty = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(745, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(389, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Facturacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "IDFactura:";
            // 
            // txtidcheckin
            // 
            this.txtidcheckin.Location = new System.Drawing.Point(68, 55);
            this.txtidcheckin.Name = "txtidcheckin";
            this.txtidcheckin.Size = new System.Drawing.Size(119, 20);
            this.txtidcheckin.TabIndex = 3;
            this.txtidcheckin.Text = "F-";
            this.txtidcheckin.TextChanged += new System.EventHandler(this.txtidcheckin_TextChanged);
            // 
            // txtidprod
            // 
            this.txtidprod.Location = new System.Drawing.Point(73, 91);
            this.txtidprod.Name = "txtidprod";
            this.txtidprod.Size = new System.Drawing.Size(79, 20);
            this.txtidprod.TabIndex = 5;
            this.txtidprod.TextChanged += new System.EventHandler(this.txtidprod_TextChanged);
            this.txtidprod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtidprod_KeyDown);
            this.txtidprod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtidprod_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "IDProducto:";
            // 
            // txtnameprod
            // 
            this.txtnameprod.Enabled = false;
            this.txtnameprod.Location = new System.Drawing.Point(158, 91);
            this.txtnameprod.Name = "txtnameprod";
            this.txtnameprod.Size = new System.Drawing.Size(233, 20);
            this.txtnameprod.TabIndex = 7;
            // 
            // txtqty
            // 
            this.txtqty.Location = new System.Drawing.Point(397, 91);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(52, 20);
            this.txtqty.TabIndex = 8;
            this.txtqty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtqty_KeyDown);
            // 
            // txtunid
            // 
            this.txtunid.Enabled = false;
            this.txtunid.Location = new System.Drawing.Point(455, 91);
            this.txtunid.Name = "txtunid";
            this.txtunid.Size = new System.Drawing.Size(51, 20);
            this.txtunid.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(741, 218);
            this.dataGridView1.TabIndex = 10;
            // 
            // btnnueva
            // 
            this.btnnueva.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnnueva.Location = new System.Drawing.Point(496, 50);
            this.btnnueva.Name = "btnnueva";
            this.btnnueva.Size = new System.Drawing.Size(75, 23);
            this.btnnueva.TabIndex = 11;
            this.btnnueva.Text = "Nueva";
            this.btnnueva.UseVisualStyleBackColor = true;
            this.btnnueva.Click += new System.EventHandler(this.btnnueva_Click);
            // 
            // txtlastid
            // 
            this.txtlastid.Location = new System.Drawing.Point(577, 24);
            this.txtlastid.Name = "txtlastid";
            this.txtlastid.Size = new System.Drawing.Size(75, 20);
            this.txtlastid.TabIndex = 14;
            this.txtlastid.TextChanged += new System.EventHandler(this.txtlastid_TextChanged);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold);
            this.btndelete.Location = new System.Drawing.Point(577, 50);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 15;
            this.btndelete.Text = "Borrar";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // btnprint
            // 
            this.btnprint.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnprint.Location = new System.Drawing.Point(658, 50);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(75, 23);
            this.btnprint.TabIndex = 16;
            this.btnprint.Text = "Imprimir";
            this.btnprint.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttotal);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtdiscount);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtsubtotal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(68, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 50);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // txttotal
            // 
            this.txttotal.Enabled = false;
            this.txttotal.Location = new System.Drawing.Point(428, 17);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(114, 20);
            this.txttotal.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(392, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Total:";
            // 
            // txtdiscount
            // 
            this.txtdiscount.Location = new System.Drawing.Point(248, 17);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(114, 20);
            this.txtdiscount.TabIndex = 21;
            this.txtdiscount.TextChanged += new System.EventHandler(this.txtdiscount_TextChanged);
            this.txtdiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdiscount_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Descuento:";
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Enabled = false;
            this.txtsubtotal.Location = new System.Drawing.Point(59, 17);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(114, 20);
            this.txtsubtotal.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Sub-Total:";
            // 
            // txtqtyavailable
            // 
            this.txtqtyavailable.Enabled = false;
            this.txtqtyavailable.Location = new System.Drawing.Point(699, 89);
            this.txtqtyavailable.Name = "txtqtyavailable";
            this.txtqtyavailable.Size = new System.Drawing.Size(54, 20);
            this.txtqtyavailable.TabIndex = 18;
            // 
            // dtpdatecheckin
            // 
            this.dtpdatecheckin.CustomFormat = "yyyy-MM-dd";
            this.dtpdatecheckin.Enabled = false;
            this.dtpdatecheckin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdatecheckin.Location = new System.Drawing.Point(260, 55);
            this.dtpdatecheckin.Name = "dtpdatecheckin";
            this.dtpdatecheckin.Size = new System.Drawing.Size(84, 20);
            this.dtpdatecheckin.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(218, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Fecha:";
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(632, 135);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(100, 20);
            this.txtuser.TabIndex = 21;
            // 
            // txtprodprice
            // 
            this.txtprodprice.Enabled = false;
            this.txtprodprice.Location = new System.Drawing.Point(517, 91);
            this.txtprodprice.Name = "txtprodprice";
            this.txtprodprice.Size = new System.Drawing.Size(75, 20);
            this.txtprodprice.TabIndex = 22;
            // 
            // txtpriceqty
            // 
            this.txtpriceqty.Enabled = false;
            this.txtpriceqty.Location = new System.Drawing.Point(598, 91);
            this.txtpriceqty.Name = "txtpriceqty";
            this.txtpriceqty.Size = new System.Drawing.Size(77, 20);
            this.txtpriceqty.TabIndex = 23;
            // 
            // checkin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(765, 404);
            this.Controls.Add(this.txtpriceqty);
            this.Controls.Add(this.txtprodprice);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpdatecheckin);
            this.Controls.Add(this.txtqtyavailable);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.txtlastid);
            this.Controls.Add(this.btnnueva);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtunid);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.txtnameprod);
            this.Controls.Add(this.txtidprod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtidcheckin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F);
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "checkin";
            this.Text = "checkin";
            this.Load += new System.EventHandler(this.checkin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtidcheckin;
        private System.Windows.Forms.TextBox txtidprod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnameprod;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.TextBox txtunid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnnueva;
        private System.Windows.Forms.TextBox txtlastid;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtqtyavailable;
        private System.Windows.Forms.DateTimePicker dtpdatecheckin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtprodprice;
        private System.Windows.Forms.TextBox txtpriceqty;
    }
}