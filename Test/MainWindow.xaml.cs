using System;
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

namespace Test
{
    public partial class MainWindow : Window
    {
        List<TestView> TestViews = new List<TestView>();
        public MainWindow()
        {
            InitializeComponent();

            for (int i = 1; i < Core.DB.User.Count() + 1; i++)
            {
                var user = Core.DB.User.Where(u => u.Id == i).FirstOrDefault();
                var ent = new TestView(user.Name, user.Description, user.Picture, user.Manufacturer, user.Cost, user.Count);
                TestViews.Add(ent);
            }

            LV.ItemsSource = TestViews;
        }
    }
}
