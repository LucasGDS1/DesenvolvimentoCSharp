using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvcEst.Models;
using SalesWebMvcEst.Models.Enums;

namespace SalesWebMvcEst.Data
{
    public class SeedingService
    {
        private SalesWebMvcEstContext _context;

        public SeedingService(SalesWebMvcEstContext context)
        {
            _context = context;
        }

        public void Seed() 
        {
            if(_context.Department.Any() || _context.Seller.Any() ||  _context.SalesRecord.Any() )
            {
                return; //Caso o DB já esteja populado, encerra a função.
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Eletronics");

            Seller s1 = new Seller(1, "Lucas", "lucasgbrsouza@gmail.com", new DateTime(1998, 10, 30), 1700.0, d1);

            SalesRecord sr1 = new SalesRecord(1, new DateTime(2020, 01, 12), 2000.0, SaleStatus.Billed, s1);

            _context.Department.AddRange(d1, d2);
            _context.Seller.AddRange(s1);
            _context.SalesRecord.AddRange(sr1);

            _context.SaveChanges();//Salva e confirma as alterações do DB.
        }
    }
}
