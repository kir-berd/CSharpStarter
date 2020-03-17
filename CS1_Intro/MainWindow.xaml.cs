using System.Windows;

namespace CS1_Intro
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Обработчик нажатия на кнопку
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }
    }
}
