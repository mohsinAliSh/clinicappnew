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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KetForm));
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
            this.KetQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KetQuantityLabel.Location = new System.Drawing.Point(12, 89);
            this.KetQuantityLabel.Name = "KetQuantityLabel";
            this.KetQuantityLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.KetQuantityLabel.Size = new System.Drawing.Size(171, 37);
            this.KetQuantityLabel.TabIndex = 27;
            this.KetQuantityLabel.Text = ": New Kits";
            // 
            // NewKetsLabel
            // 
            this.NewKetsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewKetsLabel.Location = new System.Drawing.Point(220, 89);
            this.NewKetsLabel.MaxLength = 99;
            this.NewKetsLabel.Name = "NewKetsLabel";
            this.NewKetsLabel.Size = new System.Drawing.Size(181, 44);
            this.NewKetsLabel.TabIndex = 26;
            this.NewKetsLabel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewKetsLabel_KeyPress);
            // 
            // KetsAddButton
            // 
            this.KetsAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KetsAddButton.Location = new System.Drawing.Point(453, 89);
            this.KetsAddButton.Name = "KetsAddButton";
            this.KetsAddButton.Size = new System.Drawing.Size(181, 37);
            this.KetsAddButton.TabIndex = 28;
            this.KetsAddButton.Text = "Add";
            this.KetsAddButton.UseVisualStyleBackColor = true;
            this.KetsAddButton.Click += new System.EventHandler(this.KetsAddButton_Click);
            // 
            // totalKetsLabel
            // 
            this.totalKetsLabel.AutoSize = true;
            this.totalKetsLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalKetsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalKetsLabel.Location = new System.Drawing.Point(400, 229);
            this.totalKetsLabel.Name = "totalKetsLabel";
            this.totalKetsLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totalKetsLabel.Size = new System.Drawing.Size(36, 37);
            this.totalKetsLabel.TabIndex = 29;
            this.totalKetsLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 229);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(181, 37);
            this.label2.TabIndex = 30;
            this.label2.Text = ": Total Kits";
            // 
            // KetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 492);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalKetsLabel);
            this.Controls.Add(this.KetsAddButton);
            this.Controls.Add(this.KetQuantityLabel);
            this.Controls.Add(this.NewKetsLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KetForm";
            this.Load += new System.EventHandler(this.LoadKetsQuantity);
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