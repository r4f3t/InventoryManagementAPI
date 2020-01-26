using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IM.Core.Domains;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.WebApi.Controllers
{
    [Route("api/[controller]")]
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
        public IEnumerable<Item> Get()
        {
            return _itemService.GetItems();
        }
        [HttpGet("{barcode}")]
        public Item Get(string barcode)
        {
            return _itemService.GetItems(x=>x.Barcode==barcode).FirstOrDefault();
        }
    }
}