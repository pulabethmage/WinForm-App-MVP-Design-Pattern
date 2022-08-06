namespace Test01_PulasthiBethmage
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
            this.fnameLabel = new System.Windows.Forms.Label();
            this.lnameLabel = new System.Windows.Forms.Label();
            this.contactLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.txtbFname = new System.Windows.Forms.TextBox();
            this.txtbLname = new System.Windows.Forms.TextBox();
            this.txtbContact = new System.Windows.Forms.TextBox();
            this.txtbAmountpaid = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fnameLabel
            // 
            this.fnameLabel.AutoSize = true;
            this.fnameLabel.Location = new System.Drawing.Point(107, 45);
            this.fnameLabel.Name = "fnameLabel";
            this.fnameLabel.Size = new System.Drawing.Size(76, 17);
            this.fnameLabel.TabIndex = 0;
            this.fnameLabel.Text = "First Name";
            // 
            // lnameLabel
            // 
            this.lnameLabel.AutoSize = true;
            this.lnameLabel.Location = new System.Drawing.Point(107, 87);
            this.lnameLabel.Name = "lnameLabel";
            this.lnameLabel.Size = new System.Drawing.Size(76, 17);
            this.lnameLabel.TabIndex = 1;
            this.lnameLabel.Text = "Last Name";
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Location = new System.Drawing.Point(73, 125);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(110, 17);
            this.contactLabel.TabIndex = 2;
            this.contactLabel.Text = "Contact Number";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(95, 168);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(88, 17);
            this.amountLabel.TabIndex = 3;
            this.amountLabel.Text = "Amount Paid";
            // 
            // txtbFname
            // 
            this.txtbFname.Location = new System.Drawing.Point(218, 39);
            this.txtbFname.Name = "txtbFname";
            this.txtbFname.Size = new System.Drawing.Size(215, 22);
            this.txtbFname.TabIndex = 4;
            // 
            // txtbLname
            // 
            this.txtbLname.Location = new System.Drawing.Point(218, 82);
            this.txtbLname.Name = "txtbLname";
            this.txtbLname.Size = new System.Drawing.Size(215, 22);
            this.txtbLname.TabIndex = 5;
            // 
            // txtbContact
            // 
            this.txtbContact.Location = new System.Drawing.Point(218, 120);
            this.txtbContact.Name = "txtbContact";
            this.txtbContact.Size = new System.Drawing.Size(215, 22);
            this.txtbContact.TabIndex = 6;
            // 
            // txtbAmountpaid
            // 
            this.txtbAmountpaid.Location = new System.Drawing.Point(218, 163);
            this.txtbAmountpaid.Name = "txtbAmountpaid";
            this.txtbAmountpaid.Size = new System.Drawing.Size(215, 22);
            this.txtbAmountpaid.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(218, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Points";
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.Location = new System.Drawing.Point(218, 274);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(16, 17);
            this.pointsLabel.TabIndex = 10;
            this.pointsLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 348);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbAmountpaid);
            this.Controls.Add(this.txtbContact);
            this.Controls.Add(this.txtbLname);
            this.Controls.Add(this.txtbFname);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.contactLabel);
            this.Controls.Add(this.lnameLabel);
            this.Controls.Add(this.fnameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fnameLabel;
        private System.Windows.Forms.Label lnameLabel;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox txtbFname;
        private System.Windows.Forms.TextBox txtbLname;
        private System.Windows.Forms.TextBox txtbContact;
        private System.Windows.Forms.TextBox txtbAmountpaid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pointsLabel;
    }
}

