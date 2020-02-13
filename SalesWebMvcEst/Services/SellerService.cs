using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvcEst.Data;
using SalesWebMvcEst.Models;
using Microsoft.EntityFrameworkCore;
using SalesWebMvcEst.Services.Exceptions;

namespace SalesWebMvcEst.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcEstContext _context;

        public SellerService(SalesWebMvcEstContext context)
        {
            _context = context;
        }

        public async Task<List<Seller>> FindAllAsync()
        {
            return await _context.Seller.ToListAsync();
        } 

        public async Task Insert(Seller obj)
        {
            
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Seller> FindByiDAsync(int id)
        {
            return await _context.Seller.Include(obj => obj.Department).FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task RemoveSellerAsync(int id)
        {
            try
            {
                var obj = _context.Seller.Find(id);
                _context.Seller.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateException e)
            {
                throw new IntegrityException(e.Message);
            }
            
        }

        public async Task Update(Seller obj)
        {
            var hasAny = await _context.Seller.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny)
            {
                throw new NotFoundException("Id is not found");
            }

            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            } 
            catch(DbConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message); // Relançando a exceção do DB a nível de serviço
            }
           
        }
    }
}
