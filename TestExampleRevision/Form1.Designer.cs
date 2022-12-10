namespace TestExampleRevision
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
            this.txtCustomerChange = new System.Windows.Forms.TextBox();
            this.txtNumberAdults = new System.Windows.Forms.TextBox();
            this.txtNumberChildrenConcession = new System.Windows.Forms.TextBox();
            this.txtAmountReceived = new System.Windows.Forms.TextBox();
            this.txtTotalFareCost = new System.Windows.Forms.TextBox();
            this.btnCalculateFareCost = new System.Windows.Forms.Button();
            this.btnCalculateChange = new System.Windows.Forms.Button();
            this.lblNumberOfAdults = new System.Windows.Forms.Label();
            this.lblNumberChildrenConcession = new System.Windows.Forms.Label();
            this.lblTotalFareCost = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCustomerChange = new System.Windows.Forms.Label();
            this.lblRottnestAirlines = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCustomerChange
            // 
            this.txtCustomerChange.Location = new System.Drawing.Point(394, 264);
            this.txtCustomerChange.Name = "txtCustomerChange";
            this.txtCustomerChange.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerChange.TabIndex = 0;
            // 
            // txtNumberAdults
            // 
            this.txtNumberAdults.Location = new System.Drawing.Point(394, 102);
            this.txtNumberAdults.Name = "txtNumberAdults";
            this.txtNumberAdults.Size = new System.Drawing.Size(100, 20);
            this.txtNumberAdults.TabIndex = 1;
            // 
            // txtNumberChildrenConcession
            // 
            this.txtNumberChildrenConcession.Location = new System.Drawing.Point(394, 128);
            this.txtNumberChildrenConcession.Name = "txtNumberChildrenConcession";
            this.txtNumberChildrenConcession.Size = new System.Drawing.Size(100, 20);
            this.txtNumberChildrenConcession.TabIndex = 2;
            // 
            // txtAmountReceived
            // 
            this.txtAmountReceived.Location = new System.Drawing.Point(394, 209);
            this.txtAmountReceived.Name = "txtAmountReceived";
            this.txtAmountReceived.Size = new System.Drawing.Size(100, 20);
            this.txtAmountReceived.TabIndex = 3;
            // 
            // txtTotalFareCost
            // 
            this.txtTotalFareCost.Location = new System.Drawing.Point(394, 183);
            this.txtTotalFareCost.Name = "txtTotalFareCost";
            this.txtTotalFareCost.Size = new System.Drawing.Size(100, 20);
            this.txtTotalFareCost.TabIndex = 4;
            // 
            // btnCalculateFareCost
            // 
            this.btnCalculateFareCost.Location = new System.Drawing.Point(394, 154);
            this.btnCalculateFareCost.Name = "btnCalculateFareCost";
            this.btnCalculateFareCost.Size = new System.Drawing.Size(120, 23);
            this.btnCalculateFareCost.TabIndex = 5;
            this.btnCalculateFareCost.Text = "Calculate Fare Cost";
            this.btnCalculateFareCost.UseVisualStyleBackColor = true;
            this.btnCalculateFareCost.Click += new System.EventHandler(this.btnCalculateFareCost_Click);
            // 
            // btnCalculateChange
            // 
            this.btnCalculateChange.Location = new System.Drawing.Point(394, 235);
            this.btnCalculateChange.Name = "btnCalculateChange";
            this.btnCalculateChange.Size = new System.Drawing.Size(105, 23);
            this.btnCalculateChange.TabIndex = 6;
            this.btnCalculateChange.Text = "Calculate change";
            this.btnCalculateChange.UseVisualStyleBackColor = true;
            this.btnCalculateChange.Click += new System.EventHandler(this.btnCalculateChange_Click);
            // 
            // lblNumberOfAdults
            // 
            this.lblNumberOfAdults.AutoSize = true;
            this.lblNumberOfAdults.Location = new System.Drawing.Point(300, 109);
            this.lblNumberOfAdults.Name = "lblNumberOfAdults";
            this.lblNumberOfAdults.Size = new System.Drawing.Size(88, 13);
            this.lblNumberOfAdults.TabIndex = 7;
            this.lblNumberOfAdults.Text = "Number of Adults";
            // 
            // lblNumberChildrenConcession
            // 
            this.lblNumberChildrenConcession.AutoSize = true;
            this.lblNumberChildrenConcession.Location = new System.Drawing.Point(231, 135);
            this.lblNumberChildrenConcession.Name = "lblNumberChildrenConcession";
            this.lblNumberChildrenConcession.Size = new System.Drawing.Size(157, 13);
            this.lblNumberChildrenConcession.TabIndex = 8;
            this.lblNumberChildrenConcession.Text = "Number of Children/Concession";
            // 
            // lblTotalFareCost
            // 
            this.lblTotalFareCost.AutoSize = true;
            this.lblTotalFareCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalFareCost.Location = new System.Drawing.Point(309, 190);
            this.lblTotalFareCost.Name = "lblTotalFareCost";
            this.lblTotalFareCost.Size = new System.Drawing.Size(81, 15);
            this.lblTotalFareCost.TabIndex = 9;
            this.lblTotalFareCost.Text = "Total Fare Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Amount Received";
            // 
            // lblCustomerChange
            // 
            this.lblCustomerChange.AutoSize = true;
            this.lblCustomerChange.Location = new System.Drawing.Point(297, 271);
            this.lblCustomerChange.Name = "lblCustomerChange";
            this.lblCustomerChange.Size = new System.Drawing.Size(91, 13);
            this.lblCustomerChange.TabIndex = 11;
            this.lblCustomerChange.Text = "Customer Change";
            // 
            // lblRottnestAirlines
            // 
            this.lblRottnestAirlines.AutoSize = true;
            this.lblRottnestAirlines.Location = new System.Drawing.Point(401, 86);
            this.lblRottnestAirlines.Name = "lblRottnestAirlines";
            this.lblRottnestAirlines.Size = new System.Drawing.Size(83, 13);
            this.lblRottnestAirlines.TabIndex = 12;
            this.lblRottnestAirlines.Text = "Rottnest Airlines";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRottnestAirlines);
            this.Controls.Add(this.lblCustomerChange);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotalFareCost);
            this.Controls.Add(this.lblNumberChildrenConcession);
            this.Controls.Add(this.lblNumberOfAdults);
            this.Controls.Add(this.btnCalculateChange);
            this.Controls.Add(this.btnCalculateFareCost);
            this.Controls.Add(this.txtTotalFareCost);
            this.Controls.Add(this.txtAmountReceived);
            this.Controls.Add(this.txtNumberChildrenConcession);
            this.Controls.Add(this.txtNumberAdults);
            this.Controls.Add(this.txtCustomerChange);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerChange;
        private System.Windows.Forms.TextBox txtNumberAdults;
        private System.Windows.Forms.TextBox txtNumberChildrenConcession;
        private System.Windows.Forms.TextBox txtAmountReceived;
        private System.Windows.Forms.TextBox txtTotalFareCost;
        private System.Windows.Forms.Button btnCalculateFareCost;
        private System.Windows.Forms.Button btnCalculateChange;
        private System.Windows.Forms.Label lblNumberOfAdults;
        private System.Windows.Forms.Label lblNumberChildrenConcession;
        private System.Windows.Forms.Label lblTotalFareCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCustomerChange;
        private System.Windows.Forms.Label lblRottnestAirlines;
    }
}

