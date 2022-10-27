namespace APIVersioning.Models.RecipeV2
{
    public class Recipe
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public Ingredients Ingredients { get; set; } = new Ingredients();
    }
}