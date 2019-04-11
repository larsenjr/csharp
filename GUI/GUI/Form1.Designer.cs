namespace GUI
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
            this.textInkMva = new System.Windows.Forms.TextBox();
            this.btncalcU = new System.Windows.Forms.Button();
            this.cboR = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textExVat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtU = new System.Windows.Forms.TextBox();
            this.textI = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtboxResult = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCalcVo2Max = new System.Windows.Forms.Button();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.txtCooper = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotalSec = new System.Windows.Forms.TextBox();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.txtSec = new System.Windows.Forms.TextBox();
            this.btnSplit = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtBmi = new System.Windows.Forms.TextBox();
            this.btnBmi = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.btnArray = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxIndex = new System.Windows.Forms.TextBox();
            this.textBoxNumberArray = new System.Windows.Forms.TextBox();
            this.txtBoxValues = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textInkMva
            // 
            this.textInkMva.Location = new System.Drawing.Point(85, 63);
            this.textInkMva.Name = "textInkMva";
            this.textInkMva.Size = new System.Drawing.Size(100, 20);
            this.textInkMva.TabIndex = 0;
            this.textInkMva.TextChanged += new System.EventHandler(this.textInkMva_TextChanged);
            // 
            // btncalcU
            // 
            this.btncalcU.Location = new System.Drawing.Point(303, 127);
            this.btncalcU.Name = "btncalcU";
            this.btncalcU.Size = new System.Drawing.Size(100, 25);
            this.btncalcU.TabIndex = 1;
            this.btncalcU.Text = "Beregn U";
            this.btncalcU.UseVisualStyleBackColor = true;
            this.btncalcU.Click += new System.EventHandler(this.btncalcU_Click);
            // 
            // cboR
            // 
            this.cboR.FormattingEnabled = true;
            this.cboR.Items.AddRange(new object[] {
            "100",
            "120",
            "150",
            "180",
            "220",
            "1000",
            "5000",
            "10000"});
            this.cboR.Location = new System.Drawing.Point(37, 130);
            this.cboR.Name = "cboR";
            this.cboR.Size = new System.Drawing.Size(100, 21);
            this.cboR.TabIndex = 2;
            this.cboR.SelectedIndexChanged += new System.EventHandler(this.cboR_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pris inkl.mva";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pris eks.mva";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Oppgave 1";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textExVat
            // 
            this.textExVat.Location = new System.Drawing.Point(85, 37);
            this.textExVat.Name = "textExVat";
            this.textExVat.ReadOnly = true;
            this.textExVat.Size = new System.Drawing.Size(100, 20);
            this.textExVat.TabIndex = 7;
            this.textExVat.TextChanged += new System.EventHandler(this.textExVat_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Oppgave 2";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "R:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "I:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtU
            // 
            this.txtU.Location = new System.Drawing.Point(452, 132);
            this.txtU.Name = "txtU";
            this.txtU.ReadOnly = true;
            this.txtU.Size = new System.Drawing.Size(100, 20);
            this.txtU.TabIndex = 11;
            this.txtU.TextChanged += new System.EventHandler(this.txtU_TextChanged);
            // 
            // textI
            // 
            this.textI.Location = new System.Drawing.Point(183, 130);
            this.textI.Name = "textI";
            this.textI.Size = new System.Drawing.Size(100, 20);
            this.textI.TabIndex = 12;
            this.textI.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(428, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "U:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Oppgave 3";
            // 
            // txtboxResult
            // 
            this.txtboxResult.AutoSize = true;
            this.txtboxResult.Location = new System.Drawing.Point(347, 209);
            this.txtboxResult.Name = "txtboxResult";
            this.txtboxResult.Size = new System.Drawing.Size(99, 13);
            this.txtboxResult.TabIndex = 15;
            this.txtboxResult.Text = "Resultat (VO2 Max)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Distanse løpt på 12 min";
            // 
            // btnCalcVo2Max
            // 
            this.btnCalcVo2Max.Location = new System.Drawing.Point(260, 202);
            this.btnCalcVo2Max.Name = "btnCalcVo2Max";
            this.btnCalcVo2Max.Size = new System.Drawing.Size(75, 23);
            this.btnCalcVo2Max.TabIndex = 18;
            this.btnCalcVo2Max.Text = "Beregn";
            this.btnCalcVo2Max.UseVisualStyleBackColor = true;
            this.btnCalcVo2Max.Click += new System.EventHandler(this.btnCalcVo2Max_Click);
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(133, 202);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(100, 20);
            this.txtDistance.TabIndex = 19;
            // 
            // txtCooper
            // 
            this.txtCooper.Location = new System.Drawing.Point(452, 206);
            this.txtCooper.Name = "txtCooper";
            this.txtCooper.ReadOnly = true;
            this.txtCooper.Size = new System.Drawing.Size(100, 20);
            this.txtCooper.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Oppgave 4";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Totalt antall sek";
            // 
            // txtTotalSec
            // 
            this.txtTotalSec.Location = new System.Drawing.Point(101, 288);
            this.txtTotalSec.Name = "txtTotalSec";
            this.txtTotalSec.Size = new System.Drawing.Size(100, 20);
            this.txtTotalSec.TabIndex = 23;
            // 
            // txtMinutes
            // 
            this.txtMinutes.Location = new System.Drawing.Point(386, 289);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.ReadOnly = true;
            this.txtMinutes.Size = new System.Drawing.Size(100, 20);
            this.txtMinutes.TabIndex = 24;
            // 
            // txtSec
            // 
            this.txtSec.Location = new System.Drawing.Point(569, 288);
            this.txtSec.Name = "txtSec";
            this.txtSec.ReadOnly = true;
            this.txtSec.Size = new System.Drawing.Size(100, 20);
            this.txtSec.TabIndex = 25;
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(220, 285);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(100, 23);
            this.btnSplit.TabIndex = 26;
            this.btnSplit.Text = "Splitt";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(499, 292);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Sekunder";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(335, 292);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Minutter";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 353);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Oppgave 5";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 393);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Høyde i meter";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(428, 389);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "BMI";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(198, 391);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 13);
            this.label17.TabIndex = 32;
            this.label17.Text = "Vekt";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(85, 386);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 33;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(235, 388);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 20);
            this.txtWeight.TabIndex = 34;
            // 
            // txtBmi
            // 
            this.txtBmi.Location = new System.Drawing.Point(460, 385);
            this.txtBmi.Name = "txtBmi";
            this.txtBmi.ReadOnly = true;
            this.txtBmi.Size = new System.Drawing.Size(100, 20);
            this.txtBmi.TabIndex = 35;
            // 
            // btnBmi
            // 
            this.btnBmi.Location = new System.Drawing.Point(344, 385);
            this.btnBmi.Name = "btnBmi";
            this.btnBmi.Size = new System.Drawing.Size(75, 23);
            this.btnBmi.TabIndex = 36;
            this.btnBmi.Text = "Beregn BMI";
            this.btnBmi.UseVisualStyleBackColor = true;
            this.btnBmi.Click += new System.EventHandler(this.btnBmi_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(10, 447);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(101, 13);
            this.label18.TabIndex = 37;
            this.label18.Text = "ExceptionOppgaver";
            // 
            // btnArray
            // 
            this.btnArray.Location = new System.Drawing.Point(13, 487);
            this.btnArray.Name = "btnArray";
            this.btnArray.Size = new System.Drawing.Size(75, 23);
            this.btnArray.TabIndex = 38;
            this.btnArray.Text = "Array";
            this.btnArray.UseVisualStyleBackColor = true;
            this.btnArray.Click += new System.EventHandler(this.button1_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(103, 491);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(33, 13);
            this.label19.TabIndex = 39;
            this.label19.Text = "Index";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(261, 492);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(161, 13);
            this.label20.TabIndex = 40;
            this.label20.Text = "Oppgi tall som skal legges i Array";
            // 
            // textBoxIndex
            // 
            this.textBoxIndex.Location = new System.Drawing.Point(141, 489);
            this.textBoxIndex.Name = "textBoxIndex";
            this.textBoxIndex.Size = new System.Drawing.Size(100, 20);
            this.textBoxIndex.TabIndex = 41;
            this.textBoxIndex.TextChanged += new System.EventHandler(this.textBoxIndex_TextChanged);
            // 
            // textBoxNumberArray
            // 
            this.textBoxNumberArray.Location = new System.Drawing.Point(431, 488);
            this.textBoxNumberArray.Name = "textBoxNumberArray";
            this.textBoxNumberArray.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumberArray.TabIndex = 42;
            // 
            // txtBoxValues
            // 
            this.txtBoxValues.Location = new System.Drawing.Point(15, 545);
            this.txtBoxValues.Name = "txtBoxValues";
            this.txtBoxValues.ReadOnly = true;
            this.txtBoxValues.Size = new System.Drawing.Size(431, 20);
            this.txtBoxValues.TabIndex = 43;
            this.txtBoxValues.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 612);
            this.Controls.Add(this.txtBoxValues);
            this.Controls.Add(this.textBoxNumberArray);
            this.Controls.Add(this.textBoxIndex);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btnArray);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btnBmi);
            this.Controls.Add(this.txtBmi);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.txtSec);
            this.Controls.Add(this.txtMinutes);
            this.Controls.Add(this.txtTotalSec);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCooper);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.btnCalcVo2Max);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtboxResult);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textI);
            this.Controls.Add(this.txtU);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textExVat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboR);
            this.Controls.Add(this.btncalcU);
            this.Controls.Add(this.textInkMva);
            this.Name = "Form1";
            this.Text = "Øving";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textInkMva;
        private System.Windows.Forms.Button btncalcU;
        private System.Windows.Forms.ComboBox cboR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textExVat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtU;
        private System.Windows.Forms.TextBox textI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txtboxResult;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCalcVo2Max;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.TextBox txtCooper;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotalSec;
        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.TextBox txtSec;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtBmi;
        private System.Windows.Forms.Button btnBmi;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnArray;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxIndex;
        private System.Windows.Forms.TextBox textBoxNumberArray;
        private System.Windows.Forms.TextBox txtBoxValues;
    }
}

