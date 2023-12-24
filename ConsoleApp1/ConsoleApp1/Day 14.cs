using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Day14
    {
        private string _input = "...O..O.O.O.#.OO....#..O.O#.#O...#.OO.##.#...O#...#.##........##.#O#..#......#.OO......#.....O.#..O.\r\n..OO...O.##.#...O.....OO#.O..O......O#...........#.O.#..#.###O....O..........#...O..#..#....O..#OO.O\r\n.#OO.......#.#....O..O.#......#...#O......#...O.OO..........O..O.#.O.OO.O#OO.O....#..O#..O..O.....#.\r\nOO..O#..OO.....#..OO..#..OOO#..O......O.##..O#....OOO.##........O.#.O....#..O.O...#....#..O#..#.O.##\r\n#O.O.....O.#.#.#.#.#......O#..O..O.#...O..O.O.O...O.O.O.OOO.....O...O..O...###O.OOO...#..OO..O#O#...\r\n.......O...OO.O.O.OO.OO..O....#O...O.#O........##.O...#....#O...#.....O..OO.O.##...O#####.OO.O....#.\r\n##.....O#...O..O....OO....OO#.O....O.#..O.#.O.....OO......OO...OO#....#.........#.....#..O.O....O...\r\nO#.#.OO........O....#.O...O.##..###.#.O.#......#.....O.....O#...#.#O..O....O##O#..O..O#.#..#.....O..\r\nO..O#....#...O#......OO.#...#OOOO...O..O...O###O.O###.....#....#O#O#OOO....O.#....OO..O....O...##.O.\r\n.......O#O..........#...OOO..OO##..O...O#...#O.O..O..O...#O.....O#O.#........OO.#OO....#O.O.#.O...O#\r\n.#.#.....O.#.O.#.##..#O.....#O.##O....O#O.O#.....#...O..##O............O.O#.#....O....O.O.........O.\r\n....O#..O#.#.O.........OO..O#O..#.....#.#..O..O....#.#...OO......#...#..#..O##O..O.#...........O#..#\r\n...O..........O..#O#..OO#.#...OO.O.O#.O.OO..#........#..OO..O.OO.....#.#O....O.O#O.OO.#...O.#O...O..\r\n..O..OO..#O..O#..O..O#.#..OO...O.O...#.O..O.......O...OOO.........OO..O......#..#..O...O..O##.#OO...\r\n........OO.O.O...O..##...O##...O..O..O.OO..O.#.#.....#.O.O.O.....O.##...O#O..#......##.#...O.O...O..\r\nOO#..............#...O.......#.O.....O..##.......O.O##....#O..#.O...#O#.O.##.O#....#...O..O..#....O.\r\n..#.O...#.....O...O..#.##O..O....O.O.....O..O........O...#O...#..O...O....O..O....#.O..O.O......#...\r\n...OO.O...#..#...O.OO#......O..O.O.#..#..........###..#.#.......#.O..#.O......OO.#.O#..O..O.O..#..O.\r\n...#.......O##O..#O...#.#.#..#..#...#.....OOO#.O#O#.....O......OO....#.#.OO....O.O.##O..O....O#O.#.O\r\n##O#.OO.O#....O.#..O..O..##...O..#O.O...........#O.##....#...O....#OO.OO....O....#OO#O.......O......\r\n#O..#.....O....O.O#O..O.O.O....O.O#.OOO...#.#.O.OOO#.O#....#.OO#.###.....#...O#O.#.....OO..O.....O.O\r\n##..#....#.O.#.#...OO.O.....#.#.#.###......##.....O....#...O##OO.O.OO.OO##.O.......#..O##.....OOO.#O\r\n......O.#..OO..O......#OO....O..O...O....O.....OO......##.#.OO....O.....O..O..O.#.#..#..OO#.O..OO...\r\n....##...O.O.O.O.O..O..#O..#........#.O..O...#.O.....###.O..O.#..O......O##....O.....O.#.....#....OO\r\n#....#..........#.......O.O#.........#.#..O......O..O#.O..O.##.##..O..#OO.O#...............O#.#O....\r\n..##..O#O.#......O#..#....#.O...O...O.O.O#....##.#...O..O#......#.O#.#.......O#O...#.##..#..OO..O...\r\n...O.#..O.....OO##.....OO.#......O.OO..#.O##.#....O#.O.#....#..O#.O.#...#........#.#.#O..O...#O..#..\r\n...##..........O#.#......O.......OOO...O..............O.O##........#........O.....O....#O#.#.....#O.\r\n.#......O...O..#...#..#.O#.....O..OO#O...O.....##.#.#......OO..O##......#...O.O....O..##...O....#O..\r\n..#O.O...#..O..OO.#..OO...##...#..O#O....O...O.....#O#..#.O.......O........#OO..O....#.#O.........#O\r\n.#.....O.##...#....O..O..#.O.#.#OO...#........#..O.#.#....#.O..O.#O.#..#.......#..............##.O.#\r\n...O..#...#.O....O.O#.#...#.#...........O.O..#.#..O.......#O.OOO.#.....#.O.#...#O....#O.O.......##..\r\n.#....OOOO..O.....O.OO#O..#...#.....O....O...#..##.O..O.#..O..#.O#..O.O...O#.....OO........O..OO#..O\r\nO.#.O.#...#O...#O.#......#O...O.#.O.O#O#..#.........##.O.OO..#....OOO##...O##.##.#.O...#.O.#O#......\r\nO..##..O...O#OO#O..O..O...###..OOO...#O#......##..O.........O#.....O..#...#O......#.#..O....O......O\r\n........#O#..##O....OO..#..#.#...#.#.#...OO...O###.#O.#OO.#..#.O.......O..O..O..OO...O....O..#...#..\r\n.....O...O....#.#.O#...O..O.#.#O.OO#OO.O.#.....#.#..#..O.#O....##......O##O##.O#..O.###....O#O.O.#..\r\n..##....#.O.#.#O#.O..O....OO#O..O....#....#.O.O.#...#OO....#O.#..#O.......O.O.O.#.....#O..O.O......#\r\n.O..#..........#..O.#..#.#..O..O.O#..#..O..#.....O#..#..#OO...O#.O..OOO.....O..O..OOO..#..O..#....O.\r\n.....O..#.#..#......OO...#..O.#..##....#O..O.O.O..O.#..OOO..O.OO......###..#..O#.OO####..#..OO.#....\r\n#.#...O.....O....#O..#..##.O.#...O.#.##.OO...#..#O.O...#.....#...O.O.O...O.#.#..#..O.....O..OO.O..OO\r\n..#O..O.O...O##O.O..#..O.##O##..O.OOO#O...O....#.O#............OO.#.O..#...........O......O.#..##...\r\n.....O.O...#O.O...O#....#..#...O.#..OOO.O.OO.O##..#...#..O#O#..O..##...#....OO........#..O.O.#...#O#\r\nO#..O....O.#...#...#...O#.#..OO#.#..O...O.OO....O...#.#O.###.#...##..OO..##....O.OO...OOO.O.#.......\r\nO.O.#.........#####..O..#.OO..O.OOO...#O#..O.............OOO...O.....#..OO...O......#O....OO...OO.O.\r\n#.O#...O##.O.#.........#.#.#..O......#.#....O...OOO.O...#....#.O#....O.....O.....#.O..#..#.#O.......\r\n#..O......#.......O#O.OO#......#...#.....O#..O.O.#.....O..#.#.....##...#...O...#.#.O..O.O.....O...#.\r\n.OOO.O...#O.#..O#O...#..#O#..#.......###...#.#......#O###.....#...#....###O#.O....##O...#.#...O..#..\r\n.O...OO.......O.O#O#.O.#O.O...O....OO#.....#..#.....O....OO.#......O#OO...O##.#..#.#..O..O...#...#..\r\n...O....O..O#O....#.........###..O.....O...O#....O#.....#.#.....#.O.#.OO..#.O###.....#O#...#.OO#....\r\n#.#.....O#O....O......O#..##OO......O#..#O.O#..#...O.O##OO#.......O...#...OO.....#.O.....O#O#.....#.\r\n..OO##.#..OO#O.......O.O..OO#..O....O#.O.O.#.#..#........O.....#...........#O.......O.#.#.......#.O.\r\n.##O.....O....#...O..O.OOO.O.OO..#.#..O.........#...##..#..O#....#..O..#O....O......#O..O#..#O..#O..\r\n#O.......O#......O.......O.O.#.......OO....#.....#O.#......O#OO...O.....O......O...#..O........#.OO.\r\nO....#...OO.O..O......#O.O...#.OOO.OO....#....O.O#..O#..#...O.O...O..#O....#O...O..OO........#O.O.#O\r\n#O#..O.........#......#OO..O#.OO#O##..#.O...O#.....#..#O#..OO.#.O#....O.O..##O#O..#O......#.O.OO.O.O\r\n...##.....#..........#..O.O#....#..O...O......##.O.....#.OO#..OO...O..#..#O#..#.O.#..O#O..#......#..\r\n#OO.O##..##O...#..O.O#OO#OO....##.#...O.#.#.#.#O#....O.......O.....#..#.O.#.#...........#........O..\r\n#....O..#O#O............O#O..O.......O#.O.O##..###.#.O#O.#O....O............O..O....#.....O.OOOO....\r\n.OO.OO..#O....#O....O.O..OOO..#..O..OO.....O...#.O.#.O.O.............O..#.O....O##..OO#.O.O.#O..O.#O\r\n.....O......O...#.#....#.....OO...O....#O...#.#.O..##......O...O#.....O.O...#.......................\r\nO..........#O...O#.OO..O.O.#.......#...............#....O...#.O.O..#..O....O....#...#O#.O....O.#....\r\n#..O....O...O#..#OO.O....OO.#..O.O.O.O......O.O.....O....#..O#..O.OO....#..#.#...#......#...O#..O.OO\r\n.......#..O....O.O........#O#OO.#O.O.OO....#..O.....O.#....O...#O.#.O.O.O....##..OO.#O..O#.......#.O\r\n....O....O.O.##O..O..OO####O....O..O.........O.#...OO...#..#..#...#......#......O..#...O.....##...O.\r\n.#OO#..O..O...O.OO....O.O....OO#..#O.O....O..OOO..##..................O....#....O..O...O......#.OO.O\r\n.#.........O#.O#...#...O##.....O.OO.O.##O...O.#.##...OO.....##....#..O.OO#..O....#.#...O...O..OO....\r\n.#.O...OO.OO.O.O#...#.#O.........#O..OO#O#.#.......#..O##....O#..#...#O......O.......O.....#..O..#..\r\n.##..OO....O.....#O.....O..#..#O#..#......#..O.........O.........O#O..........#OOOO.......#.###.#.#O\r\n.O..O..O...OO...OO......O.O..O.#O...#O#.O#..O#......#.O#O.......#..O##.O.O....OO#.O......##OO#.#...O\r\n..#.O..#......#..#O.OO..O...#....O.##......#....O.O.O.....O.#...##....##....OO.O#.....O....O..#....#\r\nO..#.OOO......O.O.OO...O......O.#.#OO.#.....##....#.##..O.....#.....O....#...OO....O#.#.#.........#.\r\n.O......#O.......O..#.##...#.#.O....O.##..O#.OO.O.O#.#O#..##..O..##.O#O.O...#.OO.#.O..#.O.#.O.#.#O.O\r\n.O..O.O..O.O...............OO...O.O.#..#...#.....#..O#.O.OO#.O......##O...O.....O.O.#.#..O..O.O.O.#.\r\nO.........#...O#.O....O...O......#O..##..#O.O.#O..O..OO...#..#.#.#O.........O..OO..O.O.O#.O......#..\r\nOO...........#.....O.O.#.#...O..#.#.#O.#.O#...#O.....O.OO.O..##.....##OO.........O...#OO#O...O....O.\r\n.#.......O.#OO.#OO.O#.OOO...#..##.OO..O...OO.......O.#..OO.O.O..#...O...O.....O.##OOO#..O.....O.O.#O\r\nO#.O.O.OO...#..O.....O#......#..O#OOO.OO#..O...O...O.#..O..#.O..#O.OO##...##.#.#O.#O.O.....##O..O#.#\r\nO.#.#........#...O...#...O.O.O.#.O.....O.......#....#O..OO.#.......#.O...#.O.#..#...#O.###...#.....O\r\n........OOO...O.OO.##O.O..#.O...O..#.......#OO#OO..O##O.......##.........O...OO.......#...#..O#O.#O#\r\n..O#OOO.O#..##........O.......O.....#.O....OOO..O......#.......OO.......#..#.#.#.#....O#...#.O.....#\r\n....O....#..#..O.O.O.O..O........O#....#..#.O..#OO.....OOOO....O#.O......#O..OOO#.O..#....#...O...OO\r\nO#...O#......O...#..#......#.........O.#........#.O#.#...###.#O.O....#O.....#...#.##....O..##...OO..\r\n....O....O........##.O.....#....O.....#..#........#OO.O.#OOO....#..#.#...###......O.O..#....OO......\r\n.O#O....#OO#OOO.#.....O.O......##....#..OO.OOO.O##..#O.#.#...#.#....O..O#...O..OO.#.O...O..##...#...\r\n.O#OO#..O.#OO.......##O#O.#.O..#.O#OO.OO.O.#.O#........#...O.#.O.O##O.........OO..O...O.O.O.....O#..\r\n..##....###.O#.....O....OOO.O.....OO...O....OOOO.#........#.....#.#..O.#.....#...OOO.....OOO..#.O..#\r\n.OO##.#.#....O..#..#.#..O.#..O.OO....O.O..O.OO.O.O.....#..#.............OOOO.O....O.O.O.#..#.......O\r\n#.O.#.O#O.O.O.O.#.#......O#O..OO..O.....#....O..#..#O.............#....#OO....O##...#..O....O...#..O\r\n....#...##...#...#....#.O.O#....#O.O.##.#.O...O#...O#....#.......O.#.#.....O....#.#O.O..O...O..O..#.\r\n.O.##.#...O#OO.....O.........#O.O.O#..........OO.O...#..#.OO....O..#..#...O...OO......O##O.....O#O..\r\nO#...........O....#O...O...O#..#.....#OO...OO..OO#OO..O.#.O#.OOO...O.....O..O...O...O.#O#.#O.....O..\r\nO.OO.O.OOO.O##.#..OO....#....#O.#...O...OO..OO..O#O.....#...O...O...........O....#.O....O.O..#O#..##\r\n#..#......O..OO#.......O..#......#O##....O...O.#.O#.#.O..#.#O..O..O#..O.O.#.OOO...OOO.#.#O.#....#.#.\r\nO##..O......#OOO.#..O.O#.#...O...#...O...#O..OO..#.##O.......#O.#..#...#.O.....#.O.O.#..#.O.O..O...#\r\n.#OOO.....O...#.......OOO.O.#.O.O#.#..#O.#....#O.#....#......#.O...OO..O..O..#O.##.OOO........O.O#..\r\n...O.OO.O....#O...#...#OOO..O...#....OO....O...#..#O...#.#OO......O......O#.O#....#..#OOO.#....O.#..\r\n..#.OOO....#.O..#.O#.#O...O.O.......#..OO.##.#.#..O..O....O#.#.....#..##.#O.......O#O##OO.O......OOO\r\n..O.#...##O##O.O#...O.O#.#O.#...O........#.OO.O...##...O..O..##..O...O.#.....O...#O.#O#O.O......O.#O\r\n..O.#..O.#.....O...#OO##..O.OOO...O.##O..O.O.......#.....O..O.##......O.....O#.........#.........O.#";

        public char[][] ShiftEverythingNorth(char[][] lines)
        {
            for (var i = 1; i < lines.Length; i++)
            {
                for (var j = 0; j < lines[i].Length; j++)
                {
                    if (lines[i][j] == 'O')
                    {
                        for (var k = i; k > 0; k--)
                        {
                            if (lines[k - 1][j] == '.')
                            {
                                (lines[k - 1][j], lines[k][j]) = (lines[k][j], lines[k - 1][j]);
                            }

                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }
            return lines;
        }

        public char[][] ShiftEverythingSouth(char[][] lines)
        {
            for (var i = lines.Length - 2; i >= 0; i--)
            {
                for (var j = 0; j < lines[0].Length; j++)
                {
                    if (lines[i][j] == 'O')
                    {
                        for (var k = i; k < lines.Length - 1; k++)
                        {
                            if (lines[k + 1][j] == '.')
                            {
                                (lines[k + 1][j], lines[k][j]) = (lines[k][j], lines[k + 1][j]);
                            }

                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }
            return lines;
        }

        public char[][] ShiftEverythingWest(char[][] lines)
        {
            for (var i = 0; i < lines.Length; i++)
            {
                for (var j = 1; j < lines.Length; j++)
                {
                    if (lines[i][j] == 'O')
                    {
                        for (var k = j; k >= 1; k--)
                        {
                            if (lines[i][k - 1] == '.')
                            {
                                (lines[i][k - 1], lines[i][k]) = (lines[i][k], lines[i][k - 1]);
                            }

                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }
            return lines;
        }


        public char[][] ShiftEverythingEast(char[][] lines)
        {
            for (var i = 0; i < lines.Length; i++)
            {
                for (var j = lines[0].Length - 2; j >= 0; j--)
                {
                    if (lines[i][j] == 'O')
                    {
                        for (var k = j; k < lines[i].Length - 1; k++)
                        {
                            if (lines[i][k + 1] == '.')
                            {
                                (lines[i][k + 1], lines[i][k]) = (lines[i][k], lines[i][k + 1]);
                            }

                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }
            return lines;
        }



        public void Part1()
        {
            //_input = "O....#....\r\nO.OO#....#\r\n.....##...\r\nOO.#O....O\r\n.O.....O#.\r\nO.#..O.#.#\r\n..O..#O..O\r\n.......O..\r\n#....###..\r\n#OO..#....";

            var lines = _input
                .Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.ToArray())
                .ToArray();

            ShiftEverythingNorth(lines);

            var output = 0;
            for (var i = 0; i < lines.Length; i++)
            {
                output += (lines[i].Where(x => x == 'O').Count() * (lines.Length - i));
            }

            Console.WriteLine(output);
        }

        public char[][] RotateEverythingClockwise(char[][] lines)
        {
            var rotated = new List<List<char>>();
            for (var colIndex = 0; colIndex < lines[0].Length; colIndex++)
            {
                var thisLine = new List<char>();
                rotated.Add(thisLine);
                for (var rowIndex = 0; rowIndex < lines.Length; rowIndex++)
                {
                    thisLine.Add(lines[lines.Length - 1 - rowIndex][colIndex]);
                }
            }

            return rotated.Select(x => x.ToArray()).ToArray();
        }

        public void Part2()
        {
            //_input = "O....#....\r\nO.OO#....#\r\n.....##...\r\nOO.#O....O\r\n.O.....O#.\r\nO.#..O.#.#\r\n..O..#O..O\r\n.......O..\r\n#....###..\r\n#OO..#....";

            var lines = _input
                .Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.ToArray())
                .ToArray();
            var cache = new Hashtable();
            var startTime = Stopwatch.GetTimestamp();
            //for (var i = 0; i < 1_000_000_000; i++)
            for (var i = 0; i < 220; i++)
            {
                lines = ShiftEverythingNorth(lines);
                lines = ShiftEverythingWest(lines);
                lines = ShiftEverythingSouth(lines);
                lines = ShiftEverythingEast(lines);

                var cacheable = string.Join("", lines.Select(line => string.Join("", line)));
                
                if (cache.Contains(cacheable))
                {
                    Console.WriteLine($"duplicate at i = {i} of {cache[cacheable]}");
                }
                else
                {
                    cache.Add(cacheable, i);
                }

                if (i % 100_000 == 0)
                {
                    var z = 0;
                    for (var a = 0; a < lines.Length; a++)
                    {
                        z += (lines[a].Where(x => x == 'O').Count() * (lines.Length - a));
                    }

                    //Console.WriteLine($"cycle {i} got output {z}");
                    //Console.Clear();
                    //Console.WriteLine(string.Join("\n", lines.Select(x => string.Join("", x))));
                    //Console.WriteLine();
                    Console.WriteLine($"completed {i} cycles in {Stopwatch.GetElapsedTime(startTime)}");
                }
            }

            var output = 0;
            for (var i = 0; i < lines.Length; i++)
            {
                output += (lines[i].Where(x => x == 'O').Count() * (lines.Length - i));
            }

            Console.WriteLine(output);
        }
    }
}