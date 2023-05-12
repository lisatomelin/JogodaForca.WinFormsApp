namespace JogodaForca.WinFormsApp
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
            label1 = new Label();
            textBoxPalavra = new TextBox();
            label2 = new Label();
            buttonComecar = new Button();
            buttonEscolher = new Button();
            label3 = new Label();
            label4 = new Label();
            labelLetrasEscolhidas = new Label();
            label6 = new Label();
            label7 = new Label();
            labelNumeroFaltam = new Label();
            labelNumeroErros = new Label();
            maskedTextBoxLetra = new MaskedTextBox();
            label11 = new Label();
            pictureBoxForca = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            labelNumeroTentativas = new Label();
            pictureBox7 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForca).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(126, 35);
            label1.Name = "label1";
            label1.Size = new Size(191, 30);
            label1.TabIndex = 8;
            label1.Text = "JOGO DA FORCA";
            // 
            // textBoxPalavra
            // 
            textBoxPalavra.Location = new Point(140, 144);
            textBoxPalavra.Name = "textBoxPalavra";
            textBoxPalavra.PasswordChar = '*';
            textBoxPalavra.Size = new Size(181, 23);
            textBoxPalavra.TabIndex = 10;
            textBoxPalavra.TextChanged += textBoxPalavra_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(162, 100);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 11;
            label2.Text = "DIGITE UMA PALAVRA";
            // 
            // buttonComecar
            // 
            buttonComecar.BackColor = Color.GreenYellow;
            buttonComecar.Location = new Point(177, 205);
            buttonComecar.Name = "buttonComecar";
            buttonComecar.Size = new Size(94, 76);
            buttonComecar.TabIndex = 12;
            buttonComecar.Text = "VAMOS COMEÇAR!";
            buttonComecar.UseVisualStyleBackColor = false;
            buttonComecar.Click += buttonComecar_Click;
            // 
            // buttonEscolher
            // 
            buttonEscolher.BackColor = Color.GreenYellow;
            buttonEscolher.Enabled = false;
            buttonEscolher.Location = new Point(177, 435);
            buttonEscolher.Name = "buttonEscolher";
            buttonEscolher.Size = new Size(94, 54);
            buttonEscolher.TabIndex = 15;
            buttonEscolher.Text = "ESCOLHER";
            buttonEscolher.UseVisualStyleBackColor = false;
            buttonEscolher.Click += buttonEscolher_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(162, 350);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 14;
            label3.Text = "DIGITE UMA LETRA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(397, 236);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 16;
            label4.Text = "PALAVRA:";
            // 
            // labelLetrasEscolhidas
            // 
            labelLetrasEscolhidas.AutoSize = true;
            labelLetrasEscolhidas.Location = new Point(480, 236);
            labelLetrasEscolhidas.Name = "labelLetrasEscolhidas";
            labelLetrasEscolhidas.Size = new Size(32, 15);
            labelLetrasEscolhidas.TabIndex = 17;
            labelLetrasEscolhidas.Text = "-----";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(348, 321);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 26;
            label6.Text = "FALTAM:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(480, 321);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 27;
            label7.Text = "ERROS:";
            // 
            // labelNumeroFaltam
            // 
            labelNumeroFaltam.AutoSize = true;
            labelNumeroFaltam.Location = new Point(413, 321);
            labelNumeroFaltam.Name = "labelNumeroFaltam";
            labelNumeroFaltam.Size = new Size(13, 15);
            labelNumeroFaltam.TabIndex = 28;
            labelNumeroFaltam.Text = "0";
            // 
            // labelNumeroErros
            // 
            labelNumeroErros.AutoSize = true;
            labelNumeroErros.Location = new Point(545, 321);
            labelNumeroErros.Name = "labelNumeroErros";
            labelNumeroErros.Size = new Size(13, 15);
            labelNumeroErros.TabIndex = 29;
            labelNumeroErros.Text = "0";
            // 
            // maskedTextBoxLetra
            // 
            maskedTextBoxLetra.Enabled = false;
            maskedTextBoxLetra.Location = new Point(140, 393);
            maskedTextBoxLetra.Mask = "a";
            maskedTextBoxLetra.Name = "maskedTextBoxLetra";
            maskedTextBoxLetra.Size = new Size(181, 23);
            maskedTextBoxLetra.TabIndex = 32;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(397, 283);
            label11.Name = "label11";
            label11.Size = new Size(72, 15);
            label11.TabIndex = 31;
            label11.Text = "TENTATIVAS:";
            // 
            // pictureBoxForca
            // 
            pictureBoxForca.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxForca.Image = Properties.Resources._1;
            pictureBoxForca.Location = new Point(713, 77);
            pictureBoxForca.Name = "pictureBoxForca";
            pictureBoxForca.Size = new Size(302, 339);
            pictureBoxForca.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxForca.TabIndex = 33;
            pictureBoxForca.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources._2;
            pictureBox1.Location = new Point(713, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(302, 339);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources._3;
            pictureBox2.Location = new Point(713, 77);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(302, 339);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 35;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.Image = Properties.Resources._4;
            pictureBox3.Location = new Point(713, 77);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(302, 339);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 36;
            pictureBox3.TabStop = false;
            pictureBox3.Visible = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox4.Image = Properties.Resources._5;
            pictureBox4.Location = new Point(713, 77);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(302, 339);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 37;
            pictureBox4.TabStop = false;
            pictureBox4.Visible = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox5.Image = Properties.Resources._6;
            pictureBox5.Location = new Point(713, 77);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(302, 339);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 39;
            pictureBox5.TabStop = false;
            pictureBox5.Visible = false;
            // 
            // labelNumeroTentativas
            // 
            labelNumeroTentativas.AutoSize = true;
            labelNumeroTentativas.Location = new Point(483, 283);
            labelNumeroTentativas.Name = "labelNumeroTentativas";
            labelNumeroTentativas.Size = new Size(0, 15);
            labelNumeroTentativas.TabIndex = 17;
            // 
            // pictureBox7
            // 
            pictureBox7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox7.Image = Properties.Resources._7;
            pictureBox7.Location = new Point(713, 77);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(302, 339);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 40;
            pictureBox7.TabStop = false;
            pictureBox7.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1093, 514);
            Controls.Add(pictureBox7);
            Controls.Add(labelNumeroTentativas);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBoxForca);
            Controls.Add(maskedTextBoxLetra);
            Controls.Add(label11);
            Controls.Add(labelNumeroErros);
            Controls.Add(labelNumeroFaltam);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(labelLetrasEscolhidas);
            Controls.Add(label4);
            Controls.Add(buttonEscolher);
            Controls.Add(label3);
            Controls.Add(buttonComecar);
            Controls.Add(label2);
            Controls.Add(textBoxPalavra);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Jogo Da Forca";
            ((System.ComponentModel.ISupportInitialize)pictureBoxForca).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textBoxPalavra;
        private TextBox textBox1;
        private Label label2;
        private Button buttonComecar;
        private Button buttonEscolher;
        private Button button1;
        private Button button2;
        private Label label3;
        private Label label4;
        private Label labelLetrasEscolhidas;
        private Label label6;
        private Label label7;
        private Label labelNumeroFaltam;
        private Label labelNumeroErros;
        private MaskedTextBox maskedTextBoxLetra;
        private Label label11;
        private PictureBox pictureBoxForca;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label labelNumeroTentativas;
        private PictureBox pictureBox7;
    }
}