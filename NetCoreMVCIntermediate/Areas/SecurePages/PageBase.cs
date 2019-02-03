using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NetCoreMVCIntermediate.Data;

namespace NetCoreMVCIntermediate.Areas.SecurePages
{
    [Authorize]
    public class PageBase : PageModel
    {
        protected readonly ApplicationDbContext _contextBase;
        public PageBase(ApplicationDbContext context)
        {
            _contextBase = context;
        }
    }
}
