namespace CRUD
{
    partial class YllapitoForm
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
            this.TietotauluDG = new System.Windows.Forms.DataGridView();
            this.IDLB = new System.Windows.Forms.Label();
            this.ETUNIMILB = new System.Windows.Forms.Label();
            this.SUKUNIMILB = new System.Windows.Forms.Label();
            this.PUHELINLB = new System.Windows.Forms.Label();
            this.SPOSTILB = new System.Windows.Forms.Label();
            this.OPINROLB = new System.Windows.Forms.Label();
            this.idTB = new System.Windows.Forms.TextBox();
            this.enimiTB = new System.Windows.Forms.TextBox();
            this.snimiTB = new System.Windows.Forms.TextBox();
            this.puhTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.oNroTB = new System.Windows.Forms.TextBox();
            this.tyhjennaBT = new System.Windows.Forms.Button();
            this.tallennaBT = new System.Windows.Forms.Button();
            this.paivitaBT = new System.Windows.Forms.Button();
            this.poistaBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TietotauluDG)).BeginInit();
            this.SuspendLayout();
            // 
            // TietotauluDG
            // 
            this.TietotauluDG.AllowUserToOrderColumns = true;
            this.TietotauluDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TietotauluDG.Location = new System.Drawing.Point(0, 216);
            this.TietotauluDG.Name = "TietotauluDG";
            this.TietotauluDG.Size = new System.Drawing.Size(800, 233);
            this.TietotauluDG.TabIndex = 0;
            this.TietotauluDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TietotauluDG_CellClick);
            // 
            // IDLB
            // 
            this.IDLB.AutoSize = true;
            this.IDLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLB.Location = new System.Drawing.Point(27, 24);
            this.IDLB.Name = "IDLB";
            this.IDLB.Size = new System.Drawing.Size(38, 25);
            this.IDLB.TabIndex = 1;
            this.IDLB.Text = "ID:";
            // 
            // ETUNIMILB
            // 
            this.ETUNIMILB.AutoSize = true;
            this.ETUNIMILB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ETUNIMILB.Location = new System.Drawing.Point(27, 67);
            this.ETUNIMILB.Name = "ETUNIMILB";
            this.ETUNIMILB.Size = new System.Drawing.Size(103, 25);
            this.ETUNIMILB.TabIndex = 2;
            this.ETUNIMILB.Text = "ETUNIMI:";
            // 
            // SUKUNIMILB
            // 
            this.SUKUNIMILB.AutoSize = true;
            this.SUKUNIMILB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUKUNIMILB.Location = new System.Drawing.Point(27, 113);
            this.SUKUNIMILB.Name = "SUKUNIMILB";
            this.SUKUNIMILB.Size = new System.Drawing.Size(119, 25);
            this.SUKUNIMILB.TabIndex = 3;
            this.SUKUNIMILB.Text = "SUKUNIMI:";
            // 
            // PUHELINLB
            // 
            this.PUHELINLB.AutoSize = true;
            this.PUHELINLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PUHELINLB.Location = new System.Drawing.Point(365, 24);
            this.PUHELINLB.Name = "PUHELINLB";
            this.PUHELINLB.Size = new System.Drawing.Size(108, 25);
            this.PUHELINLB.TabIndex = 4;
            this.PUHELINLB.Text = "PUHELIN:";
            // 
            // SPOSTILB
            // 
            this.SPOSTILB.AutoSize = true;
            this.SPOSTILB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPOSTILB.Location = new System.Drawing.Point(365, 67);
            this.SPOSTILB.Name = "SPOSTILB";
            this.SPOSTILB.Size = new System.Drawing.Size(153, 25);
            this.SPOSTILB.TabIndex = 5;
            this.SPOSTILB.Text = "SÄHKÖPOSTI:";
            // 
            // OPINROLB
            // 
            this.OPINROLB.AutoSize = true;
            this.OPINROLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OPINROLB.Location = new System.Drawing.Point(365, 113);
            this.OPINROLB.Name = "OPINROLB";
            this.OPINROLB.Size = new System.Drawing.Size(183, 25);
            this.OPINROLB.TabIndex = 6;
            this.OPINROLB.Text = "OPISKELIJANRO:";
            // 
            // idTB
            // 
            this.idTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTB.Location = new System.Drawing.Point(158, 29);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(189, 31);
            this.idTB.TabIndex = 7;
            // 
            // enimiTB
            // 
            this.enimiTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enimiTB.Location = new System.Drawing.Point(158, 72);
            this.enimiTB.Name = "enimiTB";
            this.enimiTB.Size = new System.Drawing.Size(189, 31);
            this.enimiTB.TabIndex = 8;
            // 
            // snimiTB
            // 
            this.snimiTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snimiTB.Location = new System.Drawing.Point(158, 119);
            this.snimiTB.Name = "snimiTB";
            this.snimiTB.Size = new System.Drawing.Size(189, 31);
            this.snimiTB.TabIndex = 9;
            // 
            // puhTB
            // 
            this.puhTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puhTB.Location = new System.Drawing.Point(554, 29);
            this.puhTB.Name = "puhTB";
            this.puhTB.Size = new System.Drawing.Size(195, 31);
            this.puhTB.TabIndex = 10;
            // 
            // emailTB
            // 
            this.emailTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTB.Location = new System.Drawing.Point(554, 72);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(195, 31);
            this.emailTB.TabIndex = 11;
            // 
            // oNroTB
            // 
            this.oNroTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oNroTB.Location = new System.Drawing.Point(554, 119);
            this.oNroTB.Name = "oNroTB";
            this.oNroTB.Size = new System.Drawing.Size(195, 31);
            this.oNroTB.TabIndex = 12;
            // 
            // tyhjennaBT
            // 
            this.tyhjennaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tyhjennaBT.Location = new System.Drawing.Point(12, 166);
            this.tyhjennaBT.Name = "tyhjennaBT";
            this.tyhjennaBT.Size = new System.Drawing.Size(145, 33);
            this.tyhjennaBT.TabIndex = 13;
            this.tyhjennaBT.Text = "TYHJENNÄ";
            this.tyhjennaBT.UseVisualStyleBackColor = true;
            this.tyhjennaBT.Click += new System.EventHandler(this.tyhjennaBT_Click);
            // 
            // tallennaBT
            // 
            this.tallennaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tallennaBT.Location = new System.Drawing.Point(201, 166);
            this.tallennaBT.Name = "tallennaBT";
            this.tallennaBT.Size = new System.Drawing.Size(145, 33);
            this.tallennaBT.TabIndex = 14;
            this.tallennaBT.Text = "TALLENNA";
            this.tallennaBT.UseVisualStyleBackColor = true;
            this.tallennaBT.Click += new System.EventHandler(this.tallennaBT_Click);
            // 
            // paivitaBT
            // 
            this.paivitaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paivitaBT.Location = new System.Drawing.Point(391, 166);
            this.paivitaBT.Name = "paivitaBT";
            this.paivitaBT.Size = new System.Drawing.Size(145, 33);
            this.paivitaBT.TabIndex = 15;
            this.paivitaBT.Text = "PÄIVITÄ";
            this.paivitaBT.UseVisualStyleBackColor = true;
            this.paivitaBT.Click += new System.EventHandler(this.paivitaBT_Click);
            // 
            // poistaBT
            // 
            this.poistaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poistaBT.Location = new System.Drawing.Point(582, 166);
            this.poistaBT.Name = "poistaBT";
            this.poistaBT.Size = new System.Drawing.Size(145, 33);
            this.poistaBT.TabIndex = 16;
            this.poistaBT.Text = "POISTA";
            this.poistaBT.UseVisualStyleBackColor = true;
            this.poistaBT.Click += new System.EventHandler(this.poistaBT_Click);
            // 
            // YllapitoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.poistaBT);
            this.Controls.Add(this.paivitaBT);
            this.Controls.Add(this.tallennaBT);
            this.Controls.Add(this.tyhjennaBT);
            this.Controls.Add(this.oNroTB);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.puhTB);
            this.Controls.Add(this.snimiTB);
            this.Controls.Add(this.enimiTB);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.OPINROLB);
            this.Controls.Add(this.SPOSTILB);
            this.Controls.Add(this.PUHELINLB);
            this.Controls.Add(this.SUKUNIMILB);
            this.Controls.Add(this.ETUNIMILB);
            this.Controls.Add(this.IDLB);
            this.Controls.Add(this.TietotauluDG);
            this.Name = "YllapitoForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.YllapitoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TietotauluDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TietotauluDG;
        private System.Windows.Forms.Label IDLB;
        private System.Windows.Forms.Label ETUNIMILB;
        private System.Windows.Forms.Label SUKUNIMILB;
        private System.Windows.Forms.Label PUHELINLB;
        private System.Windows.Forms.Label SPOSTILB;
        private System.Windows.Forms.Label OPINROLB;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.TextBox enimiTB;
        private System.Windows.Forms.TextBox snimiTB;
        private System.Windows.Forms.TextBox puhTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.TextBox oNroTB;
        private System.Windows.Forms.Button tyhjennaBT;
        private System.Windows.Forms.Button tallennaBT;
        private System.Windows.Forms.Button paivitaBT;
        private System.Windows.Forms.Button poistaBT;
    }
}

