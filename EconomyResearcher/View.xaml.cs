using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using EconomyResearcher.Data_Layer;
using EconomyResearcher.Model_Layer;
using EconomyResearcher.Presenter_Layer;

namespace EconomyResearcher
{
    public partial class View : Window, IView
    {
        private Presenter p;

        public View()
        {
            InitializeComponent();
            var m = new Model(this);
            p = new Presenter(this, m);
        }

        private void btnChina_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.Items.Clear();
            p.GetDataChina();
        }

        private void btnUSA_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.Items.Clear();
            p.GetDataUSA();
        }

        private void btnUK_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.Items.Clear();
            p.GetDataUK();
        }

        public void SetDataGridItems(DataItems items)
        {
            dataGrid.Items.Add(items);
        }

        public string ComboBoxText
        {
            get
            {
                return comboBox.Text;
            }
            set
            {
                comboBox.Text = value;
            }
        }
    }
}

















