using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace version1_SAE_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Score()
        {
            double score = 0;
            double stockage = 100;
            bool recolter = false;
            System.Drawing.Rectangle rImgChasseNeige = new System.Drawing.Rectangle((int)Canvas.GetLeft(imgChasseNeige), (int)Canvas.GetTop(imgChasseNeige), (int)imgChasseNeige.Width, (int)imgChasseNeige.Height);

            if (rImgChasseNeige.IntersectsWith(rimgNeige))
            {
                label_score.Content = "Stockage : " + score + " / " + stockage;
            } 
        }
        private void Vehicule()
        {
            double vitesse = 5;
        }
        private void InitBitImage()
        {
            chasseNeigeGauche = new BitmapImage(new Uri("pack://application:,,,/img/camionGauche.png"));

        }

    }
}