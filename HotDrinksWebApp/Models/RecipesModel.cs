using System;
namespace HotDrinksWebApp.Models
{
    public class RecipesModel
    {
        public string LemonTea { get; set; }
        public string Coffee { get; set; }
        public string Chocolate { get; set; }

        public RecipesModel(string lemontea, string coffee,string chocoalte)
        {
            this.LemonTea = lemontea;
            this.Coffee = coffee;
            this.Chocolate = chocoalte;
        }

    }
}
