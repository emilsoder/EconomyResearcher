using System.Threading.Tasks;
using EconomyResearcher.Data_Layer;

namespace EconomyResearcher.Model_Layer
{
    public interface IModel
    {
        Task<RootObject_Quandl> GetDataAsync(string _uri);
        Task<RootObject_Quandl> RequestAsync(string _jsonData);
        void GetData(GetDataArgs getDataArgs);
    }
}
