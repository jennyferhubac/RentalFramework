namespace RentalFormApplication
{
    partial class RentalFormApp
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
            this.btnCheckin = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblRequest = new System.Windows.Forms.Label();
            this.txtShowTrans = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCheckin
            // 
            this.btnCheckin.Location = new System.Drawing.Point(444, 39);
            this.btnCheckin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(100, 28);
            this.btnCheckin.TabIndex = 0;
            this.btnCheckin.Text = "Checkin";
            this.btnCheckin.UseVisualStyleBackColor = true;
            this.btnCheckin.Click += new System.EventHandler(this.btnCheckin_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(167, 43);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 22);
            this.textBox1.TabIndex = 1;
            // 
            // lblRequest
            // 
            this.lblRequest.AutoSize = true;
            this.lblRequest.Location = new System.Drawing.Point(49, 52);
            this.lblRequest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRequest.Name = "lblRequest";
            this.lblRequest.Size = new System.Drawing.Size(61, 17);
            this.lblRequest.TabIndex = 2;
            this.lblRequest.Text = "Request";
            // 
            // txtShowTrans
            // 
            this.txtShowTrans.Location = new System.Drawing.Point(53, 106);
            this.txtShowTrans.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtShowTrans.Multiline = true;
            this.txtShowTrans.Name = "txtShowTrans";
            this.txtShowTrans.Size = new System.Drawing.Size(489, 138);
            this.txtShowTrans.TabIndex = 3;
            // 
            // RentalFormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 321);
            this.Controls.Add(this.txtShowTrans);
            this.Controls.Add(this.lblRequest);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCheckin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RentalFormApp";
            this.Text = "Rental Form";
            this.Load += new System.EventHandler(this.RentalFormApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblRequest;
        private System.Windows.Forms.TextBox txtShowTrans;
    }
}

