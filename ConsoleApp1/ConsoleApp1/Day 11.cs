﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Day11
    {
        private string _input = "...........................#.......#.....................#................#.......................................#.............#...........\r\n..................................................#...........................................#.......................................#.....\r\n........#....................................#....................................#.......................#.................................\r\n........................................................................................................................#...................\r\n#...................#.......................................#...............................................................................\r\n...............#.......................................................................#...........#...........#............#...............\r\n........................................................#...........................................................................#.......\r\n..............................................#.....................#...................................#...................................\r\n.............................#......#.....................................#.................................................................\r\n.......................#...........................#............................................#.................#.........................\r\n.....#.....................................................................................................................................#\r\n...........#......#...............................................#..............................................................#..........\r\n.......................................................................................#...................#................................\r\n..............................#........................#....................................................................#...............\r\n.................................................#..........#......................................#........................................\r\n........#................................#...................................................#..........#.....#......#......................\r\n.........................#.........................................................................................................#........\r\n............#.................................................................#.........#...................................................\r\n....................#.......................................................................................................................\r\n............................................#.............#.................................................................................\r\n..............................#.....#...........................................................#........................................#..\r\n#.........#........................................#............#................................................................#..........\r\n.........................................................................................................#..................................\r\n..................#.....................................#..............................#.............................#.......#..............\r\n...........................#..............................................#.................................................................\r\n...........................................................................................#......#.........................................\r\n.......................#.......#..................#..........#....................................................................#......#..\r\n.....#.............................................................#............................................#...........................\r\n....................................#............................................#......................................#...................\r\n.....................................................................................................................................#......\r\n..............#.............................#.......#....................................#..................................................\r\n.........#......................................................#.................................................#...........#.............\r\n............................................................................................................................................\r\n.#.....................................................................#..........#....................#....................................\r\n..................................#....................................................................................................#....\r\n...........#.........#............................#......#........................................#.........................................\r\n................................................................................................................................#...........\r\n..............................................................................................#.............................................\r\n......................................#..............#.......................................................#...........#..................\r\n....#............#.........................................#................................................................................\r\n............#..............#.............................................................#..................................................\r\n...............................................#...................................................#..........................#............#\r\n..................................#.........................................................................................................\r\n........................................................................#...........#...............................#.....#.................\r\n#.........#..............#..................................................................................................................\r\n.......................................................................................................................................#....\r\n................#..........................................#................#................#.................#..................#.........\r\n...................................................................#........................................................................\r\n................................................#....................................................#......................................\r\n.....................................................#..........................................#...........................................\r\n..........................#.................................................................................................................\r\n.....#.....#.....................................................................#.......#..............................#...................\r\n.....................#........................#...............................................................#................#............\r\n................................#........#............................................................#.....................................\r\n.................................................................................................#................#.........................\r\n..................................................................#.................................................................#.......\r\n............................................................................................................................................\r\n................................................#.....#.................#................#....................................#.............\r\n......................#.....................................................................................#........#..................#...\r\n..........#........................#................................................#.......................................................\r\n....#.............#...................................................................................#...........................#.........\r\n.........................................#..................................................#.....................#.........................\r\n............................................................................................................................................\r\n..........................#..................#..........................#.................................................#.................\r\n.......................................................................................#......................#.............................\r\n................................#......#.....................#................................#......................#..................#...\r\n............................................................................................................................................\r\n........#.........#.................................................................#.......................................#......#........\r\n..........................................#........#........................................................................................\r\n............................................................................................................................................\r\n...............................................................................................#.......................#....................\r\n............................#............................................................................#.................................#\r\n............................................................................................................................................\r\n......#...........#...................................#........#........#...................................................................\r\n....................................................................................#.........................................#.............\r\n.......................................#.........#......................................................................#...................\r\n............................................................................................................................................\r\n..............................#..................................................................................#..........................\r\n.......................#......................................................#................#............................................\r\n........#..........................................................#..................#................#...........................#........\r\n.............#.....#................#.......................................................................................................\r\n.........................................#...............................#.....................................#............................\r\n.#...........................................................#...................#..................#.......................................\r\n...........................#.................#............................................................................#.................\r\n.......................................................#..................................................#.........#.....................#.\r\n......................................................................................#........#............................................\r\n......#.........#.................#............................#................................................................#...........\r\n..........................................................................#.................................................................\r\n...........#.........#.........................................................................................#............................\r\n...........................................#..............#.................................................................#...............\r\n.....................................................#.............#...................................................................#....\r\n....#.........#.................#................................................................................................#..........\r\n.......................#.......................................................#..................#........#............#...................\r\n......................................#..................................#...................#..............................................\r\n.......#.....................................#......................................................................#.......................\r\n..#..........................#...........................#..........................#.......................................................\r\n...........#.............................................................................#......................#......................#....\r\n...............................................................#.........................................#..................#...............\r\n.................#......................#........#...............................#..........................................................\r\n......................#.......................................................................#......#..............................#.......\r\n............................#......#......................#.................................................................................\r\n...........................................#.............................#..........................................#.....#.................\r\n...........#......................................................................................#.....................................#...\r\n.......................................................#..........#....................................#.......#.................#..........\r\n...............................#........................................................#...................................................\r\n..#.....#.............................#................................#....................................................................\r\n..................................................#...........................#.............................#...............................\r\n.............................................................................................#.....#........................................\r\n...............#........................................#.............................................................#.....................\r\n#....................#...........#..........................................................................................................\r\n............................#..............#..............................#.......................................................#.........\r\n.....................................................................................#......................................................\r\n.................#...........................................................................................#..............................\r\n.........#..............#............................................................................................#...................#..\r\n....................................#................#..............................................#.......................................\r\n...............................#.........#.................#...................#.........................#..................#...............\r\n#.............................................#........................................#....................................................\r\n......................................................................#..........................................#..........................\r\n.............#...............................................................................#........#...............................#.....\r\n...#............................................................#............................................#..........#..................#\r\n...................................................#........................................................................................\r\n..........................................#..............................#..................................................#...............\r\n.............................................................#....................#.....................................................#...\r\n.....................#..............#..................#................................................#...................................\r\n.......#.......................#........................................................#.......#..............#.................#..........\r\n..........................................................................................................................#.................\r\n...#.......................................#....................#...................#.......................................................\r\n..................#.........................................................................................................................\r\n...........................#...........#...................................................................#......#.........................\r\n................................#.............#....................#........................................................................\r\n.........................................................................................#.......#..........................................\r\n.......#.....................................................#................................................................#...........#.\r\n..................................................#.......................#.................................................................\r\n.............#...................................................................................................#...................#......\r\n............................#.........#................#.............................#................#.....................................\r\n......................#.......................................................................#...........................#.................\r\n............................................................................................................................................\r\n.............................................................................................................#.......#............#.........\r\n.......#...........#.....#.....#.............................#..............................................................................\r\n.............#...............................#..........#..........................................#......................................#.";

        public void Part1()
        {
            //_input = "...#......\r\n.......#..\r\n#.........\r\n..........\r\n......#...\r\n.#........\r\n.........#\r\n..........\r\n.......#..\r\n#...#.....";

            var baseMap = _input.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.ToCharArray()).ToArray();

            var map = new List<List<char>>();

            var expandedColumnIds = new List<int>();

            for (var i = 0; i < baseMap[0].Length; i++)
            {
                var columnContainsGalaxy = baseMap.Any(col => col[i] != '.');

                if (!columnContainsGalaxy)
                {
                    expandedColumnIds.Add(i);
                }
            }

            var emptyRow = baseMap[0].Select(_ => '.').ToList();

            for (var i = 0; i < expandedColumnIds.Count; i++)
            {
                emptyRow.Add('.');
            }

            for (int i = 0; i < baseMap.Length; i++)
            {
                var rowIsEmpty = baseMap[i].All(x => x == '.');
                if (rowIsEmpty)
                {
                    map.Add(emptyRow);
                }

                var row = baseMap[i];
                var currentRow = new List<char>();
                for (int j = 0; j < row.Length; j++)
                {
                    var column = row[j];

                    var c = baseMap[i][j];

                    currentRow.Add(c);

                    if (expandedColumnIds.Contains(j))
                    {
                        currentRow.Add('.');
                    }

                }
                map.Add(currentRow);
            }

            var galaxyCoordinates = new Queue<(int, int)>();

            for (int row = 0; row < map.Count; row++)
            {
                for (int col = 0; col < map[row].Count; col++)
                {
                    var c = map[row][col];
                    if (c == '#')
                    {
                        galaxyCoordinates.Enqueue((row, col));
                    }
                }
            }

            long distance = 0;
            (int, int) currentCoords;
            while (galaxyCoordinates.TryDequeue(out currentCoords))
            {
                foreach (var (x, y) in galaxyCoordinates)
                {
                    distance += Math.Abs(x - currentCoords.Item1) + Math.Abs(y - currentCoords.Item2);
                }
            }

            Console.WriteLine(distance);
        }
        public void Part2()
        {
            //_input = "...#......\r\n.......#..\r\n#.........\r\n..........\r\n......#...\r\n.#........\r\n.........#\r\n..........\r\n.......#..\r\n#...#.....";

            int emptyRowMultiplier = 999_999;
            var baseMap = _input.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.ToCharArray()).ToArray();

            var map = new List<List<char>>();

            var expandedColumnIds = new List<int>();
            var expandedRowIds = new List<int>();
            for (var i = 0; i < baseMap[0].Length; i++)
            {
                var columnContainsGalaxy = baseMap.Any(col => col[i] != '.');

                if (!columnContainsGalaxy)
                {
                    expandedColumnIds.Add(i);
                }
            }

            for (int i = 0; i < baseMap.Length; i++)
            {
                var rowContainsGalaxy = baseMap[i].Any(x => x != '.');
                if (!rowContainsGalaxy)
                {
                    expandedRowIds.Add(i);
                }

                var row = baseMap[i];
                var currentRow = new List<char>();
                for (int j = 0; j < row.Length; j++)
                {
                    var column = row[j];

                    var c = baseMap[i][j];

                    currentRow.Add(c);
                }

                map.Add(currentRow);
            }

            var galaxyCoordinates = new Queue<(int, int)>();

            for (int row = 0; row < map.Count; row++)
            {
                for (int col = 0; col < map[row].Count; col++)
                {
                    var c = map[row][col];
                    if (c == '#')
                    {
                        galaxyCoordinates.Enqueue((row, col));
                    }
                }
            }

            long distance = 0;
            (int, int) currentCoords;
            while (galaxyCoordinates.TryDequeue(out currentCoords))
            {
                var (initX, initY) = currentCoords;
                foreach (var (x, y) in galaxyCoordinates)
                {
                    var leftX = Math.Min(x, initX);
                    var rightX = Math.Max(x, initX);

                    var topY = Math.Min(y, initY);
                    var bottomY = Math.Max(y, initY);

                    distance += rightX - leftX + bottomY - topY;

                    var additionalHorizontalDistance = expandedRowIds
                        .Where(e => e < rightX && e > leftX).Count() * emptyRowMultiplier ;
                    var additionalVerticalDistance = expandedColumnIds
                        .Where(e => e < bottomY && e > topY).Count() * emptyRowMultiplier;

                    distance += additionalHorizontalDistance + additionalVerticalDistance;
                    
                }
            }

            Console.WriteLine(distance);
        }
    }
}
