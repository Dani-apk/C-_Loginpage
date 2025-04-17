
namespace Damien2
{
    partial class NurseForm
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
            this.lbltitle = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblEmployeeNumber = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtEmployeeNumber = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblSalery = new System.Windows.Forms.Label();
            this.txtSalery = new System.Windows.Forms.TextBox();
            this.btnNurse = new System.Windows.Forms.Button();
            this.dgv3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(195, 9);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(80, 29);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Nurse";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(82, 73);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(54, 13);
            this.lblFirstname.TabIndex = 1;
            this.lblFirstname.Text = "Full Name";
            // 
            // lblEmployeeNumber
            // 
            this.lblEmployeeNumber.AutoSize = true;
            this.lblEmployeeNumber.Location = new System.Drawing.Point(82, 136);
            this.lblEmployeeNumber.Name = "lblEmployeeNumber";
            this.lblEmployeeNumber.Size = new System.Drawing.Size(93, 13);
            this.lblEmployeeNumber.TabIndex = 2;
            this.lblEmployeeNumber.Text = "Employee Number";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(186, 70);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(100, 20);
            this.txtFirstname.TabIndex = 3;
            // 
            // txtEmployeeNumber
            // 
            this.txtEmployeeNumber.Location = new System.Drawing.Point(186, 133);
            this.txtEmployeeNumber.Name = "txtEmployeeNumber";
            this.txtEmployeeNumber.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeNumber.TabIndex = 4;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(85, 195);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblSalery
            // 
            this.lblSalery.AutoSize = true;
            this.lblSalery.Location = new System.Drawing.Point(82, 105);
            this.lblSalery.Name = "lblSalery";
            this.lblSalery.Size = new System.Drawing.Size(36, 13);
            this.lblSalery.TabIndex = 6;
            this.lblSalery.Text = "Salery";
            // 
            // txtSalery
            // 
            this.txtSalery.Location = new System.Drawing.Point(186, 102);
            this.txtSalery.Name = "txtSalery";
            this.txtSalery.Size = new System.Drawing.Size(100, 20);
            this.txtSalery.TabIndex = 7;
            // 
            // btnNurse
            // 
            this.btnNurse.Location = new System.Drawing.Point(186, 195);
            this.btnNurse.Name = "btnNurse";
            this.btnNurse.Size = new System.Drawing.Size(75, 23);
            this.btnNurse.TabIndex = 8;
            this.btnNurse.Text = "Nurse";
            this.btnNurse.UseVisualStyleBackColor = true;
            this.btnNurse.Click += new System.EventHandler(this.btnNurse_Click);
            // 
            // dgv3
            // 
            this.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv3.Location = new System.Drawing.Point(85, 233);
            this.dgv3.Name = "dgv3";
            this.dgv3.Size = new System.Drawing.Size(333, 76);
            this.dgv3.TabIndex = 16;
            // 
            // NurseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 344);
            this.Controls.Add(this.dgv3);
            this.Controls.Add(this.btnNurse);
            this.Controls.Add(this.txtSalery);
            this.Controls.Add(this.lblSalery);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtEmployeeNumber);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.lblEmployeeNumber);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.lbltitle);
            this.Name = "NurseForm";
            this.Text = "NurseForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblEmployeeNumber;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtEmployeeNumber;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblSalery;
        private System.Windows.Forms.TextBox txtSalery;
        private System.Windows.Forms.Button btnNurse;
        private System.Windows.Forms.DataGridView dgv3;
    }
}