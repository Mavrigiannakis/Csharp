namespace Paivakirja
{
    partial class Diary
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SyottoTB = new System.Windows.Forms.TextBox();
            this.TallennaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SyottoTB
            // 
            this.SyottoTB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SyottoTB.Location = new System.Drawing.Point(12, 12);
            this.SyottoTB.Multiline = true;
            this.SyottoTB.Name = "SyottoTB";
            this.SyottoTB.Size = new System.Drawing.Size(776, 338);
            this.SyottoTB.TabIndex = 0;
            // 
            // TallennaBT
            // 
            this.TallennaBT.BackColor = System.Drawing.Color.Gainsboro;
            this.TallennaBT.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TallennaBT.Location = new System.Drawing.Point(12, 356);
            this.TallennaBT.Name = "TallennaBT";
            this.TallennaBT.Size = new System.Drawing.Size(776, 82);
            this.TallennaBT.TabIndex = 1;
            this.TallennaBT.Text = "Tallenna päiväkirjaan";
            this.TallennaBT.UseVisualStyleBackColor = false;
            this.TallennaBT.Click += new System.EventHandler(this.TallennaBT_Click);
            // 
            // Diary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TallennaBT);
            this.Controls.Add(this.SyottoTB);
            this.Name = "Diary";
            this.Text = "Päiväkirja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox SyottoTB;
        private Button TallennaBT;
    }
}