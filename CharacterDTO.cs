public class CharacterDTO
{
  public UInt64 Id { get; set; }
  public string? Name { get; set; }

  public List<string> Alias { get; set; } = [];
  public List<string> Series { get; set; } = [];
  public string Display()
  {
    return $"Id: {Id}\nName: {Name}\nAlias: {string.Join(", ", Alias)}\nSeries: {string.Join(", ", Series)}\n";
  }
}