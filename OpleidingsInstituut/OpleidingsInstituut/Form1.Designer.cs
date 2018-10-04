namespace OpleidingsInstituut
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
            this.pnlIn02 = new System.Windows.Forms.Panel();
            this.pnlIn01 = new System.Windows.Forms.Panel();
            this.pnlOut = new System.Windows.Forms.Panel();
            this.txbIn01 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbNee = new System.Windows.Forms.RadioButton();
            this.rdbJa = new System.Windows.Forms.RadioButton();
            this.btnVerder = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.rdbSV = new System.Windows.Forms.RadioButton();
            this.rdbMV = new System.Windows.Forms.RadioButton();
            this.rdbPV = new System.Windows.Forms.RadioButton();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblAantalVakkenUit = new System.Windows.Forms.Label();
            this.lblAatnalSV = new System.Windows.Forms.Label();
            this.lblAatnalMV = new System.Windows.Forms.Label();
            this.lblAatnalPV = new System.Windows.Forms.Label();
            this.lblBetaaltotaal = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlIn02.SuspendLayout();
            this.pnlIn01.SuspendLayout();
            this.pnlOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlIn02
            // 
            this.pnlIn02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlIn02.Controls.Add(this.btnConfirm);
            this.pnlIn02.Controls.Add(this.rdbPV);
            this.pnlIn02.Controls.Add(this.rdbMV);
            this.pnlIn02.Controls.Add(this.rdbSV);
            this.pnlIn02.Controls.Add(this.lblID);
            this.pnlIn02.Location = new System.Drawing.Point(12, 118);
            this.pnlIn02.Name = "pnlIn02";
            this.pnlIn02.Size = new System.Drawing.Size(200, 109);
            this.pnlIn02.TabIndex = 0;
            this.pnlIn02.Visible = false;
            // 
            // pnlIn01
            // 
            this.pnlIn01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlIn01.Controls.Add(this.btnVerder);
            this.pnlIn01.Controls.Add(this.rdbJa);
            this.pnlIn01.Controls.Add(this.rdbNee);
            this.pnlIn01.Controls.Add(this.label3);
            this.pnlIn01.Controls.Add(this.label2);
            this.pnlIn01.Controls.Add(this.dateTimePicker1);
            this.pnlIn01.Controls.Add(this.label1);
            this.pnlIn01.Controls.Add(this.txbIn01);
            this.pnlIn01.Location = new System.Drawing.Point(12, 12);
            this.pnlIn01.Name = "pnlIn01";
            this.pnlIn01.Size = new System.Drawing.Size(427, 100);
            this.pnlIn01.TabIndex = 0;
            // 
            // pnlOut
            // 
            this.pnlOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOut.Controls.Add(this.btnExit);
            this.pnlOut.Controls.Add(this.lblBetaaltotaal);
            this.pnlOut.Controls.Add(this.lblAatnalPV);
            this.pnlOut.Controls.Add(this.lblAatnalMV);
            this.pnlOut.Controls.Add(this.lblAatnalSV);
            this.pnlOut.Controls.Add(this.lblAantalVakkenUit);
            this.pnlOut.Location = new System.Drawing.Point(239, 118);
            this.pnlOut.Name = "pnlOut";
            this.pnlOut.Size = new System.Drawing.Size(200, 109);
            this.pnlOut.TabIndex = 0;
            this.pnlOut.Visible = false;
            // 
            // txbIn01
            // 
            this.txbIn01.Location = new System.Drawing.Point(110, 7);
            this.txbIn01.Name = "txbIn01";
            this.txbIn01.Size = new System.Drawing.Size(26, 20);
            this.txbIn01.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aantal vakken:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(110, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Geboorte datum: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bent U hier gekomen met een abeids bureau?";
            // 
            // rdbNee
            // 
            this.rdbNee.AutoSize = true;
            this.rdbNee.Location = new System.Drawing.Point(245, 80);
            this.rdbNee.Name = "rdbNee";
            this.rdbNee.Size = new System.Drawing.Size(45, 17);
            this.rdbNee.TabIndex = 6;
            this.rdbNee.TabStop = true;
            this.rdbNee.Text = "Nee";
            this.rdbNee.UseVisualStyleBackColor = true;
            // 
            // rdbJa
            // 
            this.rdbJa.AutoSize = true;
            this.rdbJa.Location = new System.Drawing.Point(245, 59);
            this.rdbJa.Name = "rdbJa";
            this.rdbJa.Size = new System.Drawing.Size(36, 17);
            this.rdbJa.TabIndex = 7;
            this.rdbJa.TabStop = true;
            this.rdbJa.Text = "Ja";
            this.rdbJa.UseVisualStyleBackColor = true;
            // 
            // btnVerder
            // 
            this.btnVerder.Location = new System.Drawing.Point(349, 74);
            this.btnVerder.Name = "btnVerder";
            this.btnVerder.Size = new System.Drawing.Size(75, 23);
            this.btnVerder.TabIndex = 8;
            this.btnVerder.Text = "Verder";
            this.btnVerder.UseVisualStyleBackColor = true;
            this.btnVerder.Click += new System.EventHandler(this.btnVerder_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(3, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(35, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Vak 1";
            // 
            // rdbSV
            // 
            this.rdbSV.AutoSize = true;
            this.rdbSV.Location = new System.Drawing.Point(44, 3);
            this.rdbSV.Name = "rdbSV";
            this.rdbSV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbSV.Size = new System.Drawing.Size(94, 17);
            this.rdbSV.TabIndex = 1;
            this.rdbSV.TabStop = true;
            this.rdbSV.Text = "Schriftelijk vak";
            this.rdbSV.UseVisualStyleBackColor = true;
            // 
            // rdbMV
            // 
            this.rdbMV.AutoSize = true;
            this.rdbMV.Location = new System.Drawing.Point(44, 26);
            this.rdbMV.Name = "rdbMV";
            this.rdbMV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbMV.Size = new System.Drawing.Size(91, 17);
            this.rdbMV.TabIndex = 2;
            this.rdbMV.TabStop = true;
            this.rdbMV.Text = "Mondelijk vak";
            this.rdbMV.UseVisualStyleBackColor = true;
            // 
            // rdbPV
            // 
            this.rdbPV.AutoSize = true;
            this.rdbPV.Location = new System.Drawing.Point(44, 49);
            this.rdbPV.Name = "rdbPV";
            this.rdbPV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbPV.Size = new System.Drawing.Size(90, 17);
            this.rdbPV.TabIndex = 3;
            this.rdbPV.TabStop = true;
            this.rdbPV.Text = "Practisch vak";
            this.rdbPV.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(120, 81);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Ok";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblAantalVakkenUit
            // 
            this.lblAantalVakkenUit.AutoSize = true;
            this.lblAantalVakkenUit.Location = new System.Drawing.Point(15, 7);
            this.lblAantalVakkenUit.Name = "lblAantalVakkenUit";
            this.lblAantalVakkenUit.Size = new System.Drawing.Size(82, 13);
            this.lblAantalVakkenUit.TabIndex = 0;
            this.lblAantalVakkenUit.Text = "Aantal vakken: ";
            // 
            // lblAatnalSV
            // 
            this.lblAatnalSV.AutoSize = true;
            this.lblAatnalSV.Location = new System.Drawing.Point(19, 26);
            this.lblAatnalSV.Name = "lblAatnalSV";
            this.lblAatnalSV.Size = new System.Drawing.Size(137, 13);
            this.lblAatnalSV.TabIndex = 1;
            this.lblAatnalSV.Text = "Aantal schriftelijke vakken: ";
            // 
            // lblAatnalMV
            // 
            this.lblAatnalMV.AutoSize = true;
            this.lblAatnalMV.Location = new System.Drawing.Point(19, 39);
            this.lblAatnalMV.Name = "lblAatnalMV";
            this.lblAatnalMV.Size = new System.Drawing.Size(139, 13);
            this.lblAatnalMV.TabIndex = 2;
            this.lblAatnalMV.Text = "Aantal mondelinge vakken: ";
            // 
            // lblAatnalPV
            // 
            this.lblAatnalPV.AutoSize = true;
            this.lblAatnalPV.Location = new System.Drawing.Point(19, 53);
            this.lblAatnalPV.Name = "lblAatnalPV";
            this.lblAatnalPV.Size = new System.Drawing.Size(134, 13);
            this.lblAatnalPV.TabIndex = 3;
            this.lblAatnalPV.Text = "Aantal practische vakken: ";
            // 
            // lblBetaaltotaal
            // 
            this.lblBetaaltotaal.AutoSize = true;
            this.lblBetaaltotaal.Location = new System.Drawing.Point(19, 81);
            this.lblBetaaltotaal.Name = "lblBetaaltotaal";
            this.lblBetaaltotaal.Size = new System.Drawing.Size(43, 13);
            this.lblBetaaltotaal.TabIndex = 4;
            this.lblBetaaltotaal.Text = "Totaal: ";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(120, 76);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Einde";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 239);
            this.Controls.Add(this.pnlOut);
            this.Controls.Add(this.pnlIn01);
            this.Controls.Add(this.pnlIn02);
            this.Name = "Form1";
            this.Text = "Opleidings Inschrijving";
            this.pnlIn02.ResumeLayout(false);
            this.pnlIn02.PerformLayout();
            this.pnlIn01.ResumeLayout(false);
            this.pnlIn01.PerformLayout();
            this.pnlOut.ResumeLayout(false);
            this.pnlOut.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlIn02;
        private System.Windows.Forms.Panel pnlIn01;
        private System.Windows.Forms.Button btnVerder;
        private System.Windows.Forms.RadioButton rdbJa;
        private System.Windows.Forms.RadioButton rdbNee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbIn01;
        private System.Windows.Forms.Panel pnlOut;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.RadioButton rdbPV;
        private System.Windows.Forms.RadioButton rdbMV;
        private System.Windows.Forms.RadioButton rdbSV;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblBetaaltotaal;
        private System.Windows.Forms.Label lblAatnalPV;
        private System.Windows.Forms.Label lblAatnalMV;
        private System.Windows.Forms.Label lblAatnalSV;
        private System.Windows.Forms.Label lblAantalVakkenUit;
        private System.Windows.Forms.Button btnExit;
    }
}

