static class GetOnePolicyRepository
{
  public static Apolice Get(int id, SqlConnection connectionString)
  {
    var policy = connectionString.QueryFirstOrDefault<Apolice>("SELECT id_apolice, data_inicio, data_fim, premio, indenizacao, id_cobertura, id_usuario, id_cliente, id_veiculo, status from Apolices WHERE id_apolice = @Id", new { Id = id });

    return policy;
  }
}