using csharp.Services.Interfaces;

namespace csharp.Services
{
    public class UpdateBackstagePassesToAConcertQuality : IUpdateItemQuality
    {
        /// <inheritdoc />
        public void Update(Item item)
        {
            item.SellIn--;
            switch (item.SellIn)
            {
                // Drops the quality to 0 after concert
                case < 0:
                    item.Quality = 0;
                    return;
                // Increase the quality by day as long as the value is less than 50
                case >= 10:
                    item.Quality += item.Quality < 50 ? 1 : 0;
                    break;
                // Increase the quality twice when days left are less than 10 as long as the value is less than 50
                case < 10:
                    item.Quality += item.Quality < 50 ? 2 : 0;
                    break;
            }
            
            // Increase the quality thrice when days left are less than 5 as long as the value is less than 50
            item.Quality += item.SellIn < 5 && item.Quality < 50 ? 1 : 0;
        }
    }
}