﻿using System.Collections.Generic;
using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace VendasWeb_MVC.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();
        public Department()
        {
        }
        public Department(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}