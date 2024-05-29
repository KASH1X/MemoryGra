namespace MemoryGra
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.czas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.punkty = new System.Windows.Forms.Label();
            this.startGry = new System.Windows.Forms.Label();
            this.panelKart = new System.Windows.Forms.Panel();
            this.timerCzasGry = new System.Windows.Forms.Timer(this.components);
            this.timerCzasPodgladu = new System.Windows.Forms.Timer(this.components);
            this.timerZakrywacz = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Czas:";
            // 
            // czas
            // 
            this.czas.AutoSize = true;
            this.czas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.czas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.czas.Location = new System.Drawing.Point(75, 13);
            this.czas.Name = "czas";
            this.czas.Size = new System.Drawing.Size(24, 25);
            this.czas.TabIndex = 1;
            this.czas.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(132, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Punkty:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // punkty
            // 
            this.punkty.AutoSize = true;
            this.punkty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.punkty.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.punkty.Location = new System.Drawing.Point(223, 13);
            this.punkty.Name = "punkty";
            this.punkty.Size = new System.Drawing.Size(24, 25);
            this.punkty.TabIndex = 3;
            this.punkty.Text = "0";
            // 
            // startGry
            // 
            this.startGry.AutoSize = true;
            this.startGry.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startGry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startGry.Location = new System.Drawing.Point(294, 13);
            this.startGry.Name = "startGry";
            this.startGry.Size = new System.Drawing.Size(184, 25);
            this.startGry.TabIndex = 4;
            this.startGry.Text = "Poczatek gry za 0";
            // 
            // panelKart
            // 
            this.panelKart.Location = new System.Drawing.Point(12, 54);
            this.panelKart.Name = "panelKart";
            this.panelKart.Size = new System.Drawing.Size(776, 384);
            this.panelKart.TabIndex = 5;
            this.panelKart.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // timerCzasGry
            // 
            this.timerCzasGry.Interval = 1000;
            this.timerCzasGry.Tick += new System.EventHandler(this.timerCzasGry_Tick);
            // 
            // timerCzasPodgladu
            // 
            this.timerCzasPodgladu.Interval = 1000;
            this.timerCzasPodgladu.Tick += new System.EventHandler(this.timerCzasPodgladu_Tick);
            // 
            // timerZakrywacz
            // 
            this.timerZakrywacz.Interval = 1000;
            this.timerZakrywacz.Tick += new System.EventHandler(this.timerZakrywacz_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelKart);
            this.Controls.Add(this.startGry);
            this.Controls.Add(this.punkty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.czas);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label czas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label punkty;
        private System.Windows.Forms.Label startGry;
        private System.Windows.Forms.Panel panelKart;
        private System.Windows.Forms.Timer timerCzasGry;
        private System.Windows.Forms.Timer timerCzasPodgladu;
        private System.Windows.Forms.Timer timerZakrywacz;
    }
}

