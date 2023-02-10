namespace Ajastin
{
    partial class CountDownForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.minuutitCB = new System.Windows.Forms.ComboBox();
            this.SekunnitCB = new System.Windows.Forms.ComboBox();
            this.aikaLB = new System.Windows.Forms.Label();
            this.StartBT = new System.Windows.Forms.Button();
            this.StopBT = new System.Windows.Forms.Button();
            this.AjastinTM = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minuutit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sekunnit:";
            // 
            // minuutitCB
            // 
            this.minuutitCB.FormattingEnabled = true;
            this.minuutitCB.Location = new System.Drawing.Point(12, 44);
            this.minuutitCB.Name = "minuutitCB";
            this.minuutitCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.minuutitCB.Size = new System.Drawing.Size(111, 40);
            this.minuutitCB.TabIndex = 2;
            // 
            // SekunnitCB
            // 
            this.SekunnitCB.FormattingEnabled = true;
            this.SekunnitCB.Location = new System.Drawing.Point(131, 44);
            this.SekunnitCB.Name = "SekunnitCB";
            this.SekunnitCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SekunnitCB.Size = new System.Drawing.Size(111, 40);
            this.SekunnitCB.TabIndex = 3;
            // 
            // aikaLB
            // 
            this.aikaLB.AutoSize = true;
            this.aikaLB.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aikaLB.Location = new System.Drawing.Point(32, 87);
            this.aikaLB.Name = "aikaLB";
            this.aikaLB.Size = new System.Drawing.Size(191, 86);
            this.aikaLB.TabIndex = 4;
            this.aikaLB.Text = "00:00";
            // 
            // StartBT
            // 
            this.StartBT.Location = new System.Drawing.Point(12, 176);
            this.StartBT.Name = "StartBT";
            this.StartBT.Size = new System.Drawing.Size(105, 43);
            this.StartBT.TabIndex = 5;
            this.StartBT.Text = "Start";
            this.StartBT.UseVisualStyleBackColor = true;
            this.StartBT.Click += new System.EventHandler(this.StartBT_Click);
            // 
            // StopBT
            // 
            this.StopBT.Location = new System.Drawing.Point(137, 176);
            this.StopBT.Name = "StopBT";
            this.StopBT.Size = new System.Drawing.Size(105, 43);
            this.StopBT.TabIndex = 6;
            this.StopBT.Text = " Stop";
            this.StopBT.UseVisualStyleBackColor = true;
            this.StopBT.Click += new System.EventHandler(this.StopBT_Click);
            // 
            // AjastinTM
            // 
            this.AjastinTM.Interval = 1000;
            this.AjastinTM.Tick += new System.EventHandler(this.AjastinTM_Tick);
            // 
            // CountDownForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 228);
            this.Controls.Add(this.StopBT);
            this.Controls.Add(this.StartBT);
            this.Controls.Add(this.aikaLB);
            this.Controls.Add(this.SekunnitCB);
            this.Controls.Add(this.minuutitCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CountDownForm";
            this.Text = "Laskuri";
            this.Load += new System.EventHandler(this.CountDownForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox minuutitCB;
        private ComboBox SekunnitCB;
        private Label aikaLB;
        private Button StartBT;
        private Button StopBT;
        private System.Windows.Forms.Timer AjastinTM;
    }
}