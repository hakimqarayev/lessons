using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Device : Base
    {

        private string _barcode { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        private decimal _buyPrice { get; set; }

        private decimal _sellPrice { get; set; }

        private decimal _offerPrice { get; set; }


        public decimal BuyPrice
        {

            get
            {
                return _buyPrice;
            }

            set
            {
                if (value < 1)
                    Console.WriteLine("Alis qiymeti 1-den kicik ola bilmez!");
                else
                    this._buyPrice = value;
            }
        }
        public decimal SellPrice
        {
            get
            {
                return _sellPrice;
            }

            set
            {
                if (value < _buyPrice)
                    Console.WriteLine("Satis qiymeti alis qiymetinden az ola bilmez!");
                else
                    this._sellPrice = value;
            }
        }

        public decimal OfferPrice
        { 
            get
            {
                return this._offerPrice;
            }

            set
            {
                if (value < 1)
                    Console.WriteLine("Kompaniya qiymeti 1 - den kicik ola bilmez!");
                else
                    this._offerPrice = value;
            }
        }

        public string Barcode
        {
            get { return this._barcode; }
            set
            {
                bool checkBarcode = Database.CheckBarcode(value);

                if (!checkBarcode)
                    _barcode = value;
                else
                    Console.WriteLine("Bu barkod daha once basqa mehsul ucun sisteme elave olunub!");
            }
        }


    }
}



