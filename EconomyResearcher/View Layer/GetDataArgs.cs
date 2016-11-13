using EconomyResearcher.Model_Layer;

namespace EconomyResearcher
{
    public struct GetDataArgs
    {
        private string _uri;
        private IModel m;

        public GetDataArgs(string _uri, IModel _m)
        {
            this._uri = _uri;
            m = _m;
        }

        public string _Uri
        {
            get
            {
                return _uri;
            }
        }

        public IModel M
        {
            get
            {
                return m;
            }
        }
    }
}
