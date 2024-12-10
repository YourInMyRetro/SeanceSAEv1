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
            InitBitImage();
        }
        public static readonly VITESSE_CHASSE_NEIGE = 5;
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
            chasseNeigeDroite = new BitmapImage(new Uri("pack://application:,,,/img/camionDROITE.png"));
            chasseNeigeHaut = new BitmapImage(new Uri("pack://application:,,,/img/camionHAUT.png"));
            chasseNeigeBas = new BitmapImage(new Uri("pack://application:,,,/img/camionBAS.png"));

        }
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            double decaleGauche = Canvas.GetLeft(imgChasseNeige);
            if (e.Key == Key.Right && decaleGauche < 735)
            {
                imgChasseNeige.Source = chasseNeigeDroite;
                double newDecaleDroite = decaleGauche + PAS_PERE_NOEL;
                Canvas.SetLeft(img_Pere_Noel, newDecaleDroite);
            }
            if (e.Key == Key.Left && decaleGauche > 1)
            {
                img_Pere_Noel.Source = pereNoelGauche;
                double newDecaleGauche = decaleGauche - PAS_PERE_NOEL;
                Canvas.SetLeft(img_Pere_Noel, newDecaleGauche);
            }
        }

    }
}