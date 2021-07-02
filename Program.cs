using System;

namespace projeto
{
    class Program
    {
        static SeriesRepositorio repositorio = new SeriesRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

          while(opcaoUsuario.ToUpper() != "X"){
              switch (opcaoUsuario){
                  case "1":
                   ListarSeries();
                    break;
                   case "2":
                   //InserirSeries();
                    break;
                   case "3":
                   // AtualizarSeries();
                    break;
                   case "4":
                   // ExcluirSeries();
                    break;
                   case "5":
                   // VisualizarSeries();
                    break;
                   case "C":
                   Console.Clear();
                    break;
                    default:
                       throw new ArgumentOutOfRangeException();
              }
              opcaoUsuario = ObterOpcaoUsuario();
          }
          Console.WriteLine("Obrigado por utilizar nossos serviços.");
          Console.ReadLine();         

          }

          private static void ListarSeries(){

              Console.WriteLine("Listar series");

              var lista = repositorio.Lista();

              if(lista.Count==0)
              {
                  Console.WriteLine("Nenhuma serie cadastrada.");
                  return;
              }
              foreach(var serie in lista){
                  Console.WriteLine("#ID {0}: - {1}, ", serie.retornaId(),serie.retornaTitulo());
              }
        }

       

        private static string ObterOpcaoUsuario(){
            Console.WriteLine();
            Console.WriteLine("DIO Series a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada: ");

            Console.WriteLine("1 - Listar series");
            Console.WriteLine("2 - Inserir nova serie");
            Console.WriteLine("3 - Atualizar serie");
            Console.WriteLine("4 - Excluir serie");
            Console.WriteLine("5 - Visualizar serie");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair");



            string opcaoUsuario  = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;

           
        }
    }
}
