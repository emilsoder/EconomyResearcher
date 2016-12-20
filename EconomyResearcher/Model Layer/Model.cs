using System;
using RestSharp;
using Newtonsoft.Json;
using System.Threading.Tasks;
using EconomyResearcher.Data_Layer;

namespace EconomyResearcher.Model_Layer
{
    public class Model : IModel
    {
        private IView view;
        public Model(IView _view)
        {
            view = _view;
        }

        public async Task<RootObject_Quandl> GetDataAsync(string _uri)
        {
            return await RequestAsync(new RestClient(new Uri(_uri)).Execute(new RestRequest(Method.GET)).Content);
        }

        public Task<RootObject_Quandl> RequestAsync(string _jsonData)
        {
            return Task.Run(() => JsonConvert.DeserializeObject<RootObject_Quandl>(_jsonData));
        }

        public async void GetData(GetDataArgs getDataArgs)
        {
            var data = await getDataArgs.M.GetDataAsync(getDataArgs._Uri);
            foreach (var item in data.Dataset.Data)
            {
                DataItems items = DataItems.GetItems(item);
                view.DataGridItems = items;
            }
        }
    }
}


























