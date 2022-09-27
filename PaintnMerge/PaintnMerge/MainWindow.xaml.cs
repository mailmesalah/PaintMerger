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

namespace PaintnMerge
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Point currentPoint = new Point();
        public MainWindow()
        {
            InitializeComponent();            
        }
   

        private void theCanvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ButtonState==MouseButtonState.Pressed)
            {
                currentPoint = e.GetPosition(this);
            }
        }

        private void theCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.LeftButton==MouseButtonState.Pressed)
            {
                Line line = new Line();
                line.Stroke = Brushes.Black;
                line.X1 = currentPoint.X;
                line.Y1 = currentPoint.Y;
                line.X2 = e.GetPosition(this).X;
                line.Y2 = e.GetPosition(this).Y;

                currentPoint = e.GetPosition(this);
                theCanvas.Children.Add(line);
            }            
         
        }
       
    }
}
