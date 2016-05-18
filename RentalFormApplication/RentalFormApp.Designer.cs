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
            this.btnCheckin.Location = new System.Drawing.Point(333, 32);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(75, 23);
            this.btnCheckin.TabIndex = 0;
            this.btnCheckin.Text = "Checkin";
            this.btnCheckin.UseVisualStyleBackColor = true;
            this.btnCheckin.Click += new System.EventHandler(this.btnCheckin_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lblRequest
            // 
            this.lblRequest.AutoSize = true;
            this.lblRequest.Location = new System.Drawing.Point(37, 42);
            this.lblRequest.Name = "lblRequest";
            this.lblRequest.Size = new System.Drawing.Size(47, 13);
            this.lblRequest.TabIndex = 2;
            this.lblRequest.Text = "Request";
            // 
            // txtShowTrans
            // 
            this.txtShowTrans.Location = new System.Drawing.Point(40, 86);
            this.txtShowTrans.Multiline = true;
            this.txtShowTrans.Name = "txtShowTrans";
            this.txtShowTrans.Size = new System.Drawing.Size(368, 113);
            this.txtShowTrans.TabIndex = 3;
            // 
            // RentalFormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 261);
            this.Controls.Add(this.txtShowTrans);
            this.Controls.Add(this.lblRequest);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCheckin);
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

