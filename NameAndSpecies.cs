public class CharacterNameAndSpecies
{
  public string? Name { get; set; }

  public string? Species { get; set; }

  public string Display()
  {
    return $"\nName: {Name}\nSpecies: {Species}\n";
  }
}