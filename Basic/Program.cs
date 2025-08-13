using Basic;

namespace Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var exercicio = new Exercise01();

            Console.Write("Digite seu nome: ");
            string name = Console.ReadLine();

            Console.WriteLine(exercicio.Message(name));
        }
    }
}
