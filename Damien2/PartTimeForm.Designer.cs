
namespace Damien2
{
    partial class PartTimeForm
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
            this.lbltital = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblEmployeeNumber = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtEmployeeNumber = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.btnPartTime = new System.Windows.Forms.Button();
            this.dgv4 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv4)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltital
            // 
            this.lbltital.AutoSize = true;
            this.lbltital.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltital.Location = new System.Drawing.Point(211, 40);
            this.lbltital.Name = "lbltital";
            this.lbltital.Size = new System.Drawing.Size(124, 29);
            this.lbltital.TabIndex = 0;
            this.lbltital.Text = "Part-Time";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(119, 105);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(52, 13);
            this.lblFirstname.TabIndex = 1;
            this.lblFirstname.Text = "Firstname";
            // 
            // lblEmployeeNumber
            // 
            this.lblEmployeeNumber.AutoSize = true;
            this.lblEmployeeNumber.Location = new System.Drawing.Point(119, 235);
            this.lblEmployeeNumber.Name = "lblEmployeeNumber";
            this.lblEmployeeNumber.Size = new System.Drawing.Size(93, 13);
            this.lblEmployeeNumber.TabIndex = 2;
            this.lblEmployeeNumber.Text = "Employee Number";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(216, 102);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(100, 20);
            this.txtFirstname.TabIndex = 3;
            // 
            // txtEmployeeNumber
            // 
            this.txtEmployeeNumber.Location = new System.Drawing.Point(216, 232);
            this.txtEmployeeNumber.Name = "txtEmployeeNumber";
            this.txtEmployeeNumber.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeNumber.TabIndex = 4;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(122, 272);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(69, 28);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(119, 141);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(53, 13);
            this.lblLastname.TabIndex = 6;
            this.lblLastname.Text = "Lastname";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(119, 171);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 7;
            this.lblPhone.Text = "Phone";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(119, 202);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(35, 13);
            this.lblHours.TabIndex = 8;
            this.lblHours.Text = "Hours";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(216, 138);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(100, 20);
            this.txtLastname.TabIndex = 9;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(216, 168);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 10;
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(216, 199);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(100, 20);
            this.txtHours.TabIndex = 11;
            // 
            // btnPartTime
            // 
            this.btnPartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartTime.Location = new System.Drawing.Point(216, 272);
            this.btnPartTime.Name = "btnPartTime";
            this.btnPartTime.Size = new System.Drawing.Size(69, 28);
            this.btnPartTime.TabIndex = 12;
            this.btnPartTime.Text = "Part Time";
            this.btnPartTime.UseVisualStyleBackColor = true;
            this.btnPartTime.Click += new System.EventHandler(this.btnPartTime_Click);
            // 
            // dgv4
            // 
            this.dgv4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv4.Location = new System.Drawing.Point(122, 306);
            this.dgv4.Name = "dgv4";
            this.dgv4.Size = new System.Drawing.Size(333, 76);
            this.dgv4.TabIndex = 17;
            // 
            // PartTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 491);
            this.Controls.Add(this.dgv4);
            this.Controls.Add(this.btnPartTime);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtEmployeeNumber);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.lblEmployeeNumber);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.lbltital);
            this.Name = "PartTimeForm";
            this.Text = "Part_Time";
            ((System.ComponentModel.ISupportInitialize)(this.dgv4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltital;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblEmployeeNumber;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtEmployeeNumber;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Button btnPartTime;
        private System.Windows.Forms.DataGridView dgv4;
    }
}