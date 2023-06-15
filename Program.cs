using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08ListaseRepeticaoTerQui
{

    class Program
    {


        static void Main(string[] args{}
        
        
        
        
        
        
        
         
        
        
        
        
        
        
        
        
        




        void arrays()
        {

            string[] nomes = new string[3];

            nomes[0] = "Kennedy";
            nomes[1] = "Maria julia";
            nomes[2] = "Conrado";

            Console.WriteLine("O nome da primeira posição é " + nomes[0]);
            Console.WriteLine("O nome da segunda posição é " + nomes[1]);
            Console.WriteLine("O nome da terceira posição é " + nomes[2]);


            Console.ReadKey();



        }
        void lista()
        {
            //listas => mesmo que o array, porém com o tamanho automático

            List<string> nomes = new List<string>();

            nomes.Add("jonatas");
            nomes.Add("Natanael");
            nomes.Add("bruno");


            Console.WriteLine("O primeiro é " + nomes[0]);
            Console.WriteLine("O segundo é " + nomes[1]);
            Console.WriteLine("O terceiro é " + nomes[2]);

            Console.WriteLine("Digite o seu nome:");
            nomes.Add(Console.ReadLine());

            nomes.Remove("Natanael");
            nomes.RemoveAt(2);


            int quantidade = nomes.Count;
            Console.WriteLine($"Existem {quantidade} usuarios cadastrados");



            Console.ReadKey();



        }
    }



}

