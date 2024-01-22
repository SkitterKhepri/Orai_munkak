using csaladfa_cs.Modellek;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace csaladfa_cs.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Console.WriteLine("megy a szar");
            csaladfa_cs.Modellek.Szemely sz = new Szemely();
            sz.Id = 1;
            sz.Nev = "Taylor Hebert";
            sz.SzuletesiDatum = DateTime.Parse("2001-11-12");
            sz.SzuletesiHely = "Brockton Bay";
        }
    }
}