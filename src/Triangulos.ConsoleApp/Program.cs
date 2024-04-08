//Dados três valores X, Y, Z, verifiquem se eles podem ser os comprimentos dos lados de um triângulo
//e se forem escrever uma mensagem informando se é um triângulo eqüilátero, isósceles ou escaleno
//O comprimento de um lado do triângulo é sempre menor do que a soma dos outros dois.
//Eqüilátero: Todos os lados iguais
//Isósceles: Dois lados iguais
//Escaleno: Todos os lados diferentes


namespace Triangulos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Triangulo novoTriangulo = new Triangulo();

                Console.Clear();
                Console.WriteLine("PROGRAMA TRIÂNGULO");
                Console.WriteLine();

                Console.Write("Lado x: ");
                double x = double.Parse(Console.ReadLine());

                Console.Write("Lado y: ");
                double y = double.Parse(Console.ReadLine());

                Console.Write("Lado z: ");
                double z = double.Parse(Console.ReadLine());
                Console.WriteLine();

                bool triangulo = novoTriangulo.VerificaValores(x, y, z);

                if (triangulo == true)
                {
                    string tipo = novoTriangulo.TipoDeTriangulo(x, y, z);

                    Console.WriteLine("O valores correspondem a um triângulo " + tipo);
                }
                else
                    Console.WriteLine("O valores 'NÃO' correspondem a valores válidos para um triângulo!");

                Console.ReadLine();
            }
        }
    }
}
