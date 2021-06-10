using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace practice2.Models
{
    public class StatModel
    {
        [Display(Name = "Категория")]
        public string category_name { get; set; }
        [Display(Name = "Товар")]
        public string product_name { get; set; }
        [Display(Name = "Количество")]
        [NotMapped]
        public int ProdAmount { get; set; }
        [Display(Name = "Сумма выручки")]
        [NotMapped]
        public decimal Summa { get; set; }
    }
}