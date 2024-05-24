namespace EmployerApplication
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
            this.firstName = new System.Windows.Forms.Label();
            this.firstnametxtbox = new System.Windows.Forms.TextBox();
            this.computesalarybtn = new System.Windows.Forms.Button();
            this.departmentxtbox = new System.Windows.Forms.TextBox();
            this.departmenttxtbox = new System.Windows.Forms.Label();
            this.ratePerhourtxtbox = new System.Windows.Forms.TextBox();
            this.ratePerhourlabel = new System.Windows.Forms.Label();
            this.tothoursworktxtbox = new System.Windows.Forms.TextBox();
            this.totalhourswork = new System.Windows.Forms.Label();
            this.jobTitletxtbox = new System.Windows.Forms.TextBox();
            this.jobtitle = new System.Windows.Forms.Label();
            this.lastNametxtbox = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.Label();
            this.firstnameresult = new System.Windows.Forms.Label();
            this.lastnameresult = new System.Windows.Forms.Label();
            this.basicsalaryresult = new System.Windows.Forms.Label();
            this.fnameresult = new System.Windows.Forms.Label();
            this.lnameresult = new System.Windows.Forms.Label();
            this.basicsalresult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(149, 74);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(57, 13);
            this.firstName.TabIndex = 0;
            this.firstName.Text = "First Name";
            // 
            // firstnametxtbox
            // 
            this.firstnametxtbox.Location = new System.Drawing.Point(152, 90);
            this.firstnametxtbox.Name = "firstnametxtbox";
            this.firstnametxtbox.Size = new System.Drawing.Size(194, 20);
            this.firstnametxtbox.TabIndex = 1;
            // 
            // computesalarybtn
            // 
            this.computesalarybtn.Location = new System.Drawing.Point(289, 258);
            this.computesalarybtn.Name = "computesalarybtn";
            this.computesalarybtn.Size = new System.Drawing.Size(187, 33);
            this.computesalarybtn.TabIndex = 2;
            this.computesalarybtn.Text = "Compute Salary";
            this.computesalarybtn.UseVisualStyleBackColor = true;
            this.computesalarybtn.Click += new System.EventHandler(this.computesalarybtn_Click);
            // 
            // departmentxtbox
            // 
            this.departmentxtbox.Location = new System.Drawing.Point(152, 143);
            this.departmentxtbox.Name = "departmentxtbox";
            this.departmentxtbox.Size = new System.Drawing.Size(194, 20);
            this.departmentxtbox.TabIndex = 4;
            // 
            // departmenttxtbox
            // 
            this.departmenttxtbox.AutoSize = true;
            this.departmenttxtbox.Location = new System.Drawing.Point(149, 127);
            this.departmenttxtbox.Name = "departmenttxtbox";
            this.departmenttxtbox.Size = new System.Drawing.Size(62, 13);
            this.departmenttxtbox.TabIndex = 3;
            this.departmenttxtbox.Text = "Department";
            // 
            // ratePerhourtxtbox
            // 
            this.ratePerhourtxtbox.Location = new System.Drawing.Point(153, 199);
            this.ratePerhourtxtbox.Name = "ratePerhourtxtbox";
            this.ratePerhourtxtbox.Size = new System.Drawing.Size(194, 20);
            this.ratePerhourtxtbox.TabIndex = 6;
            // 
            // ratePerhourlabel
            // 
            this.ratePerhourlabel.AutoSize = true;
            this.ratePerhourlabel.Location = new System.Drawing.Point(149, 183);
            this.ratePerhourlabel.Name = "ratePerhourlabel";
            this.ratePerhourlabel.Size = new System.Drawing.Size(72, 13);
            this.ratePerhourlabel.TabIndex = 5;
            this.ratePerhourlabel.Text = "Rate per hour";
            // 
            // tothoursworktxtbox
            // 
            this.tothoursworktxtbox.Location = new System.Drawing.Point(381, 199);
            this.tothoursworktxtbox.Name = "tothoursworktxtbox";
            this.tothoursworktxtbox.Size = new System.Drawing.Size(194, 20);
            this.tothoursworktxtbox.TabIndex = 12;
            // 
            // totalhourswork
            // 
            this.totalhourswork.AutoSize = true;
            this.totalhourswork.Location = new System.Drawing.Point(378, 183);
            this.totalhourswork.Name = "totalhourswork";
            this.totalhourswork.Size = new System.Drawing.Size(98, 13);
            this.totalhourswork.TabIndex = 11;
            this.totalhourswork.Text = "Total hours worked";
            // 
            // jobTitletxtbox
            // 
            this.jobTitletxtbox.Location = new System.Drawing.Point(381, 143);
            this.jobTitletxtbox.Name = "jobTitletxtbox";
            this.jobTitletxtbox.Size = new System.Drawing.Size(194, 20);
            this.jobTitletxtbox.TabIndex = 10;
            // 
            // jobtitle
            // 
            this.jobtitle.AutoSize = true;
            this.jobtitle.Location = new System.Drawing.Point(378, 127);
            this.jobtitle.Name = "jobtitle";
            this.jobtitle.Size = new System.Drawing.Size(47, 13);
            this.jobtitle.TabIndex = 9;
            this.jobtitle.Text = "Job Title";
            // 
            // lastNametxtbox
            // 
            this.lastNametxtbox.Location = new System.Drawing.Point(381, 90);
            this.lastNametxtbox.Name = "lastNametxtbox";
            this.lastNametxtbox.Size = new System.Drawing.Size(194, 20);
            this.lastNametxtbox.TabIndex = 8;
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(378, 74);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(58, 13);
            this.lastName.TabIndex = 7;
            this.lastName.Text = "Last Name";
            // 
            // firstnameresult
            // 
            this.firstnameresult.AutoSize = true;
            this.firstnameresult.Location = new System.Drawing.Point(99, 268);
            this.firstnameresult.Name = "firstnameresult";
            this.firstnameresult.Size = new System.Drawing.Size(57, 13);
            this.firstnameresult.TabIndex = 13;
            this.firstnameresult.Text = "First Name";
            // 
            // lastnameresult
            // 
            this.lastnameresult.AutoSize = true;
            this.lastnameresult.Location = new System.Drawing.Point(99, 293);
            this.lastnameresult.Name = "lastnameresult";
            this.lastnameresult.Size = new System.Drawing.Size(58, 13);
            this.lastnameresult.TabIndex = 14;
            this.lastnameresult.Text = "Last Name";
            // 
            // basicsalaryresult
            // 
            this.basicsalaryresult.AutoSize = true;
            this.basicsalaryresult.Location = new System.Drawing.Point(99, 321);
            this.basicsalaryresult.Name = "basicsalaryresult";
            this.basicsalaryresult.Size = new System.Drawing.Size(65, 13);
            this.basicsalaryresult.TabIndex = 15;
            this.basicsalaryresult.Text = "Basic Salary";
            // 
            // fnameresult
            // 
            this.fnameresult.AutoSize = true;
            this.fnameresult.Location = new System.Drawing.Point(176, 268);
            this.fnameresult.Name = "fnameresult";
            this.fnameresult.Size = new System.Drawing.Size(0, 13);
            this.fnameresult.TabIndex = 16;
            // 
            // lnameresult
            // 
            this.lnameresult.AutoSize = true;
            this.lnameresult.Location = new System.Drawing.Point(176, 293);
            this.lnameresult.Name = "lnameresult";
            this.lnameresult.Size = new System.Drawing.Size(0, 13);
            this.lnameresult.TabIndex = 17;
            // 
            // basicsalresult
            // 
            this.basicsalresult.AutoSize = true;
            this.basicsalresult.Location = new System.Drawing.Point(176, 321);
            this.basicsalresult.Name = "basicsalresult";
            this.basicsalresult.Size = new System.Drawing.Size(0, 13);
            this.basicsalresult.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.basicsalresult);
            this.Controls.Add(this.lnameresult);
            this.Controls.Add(this.fnameresult);
            this.Controls.Add(this.basicsalaryresult);
            this.Controls.Add(this.lastnameresult);
            this.Controls.Add(this.firstnameresult);
            this.Controls.Add(this.tothoursworktxtbox);
            this.Controls.Add(this.totalhourswork);
            this.Controls.Add(this.jobTitletxtbox);
            this.Controls.Add(this.jobtitle);
            this.Controls.Add(this.lastNametxtbox);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.ratePerhourtxtbox);
            this.Controls.Add(this.ratePerhourlabel);
            this.Controls.Add(this.departmentxtbox);
            this.Controls.Add(this.departmenttxtbox);
            this.Controls.Add(this.computesalarybtn);
            this.Controls.Add(this.firstnametxtbox);
            this.Controls.Add(this.firstName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.TextBox firstnametxtbox;
        private System.Windows.Forms.Button computesalarybtn;
        private System.Windows.Forms.TextBox departmentxtbox;
        private System.Windows.Forms.Label departmenttxtbox;
        private System.Windows.Forms.TextBox ratePerhourtxtbox;
        private System.Windows.Forms.Label ratePerhourlabel;
        private System.Windows.Forms.TextBox tothoursworktxtbox;
        private System.Windows.Forms.Label totalhourswork;
        private System.Windows.Forms.TextBox jobTitletxtbox;
        private System.Windows.Forms.Label jobtitle;
        private System.Windows.Forms.TextBox lastNametxtbox;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label firstnameresult;
        private System.Windows.Forms.Label lastnameresult;
        private System.Windows.Forms.Label basicsalaryresult;
        private System.Windows.Forms.Label fnameresult;
        private System.Windows.Forms.Label lnameresult;
        private System.Windows.Forms.Label basicsalresult;
    }
}

