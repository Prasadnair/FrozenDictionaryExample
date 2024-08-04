using System.Collections.Frozen;

namespace FrozenDictionaryExample
{
    public class CategoryDictionary
    {
        public FrozenDictionary<string, string> Categories { get; }

        public CategoryDictionary()
        {
            // Initialize the FrozenDictionary with hard-coded values
            var dictionary = new Dictionary<string, string>
        {
            { "A123", "Category1" },
            { "B456", "Category2" },
            { "C789", "Category3" }
        };
            Categories = dictionary.ToFrozenDictionary();
        }

        public string GetCategory(string code)
        {
            // Fast access to values
            return Categories.TryGetValue(code, out var category) ? category : "Unknown Category";
        }
    }
}
