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
        private void ListButtons(List<Button> s)
        {
            foreach (Button b in s)
                b.Background = Brushes.Black;
        }

        private void CalcDigits(List<Button> diff, List<Button> one, List<Button> two)
        {
            diff = one.Except(two).ToList();
            foreach (Button b in diff)
                b.Background = Brushes.WhiteSmoke;
        }

        private void ButtonShowDigits(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;

            switch (button?.Content)
            {
                case "1":
                    ListButtons(_listOne);
                    CalcDigits(_diffListTwoListOne, _listTwo, _listOne);
                    CalcDigits(_diffListThreeListOne, _listThree, _listOne);
                    break;
                case "2":
                    ListButtons(_listTwo);
                    CalcDigits(_diffListOneListTwo, _listOne, _listTwo);
                    CalcDigits(_diffListThreeListTTwo, _listThree, _listTwo);
                    break;
                case "3":
                    ListButtons(_listThree);
                    CalcDigits(_diffListOneListThree, _listOne, _listThree);
                    CalcDigits(_diffListTwoListThree, _listTwo, _listThree);
                    break;

            }
        }
    }
}
