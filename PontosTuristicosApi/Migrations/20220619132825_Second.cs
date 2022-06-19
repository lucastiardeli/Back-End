using Microsoft.EntityFrameworkCore.Migrations;

namespace PontosTuristicosApi.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pontos",
                columns: new[] { "Id", "Cidade", "Descricao", "Estado", "Nome", "RuaReferencia" },
                values: new object[] { 1, "Curitiba", "Cartão postal de Curitiba, flores típicas da Mata-Atlântica", "PR", "Jardim Botânico", "Ostoja Ruguski" });

            migrationBuilder.InsertData(
                table: "Pontos",
                columns: new[] { "Id", "Cidade", "Descricao", "Estado", "Nome", "RuaReferencia" },
                values: new object[] { 2, "São Paulo", "Uma das principais avenidas de São Paulo, com um trecho de 3KM", "SP", "Avenida Paulista", "Avenida Paulista" });

            migrationBuilder.InsertData(
                table: "Pontos",
                columns: new[] { "Id", "Cidade", "Descricao", "Estado", "Nome", "RuaReferencia" },
                values: new object[] { 3, "Rio de Janeiro", "Destino litorâneo mais epeciais do mundo", "RJ", "Praia de Copacabana", "Copacabana Praia" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pontos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pontos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pontos",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
