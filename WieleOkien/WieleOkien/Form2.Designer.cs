namespace WieleOkien
{
    partial class Owo
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
            this.Label_tytul = new System.Windows.Forms.Label();
            this.Wynik = new System.Windows.Forms.Button();
            this.L1 = new System.Windows.Forms.RichTextBox();
            this.L2 = new System.Windows.Forms.RichTextBox();
            this.Label_znak = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label_tytul
            // 
            this.Label_tytul.AutoSize = true;
            this.Label_tytul.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label_tytul.Location = new System.Drawing.Point(275, 9);
            this.Label_tytul.Name = "Label_tytul";
            this.Label_tytul.Size = new System.Drawing.Size(0, 42);
            this.Label_tytul.TabIndex = 0;
            // 
            // Wynik
            // 
            this.Wynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wynik.Location = new System.Drawing.Point(262, 223);
            this.Wynik.Name = "Wynik";
            this.Wynik.Size = new System.Drawing.Size(219, 115);
            this.Wynik.TabIndex = 3;
            this.Wynik.Text = "=";
            this.Wynik.UseVisualStyleBackColor = true;
            this.Wynik.UseWaitCursor = true;
            this.Wynik.Click += new System.EventHandler(this.Wynik_Click);
            // 
            // L1
            // 
            this.L1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.L1.Location = new System.Drawing.Point(150, 134);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(174, 54);
            this.L1.TabIndex = 4;
            this.L1.Text = "";
            this.L1.UseWaitCursor = true;
            // 
            // L2
            // 
            this.L2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.L2.Location = new System.Drawing.Point(417, 134);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(206, 54);
            this.L2.TabIndex = 5;
            this.L2.Text = "";
            this.L2.UseWaitCursor = true;
            // 
            // Label_znak
            // 
            this.Label_znak.AutoSize = true;
            this.Label_znak.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label_znak.Location = new System.Drawing.Point(351, 137);
            this.Label_znak.Name = "Label_znak";
            this.Label_znak.Size = new System.Drawing.Size(0, 42);
            this.Label_znak.TabIndex = 6;
            this.Label_znak.UseWaitCursor = true;
            // 
            // Owo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 425);
            this.Controls.Add(this.Label_znak);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.Wynik);
            this.Controls.Add(this.Label_tytul);
            this.Name = "Owo";
            this.Text = "Unvebivable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_tytul;
        private System.Windows.Forms.Button Wynik;
        private System.Windows.Forms.RichTextBox L1;
        private System.Windows.Forms.RichTextBox L2;
        private System.Windows.Forms.Label Label_znak;
    }
}