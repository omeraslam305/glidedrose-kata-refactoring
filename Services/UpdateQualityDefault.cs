using csharp.Services.Interfaces;

namespace csharp.Services
{
    public class UpdateQualityDefault : IUpdateItemQuality
    {
        /// <inheritdoc />
        public void Update(Item item)
        {
            item.SellIn--;
            
            // decrease quality by day as long as the quality is greater than 0
            item.Quality -= item.Quality > 0 ? 1 : 0;
            
            // decreasing quality twice as selling date has passed
            item.Quality -= item.SellIn < 0 && item.Quality > 0 ? 1 : 0;
        }
    }
}