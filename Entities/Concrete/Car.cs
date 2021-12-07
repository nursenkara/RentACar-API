using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    //Araç bilgileri olarak; araç adı, modeli, gereken ehliyet yaşı, minimum yaş sınırı, günlük sınır km’si, aracın kendi anlık km’si, airbag, bagaj hacmi, koltuk sayısı, günlük kiralık fiyatı gibi değerleri barındırabilir.
    public class Car:IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public string ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
        public string Model { get; set; }
        public byte RequiredDrivingLicenseAge { get; set; }
        public byte MinimumAgeLimit { get; set; }
        public int DailyLimitKilometer { get; set; }
        public Boolean AirBag { get; set; }
        public int LuggageVolume { get; set; }
        public byte NumberofSeats { get; set; }
        


    }
}
