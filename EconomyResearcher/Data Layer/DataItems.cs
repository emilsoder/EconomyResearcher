using System.Collections.Generic;

namespace EconomyResearcher.Data_Layer
{
    public class DataItems
    {
        public static DataItems GetItems(IList<string> item)
        {
            var items = new DataItems()
            {
                Date = item[0],
                Value = item[1]
            };
            return items;
        }
        public string Date { get; set; }
        public string Value { get; set; }
    }
}
