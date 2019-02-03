using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NetCoreMVCIntermediate.Data;
using NetCoreMVCIntermediate.Model;

namespace NetCoreMVCIntermediate.Areas.SecurePages.Pages.Items
{
    public class IndexModel : PageBase
    {
        public IEnumerable<Customer> Customers { get; private set; }

        public IndexModel(ApplicationDbContext context) : base(context)
        {

        }

        //private ILogger<IndexModel> _logger;
        public async Task OnGetAsync()
        {
            Customers = await _contextBase.Customers.AsNoTracking().ToListAsync<Customer>();
        }

        public async Task<IActionResult> OnGetDeleteAsync(int id)
        {
            var customer = await _contextBase.Customers.FindAsync(id);

            if (customer != null)
            {
                _contextBase.Customers.Remove(customer);
                await _contextBase.SaveChangesAsync();
            }          

            return RedirectToPage();
        }
    }
}