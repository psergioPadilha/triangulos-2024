//Dados três valores X, Y, Z, verifiquem se eles podem ser os comprimentos dos lados de um triângulo
//e se forem escrever uma mensagem informando se é um triângulo eqüilátero, isósceles ou escaleno
//O comprimento de um lado do triângulo é sempre menor do que a soma dos outros dois.
//Eqüilátero: Todos os lados iguais
//Isósceles: Dois lados iguais
//Escaleno: Todos os lados diferentes


public class Triangulo
{
    public double ladoA;
    public double ladoB;
    public double ladoC;

    public bool VerificaValores(double ladoA, double ladoB, double ladoC)
    {
        if ((ladoA + ladoB > ladoC) && (ladoA + ladoC > ladoB) && (ladoB + ladoC > ladoA))
            return true;
        else
            return false;
    }

    public string TipoDeTriangulo(double ladoA, double ladoB, double ladoC)
    {
        string tipoDeTriangulo = "";

        if ((ladoA == ladoB) && (ladoA == ladoC) && (ladoB == ladoC))
            tipoDeTriangulo = "EQUILÁTERO";
        else if ((ladoA == ladoB) && (ladoA != ladoC) && (ladoB != ladoC))
            tipoDeTriangulo = "ISÓCESLES";
        else if ((ladoA != ladoB) && (ladoA != ladoC) && (ladoB == ladoC))
            tipoDeTriangulo = "ISÓCESLES";
        else if ((ladoA != ladoB) && (ladoA == ladoC) && (ladoB != ladoC))
            tipoDeTriangulo = "ISÓCESLES";
        else if((ladoA != ladoB) && (ladoA != ladoC) && (ladoB != ladoC))
            tipoDeTriangulo = "ESCALENO";

        return tipoDeTriangulo;
    }
}
