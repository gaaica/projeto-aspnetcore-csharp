using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasWebMSV.Models;
using Microsoft.EntityFrameworkCore;

namespace VendasWebMSV.Services
{
    public class SellerService
    {
        private readonly VendasWebMSVContext _context;

        public SellerService(VendasWebMSVContext context)
        {
            _context = context;
        }

        public List<Seller> FildAll()
        {
            return _context.Seller.ToList();
        }

        public void InsertSeller(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Seller FindById(int id)
        {
            return _context.Seller.Include(obj => obj.Department).FirstOrDefault(x => x.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();

        }
    }
}
