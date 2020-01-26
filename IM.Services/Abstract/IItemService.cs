using IM.Core.Domains;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

public interface IItemService
{
    IEnumerable<Item> GetItems(Expression<Func<Item, bool>> filter = null);
    string CreateItem(Item item);
    string UpdateItem(Item item);
    string DeleteItem(string itemId);
}
