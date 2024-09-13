using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiFilmes.Models;

namespace ApiFilmes.Data
{
    public class FilmesContext : DbContext
    {
        public FilmesContext (DbContextOptions<FilmesContext> options)
            : base(options)
        {
        }

        public DbSet<ApiFilmes.Models.Filme> Filme { get; set; } = default!;

          override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Filme>().HasData()
            new filme{
                Id=1,
                Nome="guerra dos mundos",
                Cartaz="https://resizing.flixster.com/JNTZ514VlgxJg1pZFi72RJw0ep4=/206x305/v2/https://resizing.flixster.com/-XZAfHZM39UwaGJIFWKAE8fS0ak=/v3/t/assets/p36056_p_v8_av.jpg",
                Genero="Sci-Fi/Adventure/Action",
                Duracao=" 1h 56m",
                Lancamento=2005,
                Sinopse="Ray Ferrier é um estivador divorciado, afastado de seus filhos, que vivem com a mãe. Quando sua ex-esposa deixa as crianças para ele cuidar durante alguns dias, o planeta é atacado por alienígenas que surgem do chão conduzindo tripods e destruindo tudo que encontram pelo caminho. Ray tenta proteger os seus filhos e fugir para Boston para se juntar a sua ex-esposa. Durante o trajeto, enfrenta várias adversidades e ataques.",
                Faixaetaria=14,
                Avalicaopub="42%",
                Avalicaocrit"76%",
                Status="Fora de cartaz"
            };
            new filme{
                Id=2,
                Nome="A Origem",
                Cartaz="https://resizing.flixster.com/2HAZD3mRXq8DSdsOvBiGf5Kn8HI=/206x305/v2/https://resizing.flixster.com/-XZAfHZM39UwaGJIFWKAE8fS0ak=/v3/t/assets/p7825626_p_v10_ae.jpg",
                Genero="Sci-Fi/Action/Thriller",
                Duracao="2h 28m",
                Lancamento=2010,
                Sinopse="Dom Cobb é um ladrão especializado em extrair segredos do subconsciente das pessoas enquanto elas dormem. Ele é oferecido uma chance de redenção: realizar a tarefa impossível de 'inserir' uma ideia na mente de um alvo. Com uma equipe de especialistas e enfrentando desafios no mundo dos sonhos, Cobb deve lutar contra suas próprias inseguranças e traumas para completar a missão e garantir a sua liberdade.",
                Faixaetaria=14,
                Avalicaopub="86%",
                Avalicaocrit="91%",
                Status="Fora de cartaz"
            };
            new filme{
                Id=3,
                Nome="O Senhor dos Anéis: A Sociedade do Anel",
                Cartaz="https://resizing.flixster.com/5opT-tFUEhOeMzsbrI8oZIm3EW8=/206x305/v2/https://resizing.flixster.com/-XZAfHZM39UwaGJIFWKAE8fS0ak=/v3/t/assets/p28828_p_v8_ao.jpg",
                Genero="Fantasy/Adventure",
                Duracao="2h 58m",
                Lancamento=2001,
                Sinopse="Frodo Bolseiro, um simples hobbit, é incumbido de uma missão crucial: destruir o Um Anel, um artefato poderoso que pode controlar o mundo. Para completar sua jornada, ele é acompanhado por uma sociedade de aliados, incluindo humanos, elfos, anões e outros hobbits. Juntos, eles enfrentam perigosos inimigos e obstáculos em sua busca para impedir o senhor das trevas, Sauron, de retomar o poder.",
                Faixaetaria=14,
                Avalicaopub="91%",
                Avalicaocrit="95%",
                Status="Fora de cartaz"
            };

            }
    }
}
