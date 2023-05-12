namespace JogodaForca.WinFormsApp
{
    public partial class Form1 : Form
    {
        string palavra, tentadas;
        char letra;
        int quantidade = 0;
        int erros = 0;
        int faltam = 0;
        bool achou = false;
        bool tenta = false;


        char[] escondido;

        public Form1()
        {
            InitializeComponent();
            escondido = new char[20];
        }


        private void buttonComecar_Click(object sender, EventArgs e)
        {
            palavra = textBoxPalavra.Text;
            quantidade = palavra.Length;
            faltam = quantidade;
            labelLetrasEscolhidas.Text = "";


            for (int cont = 0; cont != quantidade; cont++)
            {
                escondido[cont] = '*';
                labelLetrasEscolhidas.Text += escondido[cont];
            }
            erros = 0;

            pictureBoxForca.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            textBoxPalavra.Enabled = false;
            buttonComecar.Enabled = false;
            maskedTextBoxLetra.Enabled = true;
            buttonEscolher.Enabled = true;
            maskedTextBoxLetra.Focus();
            labelNumeroFaltam.Text = faltam.ToString();
            labelNumeroErros.Text = erros.ToString();


        }

        private void buttonEscolher_Click(object sender, EventArgs e)
        {
            letra = maskedTextBoxLetra.Text[0];
            for (int cont = 0; cont != quantidade; cont++)
            {
                if (letra == escondido[cont])
                { tenta = true; }
            }

            tentadas = labelNumeroTentativas.Text;
            int quant = tentadas.Length;

            for (int cont = 0; cont != quant; cont++)
            {
                if (letra == tentadas[cont]) ;
            }

            if (tenta == true)
            {
                MessageBox.Show("Você já digitou essa letra");
            }
            else
            {
                for (int cont = 0; cont != quantidade; cont++)
                {
                    if (letra == palavra[cont])
                    {
                        escondido[cont] = letra;
                        achou = true;
                        faltam += -1;
                    }
                }
            }
            labelLetrasEscolhidas.Text = "";
            for (int cont = 0; cont != quantidade; cont++)
            {
                labelLetrasEscolhidas.Text += escondido[cont];
            }

            if (faltam == 0)
            {
                MessageBox.Show("Parabéns! Você venceu!!");
                textBoxPalavra.Enabled = true;
                buttonComecar.Enabled = true;
                maskedTextBoxLetra.Enabled = false;
                buttonEscolher.Enabled = false;
                textBoxPalavra.Text = "";
                textBoxPalavra.Focus();
            }
            if ((achou == false) & (tenta == false))
            {

                erros += 1;
                labelNumeroTentativas.Text += letra;
            }
            if ( erros == 0)
            {
                pictureBoxForca.Visible = true;
            }
            if (erros == 1)
            {
                pictureBox1.Visible = true;
            
            }

            if (erros == 2)
            {
                
                pictureBox2.Visible = true; 
            }

            if (erros == 3)
            {
                
                pictureBox3.Visible = true; 
            }

            if (erros == 4)
            { 
                pictureBox4.Visible = true; 
            }

            if (erros == 5)
            { 
                pictureBox5.Visible = true;
            }

            if (erros == 6)
            {
                pictureBox7.Visible = true;


                MessageBox.Show("Você Perdeu!");
                textBoxPalavra.Enabled = true;
                buttonComecar.Enabled = true;
                maskedTextBoxLetra.Enabled = false;
                buttonEscolher.Enabled = false;
                textBoxPalavra.Text = "";
                textBoxPalavra.Focus();


            }

            tenta = false;
            achou = false;
            maskedTextBoxLetra.Text = "";
            maskedTextBoxLetra.Focus();

            labelNumeroFaltam.Text = faltam.ToString();
            labelNumeroErros.Text = erros.ToString();

        }



        #region
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPalavra_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {

        }
        #endregion


    }
}