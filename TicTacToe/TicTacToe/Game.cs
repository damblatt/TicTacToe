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

        enum GameState
        {
            RUNNING, OVER
        }

        public Game()
        {
            FieldSize = GetFieldSize();
            CreateField();
            AddPlayers();
            this._history = new Stack<Field>();
        }

        public void Start()
        {
           
        }

        public void Stop()
        {

        }

        private void AddPlayers()
        {
            char p1Symbol = 'X';
            char p2Symbol = 'O';
            Console.Write("Player 1 Name: ");
            string? p1Name = Console.ReadLine();
            Console.Write("Player 1 Symbol: ");
            p1Symbol = _helper.ReadSymbol();

            if (p1Name == null) p1Name = "Player 1";

            Console.Write("Player 2 Name: ");
            string? p2Name = Console.ReadLine();
            Console.Write("Player 2 Symbol: ");
            p2Symbol = _helper.ReadSymbol();

            if (p2Name == null || p2Name == p1Name) p2Name = "Player 2";

            this._player1 = new Player(p1Name, p1Symbol);
            this._player2 = new Player(p2Name, p2Symbol);
        }

        public int GetFieldSize()
        {
            return _helper.ReadInt(3);
        }

        public void CreateField()
        {
            _field = new Field(FieldSize);
        }
    }
}
