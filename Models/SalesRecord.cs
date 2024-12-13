using System;
using System.ComponentModel.DataAnnotations;
using VendasWeb_MVC.Models.Enums;

namespace VendasWeb_MVC.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public Double Quantia { get; set; }
        public SaleStatus Status { get; set; }

        [Display(Name = "Vendedor")]
        public Seller Seller { get; set; }
        public SalesRecord()
        {
        }
        public SalesRecord(int id, DateTime data, double quantia, SaleStatus status, Seller seller)
        {
            Id = id;
            Data = data;
            Quantia = quantia;
            Status = status;
            Seller = seller;
        }
    }
}