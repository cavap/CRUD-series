using crud_series.src.Enums;

namespace crud_series.src
{
    public class Serie : ControleID
    {
        private Genero genero { get; set; }
        private string nome { get; set; }
        private double nota { get; set; }
        private bool removida { get; set; }

        public Serie(int id, Genero genero, string nome, double nota)
        {
            this.id = id;
            this.genero = genero;
            this.nome = nome;
            this.nota = nota;
            this.removida = false;
        }

        public override string ToString()
        {
            return $"{this.genero}: {this.nome}, {this.nota}";
        }

        public int GetId()
        {
            return this.id;
        }

        public string Remover()
        {
            this.removida = true;
            return this.nome;
        }

        public bool Removida()
        {
            return this.removida;
        }
    }
}