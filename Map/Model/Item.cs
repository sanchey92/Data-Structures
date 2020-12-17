namespace Map.Model
{
    public class Item<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }

        public Item(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }
        
        public override int GetHashCode() => Key.GetHashCode();

        public override string ToString() => Value.ToString();
    }
}