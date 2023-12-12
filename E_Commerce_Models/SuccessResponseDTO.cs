﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Models
{
    public class SuccessResponseDTO
    {
        public string Title { get; set; }
        public int StatusCode { get; set; }
        public string ErrorMessage { get; set; }
        public object Data { get; set; }
    }
}
