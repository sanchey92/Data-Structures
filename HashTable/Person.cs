namespace HashTable
{
  public class Person
  {
    public string Name { get; set; }
    public int Age { get; set; }
    public int Gender { get; set; }

    public override string ToString() => Name;
    
    public override int GetHashCode() => Name.Length + Age + Gender + (int)Name[0];
  }
}