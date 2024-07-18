using System;

namespace Enumerados
{
    enum BONUS
    {
        SinBonus = 0,
        Minimo = 100,
        Medio = 200,
        Maximo = 500
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado Hamel = new Empleado("Hamel Zabala", 1001, BONUS.Maximo, 5000);
            Empleado Alex = new Empleado("Alexander Zabala", 1002, BONUS.SinBonus, 1000);
            
            Hamel.GetDatoEmpleado();
            Console.WriteLine("Salario: " + Hamel.GetSalario());

            Console.WriteLine();

            Alex.GetDatoEmpleado();
            Console.WriteLine($"Salario: {Alex.GetSalario()}");

            
        }
    }
    class Empleado
    {
        private string nombre;
        private int idEmpleado;
        private BONUS bonusExtra;
        private double salario;

        public Empleado(string nombre, int idEmpleado, BONUS bonusExtra, double salario)
        {
            this.nombre = nombre;
            this.idEmpleado = idEmpleado;
            this.bonusExtra = bonusExtra;
            this.salario = salario;
        }

        public double GetSalario()
        {
            return salario + (double)bonusExtra;
        }

        public void GetDatoEmpleado()
        {
            Console.WriteLine("ID: " + this.idEmpleado);
            Console.WriteLine("Nombre: " + this.nombre);            
        }

    }
}
