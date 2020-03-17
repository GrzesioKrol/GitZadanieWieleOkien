namespace WieleOkien
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
            this.Dodawanie = new System.Windows.Forms.Button();
            this.Odejmowanie = new System.Windows.Forms.Button();
            this.Mnozenie = new System.Windows.Forms.Button();
            this.Dzielenie = new System.Windows.Forms.Button();
            this.Label_wynik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Dodawanie
            // 
            this.Dodawanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Dodawanie.Location = new System.Drawing.Point(101, 28);
            this.Dodawanie.Name = "Dodawanie";
            this.Dodawanie.Size = new System.Drawing.Size(75, 46);
            this.Dodawanie.TabIndex = 0;
            this.Dodawanie.Text = "+";
            this.Dodawanie.UseVisualStyleBackColor = true;
            this.Dodawanie.Click += new System.EventHandler(this.Dodawanie_Click);
            // 
            // Odejmowanie
            // 
            this.Odejmowanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Odejmowanie.Location = new System.Drawing.Point(248, 28);
            this.Odejmowanie.Name = "Odejmowanie";
            this.Odejmowanie.Size = new System.Drawing.Size(75, 46);
            this.Odejmowanie.TabIndex = 1;
            this.Odejmowanie.Text = "-";
            this.Odejmowanie.UseVisualStyleBackColor = true;
            this.Odejmowanie.Click += new System.EventHandler(this.Odejmowanie_Click);
            // 
            // Mnozenie
            // 
            this.Mnozenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Mnozenie.Location = new System.Drawing.Point(402, 28);
            this.Mnozenie.Name = "Mnozenie";
            this.Mnozenie.Size = new System.Drawing.Size(75, 46);
            this.Mnozenie.TabIndex = 2;
            this.Mnozenie.Text = "*";
            this.Mnozenie.UseVisualStyleBackColor = true;
            this.Mnozenie.Click += new System.EventHandler(this.Mnozenie_Click);
            // 
            // Dzielenie
            // 
            this.Dzielenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Dzielenie.Location = new System.Drawing.Point(583, 28);
            this.Dzielenie.Name = "Dzielenie";
            this.Dzielenie.Size = new System.Drawing.Size(75, 46);
            this.Dzielenie.TabIndex = 3;
            this.Dzielenie.Text = "/";
            this.Dzielenie.UseVisualStyleBackColor = true;
            this.Dzielenie.Click += new System.EventHandler(this.Dzielenie_Click);
            // 
            // Label_wynik
            // 
            this.Label_wynik.AutoSize = true;
            this.Label_wynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label_wynik.Location = new System.Drawing.Point(235, 241);
            this.Label_wynik.Name = "Label_wynik";
            this.Label_wynik.Size = new System.Drawing.Size(0, 73);
            this.Label_wynik.TabIndex = 4;
            this.Label_wynik.Click += new System.EventHandler(this.Label_wynik_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Label_wynik);
            this.Controls.Add(this.Dzielenie);
            this.Controls.Add(this.Mnozenie);
            this.Controls.Add(this.Odejmowanie);
            this.Controls.Add(this.Dodawanie);
            this.Name = "Form1";
            this.Text = "Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Dodawanie;
        private System.Windows.Forms.Button Odejmowanie;
        private System.Windows.Forms.Button Mnozenie;
        private System.Windows.Forms.Button Dzielenie;
        private System.Windows.Forms.Label Label_wynik;
    }
}

