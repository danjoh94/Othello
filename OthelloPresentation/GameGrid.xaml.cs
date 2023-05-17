using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
using System.Xml.Linq;

namespace OthelloPresentation
{
    /// <summary>
    /// Interaction logic for GameGrid.xaml
    /// </summary>
    public partial class GameGrid : UserControl
    {
        public ObservableCollection<ObservableCollection<Brush>> GameGridColor { get; set; } = new();

        public GameGrid()
        {
            for (int i = 0; i < 8; i++) 
            {
                GameGridColor.Add(new ObservableCollection<Brush>());
                for (int j = 0; j < 8; j++)
                    GameGridColor[i].Add(new SolidColorBrush());
            }
                
            InitializeComponent();
            
            this.DataContext = this;
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Trace.WriteLine(e.GetPosition(Grid));
            int h = (int)Grid.ActualHeight;
            int w = (int)Grid.ActualWidth;
            Point p = e.GetPosition(Grid);
            int r = (int)p.Y * 8 / h;
            int c = (int)p.X * 8 / w;
            Trace.WriteLine("("+ c.ToString() + ","+r.ToString()+")");
            var point = Mouse.GetPosition(sender as Canvas);
            Trace.WriteLine("(" + point.X.ToString() + "," + point.Y.ToString() + ")");

            //var t = (SolidColorBrush)GameGridColor[r][c];
            //t.Color = Colors.Blue;
        }


    }
}
