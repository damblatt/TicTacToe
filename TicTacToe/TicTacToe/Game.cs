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
            _player1 = new Player();
            _player2 = new Player();
        }

        public void Start()
        {
            FieldSize = GetFieldSize();
            CreateField();
        }

        public void Stop()
        {

        }

        public int GetFieldSize()
        {
            int _minFieldSize = 3;
            string instructionMessage = "bruh";
            return _helper.ReadInt(_minFieldSize, instructionMessage);
        }

        public void CreateField()
        {
            _field = new Field(FieldSize);
        }
    }
}
