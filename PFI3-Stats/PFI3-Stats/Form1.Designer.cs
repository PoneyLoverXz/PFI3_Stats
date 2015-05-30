namespace PFI3_Stats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RB_f5 = new System.Windows.Forms.RadioButton();
            this.RB_f4 = new System.Windows.Forms.RadioButton();
            this.RB_f3 = new System.Windows.Forms.RadioButton();
            this.RB_f2 = new System.Windows.Forms.RadioButton();
            this.RB_f1 = new System.Windows.Forms.RadioButton();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TB_a = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_b = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Pi = new System.Windows.Forms.TextBox();
            this.TB_Aire = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_Probabilite = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BTN_Calculer = new System.Windows.Forms.Button();
            this.BTN_Quitter = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RB_f5);
            this.groupBox1.Controls.Add(this.RB_f4);
            this.groupBox1.Controls.Add(this.RB_f3);
            this.groupBox1.Controls.Add(this.RB_f2);
            this.groupBox1.Controls.Add(this.RB_f1);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fonctions";
            // 
            // RB_f5
            // 
            this.RB_f5.AutoSize = true;
            this.RB_f5.Location = new System.Drawing.Point(6, 188);
            this.RB_f5.Name = "RB_f5";
            this.RB_f5.Size = new System.Drawing.Size(14, 13);
            this.RB_f5.TabIndex = 14;
            this.RB_f5.UseVisualStyleBackColor = true;
            this.RB_f5.CheckedChanged += new System.EventHandler(this.RB_f5_CheckedChanged);
            // 
            // RB_f4
            // 
            this.RB_f4.AutoSize = true;
            this.RB_f4.Location = new System.Drawing.Point(6, 156);
            this.RB_f4.Name = "RB_f4";
            this.RB_f4.Size = new System.Drawing.Size(14, 13);
            this.RB_f4.TabIndex = 13;
            this.RB_f4.TabStop = true;
            this.RB_f4.UseVisualStyleBackColor = true;
            this.RB_f4.CheckedChanged += new System.EventHandler(this.RB_f4_CheckedChanged);
            // 
            // RB_f3
            // 
            this.RB_f3.AutoSize = true;
            this.RB_f3.Location = new System.Drawing.Point(6, 115);
            this.RB_f3.Name = "RB_f3";
            this.RB_f3.Size = new System.Drawing.Size(14, 13);
            this.RB_f3.TabIndex = 12;
            this.RB_f3.UseVisualStyleBackColor = true;
            this.RB_f3.CheckedChanged += new System.EventHandler(this.RB_f3_CheckedChanged);
            // 
            // RB_f2
            // 
            this.RB_f2.AutoSize = true;
            this.RB_f2.Location = new System.Drawing.Point(6, 71);
            this.RB_f2.Name = "RB_f2";
            this.RB_f2.Size = new System.Drawing.Size(14, 13);
            this.RB_f2.TabIndex = 11;
            this.RB_f2.UseVisualStyleBackColor = true;
            this.RB_f2.CheckedChanged += new System.EventHandler(this.RB_f2_CheckedChanged);
            // 
            // RB_f1
            // 
            this.RB_f1.AutoSize = true;
            this.RB_f1.Checked = true;
            this.RB_f1.Location = new System.Drawing.Point(6, 31);
            this.RB_f1.Name = "RB_f1";
            this.RB_f1.Size = new System.Drawing.Size(14, 13);
            this.RB_f1.TabIndex = 10;
            this.RB_f1.TabStop = true;
            this.RB_f1.UseVisualStyleBackColor = true;
            this.RB_f1.CheckedChanged += new System.EventHandler(this.RB_f1_CheckedChanged);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(29, 146);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(134, 30);
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(29, 104);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(183, 36);
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(29, 182);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(134, 24);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(29, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(269, 41);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 31);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // TB_a
            // 
            this.TB_a.Location = new System.Drawing.Point(42, 244);
            this.TB_a.Name = "TB_a";
            this.TB_a.Size = new System.Drawing.Size(100, 20);
            this.TB_a.TabIndex = 1;
            this.TB_a.Text = "0";
            this.TB_a.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.TB_a.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "b:";
            // 
            // TB_b
            // 
            this.TB_b.Location = new System.Drawing.Point(202, 244);
            this.TB_b.Name = "TB_b";
            this.TB_b.Size = new System.Drawing.Size(100, 20);
            this.TB_b.TabIndex = 3;
            this.TB_b.Text = "11";
            this.TB_b.TextChanged += new System.EventHandler(this.TB_b_TextChanged);
            this.TB_b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Estimateur ponctuel de π :";
            // 
            // TB_Pi
            // 
            this.TB_Pi.Location = new System.Drawing.Point(186, 280);
            this.TB_Pi.Name = "TB_Pi";
            this.TB_Pi.ReadOnly = true;
            this.TB_Pi.Size = new System.Drawing.Size(116, 20);
            this.TB_Pi.TabIndex = 6;
            // 
            // TB_Aire
            // 
            this.TB_Aire.Location = new System.Drawing.Point(186, 306);
            this.TB_Aire.Name = "TB_Aire";
            this.TB_Aire.ReadOnly = true;
            this.TB_Aire.Size = new System.Drawing.Size(116, 20);
            this.TB_Aire.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Intervalle de confiance:";
            // 
            // TB_Probabilite
            // 
            this.TB_Probabilite.Location = new System.Drawing.Point(186, 332);
            this.TB_Probabilite.Name = "TB_Probabilite";
            this.TB_Probabilite.ReadOnly = true;
            this.TB_Probabilite.Size = new System.Drawing.Size(116, 20);
            this.TB_Probabilite.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Probabilité:";
            // 
            // BTN_Calculer
            // 
            this.BTN_Calculer.Location = new System.Drawing.Point(12, 367);
            this.BTN_Calculer.Name = "BTN_Calculer";
            this.BTN_Calculer.Size = new System.Drawing.Size(123, 23);
            this.BTN_Calculer.TabIndex = 11;
            this.BTN_Calculer.Text = "Calculer";
            this.BTN_Calculer.UseVisualStyleBackColor = true;
            this.BTN_Calculer.Click += new System.EventHandler(this.BTN_Calculer_Click);
            // 
            // BTN_Quitter
            // 
            this.BTN_Quitter.Location = new System.Drawing.Point(205, 367);
            this.BTN_Quitter.Name = "BTN_Quitter";
            this.BTN_Quitter.Size = new System.Drawing.Size(123, 23);
            this.BTN_Quitter.TabIndex = 12;
            this.BTN_Quitter.Text = "Quitter";
            this.BTN_Quitter.UseVisualStyleBackColor = true;
            this.BTN_Quitter.Click += new System.EventHandler(this.BTN_Quitter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 402);
            this.Controls.Add(this.BTN_Quitter);
            this.Controls.Add(this.BTN_Calculer);
            this.Controls.Add(this.TB_Probabilite);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_Aire);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_Pi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_b);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_a);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "PFI3-Stats";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TB_a;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_b;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton RB_f5;
        private System.Windows.Forms.RadioButton RB_f4;
        private System.Windows.Forms.RadioButton RB_f3;
        private System.Windows.Forms.RadioButton RB_f2;
        private System.Windows.Forms.RadioButton RB_f1;
        private System.Windows.Forms.TextBox TB_Pi;
        private System.Windows.Forms.TextBox TB_Aire;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_Probabilite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTN_Calculer;
        private System.Windows.Forms.Button BTN_Quitter;
    }
}

