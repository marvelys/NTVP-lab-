using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms
{
    class CertificateDiscounts : IDiscounts
    {
        public double _costOfGoods;
        public double _chosenDiscount;

        public CertificateDiscounts(double _costOfGoods, double _chosenDiscount)
        {
            if (_costOfGoods < 0)
                throw new ArgumentException("Должно быть больше нуля", "_costOfGoods");
            if (_chosenDiscount < 0)
                throw new ArgumentException("Должно быть больше нуля", "_chosenDiscount");

            this._chosenDiscount = _chosenDiscount;
            this._costOfGoods = _costOfGoods;
        }

        double IDiscounts.Discount()
        {
            if ((_costOfGoods - _chosenDiscount) < 0)
                return 0;
            return _costOfGoods - _chosenDiscount;
        }
    }
}
