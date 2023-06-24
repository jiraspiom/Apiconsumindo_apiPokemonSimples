using Microsoft.OpenApi.Writers;

namespace Apiconsumindoapi.Entidades
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Url { get; set; }
        public List<Type> Types { get; set; }
        public Specie species { get; set; }
    }

    public class Type
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }
    public class Specie
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }
}
