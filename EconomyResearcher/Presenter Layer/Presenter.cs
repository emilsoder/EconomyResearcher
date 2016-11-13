using EconomyResearcher.Model_Layer;

namespace EconomyResearcher.Presenter_Layer
{
    public class Presenter
    {
        #region URI STRINGS
        private string USUnemployment = "https://www.quandl.com/api/v3/datasets/FRED/LNU03000000.json?api_key=LvkogDxsEAdhaU9RsXpT&collapse=quarterly&start_date=2011-09-30";
        private string UKUnemployment = "https://www.quandl.com/api/v3/datasets/UKONS/LMS_MGSX_Q.json?api_key=LvkogDxsEAdhaU9RsXpT&start_date=2011-03-31";
        private string ChinaUnemployment = "https://www.quandl.com/api/v3/datasets/NBSC/A040C03_A.json?api_key=LvkogDxsEAdhaU9RsXpT";
        #endregion

        private IView v;
        private IModel m;

        public Presenter(IView _view, IModel _model)
        {
            v = _view;
            m = _model;
        }

        public void GetDataUK()
        {
            m.GetData(new GetDataArgs(UKUnemployment, m));
            v.ComboBoxText = "United Kingdom";
        }

        public void GetDataChina()
        {
            m.GetData(new GetDataArgs(ChinaUnemployment, m));
            v.ComboBoxText = "China";
        }

        public void GetDataUSA()
        {
            m.GetData(new GetDataArgs(USUnemployment, m));
            v.ComboBoxText = "United States";
        }
    }
}
