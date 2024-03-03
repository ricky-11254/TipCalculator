using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculator.Models
{
    public class TipCalculatorResult
    {
        public decimal Amount { get; set; }

        public int TipPercentage { get; set; }

        public decimal TipAmount { get; set; }
    }
}