﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvcEst.Services.Exceptions
{
    public class IntegrityException : ApplicationException
    {
        public IntegrityException(String message) : base(message) { }
    }
}
