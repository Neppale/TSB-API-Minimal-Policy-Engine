static class GetVehicleByIdRepository
{
  public static Veiculo Get(int id, SqlConnection connectionString)
  {
    return connectionString.QueryFirstOrDefault<Veiculo>("SELECT * FROM Veiculos WHERE id_Veiculo = @Id AND status = 'true'", new { Id = id });
  }
}