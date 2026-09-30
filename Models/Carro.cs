namespace Renato_Origuela.Models
{
    public class Carro
    {
        public string Nome { get; set; } = string.Empty;
        public string Descricao  { get; set; }= string.Empty;
        public int Ano { get; set; }
        public int Quilometragem{ get; set; }
        public string Cambio { get; set; } = string.Empty;
        public double Preco{ get; set; }

    }
}
