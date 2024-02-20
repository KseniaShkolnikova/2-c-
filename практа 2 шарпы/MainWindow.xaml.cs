using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace практа_2_шарпы
{
    public  partial class MainWindow : Window
    {
        List<zametki> list2 = new List<zametki>();
        logic logic = new logic();
        DateTime vrema1;
        string hh = "\\ezednev.json";
        List<zametki> list = new List<zametki>();
        private void vrema_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            vrema1 = Convert.ToDateTime(vrema.Text);
            vivodzametk();
        }
        
        public MainWindow()
        {
            list = SerDes.Desir<List<zametki>>(hh) ?? new List<zametki>();
            InitializeComponent();
            string kk = DateTime.Now.ToString();
            vrema.Text = kk;
        }
        public void vivodzametk()
        {
            vivod.DisplayMemberPath = null;
            logic.Read(list, vrema1, hh, list2);
            vivod.ItemsSource = list2;
            vivod.DisplayMemberPath = "name";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            logic.Create(vrema1,zametka,opicanie,vivod,list);
            SerDes.Serialize(list, hh);
            vivodzametk();
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            logic.Delete( zametka, opicanie, vivod, list);
            SerDes.Serialize(list,hh);
            vivodzametk();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            logic.Update(vrema1, zametka, opicanie, vivod, list);
            SerDes.Serialize(list, hh);
            vivodzametk();
        }

        private void vivod_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            zametki viv = vivod.SelectedItem as zametki ?? new zametki();
            zametka.Text = viv.name;
            opicanie.Text = viv.opicanie;

        }
    }
}
