namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Visor = new TextBox();
            btnUm = new Button();
            btnDois = new Button();
            btnTrês = new Button();
            btnQuatro = new Button();
            btnCinco = new Button();
            btnSeis = new Button();
            btnSete = new Button();
            btnOito = new Button();
            btnNove = new Button();
            btnZero = new Button();
            btnVírgula = new Button();
            btnIgual = new Button();
            btnMulti = new Button();
            btnDivi = new Button();
            btnSub = new Button();
            btnRemover = new Button();
            btnAdi = new Button();
            btnLimpar1 = new Button();
            btnLimpar2 = new Button();
            lblOperacao = new Label();
            SuspendLayout();
            // 
            // Visor
            // 
            Visor.BorderStyle = BorderStyle.FixedSingle;
            Visor.Font = new Font("Segoe UI", 30F);
            Visor.Location = new Point(12, 22);
            Visor.Name = "Visor";
            Visor.RightToLeft = RightToLeft.No;
            Visor.Size = new Size(364, 61);
            Visor.TabIndex = 0;
            Visor.TextAlign = HorizontalAlignment.Right;
            // 
            // btnUm
            // 
            btnUm.Font = new Font("Segoe UI", 30F);
            btnUm.Location = new Point(12, 167);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(84, 74);
            btnUm.TabIndex = 1;
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = true;
            btnUm.Click += btnUm_Click;
            // 
            // btnDois
            // 
            btnDois.Font = new Font("Segoe UI", 30F);
            btnDois.Location = new Point(102, 167);
            btnDois.Name = "btnDois";
            btnDois.Size = new Size(84, 74);
            btnDois.TabIndex = 11;
            btnDois.Text = "2";
            btnDois.UseVisualStyleBackColor = true;
            btnDois.Click += btnDois_Click;
            // 
            // btnTrês
            // 
            btnTrês.Font = new Font("Segoe UI", 30F);
            btnTrês.Location = new Point(192, 167);
            btnTrês.Name = "btnTrês";
            btnTrês.Size = new Size(84, 74);
            btnTrês.TabIndex = 12;
            btnTrês.Text = "3";
            btnTrês.UseVisualStyleBackColor = true;
            btnTrês.Click += btnTrês_Click;
            // 
            // btnQuatro
            // 
            btnQuatro.Font = new Font("Segoe UI", 30F);
            btnQuatro.Location = new Point(12, 247);
            btnQuatro.Name = "btnQuatro";
            btnQuatro.Size = new Size(84, 74);
            btnQuatro.TabIndex = 13;
            btnQuatro.Text = "4";
            btnQuatro.UseVisualStyleBackColor = true;
            btnQuatro.Click += btnQuatro_Click;
            // 
            // btnCinco
            // 
            btnCinco.Font = new Font("Segoe UI", 30F);
            btnCinco.Location = new Point(102, 247);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(84, 74);
            btnCinco.TabIndex = 14;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            btnCinco.Click += btnCinco_Click;
            // 
            // btnSeis
            // 
            btnSeis.Font = new Font("Segoe UI", 30F);
            btnSeis.Location = new Point(192, 247);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(84, 74);
            btnSeis.TabIndex = 15;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += btnSeis_Click;
            // 
            // btnSete
            // 
            btnSete.Font = new Font("Segoe UI", 30F);
            btnSete.Location = new Point(12, 327);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(84, 74);
            btnSete.TabIndex = 16;
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = true;
            btnSete.Click += btnSete_Click;
            // 
            // btnOito
            // 
            btnOito.Font = new Font("Segoe UI", 30F);
            btnOito.Location = new Point(102, 327);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(84, 74);
            btnOito.TabIndex = 17;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = true;
            btnOito.Click += btnOito_Click;
            // 
            // btnNove
            // 
            btnNove.Font = new Font("Segoe UI", 30F);
            btnNove.Location = new Point(192, 327);
            btnNove.Name = "btnNove";
            btnNove.Size = new Size(84, 74);
            btnNove.TabIndex = 18;
            btnNove.Text = "9";
            btnNove.UseVisualStyleBackColor = true;
            btnNove.Click += btnNove_Click;
            // 
            // btnZero
            // 
            btnZero.Font = new Font("Segoe UI", 30F);
            btnZero.Location = new Point(12, 407);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(174, 74);
            btnZero.TabIndex = 19;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnVírgula
            // 
            btnVírgula.Font = new Font("Segoe UI", 30F);
            btnVírgula.Location = new Point(192, 407);
            btnVírgula.Name = "btnVírgula";
            btnVírgula.Size = new Size(84, 74);
            btnVírgula.TabIndex = 20;
            btnVírgula.Text = ",";
            btnVírgula.UseVisualStyleBackColor = true;
            btnVírgula.Click += btnVírgula_Click;
            // 
            // btnIgual
            // 
            btnIgual.Font = new Font("Segoe UI", 28F);
            btnIgual.Location = new Point(292, 414);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(84, 67);
            btnIgual.TabIndex = 22;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnMulti
            // 
            btnMulti.Font = new Font("Segoe UI", 23F);
            btnMulti.Location = new Point(292, 334);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(84, 74);
            btnMulti.TabIndex = 23;
            btnMulti.Text = "X";
            btnMulti.UseVisualStyleBackColor = true;
            btnMulti.Click += btnMulti_Click;
            // 
            // btnDivi
            // 
            btnDivi.Font = new Font("Segoe UI", 25F);
            btnDivi.Location = new Point(292, 254);
            btnDivi.Name = "btnDivi";
            btnDivi.Size = new Size(84, 74);
            btnDivi.TabIndex = 24;
            btnDivi.Text = "/";
            btnDivi.UseVisualStyleBackColor = true;
            btnDivi.Click += btnDivi_Click;
            // 
            // btnSub
            // 
            btnSub.Font = new Font("Segoe UI", 30F);
            btnSub.Location = new Point(292, 174);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(84, 74);
            btnSub.TabIndex = 25;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btnRemover
            // 
            btnRemover.Font = new Font("Segoe UI", 25F);
            btnRemover.Location = new Point(192, 98);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(84, 63);
            btnRemover.TabIndex = 26;
            btnRemover.Text = "<-";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnAdi
            // 
            btnAdi.Font = new Font("Segoe UI", 30F);
            btnAdi.Location = new Point(292, 98);
            btnAdi.Name = "btnAdi";
            btnAdi.Size = new Size(84, 70);
            btnAdi.TabIndex = 27;
            btnAdi.Text = "+";
            btnAdi.UseVisualStyleBackColor = true;
            btnAdi.Click += btnAdi_Click;
            // 
            // btnLimpar1
            // 
            btnLimpar1.Font = new Font("Segoe UI", 25F);
            btnLimpar1.Location = new Point(102, 98);
            btnLimpar1.Name = "btnLimpar1";
            btnLimpar1.Size = new Size(84, 63);
            btnLimpar1.TabIndex = 28;
            btnLimpar1.Text = "C";
            btnLimpar1.UseVisualStyleBackColor = true;
            btnLimpar1.Click += btnLimpar1_Click;
            // 
            // btnLimpar2
            // 
            btnLimpar2.Font = new Font("Segoe UI", 25F);
            btnLimpar2.Location = new Point(12, 98);
            btnLimpar2.Name = "btnLimpar2";
            btnLimpar2.Size = new Size(84, 63);
            btnLimpar2.TabIndex = 29;
            btnLimpar2.Text = "CE";
            btnLimpar2.UseVisualStyleBackColor = true;
            btnLimpar2.Click += btnLimpar2_Click;
            // 
            // lblOperacao
            // 
            lblOperacao.AutoSize = true;
            lblOperacao.BackColor = Color.White;
            lblOperacao.Font = new Font("Segoe UI", 30F);
            lblOperacao.Location = new Point(21, 24);
            lblOperacao.Name = "lblOperacao";
            lblOperacao.Size = new Size(0, 54);
            lblOperacao.TabIndex = 30;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(388, 492);
            Controls.Add(lblOperacao);
            Controls.Add(btnLimpar2);
            Controls.Add(btnLimpar1);
            Controls.Add(btnAdi);
            Controls.Add(btnRemover);
            Controls.Add(btnSub);
            Controls.Add(btnDivi);
            Controls.Add(btnMulti);
            Controls.Add(btnIgual);
            Controls.Add(btnVírgula);
            Controls.Add(btnZero);
            Controls.Add(btnNove);
            Controls.Add(btnOito);
            Controls.Add(btnSete);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnQuatro);
            Controls.Add(btnTrês);
            Controls.Add(btnDois);
            Controls.Add(btnUm);
            Controls.Add(Visor);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Visor;
        private Button btnUm;
        private Button btnDois;
        private Button btnTrês;
        private Button btnQuatro;
        private Button btnCinco;
        private Button btnSeis;
        private Button btnSete;
        private Button btnOito;
        private Button btnNove;
        private Button btnZero;
        private Button btnVírgula;
        private Button btnIgual;
        private Button btnMulti;
        private Button btnDivi;
        private Button btnSub;
        private Button btnRemover;
        private Button btnAdi;
        private Button btnLimpar1;
        private Button btnLimpar2;
        private Label lblOperacao;
    }
}
