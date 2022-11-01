namespace APIVersioning.Entities.RecipeV2
{
    public class Recipe
    {
        public Guid Id { get; set; }
        public string? RecipeName { get; set; }
        public List<string> Ingredients { get; set; } = new List<string>();
    }
}