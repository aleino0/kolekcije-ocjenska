
namespace Kolekcije_ocjenska
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
            this.ime = new System.Windows.Forms.TextBox();
            this.prezime = new System.Windows.Forms.TextBox();
            this.grad = new System.Windows.Forms.TextBox();
            this.unos = new System.Windows.Forms.Button();
            this.obrada = new System.Windows.Forms.Button();
            this.ispis = new System.Windows.Forms.Button();
            this.spol = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.richIspis = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ime
            // 
            this.ime.Location = new System.Drawing.Point(72, 30);
            this.ime.Name = "ime";
            this.ime.Size = new System.Drawing.Size(121, 20);
            this.ime.TabIndex = 0;
            // 
            // prezime
            // 
            this.prezime.Location = new System.Drawing.Point(72, 72);
            this.prezime.Name = "prezime";
            this.prezime.Size = new System.Drawing.Size(121, 20);
            this.prezime.TabIndex = 1;
            // 
            // grad
            // 
            this.grad.Location = new System.Drawing.Point(72, 177);
            this.grad.Name = "grad";
            this.grad.Size = new System.Drawing.Size(121, 20);
            this.grad.TabIndex = 2;
            // 
            // unos
            // 
            this.unos.Location = new System.Drawing.Point(353, 42);
            this.unos.Name = "unos";
            this.unos.Size = new System.Drawing.Size(75, 23);
            this.unos.TabIndex = 4;
            this.unos.Text = "Unos";
            this.unos.UseVisualStyleBackColor = true;
            this.unos.Click += new System.EventHandler(this.unos_Click);
            // 
            // obrada
            // 
            this.obrada.Location = new System.Drawing.Point(353, 105);
            this.obrada.Name = "obrada";
            this.obrada.Size = new System.Drawing.Size(75, 23);
            this.obrada.TabIndex = 5;
            this.obrada.Text = "Obrada";
            this.obrada.UseVisualStyleBackColor = true;
            this.obrada.Click += new System.EventHandler(this.obrada_Click);
            // 
            // ispis
            // 
            this.ispis.Location = new System.Drawing.Point(353, 156);
            this.ispis.Name = "ispis";
            this.ispis.Size = new System.Drawing.Size(75, 23);
            this.ispis.TabIndex = 6;
            this.ispis.Text = "Ispis";
            this.ispis.UseVisualStyleBackColor = true;
            this.ispis.Click += new System.EventHandler(this.ispis_Click);
            // 
            // spol
            // 
            this.spol.FormattingEnabled = true;
            this.spol.Items.AddRange(new object[] {
            "Muško",
            "Žensko"});
            this.spol.Location = new System.Drawing.Point(72, 125);
            this.spol.Name = "spol";
            this.spol.Size = new System.Drawing.Size(121, 21);
            this.spol.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(20, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(46, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Ime:";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(20, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(46, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "Prezime:";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(20, 126);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(46, 20);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = "Spol:";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(20, 177);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(46, 20);
            this.textBox4.TabIndex = 11;
            this.textBox4.Text = "Grad:";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // richIspis
            // 
            this.richIspis.Location = new System.Drawing.Point(62, 261);
            this.richIspis.Name = "richIspis";
            this.richIspis.Size = new System.Drawing.Size(366, 164);
            this.richIspis.TabIndex = 12;
            this.richIspis.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 450);
            this.Controls.Add(this.richIspis);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.spol);
            this.Controls.Add(this.ispis);
            this.Controls.Add(this.obrada);
            this.Controls.Add(this.unos);
            this.Controls.Add(this.grad);
            this.Controls.Add(this.prezime);
            this.Controls.Add(this.ime);
            this.Name = "Form1";
            this.Text = "kolekcije ocjenska";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ime;
        private System.Windows.Forms.TextBox prezime;
        private System.Windows.Forms.TextBox grad;
        private System.Windows.Forms.Button unos;
        private System.Windows.Forms.Button obrada;
        private System.Windows.Forms.Button ispis;
        private System.Windows.Forms.ComboBox spol;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.RichTextBox richIspis;
    }
}

