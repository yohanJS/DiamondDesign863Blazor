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

        public Task<List<AmplifierModel>> GetAmplifiersAsync()
        {
            var amplifiers = _context.AmplifierModel.ToListAsync();
            return amplifiers;
        }
    }
}
