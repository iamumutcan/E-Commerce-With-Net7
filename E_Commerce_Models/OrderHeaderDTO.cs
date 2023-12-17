﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Models
{
    public class OrderHeaderDTO
    {
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        [Display(Name = "Order Total")]
        public double OrderTotal { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        [Display(Name = "Shipping Date")]
        public DateTime ShippingDate { get; set; }
        [Required]
        public string Status { get; set; }
        //Ödeme sistemi
        public string? SessionId { get; set; }
        public string? PaymentIntentId { get; set; }
        //User
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string PostalCode { get; set; }
        [Required]
        public string AdditionalInformation { get; set; }
        [Required(ErrorMessage = "Please enter email")]
        public string Email { get; set; }
    }
}
