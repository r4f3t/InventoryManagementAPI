using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IM.Core.Domains;
using IM.TransferObjects.Concrete.Response.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IItemService _itemService;
        public ItemsController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpPost]
        public string Post([FromBody] Item item)
        {
            return _itemService.CreateItem(item);
        }

        [HttpGet]
        public DefaultResponse<IEnumerable<Item>> Get()
        {
            var result = new DefaultResponse<IEnumerable<Item>>
            {
                HasResult = true,
                Result = _itemService.GetItems(),
                ResultText = "T"
            };
            return result;
        }
        [HttpGet]
        public DefaultResponse<Item> GetItemByBarcode(string barcode)
        {
            var result = new DefaultResponse<Item>
            {
                HasResult = true,
                Result = _itemService.GetItems(x => x.Barcode == barcode).FirstOrDefault(),
                ResultText = "T"
            };
            return result;

        }
    }
}