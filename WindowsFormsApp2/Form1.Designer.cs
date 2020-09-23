namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.zoneTexteCible = new System.Windows.Forms.TextBox();
            this.gBoxCasse = new System.Windows.Forms.GroupBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.gBoxCara = new System.Windows.Forms.GroupBox();
            this.CaraNoir = new System.Windows.Forms.RadioButton();
            this.CaraBlanc = new System.Windows.Forms.RadioButton();
            this.CaraRouge = new System.Windows.Forms.RadioButton();
            this.gBoxFond = new System.Windows.Forms.GroupBox();
            this.FontBleu = new System.Windows.Forms.RadioButton();
            this.FondVert = new System.Windows.Forms.RadioButton();
            this.FondRouge = new System.Windows.Forms.RadioButton();
            this.boxChoix = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnlabel1 = new System.Windows.Forms.Label();
            this.ZoneTexte = new System.Windows.Forms.TextBox();
            this.gBoxCasse.SuspendLayout();
            this.gBoxCara.SuspendLayout();
            this.gBoxFond.SuspendLayout();
            this.boxChoix.SuspendLayout();
            this.SuspendLayout();
            // 
            // zoneTexteCible
            // 
            this.zoneTexteCible.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.zoneTexteCible.Enabled = false;
            this.zoneTexteCible.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoneTexteCible.Location = new System.Drawing.Point(43, 119);
            this.zoneTexteCible.Name = "zoneTexteCible";
            this.zoneTexteCible.Size = new System.Drawing.Size(470, 25);
            this.zoneTexteCible.TabIndex = 14;
            // 
            // gBoxCasse
            // 
            this.gBoxCasse.Controls.Add(this.radioButton7);
            this.gBoxCasse.Controls.Add(this.radioButton9);
            this.gBoxCasse.Enabled = false;
            this.gBoxCasse.ForeColor = System.Drawing.Color.Blue;
            this.gBoxCasse.Location = new System.Drawing.Point(283, 218);
            this.gBoxCasse.Name = "gBoxCasse";
            this.gBoxCasse.Size = new System.Drawing.Size(122, 90);
            this.gBoxCasse.TabIndex = 13;
            this.gBoxCasse.TabStop = false;
            this.gBoxCasse.Text = "Casse";
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.ForeColor = System.Drawing.Color.Black;
            this.radioButton7.Location = new System.Drawing.Point(6, 65);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(78, 17);
            this.radioButton7.TabIndex = 7;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Majuscules";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.ForeColor = System.Drawing.Color.Black;
            this.radioButton9.Location = new System.Drawing.Point(6, 29);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(78, 17);
            this.radioButton9.TabIndex = 5;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "Minuscules";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            // 
            // gBoxCara
            // 
            this.gBoxCara.Controls.Add(this.CaraNoir);
            this.gBoxCara.Controls.Add(this.CaraBlanc);
            this.gBoxCara.Controls.Add(this.CaraRouge);
            this.gBoxCara.Enabled = false;
            this.gBoxCara.ForeColor = System.Drawing.Color.Blue;
            this.gBoxCara.Location = new System.Drawing.Point(164, 173);
            this.gBoxCara.Name = "gBoxCara";
            this.gBoxCara.Size = new System.Drawing.Size(88, 135);
            this.gBoxCara.TabIndex = 12;
            this.gBoxCara.TabStop = false;
            this.gBoxCara.Text = "Caractères";
            // 
            // CaraNoir
            // 
            this.CaraNoir.AutoSize = true;
            this.CaraNoir.ForeColor = System.Drawing.Color.Black;
            this.CaraNoir.Location = new System.Drawing.Point(11, 101);
            this.CaraNoir.Name = "CaraNoir";
            this.CaraNoir.Size = new System.Drawing.Size(44, 17);
            this.CaraNoir.TabIndex = 7;
            this.CaraNoir.TabStop = true;
            this.CaraNoir.Text = "Noir";
            this.CaraNoir.UseVisualStyleBackColor = true;
            this.CaraNoir.Click += new System.EventHandler(this.CaraNoir_CheckedChanged);
            // 
            // CaraBlanc
            // 
            this.CaraBlanc.AutoSize = true;
            this.CaraBlanc.ForeColor = System.Drawing.Color.Black;
            this.CaraBlanc.Location = new System.Drawing.Point(11, 65);
            this.CaraBlanc.Name = "CaraBlanc";
            this.CaraBlanc.Size = new System.Drawing.Size(52, 17);
            this.CaraBlanc.TabIndex = 6;
            this.CaraBlanc.TabStop = true;
            this.CaraBlanc.Text = "Blanc";
            this.CaraBlanc.UseVisualStyleBackColor = true;
            this.CaraBlanc.CheckedChanged += new System.EventHandler(this.CaraBlanc_CheckedChanged);
            // 
            // CaraRouge
            // 
            this.CaraRouge.AutoSize = true;
            this.CaraRouge.ForeColor = System.Drawing.Color.Black;
            this.CaraRouge.Location = new System.Drawing.Point(11, 31);
            this.CaraRouge.Name = "CaraRouge";
            this.CaraRouge.Size = new System.Drawing.Size(57, 17);
            this.CaraRouge.TabIndex = 5;
            this.CaraRouge.TabStop = true;
            this.CaraRouge.Text = "Rouge";
            this.CaraRouge.UseVisualStyleBackColor = true;
            this.CaraRouge.CheckedChanged += new System.EventHandler(this.CaraRouge_CheckedChanged);
            // 
            // gBoxFond
            // 
            this.gBoxFond.Controls.Add(this.FontBleu);
            this.gBoxFond.Controls.Add(this.FondVert);
            this.gBoxFond.Controls.Add(this.FondRouge);
            this.gBoxFond.Enabled = false;
            this.gBoxFond.ForeColor = System.Drawing.Color.Blue;
            this.gBoxFond.Location = new System.Drawing.Point(43, 172);
            this.gBoxFond.Name = "gBoxFond";
            this.gBoxFond.Size = new System.Drawing.Size(87, 136);
            this.gBoxFond.TabIndex = 11;
            this.gBoxFond.TabStop = false;
            this.gBoxFond.Text = "Fond";
            // 
            // FontBleu
            // 
            this.FontBleu.AutoSize = true;
            this.FontBleu.ForeColor = System.Drawing.Color.Black;
            this.FontBleu.Location = new System.Drawing.Point(6, 101);
            this.FontBleu.Name = "FontBleu";
            this.FontBleu.Size = new System.Drawing.Size(46, 17);
            this.FontBleu.TabIndex = 7;
            this.FontBleu.TabStop = true;
            this.FontBleu.Text = "Bleu";
            this.FontBleu.UseVisualStyleBackColor = true;
            this.FontBleu.CheckedChanged += new System.EventHandler(this.FontBleu_CheckedChanged);
            // 
            // FondVert
            // 
            this.FondVert.AutoSize = true;
            this.FondVert.ForeColor = System.Drawing.Color.Black;
            this.FondVert.Location = new System.Drawing.Point(6, 65);
            this.FondVert.Name = "FondVert";
            this.FondVert.Size = new System.Drawing.Size(44, 17);
            this.FondVert.TabIndex = 6;
            this.FondVert.TabStop = true;
            this.FondVert.Text = "Vert";
            this.FondVert.UseVisualStyleBackColor = true;
            this.FondVert.CheckedChanged += new System.EventHandler(this.FondVert_CheckedChanged);
            // 
            // FondRouge
            // 
            this.FondRouge.AutoSize = true;
            this.FondRouge.ForeColor = System.Drawing.Color.Black;
            this.FondRouge.Location = new System.Drawing.Point(6, 31);
            this.FondRouge.Name = "FondRouge";
            this.FondRouge.Size = new System.Drawing.Size(57, 17);
            this.FondRouge.TabIndex = 5;
            this.FondRouge.TabStop = true;
            this.FondRouge.Text = "Rouge";
            this.FondRouge.UseVisualStyleBackColor = true;
            this.FondRouge.CheckedChanged += new System.EventHandler(this.FondRouge_CheckedChanged);
            // 
            // boxChoix
            // 
            this.boxChoix.Controls.Add(this.checkBox3);
            this.boxChoix.Controls.Add(this.checkBox2);
            this.boxChoix.Controls.Add(this.checkBox1);
            this.boxChoix.Enabled = false;
            this.boxChoix.Location = new System.Drawing.Point(548, 21);
            this.boxChoix.Name = "boxChoix";
            this.boxChoix.Size = new System.Drawing.Size(160, 123);
            this.boxChoix.TabIndex = 10;
            this.boxChoix.TabStop = false;
            this.boxChoix.Text = "Choix";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 94);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(55, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Casse";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 61);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(135, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Couleur des caractères";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 29);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Couleur du fond ";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnlabel1
            // 
            this.btnlabel1.AutoSize = true;
            this.btnlabel1.Location = new System.Drawing.Point(40, 32);
            this.btnlabel1.Name = "btnlabel1";
            this.btnlabel1.Size = new System.Drawing.Size(90, 13);
            this.btnlabel1.TabIndex = 9;
            this.btnlabel1.Text = "Tapez votre texte";
            this.btnlabel1.Click += new System.EventHandler(this.btnlabel1_Click);
            // 
            // ZoneTexte
            // 
            this.ZoneTexte.Location = new System.Drawing.Point(43, 69);
            this.ZoneTexte.Name = "ZoneTexte";
            this.ZoneTexte.Size = new System.Drawing.Size(470, 20);
            this.ZoneTexte.TabIndex = 8;
            this.ZoneTexte.TextChanged += new System.EventHandler(this.ZoneTexte_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 390);
            this.Controls.Add(this.zoneTexteCible);
            this.Controls.Add(this.gBoxCasse);
            this.Controls.Add(this.gBoxCara);
            this.Controls.Add(this.gBoxFond);
            this.Controls.Add(this.boxChoix);
            this.Controls.Add(this.btnlabel1);
            this.Controls.Add(this.ZoneTexte);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gBoxCasse.ResumeLayout(false);
            this.gBoxCasse.PerformLayout();
            this.gBoxCara.ResumeLayout(false);
            this.gBoxCara.PerformLayout();
            this.gBoxFond.ResumeLayout(false);
            this.gBoxFond.PerformLayout();
            this.boxChoix.ResumeLayout(false);
            this.boxChoix.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox zoneTexteCible;
        private System.Windows.Forms.GroupBox gBoxCasse;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.GroupBox gBoxCara;
        private System.Windows.Forms.RadioButton CaraNoir;
        private System.Windows.Forms.RadioButton CaraBlanc;
        private System.Windows.Forms.RadioButton CaraRouge;
        private System.Windows.Forms.GroupBox gBoxFond;
        private System.Windows.Forms.RadioButton FontBleu;
        private System.Windows.Forms.RadioButton FondVert;
        private System.Windows.Forms.RadioButton FondRouge;
        private System.Windows.Forms.GroupBox boxChoix;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label btnlabel1;
        private System.Windows.Forms.TextBox ZoneTexte;
    }
}

