namespace TheHubCafe.Migrations
{
    using System.Data.Entity.Migrations;
    using Food_Spot.Models;
    internal sealed class Configuration : DbMigrationsConfiguration<Food_Spot.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Food_Spot.Models.ApplicationDbContext context)
        {
            context.Orders.AddOrUpdate(p => p.PizzaName,
       new Food_Spot.Models.Order
       {
           PizzaName = "Debra Garcia",
           SaladName = "1234 Main St",
           PastaName = "Redmond",

       },
          new Food_Spot.Models.Order
          {
              PizzaName = "Deb Garcia",
              SaladName = "12 Main St",
              PastaName = "Reond",

          });
        }
    }
}
