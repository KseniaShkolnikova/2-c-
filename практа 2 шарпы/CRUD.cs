using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace практа_2_шарпы
{
    public interface CRUD
    {
        void Read(List<zametki> list, DateTime vrema1, string hh, List<zametki> list2);
        void Create(DateTime vrema1, TextBox zametka, TextBox opicanie, ListBox vivod, List<zametki> list);
        void Delete(TextBox zametka, TextBox opicanie, ListBox vivod, List<zametki> list);
        void Update(DateTime vrema1, TextBox zametka, TextBox opicanie, ListBox vivod, List<zametki> list);
    }
}
