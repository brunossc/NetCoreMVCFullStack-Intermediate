using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NetCoreMVCIntermediate.Data;
using NetCoreMVCIntermediate.Model;
using Microsoft.EntityFrameworkCore;

namespace NetCoreMVCIntermediate.Areas.SecurePages.Pages.Items
{
    public class EditModel : PageBase
    {
        [BindProperty]
        public Customer Customer { get; set; }

        public EditModel(ApplicationDbContext context): base(context)
        {
        }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            this.Customer = await _contextBase.Customers.FindAsync(id);

            if (this.Customer == null)
            {
                return RedirectToPage("./Index");
            } 
           
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _contextBase.Attach(Customer).State = EntityState.Modified;

            try
            {
                await _contextBase.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw new Exception("Error trying to update the customer.", ex);
            }
            
            return RedirectToPage("./Index");
        }
    }
}