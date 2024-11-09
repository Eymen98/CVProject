﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVProject.Core.DTOs
{
    public class LanguageDto
    {
        public int Id { get; set; }
        public int? PersonId { get; set; }
        public string? LanguageName { get; set; }
        public string? LanguageValue { get; set; }
    }
}
