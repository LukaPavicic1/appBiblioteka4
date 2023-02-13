namespace aplikacijaZaBiblioteku
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonKorisnik = new System.Windows.Forms.Button();
            this.buttonKnjiga = new System.Windows.Forms.Button();
            this.buttonPregledPodataka = new System.Windows.Forms.Button();
            this.btnPosudiVrati = new System.Windows.Forms.Button();
            this.labelNaslov = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonKorisnik
            // 
            this.buttonKorisnik.BackColor = System.Drawing.Color.MediumAquamarine;
            this.buttonKorisnik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKorisnik.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.buttonKorisnik.Location = new System.Drawing.Point(34, 178);
            this.buttonKorisnik.Name = "buttonKorisnik";
            this.buttonKorisnik.Size = new System.Drawing.Size(266, 62);
            this.buttonKorisnik.TabIndex = 0;
            this.buttonKorisnik.Text = "Unesi korisnika";
            this.buttonKorisnik.UseVisualStyleBackColor = false;
            this.buttonKorisnik.Click += new System.EventHandler(this.buttonKorisnik_Click);
            // 
            // buttonKnjiga
            // 
            this.buttonKnjiga.BackColor = System.Drawing.Color.MediumAquamarine;
            this.buttonKnjiga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKnjiga.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.buttonKnjiga.Location = new System.Drawing.Point(34, 285);
            this.buttonKnjiga.Name = "buttonKnjiga";
            this.buttonKnjiga.Size = new System.Drawing.Size(266, 62);
            this.buttonKnjiga.TabIndex = 1;
            this.buttonKnjiga.Text = "Unesi knjigu";
            this.buttonKnjiga.UseVisualStyleBackColor = false;
            this.buttonKnjiga.Click += new System.EventHandler(this.buttonKnjiga_Click);
            // 
            // buttonPregledPodataka
            // 
            this.buttonPregledPodataka.BackColor = System.Drawing.Color.MediumAquamarine;
            this.buttonPregledPodataka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPregledPodataka.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.buttonPregledPodataka.Location = new System.Drawing.Point(399, 178);
            this.buttonPregledPodataka.Name = "buttonPregledPodataka";
            this.buttonPregledPodataka.Size = new System.Drawing.Size(266, 62);
            this.buttonPregledPodataka.TabIndex = 2;
            this.buttonPregledPodataka.Text = "Pregled podataka";
            this.buttonPregledPodataka.UseVisualStyleBackColor = false;
            this.buttonPregledPodataka.Click += new System.EventHandler(this.buttonPregledPodataka_Click);
            // 
            // btnPosudiVrati
            // 
            this.btnPosudiVrati.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnPosudiVrati.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPosudiVrati.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnPosudiVrati.Location = new System.Drawing.Point(399, 285);
            this.btnPosudiVrati.Name = "btnPosudiVrati";
            this.btnPosudiVrati.Size = new System.Drawing.Size(266, 62);
            this.btnPosudiVrati.TabIndex = 3;
            this.btnPosudiVrati.Text = "Posuđivanje/Vraćanje knjiga";
            this.btnPosudiVrati.UseVisualStyleBackColor = false;
            this.btnPosudiVrati.Click += new System.EventHandler(this.btnPosudiVrati_Click);
            // 
            // labelNaslov
            // 
            this.labelNaslov.AutoSize = true;
            this.labelNaslov.BackColor = System.Drawing.Color.Transparent;
            this.labelNaslov.Font = new System.Drawing.Font("Sitka Heading", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNaslov.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelNaslov.Location = new System.Drawing.Point(19, 40);
            this.labelNaslov.Name = "labelNaslov";
            this.labelNaslov.Size = new System.Drawing.Size(586, 87);
            this.labelNaslov.TabIndex = 4;
            this.labelNaslov.Text = "Knjižnica \"Laganini\"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(714, 395);
            this.Controls.Add(this.labelNaslov);
            this.Controls.Add(this.btnPosudiVrati);
            this.Controls.Add(this.buttonPregledPodataka);
            this.Controls.Add(this.buttonKnjiga);
            this.Controls.Add(this.buttonKorisnik);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Knjižnica Laganini";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKorisnik;
        private System.Windows.Forms.Button buttonKnjiga;
        private System.Windows.Forms.Button buttonPregledPodataka;
        private System.Windows.Forms.Button btnPosudiVrati;
        private System.Windows.Forms.Label labelNaslov;
    }
}

