namespace DesafioIMasters
{
    public partial class frmVerifica : Form
    {
        public frmVerifica()
        {
            InitializeComponent();
        }

        char entrada;
        int valor;

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            try { 
            entrada = Convert.ToChar(txtCaractere.Text);
            valor = Convert.ToInt32(entrada);
            if (valor >= 65 && valor <= 90)
            {
               lblCaractere.Text = "String Maiúscula";
            }
            if (valor >= 97 && valor <= 122)
            {
                lblCaractere.Text = "String Minúscula";
            }
            if (valor >= 48 && valor <= 57)
            {
                lblCaractere.Text = "Dígito";
            }
            if (valor == 0 && valor <= 47 || valor >= 58 && valor <= 64 || valor >= 91 && valor <= 96 || valor >= 123 && valor <= 127)
            {
                lblCaractere.Text = "Símbolo Especial";
            }
            if (valor >= 127)
            {
                lblCaractere.Text = "Caractere Especial";
            }
            }
            catch(FormatException) {
                string messageBoxText = "Por favor insira apenas um caractere.";
                string titulo = "Erro!";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;
                

                MessageBox.Show(messageBoxText, titulo, button, icon);
            }
        }

        private void frmVerifica_Load(object sender, EventArgs e)
        {

        }
    }
}