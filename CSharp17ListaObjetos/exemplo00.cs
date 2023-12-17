
namespace CSharp17ListaObjetos
{
    internal class exemplo00
    {
        public void Executar()
        {
            List<Aluno> alunos = new List<Aluno>();

            Aluno paulo = new Aluno();
            paulo.Nome = "Paulo";
            paulo.Nota1 = 9.4;
            paulo.Nota2 = 8;
            paulo.Nota3 = 7.6;
            alunos.Add(paulo);

            Aluno jose = new Aluno();
            jose.Nome = "José";
            jose.Nota1 = 5;
            jose.Nota2 = 4;
            jose.Nota3 = 3;
            alunos.Add(jose);

            Console.WriteLine("Nome do 1 aluno: " + alunos[0].Nome);

            Aluno primeiroAluno = alunos[0];
            Console.WriteLine("Nome do 1 aluno: " + primeiroAluno.Nome);

            alunos.Remove(jose);

            alunos[0].Nota1 = 9.0;

            Console.WriteLine("Nome: " + alunos[0].Nome);
            Console.WriteLine("Nota 1: " + alunos[0].Nota1);
            Console.WriteLine("Nota 2: " + alunos[0].Nota2);
            Console.WriteLine("Nota 3: " + alunos[0].Nota3);

            Aluno maria = new Aluno();
            jose.Nome = "Maria";
            jose.Nota1 = 7;
            jose.Nota2 = 4;
            jose.Nota3 = 5;
            alunos.Add(maria);

            Aluno eduarda = new Aluno();
            jose.Nome = "Eduarda";
            jose.Nota1 = 9;
            jose.Nota2 = 8;
            jose.Nota3 = 7;
            alunos.Add(eduarda);

            bool joseExiste = false;
            for (int i = 0; i < alunos.Count; i++)
            {
                Aluno alunoPercorrido = alunos[i];
                if (alunoPercorrido.Nome == "José")
                {
                    joseExiste = true;
                }
            }

            if (joseExiste)
            {
                Console.WriteLine("José existe na escola");
            }
            else
            {
                Console.WriteLine("José foi expulso da escola");
            }
        }
    }
}