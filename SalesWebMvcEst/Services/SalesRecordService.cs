using Microsoft.EntityFrameworkCore;
using SalesWebMvcEst.Data;
using SalesWebMvcEst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvcEst.Services
{
    public class SalesRecordService
    {
        private readonly SalesWebMvcEstContext _context;

        public SalesRecordService(SalesWebMvcEstContext context)
        {
            _context = context;
        }

        public async Task<List<SalesRecord>> FindByDate(DateTime? dateInitial, DateTime? dateFinal) //Interrogação para opcional
        {
            var result =  from obj in _context.SalesRecord select obj;
            if(dateInitial.HasValue)
            {
                result = result.Where(x => x.Date >= dateInitial.Value);
            }
            if (dateFinal.HasValue)
            {
                result = result.Where(x => x.Date <= dateFinal.Value);
            }

            return await result
                .Include(x => x.Seller) //Inner Join
                .Include(x => x.Seller.Department) // Inner Join
                .OrderByDescending(x => x.Date) //Ordenação
                .ToListAsync(); //To list of method async
            //return _context.SalesRecord.Where(x => x.Date == dateInitial & x.Date == dateFinal);
        }

        public async Task<List<IGrouping<Department,SalesRecord>>> FindByDateGrouping(DateTime? dateInitial, DateTime? dateFinal) //Interrogação para opcional
        {
            var result = from obj in _context.SalesRecord select obj;
            if (dateInitial.HasValue)
            {
                result = result.Where(x => x.Date >= dateInitial.Value);
            }
            if (dateFinal.HasValue)
            {
                result = result.Where(x => x.Date <= dateFinal.Value);
            }

            return await result
                .Include(x => x.Seller)
                .Include(x => x.Seller.Department)
                .OrderByDescending(x => x.Date)
                .GroupBy(x => x.Seller.Department)
                .ToListAsync();
            //return _context.SalesRecord.Where(x => x.Date == dateInitial & x.Date == dateFinal);
        }
    }
}
