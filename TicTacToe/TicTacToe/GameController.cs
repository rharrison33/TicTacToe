using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace TicTacToe
{
    class GameController : INotifyPropertyChanged
    {
        private int active_player = 0;                  //Odd is player X, Even is player Y
        private char[,] game_grid = new char[3, 3];     //Structure representing state of game
        private bool x_wins;
        private bool o_wins;

        public event PropertyChangedEventHandler PropertyChanged;

        public char[,] Game_grid { get => game_grid; set => game_grid = value; }

        public bool O_wins {
            get { return o_wins; }
            set { o_wins = value; OnPropertyChanged("O_wins"); }
        }

        public bool X_wins
        {
            get { return x_wins; }
            set { x_wins = value; OnPropertyChanged("X_wins"); }
        }

        // Create the OnPropertyChanged method to raise the event
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        //Increments player, can also be used to see how many moves have happend.
        public void SwitchPlayer()
        {
            active_player++;
        }

        public char GetPlayer()
        {
            return active_player % 2 == 0 ? 'X' : 'O';
        }

        public bool IsGameOver()
        {
            if(active_player < 4)
            {
                return false;   //minimum 5 total moves before someone can win.
            }

            for(int i = 0; i < 3; i++)
            {
                //check for horizontal winner
                if(game_grid[i, 0] != '\0' && game_grid[i,0] == game_grid[i,1] && game_grid[i,1] == game_grid[i,2])
                {
                    return true;
                }
                //check for vertical winner
                else if (game_grid[0,i] != '\0' && game_grid[0,i] == game_grid[1,i] && game_grid[1,i] == game_grid[2,i])
                {
                    return true;
                }
                //check for diagonal winner when i == 0
                else if(i == 0)
                {
                    if(game_grid[i, 0] != '\0' && game_grid[i,0] == game_grid[i+1,i+1] && game_grid[i,0] == game_grid[i + 2, i + 2])
                    {
                        return true;
                    }
                }
                //check for diagonal winner when i == 3
                else if (i == 3)
                {
                    if (game_grid[i, 0] != '\0' && game_grid[i, 0] == game_grid[i - 1, i + 1] && game_grid[i, 0] == game_grid[i - 2, i + 2])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        internal void DeclareWinner(string winner)
        {
            if (winner.Equals("X"))
            {
                X_wins = true;
            }
            else
            {
                O_wins = true;
            }
        }


    }
}
