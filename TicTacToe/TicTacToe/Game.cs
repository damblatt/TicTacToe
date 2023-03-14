using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Game
    {
        public int FieldSize { get; set; }
        private Field _field;
        private Player _player1;
        private Player _player2;
        private Stack<Field> _history;
        private GameState _state;
        private Utility _helper = new Utility();
        private Player _currentPlayer;

        enum GameState
        {
            RUNNING, OVER
        }

        public Game()
        {
            FieldSize = GetFieldSize();
            CreateField();
            GetPlayers();
            this._history = new Stack<Field>();
            this._state = GameState.OVER;

            Random rnd = new Random();
            this._currentPlayer = rnd.Next(100) < 50 ? _player1 : _player2;
        }

        public void Start()
        {
            this._state = GameState.RUNNING;

            Console.Clear();

            // Game Loop
            while (this._state == GameState.RUNNING)
            {
                this._field.Draw();

                int[] position = this._currentPlayer.GetInput();
                this._field.SetCell(this._currentPlayer, position);

                if (this._currentPlayer == this._player1)
                    this._currentPlayer = this._player2;
                else 
                    this._currentPlayer = _player1;

                Console.Clear();
            }
        }

        public void Stop()
        {

        }

        private void GetPlayers()
        {
            Console.Write("Player 1 Name: ");
            string? p1Name = Console.ReadLine();
            Console.Write("Player 1 Symbol: ");
            string? p1Symbol = Console.ReadLine();

            if (p1Name == null) p1Name = "Player 1";
            if (p1Symbol == null) p1Symbol = "X";

            Console.Write("Player 2 Name: ");
            string? p2Name = Console.ReadLine();
            Console.Write("Player 2 Symbol: ");
            string? p2Symbol = Console.ReadLine();

            if (p2Name == null) p2Name = "Player 2";
            if (p2Symbol == null) p2Symbol = "O";

            this._player1 = new Player(p1Name, p1Symbol);
            this._player2 = new Player(p2Name, p2Symbol);
        }

        public int GetFieldSize()
        {
            return _helper.ReadInt(3, "Game field size: ");
        }

        public void CreateField()
        {
            _field = new Field(FieldSize);
        }
    }
}
