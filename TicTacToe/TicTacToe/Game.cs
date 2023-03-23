using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Game
    {
        public static int FieldSize { get; set; } = 3;
        private Field _field;
        public Player PlayerOne;
        public Player PlayerTwo;
        private Player _currentPlayer;
        private GameState _state;
        private Stack<Field> _history;

        enum GameState
        {
            IDLE, RUNNING, OVER
        }

        /// <summary>
        /// creates a field, adds the players to the game and randomly sets the current player
        /// </summary>
        /// <param name="playerOne">Player one</param>
        /// <param name="playerTwo">Player two</param>
        public Game(Player playerOne, Player playerTwo)
        {
            _history = new Stack<Field>();
            _state = GameState.IDLE;

            CreateField();
            AddPlayers(playerOne, playerTwo);
            SetCurrentPlayer();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Start()
        {
            _state = GameState.RUNNING;
            
            SetCurrentPlayer();

            while (_state == GameState.RUNNING)
            {
                Console.Clear();

                _field.PrintField();
                Coordinate _coordinate;
                bool _isAvailable;
                do
                {
                    _coordinate = _currentPlayer.GetInput();
                    _isAvailable = _field.Cells[_coordinate.Y, _coordinate.X].Free;
                } while (!_isAvailable);

                _field.SetCell(_currentPlayer, _coordinate);

                if (_currentPlayer == PlayerOne)
                    _currentPlayer = PlayerTwo;
                else 
                    _currentPlayer = PlayerOne;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Stop()
        {

        }

        private void AddPlayers(Player _playerOne, Player _playerTwo)
        {
            PlayerOne = _playerOne;
            PlayerOne.AddPlayerToGame(this);

            PlayerTwo = _playerTwo;
            PlayerTwo.AddPlayerToGame(this);
        }

        /// <summary>
        /// 
        /// </summary>
        public void SetIndividualPlayerInformation()
        {
            SetIndividualNames();
            SetIndividualSymbols();
        }

        private void SetIndividualNames()
        {
            if (PlayerTwo.Name == PlayerOne.Name && PlayerOne.Name != "Player 2") PlayerTwo.Name = "Player 2";
            else if (PlayerTwo.Name == PlayerOne.Name && PlayerOne.Name == "Player 2") PlayerOne.Name = "Player 1";
        }

        private void SetIndividualSymbols()
        {
            if (PlayerTwo.Symbol == PlayerOne.Symbol && PlayerOne.Symbol != 'O') PlayerTwo.Symbol = 'O';
            else if (PlayerTwo.Symbol == PlayerOne.Symbol && PlayerOne.Symbol == 'O') PlayerOne.Symbol = 'X';
        }

        public void SetCurrentPlayer()
        {
            Random rnd = new Random();
            _currentPlayer = rnd.Next(100) < 50 ? PlayerOne : PlayerTwo;
            _history = new Stack<Field>();
        }

        public int GetFieldSize()
        {
            Utility.Write("Enter the field size: ");
            return Utility.ReadInt(3);
        }

        public void CreateField()
        {
            _field = new Field(FieldSize);
        }
    }
}
