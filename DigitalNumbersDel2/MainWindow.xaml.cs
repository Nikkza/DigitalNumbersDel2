using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DigitalNumbersDel2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly List<Button> _listOne;
        private readonly List<Button> _listTwo;
        private readonly List<Button> _listThree;
        private List<Button> _diffListOneListThree;
        private List<Button> _diffListTwoListThree;
        private List<Button> _diffListOneListTwo;
        private List<Button> _diffListThreeListTTwo;
        private List<Button> _diffListThreeListOne;
        private List<Button> _diffListTwoListOne;

        public MainWindow()
        {
            InitializeComponent();
            _listOne = new List<Button>
            {
                Button11,
                Button12,
                Button13,
                Button14,
                Button15
            };
            _listTwo = new List<Button>
            {
                Button6,
                Button11,
                Button16,
                Button17,
                Button13,
                Button9,
                Button10,
                Button15,
                Button20
            };
            _listThree = new List<Button>
            {
                Button11,
                Button6,
                Button16,
                Button17,
                Button18,
                Button19,
                Button20,
                Button13,
                Button8,
                Button15,
                Button10
            };
        }

        private void ButtonShowDigits(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;

            switch (button?.Content)
            {
                case "1":
                    _diffListTwoListOne = _listTwo.Except(_listOne).ToList();
                    foreach (Button b in _diffListTwoListOne)
                        b.Background = Brushes.WhiteSmoke;

                    _diffListThreeListOne = _listThree.Except(_listOne).ToList();
                    foreach (Button b in _diffListThreeListOne)
                        b.Background = Brushes.WhiteSmoke;

                    foreach (Button b in _listOne)
                        b.Background = Brushes.Black;
                    break;
                case "2":
                    _diffListOneListTwo = _listOne.Except(_listTwo).ToList();
                    foreach (Button b in _diffListOneListTwo)
                        b.Background = Brushes.WhiteSmoke;

                    _diffListThreeListTTwo = _listThree.Except(_listTwo).ToList();
                    foreach (Button b in _diffListThreeListTTwo)
                        b.Background = Brushes.WhiteSmoke;

                    foreach (Button b in _listTwo)
                        b.Background = Brushes.Black;
                    break;
                case "3":
                    _diffListOneListThree = _listOne.Except(_listThree).ToList();
                    foreach (Button b in _diffListOneListThree)
                        b.Background = Brushes.WhiteSmoke;

                    _diffListTwoListThree = _listTwo.Except(_listThree).ToList();
                    foreach (Button b in _diffListTwoListThree)
                        b.Background = Brushes.WhiteSmoke;

                    foreach (Button b in _listThree)
                        b.Background = Brushes.Black;
                    break;
            }
        }
    }
}
