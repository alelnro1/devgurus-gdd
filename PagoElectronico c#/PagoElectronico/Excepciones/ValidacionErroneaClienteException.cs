﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Excepciones
{
    class ValidacionErroneaClienteException : Exception
    {
        public ValidacionErroneaClienteException()
        {
        }

        public ValidacionErroneaClienteException(string message)
            : base(message)
        {
        }

        public ValidacionErroneaClienteException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
