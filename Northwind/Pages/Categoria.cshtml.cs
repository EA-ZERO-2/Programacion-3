using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SampleDataLibrary.Data;

namespace NorthwindM.Pages
{
    public class CategoriaModel : PageModel
    {
        public List<Category>? Categories { get; set; }
        public void OnGet()
        {
            ViewData["Title"] = "Northwind Web - Categoria";
            using (SampleDataLibrary.Data.Northwind db = new())
            {
                Categories = db.Categories.ToList();
            }
        }
    }
}
