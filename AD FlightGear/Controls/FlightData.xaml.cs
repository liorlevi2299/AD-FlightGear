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

namespace AD_FlightGear.Controls
{
    /// <summary>
    /// Interaction logic for FlightData.xaml
    /// </summary>
    public partial class FlightData : UserControl
    {
        private VM_FlightData vM_FlightData;
        public void setVm_flightData(VM_FlightData vM_Flight)
        {
            this.vM_FlightData = vM_Flight;
            DataContext = vM_FlightData;
        }
        public FlightData()
        {
            InitializeComponent();
        }
    }
}
