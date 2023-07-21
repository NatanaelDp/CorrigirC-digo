using Aula08Estoque;

namespace Aula10Estacionamento
{
    public partial class Form1 : Form
    {
        List<string> placa = new List<string>();
        Utilidades utilidades = new Utilidades();

        public Form1()
        {
            InitializeComponent();
        }
        void adicionaCarro()
        {
            if (utilidades.textBoxEstaVazio(txtRecebePlaca) == true)
            {
                MessageBox.Show("O campo está vazio");
                return;
            }
            string nome = txtRecebePlaca.Text;

            placa.Add(nome);
        }
        void atualizaInterface()
        {
            listView1.Items.Add(txtRecebePlaca.Text);
        }
         void retirar()
        {
            if (listaEstaVazia() == true)
            {
                MessageBox.Show("Você não pode retirar !");
            }
            else
            {
                listView1.Items.RemoveAt(0);
            }
            
                
        }
        bool listaEstaVazia()
        {
            if (placa.Count() > 0)
            {
                return (false);

            }
            else
            {
                return (true);
            }
        }


        private void btnEstacionar_Click(object sender, EventArgs e)
        {
           adicionaCarro();
           atualizaInterface();


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            retirar();
        }
    }
}