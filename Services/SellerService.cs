using VendasWeb_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasWeb_MVC.Data;

namespace VendasWeb_MVC.Services
{
    public class SellerService
    {
        private readonly VendasWeb_MVCContext _context;
        public SellerService(VendasWeb_MVCContext context)
        {
            _context = context;
        }
        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}