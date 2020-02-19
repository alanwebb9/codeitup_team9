namespace _4FunctionsHospitalApp
{
    partial class HospitalLocator
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
            this.txtCombo1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCombo2 = new System.Windows.Forms.ComboBox();
            this.county = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEir = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCombo1
            // 
            this.txtCombo1.FormattingEnabled = true;
            this.txtCombo1.IntegralHeight = false;
            this.txtCombo1.Items.AddRange(new object[] {
            "Carlow",
            "Cavan",
            "Clare",
            "Cork",
            "Donegal",
            "Dublin",
            "Galway",
            "Kerry",
            "Kildare",
            "Kilkenny",
            "Laois",
            "Leitrim",
            "Limerick",
            "Longford",
            "Louth",
            "Mayo",
            "Meath",
            "Monaghan",
            "Offaly",
            "Roscommon",
            "Sligo",
            "Tipperary",
            "Waterford",
            "Westmeath",
            "Wexford",
            "Wicklow"});
            this.txtCombo1.Location = new System.Drawing.Point(199, 101);
            this.txtCombo1.Name = "txtCombo1";
            this.txtCombo1.Size = new System.Drawing.Size(568, 24);
            this.txtCombo1.TabIndex = 0;
            this.txtCombo1.SelectedIndexChanged += new System.EventHandler(this.txtCombo1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(202, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address:";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(202, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Eircode:";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(202, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "X:";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(202, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Y:";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(194, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(334, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Welcome to the Hospital Locator App";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(199, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(425, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Select a county from a drop down of available hospitals!";
            // 
            // txtCombo2
            // 
            this.txtCombo2.FormattingEnabled = true;
            this.txtCombo2.Items.AddRange(new object[] {
            "testHospital1"});
            this.txtCombo2.Location = new System.Drawing.Point(199, 167);
            this.txtCombo2.Name = "txtCombo2";
            this.txtCombo2.Size = new System.Drawing.Size(568, 24);
            this.txtCombo2.TabIndex = 15;
            this.txtCombo2.Visible = false;
            // 
            // county
            // 
            this.county.AutoSize = true;
            this.county.Location = new System.Drawing.Point(338, 236);
            this.county.Name = "county";
            this.county.Size = new System.Drawing.Size(63, 17);
            this.county.TabIndex = 16;
            this.county.Text = "Output 0";
            this.county.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(338, 269);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 17);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Output 1";
            this.lblName.Visible = false;
            this.lblName.Click += new System.EventHandler(this.label10_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(338, 304);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(63, 17);
            this.lblAddress.TabIndex = 18;
            this.lblAddress.Text = "Output 2";
            this.lblAddress.Visible = false;
            // 
            // lblEir
            // 
            this.lblEir.AutoSize = true;
            this.lblEir.Location = new System.Drawing.Point(338, 339);
            this.lblEir.Name = "lblEir";
            this.lblEir.Size = new System.Drawing.Size(63, 17);
            this.lblEir.TabIndex = 19;
            this.lblEir.Text = "Output 3";
            this.lblEir.Visible = false;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(338, 373);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(63, 17);
            this.lblX.TabIndex = 20;
            this.lblX.Text = "Output 4";
            this.lblX.Visible = false;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(338, 405);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(63, 17);
            this.lblY.TabIndex = 21;
            this.lblY.Text = "Output 5";
            this.lblY.Visible = false;
            // 
            // HospitalLocator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(991, 450);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblEir);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.county);
            this.Controls.Add(this.txtCombo2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCombo1);
            this.Name = "HospitalLocator";
            this.Text = "Hospital Locator";
            this.Load += new System.EventHandler(this.HospitalLocator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtCombo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox txtCombo2;
        private System.Windows.Forms.Label county;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEir;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
    }
}

