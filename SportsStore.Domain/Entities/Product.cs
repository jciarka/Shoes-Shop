﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ShoesStore.Domain.Entities
{
    public class Product
    {
        
        [HiddenInput(DisplayValue = false)]
        public int ProductID { get; set; }


        [Required(ErrorMessage = "Proszę podać nazwę produktu.")]
        [Display(Name = "Nazwa")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Proszę podać opis.")]
        [DataType(DataType.MultilineText), Display(Name = "Opis")]
        public string Description { get; set; }


        [Required]
        [Range(0.01, double.MaxValue,ErrorMessage = "Proszę podać cenę")]
        [Display(Name = "Cena")]
        public decimal Price { get; set; }


        [Required(ErrorMessage = "Proszę podać kategorię")]
        [Display(Name = "Kategoria")]
        public string Category { get; set; }


        public byte[] ImageData { get; set; }
        public string ImageMimeType { get; set; }
    }
}
