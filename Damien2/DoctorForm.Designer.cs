
namespace Damien2
{
    partial class DoctorForm
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
            this.lblLung = new System.Windows.Forms.Label();
            this.lblHeart = new System.Windows.Forms.Label();
            this.txtLung = new System.Windows.Forms.TextBox();
            this.txtHeart = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.txtEmployeeNumber = new System.Windows.Forms.TextBox();
            this.btnDoctor = new System.Windows.Forms.Button();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Location = new System.Drawing.Point(276, 26);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(39, 13);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Doctor";
            // 
            // lblLung
            // 
            this.lblLung.AutoSize = true;
            this.lblLung.Location = new System.Drawing.Point(131, 105);
            this.lblLung.Name = "lblLung";
            this.lblLung.Size = new System.Drawing.Size(66, 13);
            this.lblLung.TabIndex = 1;
            this.lblLung.Text = "Lung Docter";
            // 
            // lblHeart
            // 
            this.lblHeart.AutoSize = true;
            this.lblHeart.Location = new System.Drawing.Point(131, 146);
            this.lblHeart.Name = "lblHeart";
            this.lblHeart.Size = new System.Drawing.Size(68, 13);
            this.lblHeart.TabIndex = 2;
            this.lblHeart.Text = "Heart Doctor";
            // 
            // txtLung
            // 
            this.txtLung.Location = new System.Drawing.Point(242, 102);
            this.txtLung.Name = "txtLung";
            this.txtLung.Size = new System.Drawing.Size(100, 20);
            this.txtLung.TabIndex = 3;
            // 
            // txtHeart
            // 
            this.txtHeart.Location = new System.Drawing.Point(242, 143);
            this.txtHeart.Name = "txtHeart";
            this.txtHeart.Size = new System.Drawing.Size(100, 20);
            this.txtHeart.TabIndex = 4;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(134, 221);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(131, 184);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(93, 13);
            this.lblEmployee.TabIndex = 6;
            this.lblEmployee.Text = "Employee Number";
            // 
            // txtEmployeeNumber
            // 
            this.txtEmployeeNumber.Location = new System.Drawing.Point(242, 181);
            this.txtEmployeeNumber.Name = "txtEmployeeNumber";
            this.txtEmployeeNumber.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeNumber.TabIndex = 7;
            // 
            // btnDoctor
            // 
            this.btnDoctor.Location = new System.Drawing.Point(242, 221);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Size = new System.Drawing.Size(75, 23);
            this.btnDoctor.TabIndex = 8;
            this.btnDoctor.Text = "Doctor";
            this.btnDoctor.UseVisualStyleBackColor = true;
            this.btnDoctor.Click += new System.EventHandler(this.btnDoctor_Click);
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(134, 261);
            this.dgv2.Name = "dgv2";
            this.dgv2.Size = new System.Drawing.Size(333, 76);
            this.dgv2.TabIndex = 15;
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 450);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.btnDoctor);
            this.Controls.Add(this.txtEmployeeNumber);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtHeart);
            this.Controls.Add(this.txtLung);
            this.Controls.Add(this.lblHeart);
            this.Controls.Add(this.lblLung);
            this.Controls.Add(this.lbltitle);
            this.Name = "DoctorForm";
            this.Text = "DoctorForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lblLung;
        private System.Windows.Forms.Label lblHeart;
        private System.Windows.Forms.TextBox txtLung;
        private System.Windows.Forms.TextBox txtHeart;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.TextBox txtEmployeeNumber;
        private System.Windows.Forms.Button btnDoctor;
        private System.Windows.Forms.DataGridView dgv2;
    }
}