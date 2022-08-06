public static class GetOneVehicleService
{
  /** <summary> Esta função retorna um veículo específico no banco de dados. </summary>**/
  public static IResult Get(int id, SqlConnection connectionString)
  {
    var vehicle = GetOneVehicleRepository.Get(id: id, connectionString: connectionString);
    if (vehicle == null) return Results.NotFound("Veículo não encontrado.");

    // Removendo caracteres especiais da exibição do modelo do veículo.
    vehicle.modelo = VehicleModelUnformatter.Unformat(vehicle.modelo);

    return Results.Ok(vehicle);
  }
}