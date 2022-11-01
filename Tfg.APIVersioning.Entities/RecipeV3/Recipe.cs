namespace APIVersioning.Entities.RecipeV3
{
    public class Recipe
    {
        public Guid Id { get; set; }
        public string? RecipeName { get; set; }
        public List<string> Ingredients { get; set; } = new List<string>();
        public List<string> Categories { get; set; } = new List<string>();

    }
}