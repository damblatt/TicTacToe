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
        public int FieldSize { get; set; }
        private Field _field;
        private List<Player> _listOfPlayers = new List<Player>();
        private Player _playerOne;
        private Player _playerTwo;
        private Stack<Field> _history;
        private GameState _state;
        private Utility _helper = new Utility();

        enum GameState
        {
            RUNNING, OVER
        }

        /// <summary>
        /// Creating a (new) game creates a field and adds players to the game.
        /// </summary>
        public Game()
        {
            FieldSize = GetFieldSize();
            CreateField();
            AddPlayers();
            _history = new Stack<Field>();
        }

        public void Start()
        {
           
        }

        public void Stop()
        {

        }

        private void AddPlayers()
        {
            _playerOne = new Player(1);
            _playerTwo = new Player(2);
            _listOfPlayers.Add(_playerOne);
            _listOfPlayers.Add(_playerTwo);

            CustomizePlayerProfiles();
            SetIndividualPlayerInformation();
            if (_playerTwo.Name == _playerOne.Name) _playerTwo.Name = "Player 2";
        }

        public void CustomizePlayerProfiles()
        {
            foreach (Player player in _listOfPlayers)
            {
                // get name
                {
                    _helper.Write($"{player.Name}, you can now enter a custom name if you want to: ");
                    string? playerName = Console.ReadLine().Trim();
                    if (playerName != null && playerName != "")
                    {
                        player.Name = playerName;
                    }
                }

                // get symbol
                {
                    _helper.Write($"{player.Name}, please enter a symbol: ");
                    player.Symbol = _helper.ReadSymbol();
                }
            }
        }

        public void SetIndividualPlayerInformation()
        {
            if (_playerTwo.Name == _playerOne.Name && _playerOne.Name != "Player 2") _playerTwo.Name = "Player 2";
            else if (_playerTwo.Name == _playerOne.Name && _playerOne.Name == "Player 2") _playerOne.Name = "Player 1";
        }

        public int GetFieldSize()
        {
            _helper.Write("Enter the field size: ");
            return _helper.ReadInt(3);
        }

        public void CreateField()
        {
            _field = new Field(FieldSize);
        }
    }
}
