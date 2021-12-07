namespace ClinicApp.Forms
{
    partial class KetForm
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
            this.KetQuantityLabel = new System.Windows.Forms.Label();
            this.NewKetsLabel = new System.Windows.Forms.TextBox();
            this.KetsAddButton = new System.Windows.Forms.Button();
            this.totalKetsLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KetQuantityLabel
            // 
            this.KetQuantityLabel.AutoSize = true;
            this.KetQuantityLabel.Location = new System.Drawing.Point(62, 89);
            this.KetQuantityLabel.Name = "KetQuantityLabel";
            this.KetQuantityLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.KetQuantityLabel.Size = new System.Drawing.Size(59, 13);
            this.KetQuantityLabel.TabIndex = 27;
            this.KetQuantityLabel.Text = ": New Kets";
            // 
            // NewKetsLabel
            // 
            this.NewKetsLabel.Location = new System.Drawing.Point(149, 89);
            this.NewKetsLabel.MaxLength = 99;
            this.NewKetsLabel.Name = "NewKetsLabel";
            this.NewKetsLabel.Size = new System.Drawing.Size(146, 20);
            this.NewKetsLabel.TabIndex = 26;
            // 
            // KetsAddButton
            // 
            this.KetsAddButton.Location = new System.Drawing.Point(330, 89);
            this.KetsAddButton.Name = "KetsAddButton";
            this.KetsAddButton.Size = new System.Drawing.Size(75, 23);
            this.KetsAddButton.TabIndex = 28;
            this.KetsAddButton.Text = "Add";
            this.KetsAddButton.UseVisualStyleBackColor = true;
            this.KetsAddButton.Click += new System.EventHandler(this.KetsAddButton_Click);
            // 
            // totalKetsLabel
            // 
            this.totalKetsLabel.AutoSize = true;
            this.totalKetsLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalKetsLabel.Location = new System.Drawing.Point(149, 133);
            this.totalKetsLabel.Name = "totalKetsLabel";
            this.totalKetsLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totalKetsLabel.Size = new System.Drawing.Size(13, 13);
            this.totalKetsLabel.TabIndex = 29;
            this.totalKetsLabel.Text = "0";
            this.totalKetsLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 133);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = ": Total Kets";
            // 
            // KetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 257);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalKetsLabel);
            this.Controls.Add(this.KetsAddButton);
            this.Controls.Add(this.KetQuantityLabel);
            this.Controls.Add(this.NewKetsLabel);
            this.Load += new System.EventHandler(this.LoadKetsQuantity);
            this.Name = "KetForm";
            this.Text = "KetForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label KetQuantityLabel;
        private System.Windows.Forms.TextBox NewKetsLabel;
        private System.Windows.Forms.Button KetsAddButton;
        private System.Windows.Forms.Label totalKetsLabel;
        private System.Windows.Forms.Label label2;
    }
}