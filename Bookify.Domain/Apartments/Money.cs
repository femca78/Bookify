﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookify.Domain.Apartments
{
    public record Money(decimal amount, Currency currency)
    {
        public static Money operator +(Money first, Money second)
        {
            if (first.currency != second.currency)
            {
                throw new InvalidOperationException("Currencies have to be equal!");
            }
            return new Money(first.amount + second.amount, first.currency);
        }

        public static Money Zero() => new(0, Currency.None);
    }
}