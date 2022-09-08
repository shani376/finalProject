﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transaction.DTO
{
    public class TransactionDto
    {
        [Required]
        public int AccountFromId { get; set; }
        [Required]
        public int AccountToId { get; set; }
        [Required]
        [Range(1,100000000)]
        public int Amount { get; set; }
    }
}