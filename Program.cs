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
                   InserirSeries();
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
                  Console.WriteLine("#ID {0}: - {1} ", serie.RetornaId(),serie.RetornaTitulo());
              }
        }

        private static void InserirSeries(){
            Console.WriteLine("Inserir nova série");

            foreach(int i in Enum.GetValues(typeof(Genero))){
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine("Digite o genero das opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o titulo da serie: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o ano da serie: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o descricao da serie: ");
            string entradaDescricao = Console.ReadLine();

            Series novaSerie = new Series(id: repositorio.ProximoId(),
                                          genero: (Genero)entradaGenero,
                                          titulo: entradaTitulo,
                                          ano: entradaAno,
                                          descricao: entradaDescricao);

            repositorio.Insere(novaSerie);
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
