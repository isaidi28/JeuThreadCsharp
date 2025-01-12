namespace TP3InesSaidi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownNbJoueur = new System.Windows.Forms.NumericUpDown();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBoxPointage = new System.Windows.Forms.RichTextBox();
            this.buttonMeilleurPointage = new System.Windows.Forms.Button();
            this.buttonDemarrerPartie = new System.Windows.Forms.Button();
            this.textBoxNom1 = new System.Windows.Forms.TextBox();
            this.labelNom1 = new System.Windows.Forms.Label();
            this.labelNom2 = new System.Windows.Forms.Label();
            this.textBoxNom2 = new System.Windows.Forms.TextBox();
            this.labelNom3 = new System.Windows.Forms.Label();
            this.labelNom4 = new System.Windows.Forms.Label();
            this.textBoxNom3 = new System.Windows.Forms.TextBox();
            this.textBoxNom4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNbJoueur)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "PIG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Instruction: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "- Atteindre 25 points avant l\'adversaire";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(550, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "- Si le dé obtient 1, tous les points accumulés seront perdus, puis le tour se pa" +
    "sse au joueur suivant. ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(412, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "- Si le dé est différent de 1, les points s\'accumuleront selon le chiffre du dé.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F);
            this.label6.Location = new System.Drawing.Point(16, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "-- C\'est chacun son tour!";
            // 
            // numericUpDownNbJoueur
            // 
            this.numericUpDownNbJoueur.Location = new System.Drawing.Point(411, 204);
            this.numericUpDownNbJoueur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownNbJoueur.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownNbJoueur.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownNbJoueur.Name = "numericUpDownNbJoueur";
            this.numericUpDownNbJoueur.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownNbJoueur.TabIndex = 6;
            this.numericUpDownNbJoueur.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownNbJoueur.ValueChanged += new System.EventHandler(this.numericUpDownNbJoueur_ValueChanged);
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuitter.Location = new System.Drawing.Point(792, 578);
            this.buttonQuitter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(359, 78);
            this.buttonQuitter.TabIndex = 7;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = false;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(315, 22);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nombre de Joueurs(minimum 2, maximum 4)";
            // 
            // richTextBoxPointage
            // 
            this.richTextBoxPointage.Location = new System.Drawing.Point(896, 335);
            this.richTextBoxPointage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxPointage.Name = "richTextBoxPointage";
            this.richTextBoxPointage.ReadOnly = true;
            this.richTextBoxPointage.Size = new System.Drawing.Size(253, 219);
            this.richTextBoxPointage.TabIndex = 10;
            this.richTextBoxPointage.Text = "";
            // 
            // buttonMeilleurPointage
            // 
            this.buttonMeilleurPointage.BackColor = System.Drawing.Color.Snow;
            this.buttonMeilleurPointage.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMeilleurPointage.Location = new System.Drawing.Point(328, 578);
            this.buttonMeilleurPointage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMeilleurPointage.Name = "buttonMeilleurPointage";
            this.buttonMeilleurPointage.Size = new System.Drawing.Size(459, 78);
            this.buttonMeilleurPointage.TabIndex = 11;
            this.buttonMeilleurPointage.Text = "Meilleurs pointage";
            this.buttonMeilleurPointage.UseVisualStyleBackColor = false;
            this.buttonMeilleurPointage.Click += new System.EventHandler(this.buttonMeilleurPointage_Click);
            // 
            // buttonDemarrerPartie
            // 
            this.buttonDemarrerPartie.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonDemarrerPartie.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDemarrerPartie.Location = new System.Drawing.Point(12, 578);
            this.buttonDemarrerPartie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDemarrerPartie.Name = "buttonDemarrerPartie";
            this.buttonDemarrerPartie.Size = new System.Drawing.Size(311, 78);
            this.buttonDemarrerPartie.TabIndex = 12;
            this.buttonDemarrerPartie.Text = "Démarrer une partie!";
            this.buttonDemarrerPartie.UseVisualStyleBackColor = false;
            this.buttonDemarrerPartie.Click += new System.EventHandler(this.buttonDemarrerPartie_Click);
            // 
            // textBoxNom1
            // 
            this.textBoxNom1.Location = new System.Drawing.Point(76, 2);
            this.textBoxNom1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNom1.Name = "textBoxNom1";
            this.textBoxNom1.Size = new System.Drawing.Size(100, 22);
            this.textBoxNom1.TabIndex = 13;
            this.textBoxNom1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNom1_KeyPress);
            // 
            // labelNom1
            // 
            this.labelNom1.AutoSize = true;
            this.labelNom1.BackColor = System.Drawing.Color.Transparent;
            this.labelNom1.Location = new System.Drawing.Point(3, 10);
            this.labelNom1.Name = "labelNom1";
            this.labelNom1.Size = new System.Drawing.Size(61, 16);
            this.labelNom1.TabIndex = 14;
            this.labelNom1.Text = "Joueur 1:";
            // 
            // labelNom2
            // 
            this.labelNom2.AutoSize = true;
            this.labelNom2.BackColor = System.Drawing.Color.Transparent;
            this.labelNom2.Location = new System.Drawing.Point(3, 36);
            this.labelNom2.Name = "labelNom2";
            this.labelNom2.Size = new System.Drawing.Size(61, 16);
            this.labelNom2.TabIndex = 15;
            this.labelNom2.Text = "Joueur 2:";
            // 
            // textBoxNom2
            // 
            this.textBoxNom2.Location = new System.Drawing.Point(76, 36);
            this.textBoxNom2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNom2.Name = "textBoxNom2";
            this.textBoxNom2.Size = new System.Drawing.Size(100, 22);
            this.textBoxNom2.TabIndex = 16;
            this.textBoxNom2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNom2_KeyPress);
            // 
            // labelNom3
            // 
            this.labelNom3.AutoSize = true;
            this.labelNom3.Location = new System.Drawing.Point(3, 66);
            this.labelNom3.Name = "labelNom3";
            this.labelNom3.Size = new System.Drawing.Size(61, 16);
            this.labelNom3.TabIndex = 17;
            this.labelNom3.Text = "Joueur 3:";
            // 
            // labelNom4
            // 
            this.labelNom4.AutoSize = true;
            this.labelNom4.Location = new System.Drawing.Point(3, 98);
            this.labelNom4.Name = "labelNom4";
            this.labelNom4.Size = new System.Drawing.Size(61, 16);
            this.labelNom4.TabIndex = 18;
            this.labelNom4.Text = "Joueur 4:";
            // 
            // textBoxNom3
            // 
            this.textBoxNom3.Location = new System.Drawing.Point(76, 66);
            this.textBoxNom3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNom3.Name = "textBoxNom3";
            this.textBoxNom3.Size = new System.Drawing.Size(100, 22);
            this.textBoxNom3.TabIndex = 19;
            this.textBoxNom3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNom3_KeyPress);
            // 
            // textBoxNom4
            // 
            this.textBoxNom4.Location = new System.Drawing.Point(76, 98);
            this.textBoxNom4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNom4.Name = "textBoxNom4";
            this.textBoxNom4.Size = new System.Drawing.Size(100, 22);
            this.textBoxNom4.TabIndex = 20;
            this.textBoxNom4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNom4_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 22);
            this.label8.TabIndex = 21;
            this.label8.Text = "Nom des joueurs:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.labelNom1);
            this.panel1.Controls.Add(this.textBoxNom1);
            this.panel1.Controls.Add(this.textBoxNom4);
            this.panel1.Controls.Add(this.textBoxNom2);
            this.panel1.Controls.Add(this.labelNom4);
            this.panel1.Controls.Add(this.textBoxNom3);
            this.panel1.Controls.Add(this.labelNom2);
            this.panel1.Controls.Add(this.labelNom3);
            this.panel1.Location = new System.Drawing.Point(19, 278);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 140);
            this.panel1.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::TP3InesSaidi.Properties.Resources.Capture;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1165, 683);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonDemarrerPartie);
            this.Controls.Add(this.buttonMeilleurPointage);
            this.Controls.Add(this.richTextBoxPointage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.numericUpDownNbJoueur);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNbJoueur)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownNbJoueur;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBoxPointage;
        private System.Windows.Forms.Button buttonMeilleurPointage;
        private System.Windows.Forms.Button buttonDemarrerPartie;
        private System.Windows.Forms.TextBox textBoxNom1;
        private System.Windows.Forms.Label labelNom1;
        private System.Windows.Forms.Label labelNom2;
        private System.Windows.Forms.TextBox textBoxNom2;
        private System.Windows.Forms.Label labelNom3;
        private System.Windows.Forms.Label labelNom4;
        private System.Windows.Forms.TextBox textBoxNom3;
        private System.Windows.Forms.TextBox textBoxNom4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
    }
}

