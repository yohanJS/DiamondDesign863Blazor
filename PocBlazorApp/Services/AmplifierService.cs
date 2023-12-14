using Microsoft.EntityFrameworkCore;
using PocBlazorApp.Data;
using PocBlazorApp.Models;

namespace PocBlazorApp.Services
{
    public class AmplifierService : IAmplifierService
    {
        private readonly ApplicationDbContext _context;

        public AmplifierService(ApplicationDbContext context) 
        {
            _context = context;
        }

        public async Task<AmplifierModel> CreateAmplifierAsync(AmplifierModel amplifier)
        {
            _context.AmplifierModel.Add(amplifier);
            await _context.SaveChangesAsync();

            return amplifier;
        }

        public async Task<List<AmplifierModel>> GetAmplifiersAsync()
        {
            // Simulate asynchronous loading to demonstrate streaming rendering
            await Task.Delay(500);
            var amplifiers = _context.AmplifierModel.ToList();
            return amplifiers;
        }
    }
}
