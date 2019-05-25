using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MojtabaBookStore.Models;
using MojtabaBookStore.Models.Repository;
using MojtabaBookStore.Models.UnitOfWork;

namespace MojtabaBookStore.Areas.Admin.Pages.Publishers
{
    public class CreateModel : PageModel
    {
        private readonly IUnitOfWork uw;
        private readonly IBaseRepository<Publisher> repo;

        public CreateModel(IUnitOfWork uw)
        {
            this.uw = uw;
            repo = uw.BaseRepository<Publisher>();
        }


        public Publisher Publisher { get; set; }
        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            await repo.Create(Publisher);
            await uw.Commit();
            return RedirectToPage("./Index");
        }
    }
}