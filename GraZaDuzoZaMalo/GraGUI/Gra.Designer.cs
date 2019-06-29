namespace GraGUI
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
            this.components = new System.ComponentModel.Container();
            this.buttonNowaGra = new System.Windows.Forms.Button();
            this.groupBoxLosuj = new System.Windows.Forms.GroupBox();
            this.buttonLosuj = new System.Windows.Forms.Button();
            this.textBoxDo = new System.Windows.Forms.TextBox();
            this.labelDo = new System.Windows.Forms.Label();
            this.textBoxOd = new System.Windows.Forms.TextBox();
            this.labelOd = new System.Windows.Forms.Label();
            this.PropozycjaBox = new System.Windows.Forms.TextBox();
            this.sprbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.wylosowanalabel = new System.Windows.Forms.Label();
            this.odgadywaniebox = new System.Windows.Forms.GroupBox();
            this.butttonpoddaj = new System.Windows.Forms.Button();
            this.buttonhistoria = new System.Windows.Forms.Button();
            this.czaslabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBoxLosuj.SuspendLayout();
            this.odgadywaniebox.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNowaGra
            // 
            this.buttonNowaGra.Location = new System.Drawing.Point(20, 20);
            this.buttonNowaGra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonNowaGra.Name = "buttonNowaGra";
            this.buttonNowaGra.Size = new System.Drawing.Size(112, 35);
            this.buttonNowaGra.TabIndex = 0;
            this.buttonNowaGra.Text = "Nowa gra";
            this.buttonNowaGra.UseVisualStyleBackColor = true;
            this.buttonNowaGra.Click += new System.EventHandler(this.buttonNowaGra_Click);
            // 
            // groupBoxLosuj
            // 
            this.groupBoxLosuj.Controls.Add(this.buttonLosuj);
            this.groupBoxLosuj.Controls.Add(this.textBoxDo);
            this.groupBoxLosuj.Controls.Add(this.labelDo);
            this.groupBoxLosuj.Controls.Add(this.textBoxOd);
            this.groupBoxLosuj.Controls.Add(this.labelOd);
            this.groupBoxLosuj.Location = new System.Drawing.Point(20, 80);
            this.groupBoxLosuj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxLosuj.Name = "groupBoxLosuj";
            this.groupBoxLosuj.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxLosuj.Size = new System.Drawing.Size(453, 154);
            this.groupBoxLosuj.TabIndex = 1;
            this.groupBoxLosuj.TabStop = false;
            this.groupBoxLosuj.Text = "Losowanie";
            this.groupBoxLosuj.Visible = false;
            // 
            // buttonLosuj
            // 
            this.buttonLosuj.Location = new System.Drawing.Point(310, 62);
            this.buttonLosuj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLosuj.Name = "buttonLosuj";
            this.buttonLosuj.Size = new System.Drawing.Size(112, 35);
            this.buttonLosuj.TabIndex = 2;
            this.buttonLosuj.Text = "Wylosuj";
            this.buttonLosuj.UseVisualStyleBackColor = true;
            this.buttonLosuj.Click += new System.EventHandler(this.buttonLosuj_Click);
            // 
            // textBoxDo
            // 
            this.textBoxDo.Location = new System.Drawing.Point(123, 97);
            this.textBoxDo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDo.Name = "textBoxDo";
            this.textBoxDo.Size = new System.Drawing.Size(148, 26);
            this.textBoxDo.TabIndex = 3;
            // 
            // labelDo
            // 
            this.labelDo.AutoSize = true;
            this.labelDo.Location = new System.Drawing.Point(26, 102);
            this.labelDo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDo.Name = "labelDo";
            this.labelDo.Size = new System.Drawing.Size(84, 20);
            this.labelDo.TabIndex = 2;
            this.labelDo.Text = "Zakres do:";
            // 
            // textBoxOd
            // 
            this.textBoxOd.Location = new System.Drawing.Point(123, 26);
            this.textBoxOd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxOd.Name = "textBoxOd";
            this.textBoxOd.Size = new System.Drawing.Size(148, 26);
            this.textBoxOd.TabIndex = 1;
            // 
            // labelOd
            // 
            this.labelOd.AutoSize = true;
            this.labelOd.Location = new System.Drawing.Point(27, 31);
            this.labelOd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOd.Name = "labelOd";
            this.labelOd.Size = new System.Drawing.Size(84, 20);
            this.labelOd.TabIndex = 0;
            this.labelOd.Text = "Zakres od:";
            // 
            // PropozycjaBox
            // 
            this.PropozycjaBox.Location = new System.Drawing.Point(162, 38);
            this.PropozycjaBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PropozycjaBox.Name = "PropozycjaBox";
            this.PropozycjaBox.Size = new System.Drawing.Size(148, 26);
            this.PropozycjaBox.TabIndex = 5;
            // 
            // sprbutton
            // 
            this.sprbutton.Location = new System.Drawing.Point(318, 31);
            this.sprbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sprbutton.Name = "sprbutton";
            this.sprbutton.Size = new System.Drawing.Size(104, 41);
            this.sprbutton.TabIndex = 6;
            this.sprbutton.Text = "Sprawdź";
            this.sprbutton.UseVisualStyleBackColor = true;
            this.sprbutton.Click += new System.EventHandler(this.sprbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Twoja propozycja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 8;
            // 
            // wylosowanalabel
            // 
            this.wylosowanalabel.AutoSize = true;
            this.wylosowanalabel.Location = new System.Drawing.Point(17, 255);
            this.wylosowanalabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wylosowanalabel.Name = "wylosowanalabel";
            this.wylosowanalabel.Size = new System.Drawing.Size(302, 20);
            this.wylosowanalabel.TabIndex = 9;
            this.wylosowanalabel.Text = "Liczba wylosowana! Spróbuj ją odgadnąć!";
            this.wylosowanalabel.Visible = false;
            // 
            // odgadywaniebox
            // 
            this.odgadywaniebox.Controls.Add(this.butttonpoddaj);
            this.odgadywaniebox.Controls.Add(this.PropozycjaBox);
            this.odgadywaniebox.Controls.Add(this.sprbutton);
            this.odgadywaniebox.Controls.Add(this.label2);
            this.odgadywaniebox.Location = new System.Drawing.Point(20, 292);
            this.odgadywaniebox.Name = "odgadywaniebox";
            this.odgadywaniebox.Size = new System.Drawing.Size(453, 157);
            this.odgadywaniebox.TabIndex = 10;
            this.odgadywaniebox.TabStop = false;
            this.odgadywaniebox.Text = "Odgadywanie";
            this.odgadywaniebox.Visible = false;
            // 
            // butttonpoddaj
            // 
            this.butttonpoddaj.Location = new System.Drawing.Point(342, 111);
            this.butttonpoddaj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butttonpoddaj.Name = "butttonpoddaj";
            this.butttonpoddaj.Size = new System.Drawing.Size(104, 38);
            this.butttonpoddaj.TabIndex = 8;
            this.butttonpoddaj.Text = "Poddaj się";
            this.butttonpoddaj.UseVisualStyleBackColor = true;
            this.butttonpoddaj.Click += new System.EventHandler(this.buttonpoddaj);
            // 
            // buttonhistoria
            // 
            this.buttonhistoria.Location = new System.Drawing.Point(26, 456);
            this.buttonhistoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonhistoria.Name = "buttonhistoria";
            this.buttonhistoria.Size = new System.Drawing.Size(104, 38);
            this.buttonhistoria.TabIndex = 9;
            this.buttonhistoria.Text = "Historia Gry";
            this.buttonhistoria.UseVisualStyleBackColor = true;
            this.buttonhistoria.Visible = false;
            this.buttonhistoria.Click += new System.EventHandler(this.buttonhistoria_Click);
            // 
            // czaslabel
            // 
            this.czaslabel.AutoSize = true;
            this.czaslabel.Location = new System.Drawing.Point(358, 27);
            this.czaslabel.Name = "czaslabel";
            this.czaslabel.Size = new System.Drawing.Size(0, 20);
            this.czaslabel.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 508);
            this.Controls.Add(this.buttonhistoria);
            this.Controls.Add(this.czaslabel);
            this.Controls.Add(this.odgadywaniebox);
            this.Controls.Add(this.wylosowanalabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBoxLosuj);
            this.Controls.Add(this.buttonNowaGra);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxLosuj.ResumeLayout(false);
            this.groupBoxLosuj.PerformLayout();
            this.odgadywaniebox.ResumeLayout(false);
            this.odgadywaniebox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNowaGra;
        private System.Windows.Forms.GroupBox groupBoxLosuj;
        private System.Windows.Forms.Button buttonLosuj;
        private System.Windows.Forms.TextBox textBoxDo;
        private System.Windows.Forms.Label labelDo;
        private System.Windows.Forms.TextBox textBoxOd;
        private System.Windows.Forms.Label labelOd;
        private System.Windows.Forms.TextBox PropozycjaBox;
        private System.Windows.Forms.Button sprbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label wylosowanalabel;
        private System.Windows.Forms.GroupBox odgadywaniebox;
        private System.Windows.Forms.Button buttonhistoria;
        private System.Windows.Forms.Button butttonpoddaj;
        private System.Windows.Forms.Label czaslabel;
        private System.Windows.Forms.Timer timer1;
    }
}

