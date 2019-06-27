namespace GraGUI
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonNowaGra = new System.Windows.Forms.Button();
            this.groupBoxLosuj = new System.Windows.Forms.GroupBox();
            this.buttonLosuj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxZakresDo = new System.Windows.Forms.TextBox();
            this.textBoxZakresOd = new System.Windows.Forms.TextBox();
            this.groupBoxWylosowano = new System.Windows.Forms.GroupBox();
            this.buttonSprawdz = new System.Windows.Forms.Button();
            this.textBoxLiczba = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxLosuj.SuspendLayout();
            this.groupBoxWylosowano.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNowaGra
            // 
            this.buttonNowaGra.Location = new System.Drawing.Point(18, 18);
            this.buttonNowaGra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonNowaGra.Name = "buttonNowaGra";
            this.buttonNowaGra.Size = new System.Drawing.Size(136, 62);
            this.buttonNowaGra.TabIndex = 0;
            this.buttonNowaGra.Text = "Nowa Gra";
            this.buttonNowaGra.UseVisualStyleBackColor = true;
            this.buttonNowaGra.Click += new System.EventHandler(this.buttonNowaGra_Click);
            // 
            // groupBoxLosuj
            // 
            this.groupBoxLosuj.Controls.Add(this.buttonLosuj);
            this.groupBoxLosuj.Controls.Add(this.label2);
            this.groupBoxLosuj.Controls.Add(this.label1);
            this.groupBoxLosuj.Controls.Add(this.textBoxZakresDo);
            this.groupBoxLosuj.Controls.Add(this.textBoxZakresOd);
            this.groupBoxLosuj.Location = new System.Drawing.Point(20, 111);
            this.groupBoxLosuj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxLosuj.Name = "groupBoxLosuj";
            this.groupBoxLosuj.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxLosuj.Size = new System.Drawing.Size(634, 142);
            this.groupBoxLosuj.TabIndex = 1;
            this.groupBoxLosuj.TabStop = false;
            this.groupBoxLosuj.Text = "Losowanie";
            this.groupBoxLosuj.Visible = false;
            // 
            // buttonLosuj
            // 
            this.buttonLosuj.Location = new System.Drawing.Point(300, 74);
            this.buttonLosuj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLosuj.Name = "buttonLosuj";
            this.buttonLosuj.Size = new System.Drawing.Size(116, 46);
            this.buttonLosuj.TabIndex = 2;
            this.buttonLosuj.Text = "Wylosuj";
            this.buttonLosuj.UseVisualStyleBackColor = true;
            this.buttonLosuj.Click += new System.EventHandler(this.buttonLosuj_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zakres do:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zakres od:";
            // 
            // textBoxZakresDo
            // 
            this.textBoxZakresDo.Location = new System.Drawing.Point(105, 83);
            this.textBoxZakresDo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxZakresDo.Name = "textBoxZakresDo";
            this.textBoxZakresDo.Size = new System.Drawing.Size(148, 26);
            this.textBoxZakresDo.TabIndex = 1;
            // 
            // textBoxZakresOd
            // 
            this.textBoxZakresOd.Location = new System.Drawing.Point(105, 29);
            this.textBoxZakresOd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxZakresOd.Name = "textBoxZakresOd";
            this.textBoxZakresOd.Size = new System.Drawing.Size(148, 26);
            this.textBoxZakresOd.TabIndex = 0;
            // 
            // groupBoxWylosowano
            // 
            this.groupBoxWylosowano.Controls.Add(this.button1);
            this.groupBoxWylosowano.Controls.Add(this.buttonSprawdz);
            this.groupBoxWylosowano.Controls.Add(this.textBoxLiczba);
            this.groupBoxWylosowano.Location = new System.Drawing.Point(18, 277);
            this.groupBoxWylosowano.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxWylosowano.Name = "groupBoxWylosowano";
            this.groupBoxWylosowano.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxWylosowano.Size = new System.Drawing.Size(634, 252);
            this.groupBoxWylosowano.TabIndex = 2;
            this.groupBoxWylosowano.TabStop = false;
            this.groupBoxWylosowano.Text = "Wylosowano liczbę. Odgadnij ją!";
            this.groupBoxWylosowano.Visible = false;
            // 
            // buttonSprawdz
            // 
            this.buttonSprawdz.Location = new System.Drawing.Point(232, 37);
            this.buttonSprawdz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSprawdz.Name = "buttonSprawdz";
            this.buttonSprawdz.Size = new System.Drawing.Size(120, 43);
            this.buttonSprawdz.TabIndex = 4;
            this.buttonSprawdz.Text = "Sprawdź";
            this.buttonSprawdz.UseVisualStyleBackColor = true;
            this.buttonSprawdz.Click += new System.EventHandler(this.buttonSprawdz_Click);
            // 
            // textBoxLiczba
            // 
            this.textBoxLiczba.Location = new System.Drawing.Point(38, 45);
            this.textBoxLiczba.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLiczba.Name = "textBoxLiczba";
            this.textBoxLiczba.Size = new System.Drawing.Size(148, 26);
            this.textBoxLiczba.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Poddaj się";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 805);
            this.Controls.Add(this.groupBoxWylosowano);
            this.Controls.Add(this.groupBoxLosuj);
            this.Controls.Add(this.buttonNowaGra);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBoxLosuj.ResumeLayout(false);
            this.groupBoxLosuj.PerformLayout();
            this.groupBoxWylosowano.ResumeLayout(false);
            this.groupBoxWylosowano.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNowaGra;
        private System.Windows.Forms.GroupBox groupBoxLosuj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxZakresDo;
        private System.Windows.Forms.TextBox textBoxZakresOd;
        private System.Windows.Forms.Button buttonLosuj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxWylosowano;
        private System.Windows.Forms.TextBox textBoxLiczba;
        private System.Windows.Forms.Button buttonSprawdz;
        private System.Windows.Forms.Button button1;
    }
}

