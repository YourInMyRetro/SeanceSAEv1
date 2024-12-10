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
        public static readonly int VITESSE_CHASSE_NEIGE = 5;
        public static BitmapImage chasseNeigeGauche;
        public static BitmapImage chasseNeigeDroite;
        public static BitmapImage chasseNeigeHaut;
        public static BitmapImage chasseNeigeBas;
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
            double decaleHaut = Canvas.GetTop(imgChasseNeige);
            if (e.Key == Key.Right && decaleGauche < 450)
            {
                imgChasseNeige.Source = chasseNeigeDroite;
                double newDecaleDroite = decaleGauche + VITESSE_CHASSE_NEIGE;
                Canvas.SetLeft(imgChasseNeige, newDecaleDroite);
            }
            if (e.Key == Key.Left && decaleGauche > 1)
            {
                imgChasseNeige.Source = chasseNeigeGauche;
                double newDecaleGauche = decaleGauche - VITESSE_CHASSE_NEIGE;
                Canvas.SetLeft(imgChasseNeige, newDecaleGauche);
            }
            if (e.Key == Key.Up && decaleHaut > 1)
            {
                imgChasseNeige.Source = chasseNeigeHaut;
                double nouvDecaleHaut = decaleHaut + VITESSE_CHASSE_NEIGE;
                Canvas.SetTop(imgChasseNeige, nouvDecaleHaut);
            }
            if (e.Key == Key.Down && decaleHaut < 450)
            {
                imgChasseNeige.Source = chasseNeigeBas;
                double nouvDecaleBas = decaleHaut - VITESSE_CHASSE_NEIGE;
                Canvas.SetTop(imgChasseNeige, nouvDecaleBas);
            }
        }

    }
}