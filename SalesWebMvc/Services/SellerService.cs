using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcContext _context;

        // Construct

        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }

        // Methods

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
