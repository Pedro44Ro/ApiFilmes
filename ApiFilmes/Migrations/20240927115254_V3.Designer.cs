﻿// <auto-generated />
using ApiFilmes.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiFilmes.Migrations
{
    [DbContext(typeof(FilmesContext))]
    [Migration("20240927115254_V3")]
    partial class V3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ApiFilmes.Models.Filme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Avalicaocrit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Avalicaopub")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cartaz")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Duracao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Faixaetaria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Lancamento")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sinopse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Filmes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Avalicaocrit = "76%",
                            Avalicaopub = "42%",
                            Cartaz = "https://resizing.flixster.com/JNTZ514VlgxJg1pZFi72RJw0ep4=/206x305/v2/https://resizing.flixster.com/-XZAfHZM39UwaGJIFWKAE8fS0ak=/v3/t/assets/p36056_p_v8_av.jpg",
                            Duracao = " 1h 56m",
                            Faixaetaria = "14",
                            Genero = "Sci-Fi/Adventure/Action",
                            Lancamento = 2005,
                            Nome = "guerra dos mundos",
                            Sinopse = "Ray Ferrier é um estivador divorciado, afastado de seus filhos, que vivem com a mãe. Quando sua ex-esposa deixa as crianças para ele cuidar durante alguns dias, o planeta é atacado por alienígenas que surgem do chão conduzindo tripods e destruindo tudo que encontram pelo caminho. Ray tenta proteger os seus filhos e fugir para Boston para se juntar a sua ex-esposa. Durante o trajeto, enfrenta várias adversidades e ataques.",
                            Status = "Fora de cartaz"
                        },
                        new
                        {
                            Id = 2,
                            Avalicaocrit = "91%",
                            Avalicaopub = "86%",
                            Cartaz = "https://resizing.flixster.com/2HAZD3mRXq8DSdsOvBiGf5Kn8HI=/206x305/v2/https://resizing.flixster.com/-XZAfHZM39UwaGJIFWKAE8fS0ak=/v3/t/assets/p7825626_p_v10_ae.jpg",
                            Duracao = "2h 28m",
                            Faixaetaria = "14",
                            Genero = "Sci-Fi/Action/Thriller",
                            Lancamento = 2010,
                            Nome = "A Origem",
                            Sinopse = "Dom Cobb é um ladrão especializado em extrair segredos do subconsciente das pessoas enquanto elas dormem. Ele é oferecido uma chance de redenção: realizar a tarefa impossível de 'inserir' uma ideia na mente de um alvo. Com uma equipe de especialistas e enfrentando desafios no mundo dos sonhos, Cobb deve lutar contra suas próprias inseguranças e traumas para completar a missão e garantir a sua liberdade.",
                            Status = "Fora de cartaz"
                        },
                        new
                        {
                            Id = 3,
                            Avalicaocrit = "95%",
                            Avalicaopub = "91%",
                            Cartaz = "https://resizing.flixster.com/5opT-tFUEhOeMzsbrI8oZIm3EW8=/206x305/v2/https://resizing.flixster.com/-XZAfHZM39UwaGJIFWKAE8fS0ak=/v3/t/assets/p28828_p_v8_ao.jpg",
                            Duracao = "2h 58m",
                            Faixaetaria = "14",
                            Genero = "Fantasy/Adventure",
                            Lancamento = 2001,
                            Nome = "O Senhor dos Anéis: A Sociedade do Anel",
                            Sinopse = "Frodo Bolseiro, um simples hobbit, é incumbido de uma missão crucial: destruir o Um Anel, um artefato poderoso que pode controlar o mundo. Para completar sua jornada, ele é acompanhado por uma sociedade de aliados, incluindo humanos, elfos, anões e outros hobbits. Juntos, eles enfrentam perigosos inimigos e obstáculos em sua busca para impedir o senhor das trevas, Sauron, de retomar o poder.",
                            Status = "Fora de cartaz"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
