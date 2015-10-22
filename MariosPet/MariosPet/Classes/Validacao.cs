using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MariosPet.Classes
{
    class Validacao
    {

       
        public bool validaAnimal(Animal animal)
        {
            bool entrou = true;
            if (animal.nome.Length < 3)
            {
                MessageBox.Show("Insira o nome do animal!");
                entrou = false;

            }
            return entrou;

        }


        
        public bool validaCliente(Cliente cliente) // nao tem nada na classe
        {
            bool entrou = true;
            if (cliente.nome.Length < 3)
            {
                MessageBox.Show("Insira o nome!");
                entrou = false;

            }
           
            return entrou;
        }

        public bool validaEndereco(Endereco endereco)
        {
            bool entrou = true;
            if (endereco.rua.Length < 3)
            {
                MessageBox.Show("Insira o nome da rua!");
                entrou = false;
            }
            if (endereco.numero.Length < 1) //colocar . Length quando udar numero para string
            {
                MessageBox.Show("Insira o número!");
                entrou = false;
            }
            return entrou;
        }

        public bool validaFichaClinica (FichaClinica fichaClinica)
        {
            bool entrou = true;
            if (fichaClinica.historicoClinico.Length < 3)
            {
                MessageBox.Show("Insira o histórico Clinico!");
                entrou = false;

            }
            if (fichaClinica.queixaPrincipal.Length < 3)
            {
                MessageBox.Show("Insira a queixa principal!");
                entrou = false;

            }
            return entrou;

        }

        public bool validaFornecedor (Fornecedor fornecedor) 
        {
            bool entrou = true;
            if (fornecedor.ramoAtividade.Length < 3) 
            {
                MessageBox.Show("Insira o ramo do fornecedor!");
                entrou = false;
            }

            if (fornecedor.nomeContato.Length < 3) //ver se nao houve alteração posterior na classe
            {
                MessageBox.Show("Insira o nome do contato!");
                entrou = false;
            }
            return entrou;
        
        }

        public bool validaFuncionario (Funcionario funcionario) 
        {
            bool entrou = true;
            if (funcionario.tipo.Length < 3)
            {
                MessageBox.Show("Insira o tipo de funcionário!");
                entrou = false;
            }
            if (funcionario.apelido.Length < 4)
            {
                MessageBox.Show("Insira um apelido com pelo menos 4 letras!");
                entrou = false;
            }
            if (funcionario.senha.Length < 4)
            {
                MessageBox.Show("Insira uma senha com pelo menos 6 dígitos!");
                entrou = false;
            }
            return entrou;
        
        }

        public bool validaMedicamento(Medicamento medicamento) // ver o que é realmente obrigatório
        {
            bool entrou = true;
            if (medicamento.descricao.Length < 3)
            {
                MessageBox.Show("Insira o tipo de funcionário!");
                entrou = false;
            }
            return entrou;
        }

        public bool validaPessoa(Pessoa pessoa)
        {
            bool entrou = true;
            if (pessoa.nome.Length < 3)
            {
                MessageBox.Show("Insira o nome!");
                entrou = false;
            }
            if (pessoa.rg.Length < 6)
            {
                MessageBox.Show("Insira o RG!");
                entrou = false;
            }
            if (pessoa.cpf.Length < 6)
            {
                MessageBox.Show("Insira o CPF!");
                entrou = false;
            }
            if (pessoa.telefone1.Length <= 6)
            {
                MessageBox.Show("Insira pelo menos um telefone para contato!");
                entrou = false;
            }
            return entrou;
        }

        public bool validaPessoaJuridica(PessoaJuridica pessoaJuridica)
        {
            bool entrou = true;
            if (pessoaJuridica.razaoSocial.Length < 3)
            {
                MessageBox.Show("Insira a Razão Social!");
                entrou = false;
            }
            if (pessoaJuridica.cnpj.Length < 6)
            {
                MessageBox.Show("Insira o CNPJ!");
                entrou = false;
            }
            if (pessoaJuridica.telefone1.Length <= 6)
            {
                MessageBox.Show("Insira pelo menos um telefone para contato!");
                entrou = false;
            }
            return entrou;
        }

        public bool validaProduto(Produto produto)
        {
            bool entrou = true;
            if (produto.descricao.Length < 3) // na tela nao tem campo descrição, tem campo nome
            {
                MessageBox.Show("Insira o nome o produto!");
                entrou = false;
            }
            if (produto.setor.Length < 6) // Na tela tem um ComboBox
            {
                MessageBox.Show("Selecione um setor!");
                entrou = false;
            }
            if (produto.fabricante.Length < 3)
            {
                MessageBox.Show("Insira o Fabricante!");
                entrou = false;
            }
            if (produto.valorCusto <= 0)
            {
                MessageBox.Show("Insira o valor de Custo!");
                entrou = false;
            }
            if (produto.valorVenda <= 0)
            {
                MessageBox.Show("Insira o valor de Venda!");
                entrou = false;
            }
            return entrou;
        }
        public bool validaServico(Servico servico)
        {
            bool entrou = true;
            if (servico.descricao.Length < 3)
            {
                MessageBox.Show("Insira a descrição do serviço!");
                entrou = false;
            }
            if (servico.preco <= 0)
            {
                MessageBox.Show("Insira o Preço!");
                entrou = false;
            }
            return entrou;
        }

        public bool validaVeterinario(Veterinario veterinario)
        {
            bool entrou = true;
            if (veterinario.crmv <= 3) // O CRMV está como int na classe, tem que mudar para String, pois as vezes tem letras.
            {
                MessageBox.Show("Insira o CRMV do veterinário!");
                entrou = false;
            }
            return entrou;
        }     

    }

}