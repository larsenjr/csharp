namespace Oppgave2AlderFarge
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFodselsAar = new System.Windows.Forms.TextBox();
            this.textBoxAlder = new System.Windows.Forms.TextBox();
            this.textBoxFarge = new System.Windows.Forms.TextBox();
            this.buttonVisAlderOgFarge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oppgave 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Angi fødselsår";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(561, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Farge";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Alder";
            // 
            // textBoxFodselsAar
            // 
            this.textBoxFodselsAar.Location = new System.Drawing.Point(124, 105);
            this.textBoxFodselsAar.Name = "textBoxFodselsAar";
            this.textBoxFodselsAar.Size = new System.Drawing.Size(100, 20);
            this.textBoxFodselsAar.TabIndex = 1;
            // 
            // textBoxAlder
            // 
            this.textBoxAlder.Location = new System.Drawing.Point(422, 105);
            this.textBoxAlder.Name = "textBoxAlder";
            this.textBoxAlder.Size = new System.Drawing.Size(100, 20);
            this.textBoxAlder.TabIndex = 2;
            this.textBoxAlder.TextChanged += new System.EventHandler(this.TextBoxAlder_TextChanged);
            // 
            // textBoxFarge
            // 
            this.textBoxFarge.Location = new System.Drawing.Point(613, 105);
            this.textBoxFarge.Name = "textBoxFarge";
            this.textBoxFarge.Size = new System.Drawing.Size(100, 20);
            this.textBoxFarge.TabIndex = 3;
            // 
            // buttonVisAlderOgFarge
            // 
            this.buttonVisAlderOgFarge.Location = new System.Drawing.Point(245, 103);
            this.buttonVisAlderOgFarge.Name = "buttonVisAlderOgFarge";
            this.buttonVisAlderOgFarge.Size = new System.Drawing.Size(114, 23);
            this.buttonVisAlderOgFarge.TabIndex = 4;
            this.buttonVisAlderOgFarge.Text = "Vis alder og farge";
            this.buttonVisAlderOgFarge.UseVisualStyleBackColor = true;
            this.buttonVisAlderOgFarge.Click += new System.EventHandler(this.ButtonVisAlderOgFarge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVisAlderOgFarge);
            this.Controls.Add(this.textBoxFarge);
            this.Controls.Add(this.textBoxAlder);
            this.Controls.Add(this.textBoxFodselsAar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFodselsAar;
        private System.Windows.Forms.TextBox textBoxAlder;
        private System.Windows.Forms.TextBox textBoxFarge;
        private System.Windows.Forms.Button buttonVisAlderOgFarge;
    }
}

