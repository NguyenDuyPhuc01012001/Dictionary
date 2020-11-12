using System;

namespace Từ_điển
{
    public class DictionaryData : IComparable<DictionaryData>
    {
        public string Key { get; set; }
        public string Explanation { get; set; }

        public override string ToString()
        {
            return Explanation;
        }
        public int CompareTo(DictionaryData obj) // OverRight phương thức CompareTo của Interface IComparable
        {
            return this.Key.CompareTo(obj.Key);
        }
    }
}
