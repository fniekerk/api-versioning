namespace APIVersioning.Entities.RecipeV1
{
    public class Recipe
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public List<string> Ingredients { get; set; } = new List<string>();
    }
}