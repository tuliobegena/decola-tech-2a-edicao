using ExemploConstrutores.Models;

class Program
{
    public delegate void Operacao(int x, int y);

    static void Main(string[] args)
    {
        Matematica m = new Matematica(10, 20);
        m.Somar();

        //Operacao OP = Calculadora.Somar;
        // Operacao op = new Operacao(Calculadora.Somar);
        // op += Calculadora.Subtrair;

        // op.Invoke(10, 10);
        //op(10, 10);

        // const double pi = 3.14;
        // System.Console.WriteLine(pi);

       // Data data = new Data();
        //data.SetMes(20);

       // data.Mes = 12;
        //System.Console.WriteLine(data.Mes);

        //data.ApresentarMes();

        // Log log = Log.GetInstance();

        // log.PropriedadeLog = "Teste instancia";

        // Log log2 = Log.GetInstance();
        // System.Console.WriteLine(log2.PropriedadeLog);

        // Aluno p1 = new Aluno("Túlio", "Begena", "Teste");
        // p1.Apresentar();
    }
}