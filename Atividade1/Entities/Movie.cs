using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atividade1.Entities
{
    // Informações da tabela Filmes no banco de dados
    [Table("Filmes")]
    public class Movie
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public DateTime Data_de_Lancamento { get; set; }

        public string Estudio { get; set; }
    }
}
