namespace webbDalyssaHW1
{
    partial class frmCalculator
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtIDNumber = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblIDNumber = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.toolCalculate = new System.Windows.Forms.ToolTip(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.radGood = new System.Windows.Forms.RadioButton();
            this.radFair = new System.Windows.Forms.RadioButton();
            this.grpPerformance = new System.Windows.Forms.GroupBox();
            this.radExcellent = new System.Windows.Forms.RadioButton();
            this.radHigh = new System.Windows.Forms.RadioButton();
            this.radMedium = new System.Windows.Forms.RadioButton();
            this.radLow = new System.Windows.Forms.RadioButton();
            this.grpRank = new System.Windows.Forms.GroupBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.toolClear = new System.Windows.Forms.ToolTip(this.components);
            this.toolExit = new System.Windows.Forms.ToolTip(this.components);
            this.grpPerformance.SuspendLayout();
            this.grpRank.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(113, 79);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(160, 20);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(113, 110);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(160, 20);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtIDNumber
            // 
            this.txtIDNumber.Location = new System.Drawing.Point(113, 144);
            this.txtIDNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIDNumber.Name = "txtIDNumber";
            this.txtIDNumber.Size = new System.Drawing.Size(160, 20);
            this.txtIDNumber.TabIndex = 2;
            this.txtIDNumber.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(113, 175);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(160, 20);
            this.txtSalary.TabIndex = 3;
            this.txtSalary.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(43, 80);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(67, 15);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(43, 111);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(67, 15);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name";
            // 
            // lblIDNumber
            // 
            this.lblIDNumber.AutoSize = true;
            this.lblIDNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDNumber.Location = new System.Drawing.Point(45, 146);
            this.lblIDNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIDNumber.Name = "lblIDNumber";
            this.lblIDNumber.Size = new System.Drawing.Size(67, 15);
            this.lblIDNumber.TabIndex = 6;
            this.lblIDNumber.Text = "ID Number";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(28, 176);
            this.lblSalary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(82, 15);
            this.lblSalary.TabIndex = 7;
            this.lblSalary.Text = "Annual Salary";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(108, 359);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(78, 43);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "&Calculate";
            this.toolCalculate.SetToolTip(this.btnCalculate, "Calculate end-of-year bonus");
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(213, 359);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(78, 43);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "C&lear";
            this.toolClear.SetToolTip(this.btnClear, "Clear all input and output");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(319, 359);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 43);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.toolExit.SetToolTip(this.btnExit, "Exit calculator");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.SystemColors.Control;
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(90, 203);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(325, 147);
            this.lblOutput.TabIndex = 11;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(6, 5);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 13);
            this.lblDate.TabIndex = 12;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(161, 38);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(178, 26);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Bonus Calculator";
            // 
            // radGood
            // 
            this.radGood.AutoSize = true;
            this.radGood.Location = new System.Drawing.Point(79, 19);
            this.radGood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radGood.Name = "radGood";
            this.radGood.Size = new System.Drawing.Size(55, 19);
            this.radGood.TabIndex = 2;
            this.radGood.Text = "Good";
            this.radGood.UseVisualStyleBackColor = true;
            this.radGood.CheckedChanged += new System.EventHandler(this.radHigh_CheckedChanged);
            // 
            // radFair
            // 
            this.radFair.AutoSize = true;
            this.radFair.Location = new System.Drawing.Point(134, 19);
            this.radFair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radFair.Name = "radFair";
            this.radFair.Size = new System.Drawing.Size(46, 19);
            this.radFair.TabIndex = 3;
            this.radFair.Text = "Fair";
            this.radFair.UseVisualStyleBackColor = true;
            this.radFair.CheckedChanged += new System.EventHandler(this.radHigh_CheckedChanged);
            // 
            // grpPerformance
            // 
            this.grpPerformance.Controls.Add(this.radFair);
            this.grpPerformance.Controls.Add(this.radGood);
            this.grpPerformance.Controls.Add(this.radExcellent);
            this.grpPerformance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPerformance.Location = new System.Drawing.Point(295, 144);
            this.grpPerformance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpPerformance.Name = "grpPerformance";
            this.grpPerformance.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpPerformance.Size = new System.Drawing.Size(191, 48);
            this.grpPerformance.TabIndex = 14;
            this.grpPerformance.TabStop = false;
            this.grpPerformance.Text = "Employee Performance Level";
            // 
            // radExcellent
            // 
            this.radExcellent.AutoSize = true;
            this.radExcellent.Checked = true;
            this.radExcellent.Location = new System.Drawing.Point(4, 19);
            this.radExcellent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radExcellent.Name = "radExcellent";
            this.radExcellent.Size = new System.Drawing.Size(75, 19);
            this.radExcellent.TabIndex = 1;
            this.radExcellent.TabStop = true;
            this.radExcellent.Text = "Excellent";
            this.radExcellent.UseVisualStyleBackColor = true;
            this.radExcellent.CheckedChanged += new System.EventHandler(this.radHigh_CheckedChanged);
            // 
            // radHigh
            // 
            this.radHigh.AutoSize = true;
            this.radHigh.Checked = true;
            this.radHigh.Location = new System.Drawing.Point(4, 19);
            this.radHigh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radHigh.Name = "radHigh";
            this.radHigh.Size = new System.Drawing.Size(51, 19);
            this.radHigh.TabIndex = 0;
            this.radHigh.TabStop = true;
            this.radHigh.Text = "High";
            this.radHigh.UseVisualStyleBackColor = true;
            this.radHigh.CheckedChanged += new System.EventHandler(this.radHigh_CheckedChanged);
            // 
            // radMedium
            // 
            this.radMedium.AutoSize = true;
            this.radMedium.Location = new System.Drawing.Point(55, 19);
            this.radMedium.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radMedium.Name = "radMedium";
            this.radMedium.Size = new System.Drawing.Size(71, 19);
            this.radMedium.TabIndex = 1;
            this.radMedium.Text = "Medium";
            this.radMedium.UseVisualStyleBackColor = true;
            this.radMedium.CheckedChanged += new System.EventHandler(this.radHigh_CheckedChanged);
            // 
            // radLow
            // 
            this.radLow.AutoSize = true;
            this.radLow.Location = new System.Drawing.Point(126, 19);
            this.radLow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radLow.Name = "radLow";
            this.radLow.Size = new System.Drawing.Size(48, 19);
            this.radLow.TabIndex = 2;
            this.radLow.Text = "Low";
            this.radLow.UseVisualStyleBackColor = true;
            this.radLow.CheckedChanged += new System.EventHandler(this.radHigh_CheckedChanged);
            // 
            // grpRank
            // 
            this.grpRank.Controls.Add(this.radLow);
            this.grpRank.Controls.Add(this.radMedium);
            this.grpRank.Controls.Add(this.radHigh);
            this.grpRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRank.Location = new System.Drawing.Point(295, 77);
            this.grpRank.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpRank.Name = "grpRank";
            this.grpRank.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpRank.Size = new System.Drawing.Size(191, 48);
            this.grpRank.TabIndex = 13;
            this.grpRank.TabStop = false;
            this.grpRank.Text = "Employee Rank";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(6, 23);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 13);
            this.lblTime.TabIndex = 16;
            // 
            // frmCalculator
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(514, 416);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpPerformance);
            this.Controls.Add(this.grpRank);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblIDNumber);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtIDNumber);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acme Widgets Bonus Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCalculator_FormClosing);
            this.Load += new System.EventHandler(this.frmCalculator_Load);
            this.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            this.grpPerformance.ResumeLayout(false);
            this.grpPerformance.PerformLayout();
            this.grpRank.ResumeLayout(false);
            this.grpRank.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtIDNumber;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblIDNumber;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ToolTip toolCalculate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton radGood;
        private System.Windows.Forms.RadioButton radFair;
        private System.Windows.Forms.GroupBox grpPerformance;
        private System.Windows.Forms.RadioButton radExcellent;
        private System.Windows.Forms.RadioButton radHigh;
        private System.Windows.Forms.RadioButton radMedium;
        private System.Windows.Forms.RadioButton radLow;
        private System.Windows.Forms.GroupBox grpRank;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ToolTip toolClear;
        private System.Windows.Forms.ToolTip toolExit;
    }
}

