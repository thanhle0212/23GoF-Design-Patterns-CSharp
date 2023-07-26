using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoRSample
{
    public interface IHandler
    {
        public void SetTheNextHandler(IHandler handler);

        public void Process(GadgetPurchase request);
    }
}