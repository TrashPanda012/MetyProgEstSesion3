using UseIf.models;

namespace UseIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Decir si es niño, joven o adulto
            //Niño: 0 - 12
            //Joven: 13 - 25
            //Adulto: 26 a más
            int edad = 0;
            Evaluate evaluate = new Evaluate();

            Console.WriteLine("Evaluar edad");
            Console.WriteLine("Ingresa tu edad");
            try
            {
                edad = int.Parse(Console.ReadLine());
                Console.WriteLine(evaluate.EvalAge(edad));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
