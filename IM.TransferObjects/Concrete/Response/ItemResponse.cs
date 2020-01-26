using IM.TransferObjects.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace IM.TransferObjects.Concrete.Response
{
    public class ItemResponse:ITransferModel
    {
        public string Id { get; set; }
        public string Barcode { get; set; }
        public string StockName { get; set; }
        public string StockCode { get; set; }
        public string Specode { get; set; }
        public string Specode2 { get; set; }
        public string Specode3 { get; set; }
        public string Specode4 { get; set; }
        public string Warehouse { get; set; }
        public int WarehouseId { get; set; }
    }
}
