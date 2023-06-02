using FilmesApi.Models;

namespace FilmesApi
{
    public static class MockFilmes
    {
        public static IList<Filme> Filmes = new List<Filme>()
        {
            new Filme {
                FilmeId = 1,
                FilmeName= "Blade Runner",
                Diretor = "Jane Campion",
                Duracao = 60,
                Genero =  "Suspense"},
            new Filme
            {
                FilmeId = 2,
                FilmeName = "Trainspotting - Sem Limites",
                Diretor = "Quentin Tarantino",
                Duracao = 90,
                Genero = "Documentário"
            },
            new Filme
            {
                FilmeId = 3,
                FilmeName = "Gênio Indomável",
                Diretor = "Sofia Coppola",
                Duracao = 90,
                Genero = "Romance"
            },
            new Filme
            {
                FilmeId = 4,
                FilmeName = "Titanic",
                Diretor = "Petra Costa",
                Duracao = 120,
                Genero = "Romance"
            },
            new Filme
            {
                FilmeId = 5,
                FilmeName = "Aliens, O Resgate",
                Diretor = "Sofia Coppola",
                Duracao = 120,
                Genero = "Desenho"
            },
            new Filme
            {
                FilmeId = 6,
                FilmeName = "Um Sonho de Liberdade",
                Diretor = "Kathryn Bigelow",
                Duracao = 60,
                Genero = "Ficção"
            },
            new Filme
            {
                FilmeId = 7,
                FilmeName = "Blade Runner",
                Diretor = "Jean-Luc Godard",
                Duracao = 120,
                Genero = "Policial"
            },
            new Filme
            {
                FilmeId = 8,
                FilmeName = "Noivo Neurótico, Noiva Nervosa",
                Diretor = "Alfred Hitchcock",
                Duracao = 60,
                Genero = "Romance"
            },
            new Filme
            {
                FilmeId = 9,
                FilmeName = "Uma Vida sem Limites",
                Diretor = "Steven Spielberg",
                Duracao = 90,
                Genero = "Aventura"
            },
            new Filme
            {
                FilmeId = 10,
                FilmeName = "Donnie Darko",
                Diretor = "Stanley Kubrick",
                Duracao = 90,
                Genero = "Ficção"
            }

        };
    }
}
