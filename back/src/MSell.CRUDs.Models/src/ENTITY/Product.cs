using MSell.CRUDs.Share.src.ENUMS;

namespace MSell.CRUDs.Share.src.ENTITY
{
    public class Product : BaseEntity
    {
        public string Description { get; set; }

        public string ClientCode { get; set; }

        public string BARCODE { get; set; }

        public MeasureUnitType MeasureType { get; set; }

        public decimal UnitPrice { get; set; }
    }
}
