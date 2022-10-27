namespace APIVersioning.Models.RecipeV1
{
    public class Recipe
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public Ingredients Ingredients { get; set; } = new Ingredients();
    }
}