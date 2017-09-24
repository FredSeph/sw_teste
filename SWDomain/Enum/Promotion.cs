using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWDomain.Enum
{
    public enum Promotion : short
    {
        None = 0, // -----------------> Sem promoção
        BuyOneGetOneFree = 1, // -----> Pague 1 e leve 2
        ThreeFor10 = 2 //-------------> 3 por 10 reais
    }
}
