namespace DistanceConversion
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
            this.lblMiles = new System.Windows.Forms.Label();
            this.lblKM = new System.Windows.Forms.Label();
            this.txtKM = new System.Windows.Forms.TextBox();
            this.txtMiles = new System.Windows.Forms.TextBox();
            this.lblDashes = new System.Windows.Forms.Label();
            this.btnMItoKM = new System.Windows.Forms.Button();
            this.btnKMtoMI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMiles
            // 
            this.lblMiles.AutoSize = true;
            this.lblMiles.Location = new System.Drawing.Point(13, 19);
            this.lblMiles.Name = "lblMiles";
            this.lblMiles.Size = new System.Drawing.Size(31, 13);
            this.lblMiles.TabIndex = 0;
            this.lblMiles.Text = "Miles";
            // 
            // lblKM
            // 
            this.lblKM.AutoSize = true;
            this.lblKM.Location = new System.Drawing.Point(270, 19);
            this.lblKM.Name = "lblKM";
            this.lblKM.Size = new System.Drawing.Size(55, 13);
            this.lblKM.TabIndex = 1;
            this.lblKM.Text = "Kilometers";
            // 
            // txtKM
            // 
            this.txtKM.Location = new System.Drawing.Point(331, 16);
            this.txtKM.Name = "txtKM";
            this.txtKM.Size = new System.Drawing.Size(100, 20);
            this.txtKM.TabIndex = 2;
            // 
            // txtMiles
            // 
            this.txtMiles.Location = new System.Drawing.Point(52, 16);
            this.txtMiles.Name = "txtMiles";
            this.txtMiles.Size = new System.Drawing.Size(100, 20);
            this.txtMiles.TabIndex = 3;
            // 
            // lblDashes
            // 
            this.lblDashes.AutoSize = true;
            this.lblDashes.Location = new System.Drawing.Point(158, 19);
            this.lblDashes.Name = "lblDashes";
            this.lblDashes.Size = new System.Drawing.Size(106, 13);
            this.lblDashes.TabIndex = 4;
            this.lblDashes.Text = "<----------------------------->";
            // 
            // btnMItoKM
            // 
            this.btnMItoKM.Location = new System.Drawing.Point(65, 43);
            this.btnMItoKM.Name = "btnMItoKM";
            this.btnMItoKM.Size = new System.Drawing.Size(75, 23);
            this.btnMItoKM.TabIndex = 5;
            this.btnMItoKM.Text = "&Mi to Km";
            this.btnMItoKM.UseVisualStyleBackColor = true;
            this.btnMItoKM.Click += new System.EventHandler(this.btnMItoKM_Click);
            // 
            // btnKMtoMI
            // 
            this.btnKMtoMI.Location = new System.Drawing.Point(344, 42);
            this.btnKMtoMI.Name = "btnKMtoMI";
            this.btnKMtoMI.Size = new System.Drawing.Size(75, 23);
            this.btnKMtoMI.TabIndex = 6;
            this.btnKMtoMI.Text = "&Km to Mi";
            this.btnKMtoMI.UseVisualStyleBackColor = true;
            this.btnKMtoMI.Click += new System.EventHandler(this.btnKMtoMI_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 89);
            this.Controls.Add(this.btnKMtoMI);
            this.Controls.Add(this.btnMItoKM);
            this.Controls.Add(this.lblDashes);
            this.Controls.Add(this.txtMiles);
            this.Controls.Add(this.txtKM);
            this.Controls.Add(this.lblKM);
            this.Controls.Add(this.lblMiles);
            this.Name = "Form1";
            this.Text = "Distance Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMiles;
        private System.Windows.Forms.Label lblKM;
        private System.Windows.Forms.TextBox txtKM;
        private System.Windows.Forms.TextBox txtMiles;
        private System.Windows.Forms.Label lblDashes;
        private System.Windows.Forms.Button btnMItoKM;
        private System.Windows.Forms.Button btnKMtoMI;
    }
}

