using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet8.Delegates
{
    public delegate void PriceChangedHandler(decimal oldPrice, decimal newPrice);
    public interface DelegateClass
    {
        public delegate void RunStart();

        public RunStart RunStartFunc { get; set; }

        public PriceChangedHandler PriceChangedHandler { get; set; }

    }
}
