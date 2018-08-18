using System.Collections.Generic;
using System.Threading.Tasks;
using TheOfficeTrivia_First.API.Models;
using Microsoft.EntityFrameworkCore;

namespace TheOfficeTrivia_First.API.Data
{
    public class OfficeRepository : IOfficeRepository
    {
        private readonly DataContext _context;
        public OfficeRepository(DataContext context) {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        // public async Task<User> GetUser(int id)
        // {
        //     var user = await _context.Users.Include(p => p.Photos).FirstOrDefaultAsync(u => u.Id == id);

        //     return user;
        // }

        // public async Task<IEnumerable<User>> GetUsers()
        // {
        //     var users = await _context.Users.Include(p => p.Photos).ToListAsync();

        //     return users;
        // }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}