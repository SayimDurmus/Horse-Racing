namespace AtYarisi_WinForm
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFinish = new System.Windows.Forms.Label();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnSifirla = new System.Windows.Forms.Button();
            this.pbAt3 = new System.Windows.Forms.PictureBox();
            this.pbAt2 = new System.Windows.Forms.PictureBox();
            this.pbAt1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbAt3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBilgi
            // 
            this.lblBilgi.BackColor = System.Drawing.Color.OliveDrab;
            this.lblBilgi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBilgi.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgi.Location = new System.Drawing.Point(27, 13);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(459, 23);
            this.lblBilgi.TabIndex = 0;
            this.lblBilgi.Text = "label1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(27, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(710, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(28, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(709, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // lblFinish
            // 
            this.lblFinish.BackColor = System.Drawing.Color.Black;
            this.lblFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFinish.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFinish.Location = new System.Drawing.Point(743, 64);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(45, 334);
            this.lblFinish.TabIndex = 3;
            this.lblFinish.Text = "FINISH";
            this.lblFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBaslat
            // 
            this.btnBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaslat.Location = new System.Drawing.Point(508, 12);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(81, 24);
            this.btnBaslat.TabIndex = 5;
            this.btnBaslat.Tag = "Baslat";
            this.btnBaslat.Text = "BASLAT";
            this.btnBaslat.UseVisualStyleBackColor = true;
            // 
            // btnSifirla
            // 
            this.btnSifirla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifirla.Location = new System.Drawing.Point(610, 12);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(75, 24);
            this.btnSifirla.TabIndex = 6;
            this.btnSifirla.Tag = "Sifirla";
            this.btnSifirla.Text = "SIFIRLA";
            this.btnSifirla.UseVisualStyleBackColor = true;
            // 
            // pbAt3
            // 
            this.pbAt3.Image = global::AtYarisi_WinForm.Properties.Resources.At31;
            this.pbAt3.Location = new System.Drawing.Point(15, 320);
            this.pbAt3.Name = "pbAt3";
            this.pbAt3.Size = new System.Drawing.Size(100, 50);
            this.pbAt3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAt3.TabIndex = 9;
            this.pbAt3.TabStop = false;
            // 
            // pbAt2
            // 
            this.pbAt2.Image = global::AtYarisi_WinForm.Properties.Resources.At2;
            this.pbAt2.Location = new System.Drawing.Point(15, 211);
            this.pbAt2.Name = "pbAt2";
            this.pbAt2.Size = new System.Drawing.Size(100, 50);
            this.pbAt2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAt2.TabIndex = 8;
            this.pbAt2.TabStop = false;
            // 
            // pbAt1
            // 
            this.pbAt1.Image = global::AtYarisi_WinForm.Properties.Resources.At1;
            this.pbAt1.Location = new System.Drawing.Point(15, 112);
            this.pbAt1.Name = "pbAt1";
            this.pbAt1.Size = new System.Drawing.Size(100, 50);
            this.pbAt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAt1.TabIndex = 7;
            this.pbAt1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbAt3);
            this.Controls.Add(this.pbAt2);
            this.Controls.Add(this.pbAt1);
            this.Controls.Add(this.btnSifirla);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBilgi);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Name = "Form1";
            this.Text = "Form1";
           
            ((System.ComponentModel.ISupportInitialize)(this.pbAt3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button btnSifirla;
        private System.Windows.Forms.PictureBox pbAt1;
        private System.Windows.Forms.PictureBox pbAt2;
        private System.Windows.Forms.PictureBox pbAt3;
        private System.Windows.Forms.Timer timer1;
    }
}

