using MachadosCore;
using MachadosCore.Clientes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class AdicionarPacientes : WindowsFormsApp1.Forms.Intermediario
    {
        int a;
        List<List<Label>> labels = new List<List<Label>>();
        bool vizualizar = false;
        public AdicionarPacientes()
        {
            InitializeComponent();
            int a = gerenciadorP._itens.Count - 1;
        }

        private void AdicionarPacientes_Load(object sender, EventArgs e)
        {
           
            NomeTextBox.Text = "Tomas";
            RgTextBox.Text = "90-90-90";
            CpfTextBox.Text = "90-9";
            ValorTextBox.Text = "100";
            DiaDaSemanaTextBox.Text = "Quinta";
            HorarioTextBox.Text = "2019/12/12/00:59";
            PlanoTextBox.Text = "Bradesco";
        }

        private void AdicionarClienteBotao_Click(object sender, EventArgs e)
        {
            Paciente pacienteTemporario = new Paciente()
            {
                NomeCompleto = NomeTextBox.Text,
                RG = RgTextBox.Text,
                Cpf = CpfTextBox.Text,
                Valor = int.Parse(ValorTextBox.Text),
                DiaDaSemana = DiaDaSemanaTextBox.Text,
                Horario = DateTime.Now,
                PlanoDeSaude = PlanoTextBox.Text,
                UltimoRecibo = DateTime.Now,
                Indice = gerenciadorP._itens.Count - 1
            };
            gerenciadorP.Adicionar(pacienteTemporario);


            while (gerenciadorP.valor != 4)
            {

                int a = gerenciadorP._itens.Count - 1;
                Application.DoEvents();
                listBox1.Items.Add($"O Paciente {gerenciadorP._itens[a].NomeCompleto }," +
                       $",Paciente numero {gerenciadorP._itens[a].Indice} " +
                       $", seu ultimo recibo {gerenciadorP._itens[a].UltimoRecibo}" +
                       $", seu Rg é  {gerenciadorP._itens[a].RG} ");
                gerenciadorP.valor = 4;

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoNovo = listBox1.SelectedItem.ToString();
            int indice = FoundOIndice(textoNovo);

            MessageBox.Show("" + indice);
            string paciente = $"Nome {gerenciadorP._itens[a + 1].NomeCompleto }, " +
                $"Rg {gerenciadorP._itens[indice].RG} " +
                $"Cpf {gerenciadorP._itens[indice].Cpf } " +
                $"Valor {gerenciadorP._itens[indice].Valor}" +
                $"Plano {gerenciadorP._itens[indice].PlanoDeSaude} " +
                $"Horario {gerenciadorP._itens[indice].Horario}";

            // Criar Arquivo 
            var caminhoNovoArquivo = "contasExportadas.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDeArquivo, Encoding.UTF8))
            {
                escritor.Write(paciente);
            }


            gerenciadorP._itens[a].Horario = DateTime.Now;
            listBox1.SelectedItem = ($"O Paciente {gerenciadorP._itens[a].NomeCompleto }," +
                       $",Paciente numero {gerenciadorP._itens[a].Indice} " +
                       $", seu ultimo recibo {gerenciadorP._itens[a].Horario}" +
                       $", seu Rg é  {gerenciadorP._itens[a].RG} ");

            Enumerar();
        }
        public int FoundOIndice(string stringIndice)
        {
            string padrao =
            "[0123456789]";
            //adicionar +1 
            Match resultado = Regex.Match(stringIndice, padrao);
            int indice = int.Parse(resultado.Value);
            MessageBox.Show($"{indice + 1}");

            return indice + 1;
        }

        void tabeladeHorarios()
        {
            string textoNovo = listBox1.SelectedItem.ToString();
            FoundOIndice(textoNovo);
        }

        private void btnTabela_Click(object sender, EventArgs e)
        {
            for (int i = 0; i == 7; i++)
            {
               
            }
        }

        void Enumerar() // Metodo para 
        {
            MessageBox.Show("PAO");
            List<string> dia = new List<string>();
            int retornada = -1;


            for (int i = 0; i <= gerenciadorP._itens.Count ; i++)
            {  
                MessageBox.Show($"{i}");
                gerenciadorP.valor = 3;
                
                while (gerenciadorP.valor == 3)
                    i = 0;
                {
                  
                    if (i <= 0)
                    {
                        string temporaria = gerenciadorP._itens[0].DiaDaSemana;
                        dia.Add(temporaria);
                        //dia[0] = gerenciadorP._itens[0].DiaDaSemana;
                    }
                    else
                    {
                        string temporaria = gerenciadorP._itens[i].DiaDaSemana;
                        dia.Add(temporaria);
                    }
                    gerenciadorP.valor = 4;
                }
                string[] diaSplit = dia[i].Split('-');
               
              
                foreach (var word in diaSplit)
                {
                    diaSplit[i].Trim();
                    diaSplit[i].ToUpper();
                    
                    Console.WriteLine($"<{word}>");
                    switch (word)
                    {

                        case "-FEIRA":
                            gerenciadorP._itens[i].MaiorMenor = -1;
                            break;
                        case "DOMINGO":
                            gerenciadorP._itens[i].MaiorMenor = 0;
                            break;
                        case "Segunda":
                            gerenciadorP._itens[i].MaiorMenor = 1;
                            break;
                        case "Terça":
                            gerenciadorP._itens[i].MaiorMenor = 2;
                            break;
                        case "Quarta":
                            gerenciadorP._itens[i].MaiorMenor = 3;
                            break;
                        case "Quinta":
                            gerenciadorP._itens[i].MaiorMenor = 4;
                            break;
                        case "Sexta":
                            gerenciadorP._itens[i].MaiorMenor = 5;
                            break;
                        case "Sábado":
                            gerenciadorP._itens[i].MaiorMenor = 6;
                            break;



                        default:
                            
                            break;
                    }
                }

                retornada = i;
            }

            //return gerenciadorP._itens[retornada].MaiorMenor;


        }
    }
}

