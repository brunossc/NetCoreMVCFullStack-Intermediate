using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NetCoreMVCIntermediate.Data;
using NetCoreMVCIntermediate.Model;
using System.Threading.Tasks;

namespace NetCoreMVCIntermediate.Areas.SecurePages.Pages.Items
{
    public class CreateModel : PageBase
    {
        [BindProperty]
        public Customer Customer { get; set; }

        public CreateModel(ApplicationDbContext context) : base(context)
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _contextBase.Customers.Add(Customer);
            await _contextBase.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}