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

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        private int targetNumber;
        private Random random;

        public MainWindow()
        {
            InitializeComponent();
            random = new Random();
            StartNewGame();
        }

        private void StartNewGame()
        {
            targetNumber = random.Next(1, 101);
            resultLabel.Content = string.Empty;
            guessTextBox.Text = string.Empty;
        }

        private void GuessButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(guessTextBox.Text, out int guess))
            {
                if (guess < targetNumber)
                {
                    resultLabel.Content = "Muito baixo! Tente novamente.";
                }
                else if (guess > targetNumber)
                {
                    resultLabel.Content = "Muito alto! Tente novamente.";
                }
                else
                {
                    resultLabel.Content = "Parabéns! Você acertou!";
                    StartNewGame();
                }
            }
            else
            {
                resultLabel.Content = "Por favor, insira um número válido.";
            }
        }
    }
}