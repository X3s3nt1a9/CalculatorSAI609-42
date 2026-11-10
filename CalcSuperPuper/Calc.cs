namespace CalcSuperPuper
{
    public interface ICalc
    {
        string Display { get; }
        void SetChar(char someChar);
    }

    public class Calc : ICalc
    {
        private char? _operation = null;
        private double? _firstOperand = null;
        private double? _secondOperand = null;

        public string Display { get; private set; } = "0";

        public void SetChar(char someChar)
        {
            switch (someChar)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':

                    if (_operation.HasValue && _firstOperand == null)
                    {
                        _firstOperand = Convert.ToDouble(Display);
                        Display = "0";
                    }

                    if (Display == "0")
                    {
                        Display = someChar.ToString();
                    }
                    else
                    {
                        Display += someChar.ToString();
                    }
                    break;
                case '+':
                case '-':
                case 'x':
                case '/':
                    _operation = someChar;
                    break;

                case '=':

                    _secondOperand = Convert.ToDouble(Display);

                    if (_operation == '+')
                    {
                        _firstOperand = _firstOperand + _secondOperand;
                        Display = _firstOperand.ToString() ?? "0";
                    }
                    break;

                default:
                    break;
            }
        }
    }
}
