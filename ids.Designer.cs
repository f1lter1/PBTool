namespace WindowsFormsApplication1
{
    partial class ids
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ids));
            this.cmbRiffle = new System.Windows.Forms.ComboBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbRiffle
            // 
            this.cmbRiffle.FormattingEnabled = true;
            this.cmbRiffle.Location = new System.Drawing.Point(12, 25);
            this.cmbRiffle.Name = "cmbRiffle";
            this.cmbRiffle.Size = new System.Drawing.Size(268, 21);
            this.cmbRiffle.TabIndex = 0;
            this.cmbRiffle.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cmbRiffle.TextChanged += new System.EventHandler(this.cmbRiffle_TextChanged_1);
            this.cmbRiffle.Click += new System.EventHandler(this.cmbRiffle_Click);
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtValor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtValor.Location = new System.Drawing.Point(0, 159);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(292, 20);
            this.txtValor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Armas...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID:";
            // 
            // ids
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 179);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.cmbRiffle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ids";
            this.Text = "BloodID";
            this.Load += new System.EventHandler(this.ids_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRiffle;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}