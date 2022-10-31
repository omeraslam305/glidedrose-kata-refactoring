using System.Collections.Generic;
using csharp.ServiceFactory;
using csharp.Services.Interfaces;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> items;
        public GildedRose(IList<Item> _items)
        {
            this.items = _items;
        }

        public void UpdateQuality()
        {
            foreach (var item in items)
            {
                var itemQuality = UpdateQualityFactory.GetUpdateItemQuality(item);
                itemQuality.Update(item);
            }
        }
    }
}
