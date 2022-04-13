using crud_series.src;
using crud_series.src.Enums;

namespace crud_series
{
    class Program
    {
        static ListaDeSeries listaDeSeries = new ListaDeSeries();

        static void Main(string[] args)
        {
            InserirSerie(1, "AAAAA", 5.1);
            InserirSerie(2, "BBBBB", 4.7);
            ListarSeries();
            AtualizarSerie(999, 2, "BBBBB", 9.14);
            ListarSeries();
            AtualizarSerie(1, 2, "BBBBB", 9.14);
            ListarSeries();
            RemoverSerie(1);
            ListarSeries();
        }

        public static void ListarSeries()
        {
            var lista = listaDeSeries.GetLista();
            if(lista.Count > 0)
            {
                Console.WriteLine();
                Console.WriteLine("-----------------------");
                foreach (var serie in lista)
                {
                    if(!serie.Removida())
                    {
                        Console.WriteLine(serie.ToString());
                    }
                }
                Console.WriteLine("-----------------------");
                Console.WriteLine();
            }
        }

        public static void InserirSerie(int genero, string nome, double nota)
        {
            Serie serie = new Serie(id: listaDeSeries.ProximoId(), genero: (Genero)genero, nome: nome, nota: nota);
            if(listaDeSeries.Inserir(serie)){
                Console.WriteLine($"Serie {nome} inserida");
            }
            else
            {
                Console.WriteLine($"Falha ao inserir {nome}");
            }
        }

        public static void AtualizarSerie(int id, int genero, string nome, double nota)
        {
            Serie serie = new Serie(id: id, genero: (Genero)genero, nome: nome, nota: nota);
            if(listaDeSeries.Atualizar(id, serie)){
                Console.WriteLine($"Serie {nome} atualizada");
            }
            else
            {
                Console.WriteLine($"Falha ao atualizar {nome}");
            }
        }

        public static void RemoverSerie(int id)
        {
            string nome = listaDeSeries.Excluir(id);
            Console.WriteLine($"Serie {nome} removida");
        }
    }
}
