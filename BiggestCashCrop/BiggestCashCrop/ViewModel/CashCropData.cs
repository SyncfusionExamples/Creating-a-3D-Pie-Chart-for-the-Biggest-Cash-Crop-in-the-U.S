using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestCashCrop
{
    public class CashCropData
    {
        public ObservableCollection<CashCropModel> Data { get; set; }

        public CashCropData()
        {
            this.Data = new ObservableCollection<CashCropModel>
            {
                 new CashCropModel("Cotton", 7.5),
                 new CashCropModel("Corn", 82.6),
                 new CashCropModel("Cannabis", 5),
                 new CashCropModel("Soybeans", 57.5),
                 new CashCropModel("Hay", 19.3),
                 new CashCropModel("Wheat", 11.9)
            };
        }
    }
}
