using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        // Construct

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return; // O banco de dados já foi populado
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Fashion");
            Department d3 = new Department(3, "Books");
            Department d4 = new Department(4, "Food");

            Seller s1 = new Seller(1, "Gabriel de Oliveira Lopes", "lopesgabriel0199@gmail.com", new DateTime(1999, 1, 13), 1000.0, d1);
            Seller s2 = new Seller(2, "Matheus de Oliveira Lopes", "mat-lopes@gmail.com", new DateTime(1999, 1, 13), 1000.0, d1);
            Seller s3 = new Seller(3, "Indinária dos Santos", "indinariasantos@gmail.com", new DateTime(1999, 10, 26), 1400.0, d2);
            Seller s4 = new Seller(4, "Paulo Lopes", "paulinhogeo@bol.com.br", new DateTime(1943, 10, 10), 2500.0, d3);
            Seller s5 = new Seller(5, "Ivaneide Lopes de Oliveira", "nutneide@bol.com.br", new DateTime(1964, 12, 23), 2500.0, d4);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 12, 20), 11000.0, SaleStatus.Billed, s1);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5);
            _context.SalesRecord.Add(r1);
            _context.SaveChanges();
        }
    }
}
