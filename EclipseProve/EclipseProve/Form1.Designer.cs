namespace EclipseProve
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAreal = new System.Windows.Forms.Label();
            this.buttonSirkel = new System.Windows.Forms.Button();
            this.buttonEclipse = new System.Windows.Forms.Button();
            this.textBoxR1 = new System.Windows.Forms.TextBox();
            this.textBoxAreal = new System.Windows.Forms.TextBox();
            this.textBoxR2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "r1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "r2";
            // 
            // labelAreal
            // 
            this.labelAreal.AutoSize = true;
            this.labelAreal.Location = new System.Drawing.Point(578, 63);
            this.labelAreal.Name = "labelAreal";
            this.labelAreal.Size = new System.Drawing.Size(64, 13);
            this.labelAreal.TabIndex = 0;
            this.labelAreal.Text = "Eclipseareal";
            // 
            // buttonSirkel
            // 
            this.buttonSirkel.Location = new System.Drawing.Point(314, 58);
            this.buttonSirkel.Name = "buttonSirkel";
            this.buttonSirkel.Size = new System.Drawing.Size(126, 23);
            this.buttonSirkel.TabIndex = 1;
            this.buttonSirkel.Text = "Beregn sirkelareal";
            this.buttonSirkel.UseVisualStyleBackColor = true;
            this.buttonSirkel.Click += new System.EventHandler(this.ButtonSirkel_Click);
            // 
            // buttonEclipse
            // 
            this.buttonEclipse.Location = new System.Drawing.Point(446, 58);
            this.buttonEclipse.Name = "buttonEclipse";
            this.buttonEclipse.Size = new System.Drawing.Size(116, 23);
            this.buttonEclipse.TabIndex = 2;
            this.buttonEclipse.Text = "Beregn eclipseareal";
            this.buttonEclipse.UseVisualStyleBackColor = true;
            this.buttonEclipse.Click += new System.EventHandler(this.ButtonEclipse_Click);
            // 
            // textBoxR1
            // 
            this.textBoxR1.Location = new System.Drawing.Point(80, 60);
            this.textBoxR1.Name = "textBoxR1";
            this.textBoxR1.Size = new System.Drawing.Size(100, 20);
            this.textBoxR1.TabIndex = 3;
            // 
            // textBoxAreal
            // 
            this.textBoxAreal.Location = new System.Drawing.Point(660, 60);
            this.textBoxAreal.Name = "textBoxAreal";
            this.textBoxAreal.ReadOnly = true;
            this.textBoxAreal.Size = new System.Drawing.Size(100, 20);
            this.textBoxAreal.TabIndex = 4;
            // 
            // textBoxR2
            // 
            this.textBoxR2.Location = new System.Drawing.Point(208, 60);
            this.textBoxR2.Name = "textBoxR2";
            this.textBoxR2.Size = new System.Drawing.Size(100, 20);
            this.textBoxR2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Oppgave 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxR2);
            this.Controls.Add(this.textBoxAreal);
            this.Controls.Add(this.textBoxR1);
            this.Controls.Add(this.buttonEclipse);
            this.Controls.Add(this.buttonSirkel);
            this.Controls.Add(this.labelAreal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAreal;
        private System.Windows.Forms.Button buttonSirkel;
        private System.Windows.Forms.Button buttonEclipse;
        private System.Windows.Forms.TextBox textBoxR1;
        private System.Windows.Forms.TextBox textBoxAreal;
        private System.Windows.Forms.TextBox textBoxR2;
        private System.Windows.Forms.Label label3;
    }
}

