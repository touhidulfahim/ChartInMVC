using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartInMVC.Repository
{
    public interface IChart
    {
        void ProductWiseSales(out string MobileCountList, out string ProductList);
        void StateWiseSales(out string MobileCountList, out string StateNameList);

    }
}
