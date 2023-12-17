using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp16ListasTiposPrimitivos
{
    internal class Exemplo02
    {
        public void Executar()
        {
            List<string> alunos = new List<string>();
            List<int> nota1 = new List<int>();
            List<int> nota2 = new List<int>();
            List<int> nota3 = new List<int>();

            Console.WriteLine("1 - Cadastrar");
            Console.WriteLine("2 - Alterar");
            Console.WriteLine("3 - Listar");
            Console.WriteLine("4 - Apagar");
            Console.WriteLine("0 - Sair");
            Console.Write("Digite a opção desejada: ");

            int escolha = Convert.ToInt32(Console.ReadLine());


            while (escolha != 0)
            {
                Console.Clear();

                if (escolha == 1)
                {
                    Console.Write("Dígite o nome do aluno: ");
                    string nome = Console.ReadLine();
                    alunos.Add(nome);
                    Console.Write("Dígite a nota 1: ");
                    nota1.Add(Convert.ToInt32(Console.ReadLine()));
                    Console.Write("Dígite a nota 2: ");
                    nota2.Add(Convert.ToInt32(Console.ReadLine()));
                    Console.Write("Dígite a nota 3: ");
                    nota3.Add(Convert.ToInt32(Console.ReadLine()));
                }
                else if (escolha == 2)
                {
                    Console.Write("Dígite qual informação você deseja alterar: ");
                    string qualAlterar = Console.ReadLine().Trim();
                    int indexDaAlteracao = alunos.IndexOf(qualAlterar);
                    Console.Write("Deseja alterar o nome? [S] [N]: ");
                    string alterarNome = Console.ReadLine().ToUpper();

                    if (alterarNome == "S")
                    {
                        Console.Write("O Nome: ");
                        alunos[indexDaAlteracao] = Console.ReadLine();
                        Console.WriteLine("Altere as notas 1: ");
                        nota1[indexDaAlteracao] = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Altere as notas 2: ");
                        nota2[indexDaAlteracao] = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Altere as notas 3: ");
                        nota3[indexDaAlteracao] = Convert.ToInt32(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Altere as notas 1: ");
                        nota1[indexDaAlteracao] = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Altere as notas 2: ");
                        nota2[indexDaAlteracao] = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Altere as notas 3: ");
                        nota3[indexDaAlteracao] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                else if (escolha == 3)
                {
                    Console.WriteLine("Lista de alunos: ");
                    for (int i = 0; i < alunos.Count; i++)
                    {
                        Console.WriteLine($"Nome: {alunos[i]}\n" +
                                          $"Nota 1: {nota1[i]} \n" +
                                          $"Nota 2: {nota2[i]} \n" +
                                          $"Nota 3: {nota3[i]} \n");
                        int media = (nota1[i] + nota2[i] + nota3[i]) / 3;
                        Console.WriteLine($"Média é {media}");
                    }
                    Thread.Sleep(5000);

                }
                else if (escolha == 4)
                {
                    Console.Write("Dígite o nome do aluno para remover: ");
                    string nome = Console.ReadLine().Trim();
                    int indexDaAlteracao = alunos.IndexOf(nome);
                    alunos.Remove(nome);
                    nota1.RemoveAt(indexDaAlteracao);
                    nota2.RemoveAt(indexDaAlteracao);
                    nota3.RemoveAt(indexDaAlteracao);

                }

                Console.WriteLine("1 - Cadastrar");
                Console.WriteLine("2 - Alterar");
                Console.WriteLine("3 - Listar");
                Console.WriteLine("4 - Apagar");
                Console.WriteLine("0 - Sair");
                Console.Write("Digite a opção desejada: ");
                escolha = Convert.ToInt32(Console.ReadLine());

            }
        }
    }
}
