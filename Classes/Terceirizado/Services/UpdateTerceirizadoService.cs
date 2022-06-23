using Dapper;
using Microsoft.Data.SqlClient;
using tsb.mininal.policy.engine.Utils;
using DocumentValidator;
public static class UpdateTerceirizadoService
{
  /** <summary> Esta função altera um terceirizado no banco de dados. </summary>**/
  public static IResult Update(int id, Terceirizado terceirizado, string dbConnectionString)
  {
    SqlConnection connectionString = new SqlConnection(dbConnectionString);

    // Verificando se terceirizado existe.
    bool isExistent = connectionString.QueryFirstOrDefault<bool>("SELECT id_terceirizado from Terceirizados WHERE id_terceirizado = @Id", new { Id = id });
    if (!isExistent) return Results.NotFound("Terceirizado não encontrado");

    // Verificando se alguma das propriedades do terceirizado é nula ou vazia.
    bool hasValidProperties = NullPropertyValidator.Validate(terceirizado);
    if (!hasValidProperties) return Results.BadRequest("Há um campo inválido na sua requisição.");

    // Validando CNPJ
    bool cnpjIsValid = CnpjValidation.Validate(terceirizado.cnpj);
    if (!cnpjIsValid) return Results.BadRequest("O CNPJ informado é inválido.");

    // Verificando se o CNPJ já existe no banco de dados.
    bool cnpjIsExistent = connectionString.QueryFirstOrDefault<bool>("SELECT cnpj FROM Terceirizados WHERE cnpj = @Cnpj AND id_terceirizado != @Id", new { Cnpj = terceirizado.cnpj, Id = id });
    if (cnpjIsExistent) return Results.Conflict("O CNPJ informado já está cadastrado.");

    // Verificando se o telefone já existe no banco de dados.
    bool telefoneIsExistent = connectionString.QueryFirstOrDefault<bool>("SELECT telefone FROM Terceirizados WHERE telefone = @Telefone AND id_terceirizado != @Id", new { Telefone = terceirizado.telefone, Id = id });
    if (telefoneIsExistent) return Results.Conflict("O telefone informado já está cadastrado.");


    try
    {
      connectionString.Query<Terceirizado>("UPDATE Terceirizados SET nome = @Nome, funcao = @Funcao, cnpj = @Cnpj, telefone = @Telefone, valor = @Valor, WHERE id_terceirizado = @Id", new { Nome = terceirizado.nome, Funcao = terceirizado.funcao, Cnpj = terceirizado.cnpj, Telefone = terceirizado.telefone, Valor = terceirizado.valor, Id = id });
      return Results.Ok();
    }
    catch (SystemException)
    {
      return Results.BadRequest("Requisição feita incorretamente. Confira todos os campos e tente novamente.");
    }

  }
}
