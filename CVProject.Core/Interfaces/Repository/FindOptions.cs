﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVProject.Core.Interfaces.Repository
{
    public class FindOptions
    {
        public bool IsIgnoreAutoIncludes { get; set; }
        public bool IsAsNoTracking { get; set; }
    }
}