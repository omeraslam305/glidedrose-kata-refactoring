using System;
using System.Collections.Generic;
using csharp.Services;
using csharp.Services.Interfaces;

namespace csharp.ServiceFactory
{
    public static class UpdateQualityFactory
    {
        /// <summary>
        /// Dynamically create instance of Update logic for specific item.
        /// </summary>
        /// <param name="item">Item for which the instance is required.</param>
        /// <returns>Returns the instance of Update logic of provided item.</returns>
        public static IUpdateItemQuality GetUpdateItemQuality(Item item)
        {
            return item.Name switch
            {
                "+5 Dexterity Vest" or "Elixir of the Mongoose" => new UpdateQualityDefault(),
                "Aged Brie" => new UpdateAgedBrieQuality(),
                "Sulfuras, Hand of Ragnaros" => new UpdateSulfurasHandOfRagnarosQuality(),
                "Backstage passes to a TAFKAL80ETC concert" => new UpdateBackstagePassesToAConcertQuality(),
                "Conjured Mana Cake" => new UpdateConjuredQuality(),
                _ => throw new ArgumentException("Item not found.")
            };
        }
    }
}