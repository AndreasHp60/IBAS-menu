using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IBAS_menu.Pages;

public class NyIndexModel : PageModel
{
    private readonly ILogger<NyIndexModel> _logger;

    public NyIndexModel(ILogger<NyIndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
