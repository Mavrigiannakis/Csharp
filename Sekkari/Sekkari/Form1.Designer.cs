namespace Sekkari
{
    partial class SekkariForm
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
            this.components = new System.ComponentModel.Container();
            this.AikaLB = new System.Windows.Forms.Label();
            this.KaynnistaBT = new System.Windows.Forms.Button();
            this.LopetaBT = new System.Windows.Forms.Button();
            this.TyhjennaBT = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // AikaLB
            // 
            this.AikaLB.AutoSize = true;
            this.AikaLB.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AikaLB.Location = new System.Drawing.Point(22, 23);
            this.AikaLB.Name = "AikaLB";
            this.AikaLB.Size = new System.Drawing.Size(585, 128);
            this.AikaLB.TabIndex = 0;
            this.AikaLB.Text = "00:00:00.000";
            // 
            // KaynnistaBT
            // 
            this.KaynnistaBT.BackColor = System.Drawing.Color.Gainsboro;
            this.KaynnistaBT.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KaynnistaBT.Location = new System.Drawing.Point(12, 154);
            this.KaynnistaBT.Name = "KaynnistaBT";
            this.KaynnistaBT.Size = new System.Drawing.Size(198, 59);
            this.KaynnistaBT.TabIndex = 1;
            this.KaynnistaBT.Text = "Käynnistä";
            this.KaynnistaBT.UseVisualStyleBackColor = false;
            this.KaynnistaBT.Click += new System.EventHandler(this.KaynnistaBT_Click);
            // 
            // LopetaBT
            // 
            this.LopetaBT.BackColor = System.Drawing.Color.Gainsboro;
            this.LopetaBT.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LopetaBT.Location = new System.Drawing.Point(216, 154);
            this.LopetaBT.Name = "LopetaBT";
            this.LopetaBT.Size = new System.Drawing.Size(198, 59);
            this.LopetaBT.TabIndex = 2;
            this.LopetaBT.Text = "Lopeta";
            this.LopetaBT.UseVisualStyleBackColor = false;
            this.LopetaBT.Click += new System.EventHandler(this.LopetaBT_Click);
            // 
            // TyhjennaBT
            // 
            this.TyhjennaBT.BackColor = System.Drawing.Color.Gainsboro;
            this.TyhjennaBT.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TyhjennaBT.Location = new System.Drawing.Point(420, 154);
            this.TyhjennaBT.Name = "TyhjennaBT";
            this.TyhjennaBT.Size = new System.Drawing.Size(198, 59);
            this.TyhjennaBT.TabIndex = 3;
            this.TyhjennaBT.Text = "Tyhjennä";
            this.TyhjennaBT.UseVisualStyleBackColor = false;
            this.TyhjennaBT.Click += new System.EventHandler(this.TyhjennaBT_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SekkariForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 290);
            this.Controls.Add(this.TyhjennaBT);
            this.Controls.Add(this.LopetaBT);
            this.Controls.Add(this.KaynnistaBT);
            this.Controls.Add(this.AikaLB);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "SekkariForm";
            this.Text = "Sekuntikello";
            this.Load += new System.EventHandler(this.SekkariForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label AikaLB;
        private Button KaynnistaBT;
        private Button LopetaBT;
        private Button TyhjennaBT;
        private System.Windows.Forms.Timer timer1;
    }
}