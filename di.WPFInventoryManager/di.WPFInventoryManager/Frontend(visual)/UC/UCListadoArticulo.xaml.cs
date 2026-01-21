using di.WPFInventoryManager.MVVM;
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

namespace di.WPFInventoryManager.Frontend_visual_.UC
{
    /// <summary>
    /// Interaction logic for UCListadoArticulo.xaml
    /// </summary>
    public partial class UCListadoArticulo : UserControl
    {
        private MVArticulo _mvArticulo;
        public UCListadoArticulo(MVArticulo mvArticulo)
        {
            InitializeComponent();
            _mvArticulo = mvArticulo;
        }

        private async void ucListadoArticulo_Loaded(object sender, RoutedEventArgs e)
        {
            await _mvArticulo.Inicializa();
            this.DataContext = _mvArticulo;
        }
    }
}
