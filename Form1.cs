using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AULA09.Controller;
using AULA09.Model;

namespace AULA09
{
    public partial class Form1 : Form
    {
        private ControllerCliente cc = new ControllerCliente();

        public Form1()
        {
            InitializeComponent();
            AtualizarLista();
        }
        private void AtualizarLista()
        {
            List<Cliente> clientes = cc.CarregarDados();
            list_clientes.Items.Clear();
            foreach( Cliente cliente in clientes)
            {
                list_clientes.Items.Add(cliente);
            }
        }
      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = tb_nome.Text;
            string email = tb_email.Text;   
            int idade = int.Parse(tb_idade.Text);
            cc.CadastrarCliente(nome, email, idade);
            AtualizarLista();
        }

        private void bt_Deletar_Click(object sender, EventArgs e)
        {
            List<Cliente> clientes = cc.CarregarDados();
            if (list_clientes.SelectedIndex != -1)
            {
                int index = list_clientes.SelectedIndex;

                if (index >= 0 && index < clientes.Count)
                {
                    clientes.RemoveAt(index);
                    cc.clientes = clientes;
                    cc.SalvarDados();
                    AtualizarLista();
                }
            }
            else
            {
                MessageBox.Show("Selecione um cliente para deletar.");
            }
        }

        private void list_clientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

  }

