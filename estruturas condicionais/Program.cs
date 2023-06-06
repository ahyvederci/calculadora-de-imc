using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoradeimc {
    internal class Program {
        static void Main(string[] args) {
           
            #region calcular imc

            Console.WriteLine("Informe o peso em kg");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe sua Altura");
            double altura = double.Parse(Console.ReadLine());

            double valorimc = peso / (altura * altura);

            if (valorimc <= 18.5) {
                Console.WriteLine("Você está abaixo do peso " +  valorimc  + " seu valor imc");
            }
            else if (valorimc >= 18.5 && valorimc <= 29.9) { 
                Console.WriteLine("Você está com o peso normal " +  valorimc  + " seu valor imc");
            }
            else if (valorimc <= 29.9 && valorimc <= 35.5)
                Console.WriteLine("Você está sobrepeso " +  valorimc  + " seu valor imc");
            else if (valorimc >= 35.5)
                Console.WriteLine("Você está em obesidade " +  valorimc  + " Seu valor imc");
            










            #endregion

            Console.ReadKey();
             
            



        }
    }
}
