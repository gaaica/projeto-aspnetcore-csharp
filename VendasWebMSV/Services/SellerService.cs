using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasWebMSV.Models;

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

    }
}
