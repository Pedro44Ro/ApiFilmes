using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiFilmes.Migrations
{
    public partial class V3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Filmes",
                columns: new[] { "Id", "Avalicaocrit", "Avalicaopub", "Cartaz", "Duracao", "Faixaetaria", "Genero", "Lancamento", "Nome", "Sinopse", "Status" },
                values: new object[] { 1, "76%", "42%", "https://resizing.flixster.com/JNTZ514VlgxJg1pZFi72RJw0ep4=/206x305/v2/https://resizing.flixster.com/-XZAfHZM39UwaGJIFWKAE8fS0ak=/v3/t/assets/p36056_p_v8_av.jpg", " 1h 56m", "14", "Sci-Fi/Adventure/Action", 2005, "guerra dos mundos", "Ray Ferrier é um estivador divorciado, afastado de seus filhos, que vivem com a mãe. Quando sua ex-esposa deixa as crianças para ele cuidar durante alguns dias, o planeta é atacado por alienígenas que surgem do chão conduzindo tripods e destruindo tudo que encontram pelo caminho. Ray tenta proteger os seus filhos e fugir para Boston para se juntar a sua ex-esposa. Durante o trajeto, enfrenta várias adversidades e ataques.", "Fora de cartaz" });

            migrationBuilder.InsertData(
                table: "Filmes",
                columns: new[] { "Id", "Avalicaocrit", "Avalicaopub", "Cartaz", "Duracao", "Faixaetaria", "Genero", "Lancamento", "Nome", "Sinopse", "Status" },
                values: new object[] { 2, "91%", "86%", "https://resizing.flixster.com/2HAZD3mRXq8DSdsOvBiGf5Kn8HI=/206x305/v2/https://resizing.flixster.com/-XZAfHZM39UwaGJIFWKAE8fS0ak=/v3/t/assets/p7825626_p_v10_ae.jpg", "2h 28m", "14", "Sci-Fi/Action/Thriller", 2010, "A Origem", "Dom Cobb é um ladrão especializado em extrair segredos do subconsciente das pessoas enquanto elas dormem. Ele é oferecido uma chance de redenção: realizar a tarefa impossível de 'inserir' uma ideia na mente de um alvo. Com uma equipe de especialistas e enfrentando desafios no mundo dos sonhos, Cobb deve lutar contra suas próprias inseguranças e traumas para completar a missão e garantir a sua liberdade.", "Fora de cartaz" });

            migrationBuilder.InsertData(
                table: "Filmes",
                columns: new[] { "Id", "Avalicaocrit", "Avalicaopub", "Cartaz", "Duracao", "Faixaetaria", "Genero", "Lancamento", "Nome", "Sinopse", "Status" },
                values: new object[] { 3, "95%", "91%", "https://resizing.flixster.com/5opT-tFUEhOeMzsbrI8oZIm3EW8=/206x305/v2/https://resizing.flixster.com/-XZAfHZM39UwaGJIFWKAE8fS0ak=/v3/t/assets/p28828_p_v8_ao.jpg", "2h 58m", "14", "Fantasy/Adventure", 2001, "O Senhor dos Anéis: A Sociedade do Anel", "Frodo Bolseiro, um simples hobbit, é incumbido de uma missão crucial: destruir o Um Anel, um artefato poderoso que pode controlar o mundo. Para completar sua jornada, ele é acompanhado por uma sociedade de aliados, incluindo humanos, elfos, anões e outros hobbits. Juntos, eles enfrentam perigosos inimigos e obstáculos em sua busca para impedir o senhor das trevas, Sauron, de retomar o poder.", "Fora de cartaz" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Filmes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Filmes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Filmes",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
