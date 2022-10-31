using csharp.Services.Interfaces;

namespace csharp.Services
{
    public class UpdateConjuredQuality : IUpdateItemQuality
    {
        /// <inheritdoc />
        public void Update(Item item)
        {
            item.SellIn--;
            
            // decreasing quality twice by day
            item.Quality -= 2;
        }
    }
}