using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Finals.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GamerFinalProject.Pages.Products
{
    public class AddReviewModel : PageModel
    {
        private readonly ILogger<AddReviewModel> _logger;
        private readonly ProductsContext _context; // Products database context
        [BindProperty]
        public Review Review {get; set;}
        public SelectList ProductsDropDown {get; set;}

         public AddReviewModel(ProductsContext context, ILogger<AddReviewModel> logger)
        {
            // Bring in Database context and logger using dependency injection
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            ProductsDropDown = new SelectList(_context.Product.ToList(), "ProductId", "ProductName");
        }

         public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Review.Add(Review);
            _context.SaveChanges();

            return RedirectToPage("./Index");
        }




    }
}