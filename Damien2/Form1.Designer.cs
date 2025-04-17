
namespace Damien2
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
            this.lbltitle = new System.Windows.Forms.Label();
            this.radiobtnPatient = new System.Windows.Forms.RadioButton();
            this.radioBtnDoctor = new System.Windows.Forms.RadioButton();
            this.radioBtnPartTime = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.BtnNurse = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(211, 9);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(65, 26);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Login";
            // 
            // radiobtnPatient
            // 
            this.radiobtnPatient.AutoSize = true;
            this.radiobtnPatient.Location = new System.Drawing.Point(115, 60);
            this.radiobtnPatient.Name = "radiobtnPatient";
            this.radiobtnPatient.Size = new System.Drawing.Size(58, 17);
            this.radiobtnPatient.TabIndex = 1;
            this.radiobtnPatient.TabStop = true;
            this.radiobtnPatient.Text = "Patient";
            this.radiobtnPatient.UseVisualStyleBackColor = true;
            this.radiobtnPatient.CheckedChanged += new System.EventHandler(this.radiobtnPatient_CheckedChanged);
            // 
            // radioBtnDoctor
            // 
            this.radioBtnDoctor.AutoSize = true;
            this.radioBtnDoctor.Location = new System.Drawing.Point(115, 95);
            this.radioBtnDoctor.Name = "radioBtnDoctor";
            this.radioBtnDoctor.Size = new System.Drawing.Size(57, 17);
            this.radioBtnDoctor.TabIndex = 2;
            this.radioBtnDoctor.TabStop = true;
            this.radioBtnDoctor.Text = "Doctor";
            this.radioBtnDoctor.UseVisualStyleBackColor = true;
            this.radioBtnDoctor.CheckedChanged += new System.EventHandler(this.radioBtnDoctor_CheckedChanged_1);
            // 
            // radioBtnPartTime
            // 
            this.radioBtnPartTime.AutoSize = true;
            this.radioBtnPartTime.Location = new System.Drawing.Point(115, 168);
            this.radioBtnPartTime.Name = "radioBtnPartTime";
            this.radioBtnPartTime.Size = new System.Drawing.Size(70, 17);
            this.radioBtnPartTime.TabIndex = 4;
            this.radioBtnPartTime.TabStop = true;
            this.radioBtnPartTime.Text = "Part Time";
            this.radioBtnPartTime.UseVisualStyleBackColor = true;
            this.radioBtnPartTime.CheckedChanged += new System.EventHandler(this.radioBtnPartTime_CheckedChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(110, 227);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // BtnNurse
            // 
            this.BtnNurse.AutoSize = true;
            this.BtnNurse.Location = new System.Drawing.Point(115, 133);
            this.BtnNurse.Name = "BtnNurse";
            this.BtnNurse.Size = new System.Drawing.Size(53, 17);
            this.BtnNurse.TabIndex = 6;
            this.BtnNurse.TabStop = true;
            this.BtnNurse.Text = "Nurse";
            this.BtnNurse.UseVisualStyleBackColor = true;
            this.BtnNurse.CheckedChanged += new System.EventHandler(this.BtnNurse_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 333);
            this.Controls.Add(this.BtnNurse);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.radioBtnPartTime);
            this.Controls.Add(this.radioBtnDoctor);
            this.Controls.Add(this.radiobtnPatient);
            this.Controls.Add(this.lbltitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.RadioButton radiobtnPatient;
        private System.Windows.Forms.RadioButton radioBtnDoctor;
        private System.Windows.Forms.RadioButton radioBtnPartTime;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RadioButton BtnNurse;
    }
}

