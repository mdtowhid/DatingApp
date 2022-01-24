﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bees.Shared.DTO
{
    public class ApiResponseDto<T>
    {
        public List<T>? Results { get; set; }
        public T? Result { get; set; }
        public int StatusCode { get; set; }
        public string? Message { get; set; }
    }
}
