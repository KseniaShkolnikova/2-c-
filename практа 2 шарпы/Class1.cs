using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Windows.Documents;
using System.Windows.Controls;

namespace практа_2_шарпы
{
    public class logic : CRUD
    {
        public void Read(List<zametki>list, DateTime vrema1,string hh, List<zametki> list2)
        {
            
            list2.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                if (vrema1 == list[i].vrema)
                {
                    list2.Add(list[i]);
                }
            }

            
        }
        public void Create(DateTime vrema1,TextBox zametka, TextBox opicanie, ListBox vivod, List<zametki> list)
        {
            zametki zametks = new zametki();
            zametks.vrema = vrema1;
            zametks.name = zametka.Text;
            zametks.opicanie = opicanie.Text;
            vivod.ItemsSource = zametks.name;
            list.Add(zametks);
            zametka.Text = null;
            opicanie.Text = null;
        }
        public void Delete(TextBox zametka, TextBox opicanie, ListBox vivod, List<zametki> list)
        {
            zametki delete = vivod.SelectedItem as zametki;
            list.Remove(delete);
            zametka.Text = null;
            opicanie.Text = null;
        }
        public void Update(DateTime vrema1, TextBox zametka, TextBox opicanie, ListBox vivod, List<zametki> list)
        {
            zametki update = vivod.SelectedItem as zametki;
            list.Remove(update);
            zametki zametks = new zametki();
            zametks.vrema = vrema1;
            zametks.name = zametka.Text;
            zametks.opicanie = opicanie.Text;
            vivod.ItemsSource = zametks.name;
            list.Add(zametks);
            zametka.Text = null;
            opicanie.Text = null;
        }
    }
}
