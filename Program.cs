using System;
using ProjetoEvento.ClassePai.ClassesFilhas;

namespace ProjetoEventoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Menu do programinha
            string opcao = "";
            do
            {
                Console.WriteLine("Digite a opção desejada:");
                Console.WriteLine("1 - Show");
                Console.WriteLine("2 - Teatro");
                Console.WriteLine("3 - Cinema");
                Console.WriteLine("9 - Sair");

                opcao = Console.ReadLine();

                switch (opcao)
                {

                    case "1":
                    MenuShow();
                        break;

                    case "2":
                        break;

                    case "3":
                        break;
                    
                    case "9":
                        break;

                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;

                }

            } while (opcao != "9");
        }
        static void MenuShow(){
            string opcao = "";
                 do
            {
                Console.WriteLine("Digite a opção desejada:");
                Console.WriteLine("1 - Cadastrar Show");
                Console.WriteLine("2 - Pesquisar Show por título");
                Console.WriteLine("3 - Pesquisar Show por data");
                Console.WriteLine("9 - Voltar");

                opcao = Console.ReadLine();

                switch (opcao)
                {

                    case "1":
                    Console.WriteLine("Informe o título:");
                    string titulo = Console.ReadLine();
                    Console.WriteLine("Informe o local:");
                    string local = Console.ReadLine();
                    Console.WriteLine("Informe a lotação:");
                    int lotacao = int.Parse(Console.ReadLine());
                    Console.WriteLine("Informe a duração:");
                    string duracao = Console.ReadLine();
                    Console.WriteLine("Informe a classificação:");
                    int classificacao = int.Parse(Console.ReadLine());
                    Console.WriteLine("Informe o artista:");
                    string artista = Console.ReadLine();
                    Console.WriteLine("Informe a gênero musical:");
                    string generomusical = Console.ReadLine();
                    Console.WriteLine("Informe a data:");
                    DateTime data = Convert.ToDateTime(Console.ReadLine());

                    Show novoshow = new Show(titulo,local,lotacao,duracao,classificacao,data,artista,generomusical);
                    
                    bool showcadastrado = novoshow.Cadastrar();

                    if(showcadastrado == true){
                        Console.WriteLine("Arquivo Criado com sucesso!");
                    }
                    else{
                        Console.WriteLine("Erro ao gravar!");
                    }
                        break;

                    case "2":
                        Console.WriteLine("Digite o título a ser pesquisado:");
                        string pesquisatitulo = Console.ReadLine();
                        Show showpesquisatitulo = new Show();
                        string resultadopesquisa = showpesquisatitulo.Pesquisar(pesquisatitulo);
                        Console.WriteLine(resultadopesquisa);

                        break;

                    case "3":
                        Console.WriteLine("Digite a data a ser pesquisada:");
                        DateTime pesquisadata = Convert.ToDateTime(Console.ReadLine());
                        Show showpesquisadata = new Show();
                        string resultadopesquisadata = showpesquisadata.Pesquisar(pesquisadata);
                        Console.WriteLine(resultadopesquisadata);
                        break;
                    
                    case "4":
                        break;
                    
                    case "9":
                        break;

                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                    

                }

            } while (opcao != "9");
        }
    }
}
