namespace SOFiaT
{
    partial class RNC
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
            this.txtfile = new System.Windows.Forms.TextBox();
            this.btnfile = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btnuploadRNC = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbprogress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(744, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subir RNC";
            // 
            // txtfile
            // 
            this.txtfile.Location = new System.Drawing.Point(17, 70);
            this.txtfile.Name = "txtfile";
            this.txtfile.Size = new System.Drawing.Size(412, 20);
            this.txtfile.TabIndex = 2;
            // 
            // btnfile
            // 
            this.btnfile.Location = new System.Drawing.Point(435, 68);
            this.btnfile.Name = "btnfile";
            this.btnfile.Size = new System.Drawing.Size(75, 23);
            this.btnfile.TabIndex = 3;
            this.btnfile.Text = "Examinar";
            this.btnfile.UseVisualStyleBackColor = true;
            this.btnfile.Click += new System.EventHandler(this.btnfile_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(765, 503);
            this.shapeContainer1.TabIndex = 4;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.Highlight;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 17;
            this.lineShape1.X2 = 309;
            this.lineShape1.Y1 = 40;
            this.lineShape1.Y2 = 40;
            // 
            // btnuploadRNC
            // 
            this.btnuploadRNC.Location = new System.Drawing.Point(516, 68);
            this.btnuploadRNC.Name = "btnuploadRNC";
            this.btnuploadRNC.Size = new System.Drawing.Size(75, 23);
            this.btnuploadRNC.TabIndex = 5;
            this.btnuploadRNC.Text = "Subir";
            this.btnuploadRNC.UseVisualStyleBackColor = true;
            this.btnuploadRNC.Click += new System.EventHandler(this.btnuploadRNC_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(17, 128);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(535, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // lbprogress
            // 
            this.lbprogress.AutoSize = true;
            this.lbprogress.Location = new System.Drawing.Point(254, 112);
            this.lbprogress.Name = "lbprogress";
            this.lbprogress.Size = new System.Drawing.Size(46, 13);
            this.lbprogress.TabIndex = 7;
            this.lbprogress.Text = "Proceso";
            // 
            // RNC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(765, 503);
            this.Controls.Add(this.lbprogress);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnuploadRNC);
            this.Controls.Add(this.btnfile);
            this.Controls.Add(this.txtfile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RNC";
            this.Text = "RNC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfile;
        private System.Windows.Forms.Button btnfile;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button btnuploadRNC;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbprogress;
    }
}