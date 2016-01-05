using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms
{
    class PercentDiscounts : IDiscounts
    {
        public double _costOfGoods;
        public double _chosenDiscount;

        public PercentDiscounts(double _costOfGoods, double _chosenDiscount)
        {
            if (_costOfGoods < 0)
                throw new ArgumentException("Должно быть больше нуля", "_costOfGoods");//исключение с указаннным сообщением об ошибке
            if (_chosenDiscount < 0 || _chosenDiscount > 1)
                throw new ArgumentException("Должно быть от 0 до 1", "_chosenDiscount");

            this._chosenDiscount = _chosenDiscount;
            this._costOfGoods = _costOfGoods;
        }

        double IDiscounts.Discount()
        {
            return _costOfGoods - _costOfGoods * _chosenDiscount;
        }
    }
}
