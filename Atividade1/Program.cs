using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using Atividade1.Context;
using Atividade1.Entities;
using Atividade1.Model;

namespace Atividade1
{
    class Program
    {
        public static void Main()
        {
            try
            {
                // Imprime o nome do estúdio que for inserido pelo usuário
                Console.WriteLine("Qual o estúdio?");
                var studio = Console.ReadLine();

                var movieList = new List<Movie>();
                var xmlData = RetrievesMarvelDataFromXML();

                foreach (var item in xmlData.Items)
                {
                    movieList.Add(new Movie()
                    {
                        Titulo = item.Title,
                        Data_de_Lancamento = item.ReleaseDate,
                        Estudio = studio
                    });
                }

                SaveMovies(movieList);
            }
            // Imprime mensagem de erro caso algum erro aconteça
            catch (Exception e)
            {
                Console.WriteLine($"Ops! Algo inesperado aconteceu, {e.Message}");
            }

            Console.ReadKey();
        }

        // Recupera as informações do arquivo xml
        static MarvelData RetrievesMarvelDataFromXML()
        {
            using TextReader reader = new StreamReader(@"C:\Users\eduardo.miranda\Desktop\Teste Message\Atividade1\Atividade1\Model\marvel.xml");
            {
                XmlSerializer serializer = new XmlSerializer(typeof(MarvelData));

                return (MarvelData)serializer.Deserialize(reader);
            }
        }

        /// <summary>
        /// Esse método está criado para facilitar a busca da lista caso o senhor deseje testar
        /// </summary>
        static List<Movie> GetMovies()
        {
            var context = new Atividade1Context();
            var movies = context.Movies.ToList();

            return movies;
        }

        // Salva as informações no banco de dados
        static void SaveMovies(List<Movie> movies)
        {

            var context = new Atividade1Context();
            context.Movies.AddRange(movies);
            context.SaveChanges();

            // Imprime mensagem de sucesso caso as informações sejam salvas com sucesso no banco de dados
            Console.WriteLine();
            Console.WriteLine("Dados dos filmes salvos com sucesso.");
        }
    }
}


