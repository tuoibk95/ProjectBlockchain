using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LoggingWithSerilog.Pages
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
            _logger.LogInformation("You request the index page.");
            try
            {
                for (int i = 0; i < 50; i++)
                {
                    if (i == 23)
                    {
                        throw new Exception("This is our demo exception");
                    }
                    else
                    {
                        _logger.LogInformation("The value of i  is {LoopCountValue}", i);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "We caught this exception in the Index Get call");
            }
        }
    }
}