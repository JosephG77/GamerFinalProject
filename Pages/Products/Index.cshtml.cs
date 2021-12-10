using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Finals.Models;

namespace GamerFinalProject.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly ProductsContext _context;

        public IndexModel(ProductsContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }
        //Paging support
        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 10;

        public async Task OnGetAsync()

        {
            // Gets just the products for the page you are on
            // Use .Skip() and .Take() to select them
            Product = await _context.Product.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
        }
    }
}
