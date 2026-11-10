using CalcSuperPuper;

namespace Calculator
{
    public partial class MainPage : ContentPage
    {
        private ICalc _calc = new Calc();

        public MainPage()
        {
            InitializeComponent();
            Display.Text = _calc.Display;
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var buttonText = button.Text;
            var firstCharFromButtonText = buttonText[0];

            _calc.SetChar(firstCharFromButtonText);

            Display.Text = _calc.Display;
        }

        private void ShowHistory(object sender, EventArgs e)
        {
            HistoryScroll.IsVisible = true;
            MemoryScroll.IsVisible = false;
        }

        private void ShowMemory(object sender, EventArgs e)
        {
            HistoryScroll.IsVisible = false;
            MemoryScroll.IsVisible = true;
        }

        private void ClearClicked(object sender, EventArgs e)
        {
            bool isHistory = HistoryScroll.IsVisible;
            var list = isHistory ? HistoryList : MemoryList;
            var emptyLabel = isHistory ? EmptyHistoryLabel : EmptyMemoryLabel;

            foreach (var b in list.Children.OfType<Button>().ToList())
                list.Children.Remove(b);

            emptyLabel.IsVisible = true;
        }
    }
}
