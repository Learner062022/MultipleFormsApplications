namespace DylanDeSouzaWk12ExAMultipleForms
{
    partial class frmSmallCar
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
            this.txt_num_days_hired = new System.Windows.Forms.TextBox();
            this.txt_hire_charge = new System.Windows.Forms.TextBox();
            this.lbl_number_days_hired = new System.Windows.Forms.Label();
            this.lbl_hire_charge = new System.Windows.Forms.Label();
            this.btnClick = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_num_days_hired
            // 
            this.txt_num_days_hired.Location = new System.Drawing.Point(325, 159);
            this.txt_num_days_hired.Name = "txt_num_days_hired";
            this.txt_num_days_hired.Size = new System.Drawing.Size(100, 20);
            this.txt_num_days_hired.TabIndex = 0;
            // 
            // txt_hire_charge
            // 
            this.txt_hire_charge.Location = new System.Drawing.Point(325, 185);
            this.txt_hire_charge.Name = "txt_hire_charge";
            this.txt_hire_charge.Size = new System.Drawing.Size(100, 20);
            this.txt_hire_charge.TabIndex = 1;
            // 
            // lbl_number_days_hired
            // 
            this.lbl_number_days_hired.AutoSize = true;
            this.lbl_number_days_hired.Location = new System.Drawing.Point(224, 166);
            this.lbl_number_days_hired.Name = "lbl_number_days_hired";
            this.lbl_number_days_hired.Size = new System.Drawing.Size(95, 13);
            this.lbl_number_days_hired.TabIndex = 2;
            this.lbl_number_days_hired.Text = "Number days hired";
            // 
            // lbl_hire_charge
            // 
            this.lbl_hire_charge.AutoSize = true;
            this.lbl_hire_charge.Location = new System.Drawing.Point(224, 192);
            this.lbl_hire_charge.Name = "lbl_hire_charge";
            this.lbl_hire_charge.Size = new System.Drawing.Size(62, 13);
            this.lbl_hire_charge.TabIndex = 3;
            this.lbl_hire_charge.Text = "Hire charge";
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(325, 211);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(75, 23);
            this.btnClick.TabIndex = 4;
            this.btnClick.Text = "Click";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmSmallCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.lbl_hire_charge);
            this.Controls.Add(this.lbl_number_days_hired);
            this.Controls.Add(this.txt_hire_charge);
            this.Controls.Add(this.txt_num_days_hired);
            this.Name = "frmSmallCar";
            this.Text = "Small Car";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_number_days_hired;
        private System.Windows.Forms.Label lbl_hire_charge;
        private System.Windows.Forms.Button btnClick;
        internal System.Windows.Forms.TextBox txt_num_days_hired;
        internal System.Windows.Forms.TextBox txt_hire_charge;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}