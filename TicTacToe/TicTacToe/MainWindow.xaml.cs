using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GameController gameController = new GameController();

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = gameController;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var clickedButton = sender as Button;

            if (!string.IsNullOrEmpty(clickedButton.Content.ToString()) || gameController.GameOver)
            {
                return; //this square already taken or game is over
            }

            clickedButton.Content = gameController.GetPlayer();
            string buttonName = clickedButton.Name;
            gameController.Game_grid[getXCoordinate(buttonName), getYCoordinate(buttonName)] = gameController.GetPlayer();

            if (gameController.IsGameOver())
            {
                gameController.GameOver = true;
                gameController.DeclareWinner(clickedButton.Content.ToString());
                HighlightWinningCells();
            }
            else
            {
                gameController.SwitchPlayer();
            }
        }

        private void HighlightWinningCells()
        {
            foreach (Control control in BoardGrid.Children)
            {
                if (control.GetType() == typeof(Button))
                {
                    Button btn = ((Button)control);
                    string buttonName = btn.Name;
                    //only check square buttons
                    if (!buttonName.StartsWith("Square"))
                    {
                        continue;
                    }
                    //button names are of the form, Square##, where ## are the coordinates of the board.
                    if (gameController.WinningCoordinates.Contains(buttonName.Substring(buttonName.Length - 2, 2)))
                    {
                        btn.Background = Brushes.DeepSkyBlue;
                    }
                }

                
            }
        }

        private void ClearBoardGrid()
        {
            foreach (Control control in BoardGrid.Children)
            {
                if (control.GetType() == typeof(Button))
                {
                    Button btn = ((Button)control);
                    if (btn.Name.StartsWith("Square"))
                    {
                        btn.Content = string.Empty;
                        btn.Background = Brushes.White;
                    }
                }
            }
        }

        private int getYCoordinate(string name)
        {
            //name contains the button name
            //button names are formated where last two chars are indexes
            return int.Parse(name.Substring(name.Length - 1, 1));
        }

        private int getXCoordinate(string name)
        {
            //name contains the button name
            //button names are formated where last two chars are indexes
            return int.Parse(name.Substring(name.Length - 2, 1));
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            gameController.ResetGame();
            ClearBoardGrid();
        }
    }
}
