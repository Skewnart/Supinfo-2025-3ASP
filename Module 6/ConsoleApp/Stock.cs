namespace ConsoleApp
{
    public class Stock<T> where T : IStorable
    {
        public Dictionary<T, int> Storage { get; private set; }

        public Stock()
        {
            this.Storage = new Dictionary<T, int>();
        }

        public void Add(T item, int quantity = 1)
        {
            if (string.IsNullOrWhiteSpace(item.ISBN))
                throw new StorableMisconfiguredException("L'article est mal configuré", null);

            var article = this.Storage.FirstOrDefault(x => x.Key.ISBN.Equals(item.ISBN));
            if (article.Key != null)
                this.Storage[article.Key] += quantity;
            else
                this.Storage.Add(item, quantity);
        }

        public bool Remove(T item, int quantity = 1)
        {
            if (string.IsNullOrWhiteSpace(item.ISBN))
                return false;

            var article = this.Storage.FirstOrDefault(x => x.Key.ISBN.Equals(item.ISBN));
            if (article.Key == null)
                return false;

            this.Storage[article.Key] -= quantity;

            if (this.Storage[article.Key] <= 0)
                this.Storage.Remove(article.Key);

            return true;
        }

        public void RemoveWhen(Func<T, bool> predicate)
        {
            foreach(T element in this.Storage.Keys.ToList())
            {
                if (predicate(element))
                    this.Storage.Remove(element);
            }
        }

        public int GetQuantity(T item)
        {
            if (string.IsNullOrWhiteSpace(item.ISBN))
                return 0;

            var article = this.Storage.FirstOrDefault(x => x.Key.ISBN.Equals(item.ISBN));
            if (article.Key == null)
                return 0;

            return this.Storage[article.Key];
        }
    }
}
