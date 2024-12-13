using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace VendasWeb_MVC.Models
{
    public class Seller
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome obrigatorio")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O tamanho do nome deve ser entre 3 e 60")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Email obrigatorio")]
        [EmailAddress(ErrorMessage = "Insira um email valido")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Data de nascimento obrigatorio")]
        [Display(Name = "Data de nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Salario base obrigatorio")]
        [Range(100, 50000, ErrorMessage = "O salario base deve ser entre 100 e 50000")]
        [Display(Name = "Salario base")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double SalarioBase { get; set; }
        public Department Department { get; set; }

        [Display(Name = "Departmento")]
        public int DepartmentId { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();
        public Seller()
        {
        }
        public Seller(int id, string nome, string email, DateTime dataNascimento, double salarioBase, Department department)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            SalarioBase = salarioBase;
            Department = department;
        }
        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }
        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Data >= initial && sr.Data <= final).Sum(sr => sr.Quantia);
        }
    }
}