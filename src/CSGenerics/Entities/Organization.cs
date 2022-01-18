namespace CSGenerics.Entities
{
    public class Organization: EntityBase
    {
        public int Id {get; set;}
        public string Name { get; set; }

        public override string ToString() => $"Id: {Id}, FirstName: {Name}";
    }
}