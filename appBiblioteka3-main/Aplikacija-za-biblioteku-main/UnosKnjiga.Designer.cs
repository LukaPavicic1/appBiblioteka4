namespace aplikacijaZaBiblioteku
{
    partial class UnosKnjiga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnosKnjiga));
            this.labelNaslov = new System.Windows.Forms.Label();
            this.labelAut = new System.Windows.Forms.Label();
            this.labelGod = new System.Windows.Forms.Label();
            this.labelCijena = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.buttonUnesi = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNaslov
            // 
            this.labelNaslov.AutoSize = true;
            this.labelNaslov.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelNaslov.Location = new System.Drawing.Point(13, 13);
            this.labelNaslov.Name = "labelNaslov";
            this.labelNaslov.Size = new System.Drawing.Size(43, 13);
            this.labelNaslov.TabIndex = 0;
            this.labelNaslov.Text = "Naslov:";
            // 
            // labelAut
            // 
            this.labelAut.AutoSize = true;
            this.labelAut.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelAut.Location = new System.Drawing.Point(10, 61);
            this.labelAut.Name = "labelAut";
            this.labelAut.Size = new System.Drawing.Size(61, 13);
            this.labelAut.TabIndex = 1;
            this.labelAut.Text = "Ime Autora:";
            // 
            // labelGod
            // 
            this.labelGod.AutoSize = true;
            this.labelGod.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelGod.Location = new System.Drawing.Point(13, 113);
            this.labelGod.Name = "labelGod";
            this.labelGod.Size = new System.Drawing.Size(80, 13);
            this.labelGod.TabIndex = 2;
            this.labelGod.Text = "Godina izdanja:";
            // 
            // labelCijena
            // 
            this.labelCijena.AutoSize = true;
            this.labelCijena.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelCijena.Location = new System.Drawing.Point(13, 220);
            this.labelCijena.Name = "labelCijena";
            this.labelCijena.Size = new System.Drawing.Size(39, 13);
            this.labelCijena.TabIndex = 3;
            this.labelCijena.Text = "Cijena:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Honeydew;
            this.textBox1.Location = new System.Drawing.Point(13, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Honeydew;
            this.textBox2.Location = new System.Drawing.Point(13, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(246, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Honeydew;
            this.textBox3.Location = new System.Drawing.Point(12, 129);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(246, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Honeydew;
            this.textBox4.Location = new System.Drawing.Point(12, 238);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(247, 20);
            this.textBox4.TabIndex = 10;
            // 
            // buttonUnesi
            // 
            this.buttonUnesi.BackColor = System.Drawing.Color.MediumAquamarine;
            this.buttonUnesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUnesi.Location = new System.Drawing.Point(64, 292);
            this.buttonUnesi.Name = "buttonUnesi";
            this.buttonUnesi.Size = new System.Drawing.Size(129, 44);
            this.buttonUnesi.TabIndex = 14;
            this.buttonUnesi.Text = "Unesi";
            this.buttonUnesi.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Honeydew;
            this.textBox5.Location = new System.Drawing.Point(13, 183);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(247, 20);
            this.textBox5.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(13, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ime izdavačke kuće:";
            // 
            // UnosKnjiga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(271, 362);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.buttonUnesi);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelCijena);
            this.Controls.Add(this.labelGod);
            this.Controls.Add(this.labelAut);
            this.Controls.Add(this.labelNaslov);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UnosKnjiga";
            this.Text = "Knjižnica Laganini";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNaslov;
        private System.Windows.Forms.Label labelAut;
        private System.Windows.Forms.Label labelGod;
        private System.Windows.Forms.Label labelCijena;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button buttonUnesi;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
    }
}