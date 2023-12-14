using PocBlazorApp.Data;
using PocBlazorApp.Models;

namespace PocBlazorApp.Services
{
    public interface IAmplifierService
    {
       Task<List<AmplifierModel>> GetAmplifiersAsync();
    }
}
