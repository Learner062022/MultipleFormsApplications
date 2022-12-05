namespace DylanDeSouzaWk12ExAMultipleForms
{
    partial class frmNames
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
            this.lstNames = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstNames
            // 
            this.lstNames.FormattingEnabled = true;
            this.lstNames.Location = new System.Drawing.Point(292, 103);
            this.lstNames.Name = "lstNames";
            this.lstNames.Size = new System.Drawing.Size(236, 95);
            this.lstNames.TabIndex = 0;
            // 
            // frmNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstNames);
            this.Name = "frmNames";
            this.Text = "Display Names";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ListBox lstNames;
    }
}