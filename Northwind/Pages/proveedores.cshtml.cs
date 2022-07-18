using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SampleDataLibrary.Data;

namespace NorthwindM.Pages
{
    public class proveedoresModel : PageModel
    {
        public List<Supplier>? Proveedores { get; set; }
        public void OnGet()
        {
            ViewData["Title"] = "Northwind Web - Proveedores";
            using (SampleDataLibrary.Data.Northwind db = new())
            {
                Proveedores = db.Suppliers.ToList();
            }
        }
    }
}
