namespace csharp.Services.Interfaces
{
    public interface IUpdateItemQuality
    {
        /// <summary>
        /// Update quality and sell in value of an item
        /// </summary>
        /// <param name="item">Item to update</param>
        void Update(Item item);
    }
}