namespace DylanDeSouzaWk12ExAMultipleForms
{
    partial class frmCarRentals
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
            this.btn_small = new System.Windows.Forms.Button();
            this.btn_medium = new System.Windows.Forms.Button();
            this.btn_large = new System.Windows.Forms.Button();
            this.lbl_car_types = new System.Windows.Forms.Label();
            this.lst_car_type_daily_fee = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_small
            // 
            this.btn_small.Location = new System.Drawing.Point(303, 117);
            this.btn_small.Name = "btn_small";
            this.btn_small.Size = new System.Drawing.Size(75, 23);
            this.btn_small.TabIndex = 0;
            this.btn_small.Text = "Small";
            this.btn_small.UseVisualStyleBackColor = true;
            this.btn_small.Click += new System.EventHandler(this.btn_small_Click);
            // 
            // btn_medium
            // 
            this.btn_medium.Location = new System.Drawing.Point(303, 146);
            this.btn_medium.Name = "btn_medium";
            this.btn_medium.Size = new System.Drawing.Size(75, 23);
            this.btn_medium.TabIndex = 1;
            this.btn_medium.Text = "Medium";
            this.btn_medium.UseVisualStyleBackColor = true;
            this.btn_medium.Click += new System.EventHandler(this.btn_medium_Click);
            // 
            // btn_large
            // 
            this.btn_large.Location = new System.Drawing.Point(303, 175);
            this.btn_large.Name = "btn_large";
            this.btn_large.Size = new System.Drawing.Size(75, 23);
            this.btn_large.TabIndex = 2;
            this.btn_large.Text = "Large";
            this.btn_large.UseVisualStyleBackColor = true;
            this.btn_large.Click += new System.EventHandler(this.btn_large_Click);
            // 
            // lbl_car_types
            // 
            this.lbl_car_types.AutoSize = true;
            this.lbl_car_types.Location = new System.Drawing.Point(300, 101);
            this.lbl_car_types.Name = "lbl_car_types";
            this.lbl_car_types.Size = new System.Drawing.Size(55, 13);
            this.lbl_car_types.TabIndex = 3;
            this.lbl_car_types.Text = "Car Types";
            // 
            // lst_car_type_daily_fee
            // 
            this.lst_car_type_daily_fee.FormattingEnabled = true;
            this.lst_car_type_daily_fee.Location = new System.Drawing.Point(436, 117);
            this.lst_car_type_daily_fee.Name = "lst_car_type_daily_fee";
            this.lst_car_type_daily_fee.Size = new System.Drawing.Size(120, 95);
            this.lst_car_type_daily_fee.TabIndex = 4;
            // 
            // frmCarRentals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lst_car_type_daily_fee);
            this.Controls.Add(this.lbl_car_types);
            this.Controls.Add(this.btn_large);
            this.Controls.Add(this.btn_medium);
            this.Controls.Add(this.btn_small);
            this.Name = "frmCarRentals";
            this.Text = "Car Rentals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_small;
        private System.Windows.Forms.Button btn_medium;
        private System.Windows.Forms.Button btn_large;
        private System.Windows.Forms.Label lbl_car_types;
        private System.Windows.Forms.ListBox lst_car_type_daily_fee;
    }
}