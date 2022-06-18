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
using System.Windows.Shapes;
using System.Xml;

namespace NET_ININ3_PR1_z4
{
    /// <summary>
    /// Logika interakcji dla klasy SzczegółyGrupy.xaml
    /// </summary>
    public partial class SzczegółyGrupy : Window
    {
        public SzczegółyGrupy(XmlNode grupa)
        {
            DataContext = grupa;
            InitializeComponent();
        }
    }
}
