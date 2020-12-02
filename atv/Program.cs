using System;
using Atividade_atributos.Classes;

namespace Atividade_atributos
{
    class Program
    {
        static void Main(string[] args)
        {
            string liga;
            
            
            celular cel1 = new celular();
           
               
            Console.Clear();
            Console.WriteLine("Digite o nome do modelo: ");
            cel1.nomeModelo = Console.ReadLine();

            Console.WriteLine("Insira a cor: ");
            cel1.cor = Console.ReadLine();

            Console.WriteLine("Insira o tamanho: ");
            cel1.tamanho = int.Parse(Console.ReadLine());
            do{
                
            Console.WriteLine("o celular está ligado ou nao? S/N");
            cel1.ligado = Console.ReadLine();
            
            
            if(cel1.ligado.ToLower()=="s"){
                Console.WriteLine("você gostaria de: desligar | ligar para algum numero | mandar mensagem");
                string escolha=Console.ReadLine();
                switch(escolha){
                    case "desligar":
                     Console.WriteLine("tudo bem entao");
                      Console.WriteLine("gostaria de ligar seu celular novamente S/N");
                      liga=Console.ReadLine();
                    break;
                    case " ligar para algum numero":
                     Console.WriteLine("insira o numero o qual voce ligara:");
                     int numero=int.Parse(Console.ReadLine());
                     Console.WriteLine("sua ligaçao acabou");
                      Console.WriteLine("gostaria de desligar seu celular?");
                     liga=Console.ReadLine();
                    break;
                    case "mandar mensagem":
                     Console.WriteLine("insira o numero o qual voce enviara mensagem:");
                     int numero2=int.Parse(Console.ReadLine());
                     Console.WriteLine("insira a mensagem que voce gostaria de mandar");
                     string mensagem=Console.ReadLine();
                     Console.WriteLine("sua mensagem foi enviada");
                      Console.WriteLine("gostaria de desligar seu celular?");
                     liga=Console.ReadLine();
                    break;
                }
                
            }
            else if(cel1.ligado.ToLower()=="n")
            {
                Console.WriteLine("Gostaria de liga-lo?");
                liga=Console.ReadLine();
            }
            }while(liga =="s");
            
            Console.WriteLine("Tudo bem, então me desligarei");
            
        }
    }
}
