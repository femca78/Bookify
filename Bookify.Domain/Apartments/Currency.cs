using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookify.Domain.Apartments
{
    public record Currency
    {
        public static readonly Currency None = new Currency("", "");
        public static readonly Currency Usd = new Currency("USD", "$");
        public static readonly Currency Eur = new Currency("EUR", "€");
        public static readonly Currency Real = new Currency("BRL", "R$");
        private Currency(string code, string symbol)
        {
            Code = code;
            Symbol = symbol;
        }
        public string Code { get; init; }
        public string Symbol { get; init; }

        public static IReadOnlyCollection<Currency> All = new[] { Usd, Eur, Real };
        public static Currency FromCode(string code)
        {
            return All.FirstOrDefault(c => c.Code == code) ?? throw new ApplicationException("The currency code is invalid!");
        }

    }

}
