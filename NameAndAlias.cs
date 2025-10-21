public class CharacterNameAndAlias
{
  public string? Name { get; set; }

  public List<string> Alias { get; set; } = [];

  public string Display()
  {
    return $"\nName: {Name}\nAlias: {string.Join(", ", Alias)}\n";
  }
}