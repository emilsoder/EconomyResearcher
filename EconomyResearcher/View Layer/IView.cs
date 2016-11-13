using System;
using System.Linq;
using System.Collections.Generic;
using EconomyResearcher.Data_Layer;

namespace EconomyResearcher
{
    public interface IView
    {
        string ComboBoxText { get; set; }
        void SetDataGridItems(DataItems items);
    }
}
