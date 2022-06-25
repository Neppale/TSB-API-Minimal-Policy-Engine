static class VehicleYearValidator
{
  private static string[] approvedFuels = new string[] { "Gasolina", "Alcool", "Diesel", "Flex", "Tetrafuel", "Alcool/Gasolina" };
  /**<summary> Valida se o ano do veículo está no formato adequado. </summary>*/
  public static bool Validate(string year)
  {
    // Deve retornar falso se ano não seguir o seguinte formato: YYYY Combustível
    Regex regex = new Regex(@"[0-9]+ \w");
    bool isValid = regex.IsMatch(year);
    return isValid;
  }
}