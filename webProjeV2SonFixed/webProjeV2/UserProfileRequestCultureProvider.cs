using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using System.Threading.Tasks;

namespace webProjeV2
{

    public class UserProfileRequestCultureProvider : IRequestCultureProvider
    {
        public static string culture;
        public void changeLan(string lan)
        {
            culture = lan;
            
        }
        public Task<ProviderCultureResult> DetermineProviderCultureResult(HttpContext httpContext)
        {
            return Task.FromResult(new ProviderCultureResult(culture));
        }
    }
}