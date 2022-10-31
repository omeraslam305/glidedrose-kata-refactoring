using csharp.Services.Interfaces;

namespace csharp.Services
{
    public class UpdateAgedBrieQuality : IUpdateItemQuality
    {
        /// <inheritdoc />
        public void Update(Item item)
        {
            item.SellIn--;
            
            // increase quality by day as long as the value is less than 50
            item.Quality += item.Quality < 50 ? 1 : 0;
            
            // increasing quality twice as selling date has passed
            item.Quality += item.SellIn < 0 && item.Quality < 50 ? 1 : 0;
        }
    }
}