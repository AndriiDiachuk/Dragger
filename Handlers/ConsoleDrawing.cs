using GameEngine;
using GameEngine.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handlers
{
    public class ConsoleDrawing
    {
        // Console controls to display information on the screen
        #region Private fields
        private Level _level;
        private string _item;
        private static string[,] _map;
        #endregion

        #region Constructors
        public ConsoleDrawing(Level level)
        {
            this._level = level;
        }
        #endregion

        #region Draw
        public void DrawLevel()
        {

            int levelWidth = (_level.Width);
            int levelHeight = (_level.Height);
            _map = new string[_level.Height, _level.Width];

            for (int i = 0; i < _level.LevelMap.GetLength(0); i++)
            {
                for (int j = 0; j < _level.LevelMap.GetLength(1); j++)
                {
                    string image = GetLevelImage(_level.LevelMap[i, j], _level.SokoDirection);
                    _map[i, j] = image;

                    Console.Write(image);
                    
                    if (_level.LevelMap[i, j] == ItemType.Dragger ||
                        _level.LevelMap[i, j] == ItemType.DraggerOnGoal)
                    {
                        _level.SokoPosX = i;
                        _level.SokoPosY = j;
                    }
                }
                Console.WriteLine();
            }
        }
        public string[,] DrawChanges()
        {

            string image1 = GetLevelImage(_level.Item1.ItemType, _level.SokoDirection);
            _map[_level.Item1.XPos, _level.Item1.YPos] = image1;

            string image2 = GetLevelImage(_level.Item2.ItemType, _level.SokoDirection);
            _map[_level.Item2.XPos, _level.Item2.YPos] = image2;

            if (_level.Item3 != null)
            {
                string image3 = GetLevelImage(_level.Item3.ItemType, _level.SokoDirection);
                _map[_level.Item3.XPos, _level.Item3.YPos] = image3;
            }

            return _map;
        }
        public string GetLevelImage(ItemType itemType, MoveDirection direction)
        {
            if (itemType == ItemType.Wall)
            {
                _item = "#";
            }
            else if (itemType == ItemType.Floor)
            {
                _item = " ";
            }
            else if (itemType == ItemType.Package)
            {
                _item = "@";
            }
            else if (itemType == ItemType.Goal)
            {
                _item = "X";
            }
            else if (itemType == ItemType.Dragger)
            {
                if (direction == MoveDirection.Up)
                {
                    _item = "Y";
                }
                else if (direction == MoveDirection.Down)
                {
                    _item = "Y";
                }
                else if (direction == MoveDirection.Right)
                {
                    _item = "Y";
                }
                else
                {
                    _item = "Y";
                }
            }
            else if (itemType == ItemType.PackageOnGoal)
            {
                _item = "@";
            }
            else if (itemType == ItemType.DraggerOnGoal)
            {
                if (direction == MoveDirection.Up)
                {
                    _item = "Y";
                }
                else if (direction == MoveDirection.Down)
                {
                    _item = "Y";
                }
                else if (direction == MoveDirection.Right)
                {
                    _item = "Y";
                }
                else
                {
                    _item = "Y";
                }
            }
            else
            {
                _item = " ";
            }
            return _item;
        }
        public void DrawMap(string[,] map)
        {
            Console.Clear();
            for (int i = 0; i < map.GetLength(0); i++)                        
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[i, j] == "#")
                    {
                        Console.Write(map[i, j]);
                    }
                    if (map[i, j] == "X")
                    {
                        Console.Write(map[i, j]);
                    }
                    if (map[i, j] == "@")
                    {
                        Console.Write(map[i, j]);
                    }
                    if (map[i, j] == " ")
                    {
                        Console.Write(map[i, j]);
                    }
                    if (map[i, j] == "Y")
                    {
                        Console.Write(map[i, j]);
                    }
                }
                Console.WriteLine();
            }
        }
        #endregion
    }
}

