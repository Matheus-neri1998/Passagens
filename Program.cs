using System;

namespace Passagens
{
    class Program
    {
        static void Main(string[] args)
        {  

           // Declarações de variáveis
           bool senhaValida;
           int escolha;
           int contador = 0;
           string resposta;
           // Dados da passagem
           string[] nomes = new string [5]; // tamanho do array é 5
           string[] origem = new string [5];
           string[] destino = new string [5];
           string[] data = new string [5];

           Console.Clear(); // Limpa o inicio da apresentação no console
           Console.WriteLine("------------------------------");
           Console.WriteLine("---- Sistema de Passagens ----");
           Console.WriteLine("------------------------------");
           
           // Login
            do
            {
               
                Console.WriteLine("Digite a senha para acessar o sistema");
                string senha = Console.ReadLine();
                senhaValida = EfetuarLogin(senha);
           } while (!senhaValida); // ponto de exclamação indica negação

           // Menu
            do
            {
                Console.WriteLine("Menu Principal");
                Console.WriteLine("Selecione uma opção a baixo");
                Console.WriteLine("[1] = Cadastre sua passagem");
                Console.WriteLine("[2] = Listar Passagens");
                Console.WriteLine("[0] = Sair");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Cadastrar Passageiro");
                        do
                        {   if (contador <5)
                            {
                                Console.WriteLine($"Digite o nome do {contador+1} passageiro:");
                                nomes[contador] = Console.ReadLine();
                                Console.WriteLine("Digite o destino:");
                                destino[contador] = Console.ReadLine();
                                Console.WriteLine("Digite a origem:");
                                origem[contador] = Console.ReadLine();
                                Console.WriteLine("Digite a data do Vôo:");
                                data[contador] = Console.ReadLine();
                                contador++; // incrementando e a partir do valor 1
                            }else
                            {
                                Console.WriteLine("Limite excedido");
                                break; // break faz com que saia do switch e retorne a execução a partir do menu
                            }
                            Console.WriteLine("Você gostaria de realizar um novo cadastro? S/N"); // S/N = SIM OU NÃO
                            resposta = Console.ReadLine();

                        } while (resposta == "S"); // while = enquanto
                        Console.Clear();
                        break;

                    case 2:
                        Console.WriteLine("Listar Passagens");
                            for (var i = 0; i < contador; i++)
                            {
                                Console.WriteLine($"Passageiro: {nomes[i]} ");
                                Console.WriteLine($"Origem: {origem[i]} "); 
                                Console.WriteLine($"Destino {destino[i]} ");
                                Console.WriteLine($"Data do Vôo: {data[i]} ");
                                Console.WriteLine("--------------------");

                            }
                        break;
                    case 0:
                        Console.WriteLine("Obrigado! A Matheus-Airlines agradece a sua preferência");
                        break;

                    default: // default é a última opção que executa do laço switch
                        Console.WriteLine("Opção inválida");
                        break;
                }
                
            } while (escolha != 0); // menu sempre irá repetir se o valor não for "0"

           

           // Funções
           bool EfetuarLogin(string senha){
               if(senha == "123456"){ // if = se (condicional)
                    return true; // = valor booleano
              
               }else{ // else = senão
                    Console.WriteLine("Senha inválida, tente novamente.");
                    return false;
               }
           }




        }
    }
}
