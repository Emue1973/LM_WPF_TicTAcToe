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

namespace WPF_TicTAcToe
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
        //Übung 02, Aufgabe 03
        //die Farben des Button beim Anklicken einmalig invertieren
        private void Btn_kaestchen_1_1_Click(object sender, RoutedEventArgs e)
        {
            //die aktuelle Farbeinstellungen sichern
            //durch die Speicherung der Farbeinstellungen, kann die
            //Invertierung wieder umgekehrt werde
            Brush tempBackground = btn_kaestchen_1_1.Background;
            Brush tempForeground = btn_kaestchen_1_1.Foreground;

            //die Farben invertieren
            btn_kaestchen_1_1.Background = tempForeground;
            btn_kaestchen_1_1.Foreground = tempBackground;
        }
    }
}
