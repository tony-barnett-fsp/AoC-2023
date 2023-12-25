﻿using Microsoft.Win32.SafeHandles;
using System.Collections.Concurrent;

namespace ConsoleApp1
{
    internal class Day16
    {
        private string _input = "\\..\\.|.........|..|................................................................./.-............./-....../.\r\n............../..--.../...................-....|.......................\\../...|..-....\\...-|...-...........\\..\r\n.......\\......................................|..-\\.................-..-......................................\r\n........\\..............|......................\\........./..............................|..............||......\r\n.........|........|......-...........|....../....-.../.....|/.........-..../.../..........................|...\r\n..\\............................./\\............................................................................\r\n........|....................\\............................./.....|\\|..-....../............/..-..........\\.....\r\n...\\.........................\\.............|.........../..............-..../.............../-.................\r\n.||....../..............\\.|...............-......................|-..-......../.|.............................\r\n...|.|.....-...../.............-............./............\\.\\/........|.............................\\|.-..\\.-.\r\n............./....................|.......|.....\\..\\..............................-.../....|..................\r\n./......./.|...............\\................................................||................................\r\n......\\......|.................|........../......|\\|.......-|..................|.....-.-.||../.\\..............\r\n................../...............|.....\\........-...-.\\...||..\\...........\\............|.........|...........\r\n...-........|\\|........././/............|...........\\.../\\...|.......-........\\....................-..........\r\n..../...........\\.........................../......-.|...................................../..\\........|......\r\n\\...............\\/......./........-..............|..............--........../....|..-.\\...........-........./.\r\n..........\\........\\|.........|\\.........../........................../.........|............\\..........|.....\r\n...........\\....|/.|..........-..............-....-|...\\..........-.../............./.........................\r\n..\\..\\......../...\\\\....................../...../.........................|.....\\..............|..\\...-.......\r\n...........................-./...................................-/.\\.....\\...................\\.../...........\r\n..-..................|..................-...\\.......|../............./|-............/........|.......|..-.....\r\n...........-......................-.................|............../.......-./..........|....../..............\r\n.........|.............././...............|..../..............|.........|.....|..\\......................|.....\r\n......./-/...................\\\\..\\......|........................\\...\\....../.....................|...-.......\r\n.....|.......................|............|...|........|...........-....../..................-...-............\r\n.../................../......|...........................-............|.............-........./............|..\r\n.-.........|.............|-...../..............................\\................|........................../..\r\n.........../.........-.......|..-.........................-...............-...-.../...................../.....\r\n../.......-../....................-...\\...\\........................-.............-...\\...../.|.........../....\r\n............-...............|........................................../...\\.|....|........-.....\\|...........\r\n.....................|\\............................-..-....../..-|..../..................\\................\\...\r\n.\\.................-......\\...|............................./......./.........-............../................\r\n.\\.........././............../|......\\/..............\\........................|........................|...-..\r\n.............../.........|.................................-.......\\\\.\\-..........-......................./-..\r\n-.|......................|.............|............................/....................|...........-........\r\n../.....-.......|.....-.....\\.../\\........|.............|.........\\./..//\\................|.........-.....||..\r\n.\\..\\.......|......./............\\..\\.........../........-.../.|..............-..../....\\.........../.\\.\\.....\r\n.............|..........|.........|.|...\\-......................-..............|.../............./.........|..\r\n....|................................................../...........-......-/......................-.....-.....\r\n............................./.........-............................./..................\\..........\\..../.....\r\n.....|.....................-.........../.......|..................-.......\\...|\\...|......\\.....\\...|.........\r\n........|............../..../|.|......-................|...../..........|................|...................-\r\n....../.....//..........\\.-|......|.....|..................../..............|.................................\r\n\\.-...-....\\..................\\....................|............||............................../.............\r\n............................-|...-...........-.../......-.........\\..-...|.|\\..........-...............\\.|//./\r\n....../......././.|...................|\\........../.\\.../-...\\..........\\.-..|\\../...........\\....\\..|.....\\..\r\n...............\\.../..../.................\\.......-...........\\..|..................\\\\................./.\\....\r\n............-..........-......................|.......|..|....................-......|......\\...........|.....\r\n...............\\......|.-............./............\\.../.............-|........./...............\\|\\.....|.....\r\n.\\...............|.................|...........\\......\\................\\............\\.|...\\......./...........\r\n\\...|..............-..........|...................|....-.....\\......../..........................\\........|..|\r\n.........|........./.........|....-........-...................../|./.--.......\\........................-..../\r\n..........................-.....-...............-/............................--...../........................\r\n.....................-.\\../\\..........|.....................\\.......\\.../..........|.............\\............\r\n......................../..\\.......\\...............................................\\./........................\r\n....|......\\..|\\.-........../......................\\|........\\...............\\.................|..............\r\n............................./.....|..|............-...\\.........-...\\....|......\\.............-..|...........\r\n..................-......-.....................-...........-......\\...-|-.-................\\............|/....\r\n...|....../............../..\\.......................-....\\...|.....\\..|..\\......./.................-.....-....\r\n.........-........|........../..-................................./....-.................-....................\r\n.............................-.......\\...............\\.....|......-....-.../.................\\................\r\n...../......|...................|..............-........./.............\\...\\....|.............\\.......|.......\r\n.......|............./........./......\\..../........|...........\\................................-............\r\n/...|././.......|-.|..........|................................/\\.\\.......-......-........-........\\..........\r\n../................./|.-...\\........................|........|........|...\\|.\\........................./.....-\r\n................-.........../|..............|.|/...|\\...........-.......................-..|../...............\r\n./..||........|....../........................|.................................../..............\\..|./-......\r\n/..-...../......................................\\-...........-..................\\|................../.........\r\n.............|.-......................|................-../.................-............../..............-...\r\n-.....-|-...............\\..........-...........\\.......\\........................\\.........../..../...../......\r\n.-..................../..........|.--.............................-..-....|.\\................|....|...\\......\\\r\n......./.-........................................\\....|........|...../...........|...\\|..-...................\r\n\\...............|........|.......\\|..-..|...-..|-........|........./.\\........................................\r\n/.|./....|....-...../\\..|...............................-.../........./.............-|.........-..../.-..\\....\r\n../......./...../..|........|../.....\\....\\.............-.-.................-...\\.......|.\\...........\\.......\r\n...-........./.............../..................\\.|................/..//..................|.......-..\\......-.\r\n./.............../.-..\\..........|.............-....................-....-..|...........-.....................\r\n...........|-..|........................................./\\............./-.../.................\\........\\.....\r\n................................/...........................\\.....................|.|.........................\r\n.........|............\\........................................-...../..........|........../.../......\\...\\...\r\n../.........|......./..................|........\\.../.\\.-...-......../../\\......../................../........\r\n.-........./.........|....|.|.............................................|.\\............/../.................\r\n./.........................................\\....../................../.--.....-..../.....|./.-......|.......\\.\r\n.\\..................../.-........|.........\\............\\...........\\...............|-../................\\....\r\n........................|......./.-....-....\\.|...................-......-..........|........\\.........../...|\r\n.............-......./.../......................\\.......\\............/......................................|.\r\n............-..........................-..................-.......\\--......-.....-.......|..\\..-....|........\\\r\n...............|.......\\......|....................\\.....................-.../.|......|................../....\r\n---..\\-.../.........//....\\../....|........\\....|-.........-.....|..........-|..............|...../..........|\r\n......-.............................-.........................-.........../...../.|.../................-.....|\r\n.........-.........\\..............|....\\..............-......\\......../......\\.......-\\........-.............\\\r\n.................../......................|......|.....\\..........................-..-......./....-.....-.....\r\n...\\.....................-..-....\\.......././....\\......./...........................\\..............\\\\........\r\n.................|................./.....................\\...../.\\.................\\.........|...|....|.......\r\n./............-........................\\..|...-............................./............./..\\................\r\n-............-..............|.................-..............................-..............................\\.\r\n................................/.....\\........|....-.....||............/.|.............-..|....|....-........\r\n/.........|............-./...|././..............\\./-............/......../\\.\\..././../..\\..\\..............-...\r\n..../.....................\\.........|......-...........|...\\/..........//\\.......//....-...|/.....\\..\\........\r\n../............................/...././...-....-............./.|..\\..............|...../.........-.....\\....|.\r\n.................................\\..../...-.....-.....-....|..\\.\\...../....../.............../.\\..............\r\n..................|..|.......-......\\.../....../....................................................|.......-.\r\n-./.....|...\\.....\\../.......\\..........................\\.....|.............|...................|.\\.../.../\\..\r\n..................-.....\\.............|...|.........-..-............................../............/..|.......\r\n.....................\\..../.....|......................................\\.\\............|/....................\\.\r\n.....-..\\.........-....\\..............-..........................\\.....\\....................\\.........\\.....-.\r\n\\...\\|\\...../.\\............................\\........-.........................../.......-............\\........\r\n.............................................-......\\.............|..../.......|......../.....................\r\n/.........-............./......|................-........-.............|...-..../.....\\.\\....\\................";

        private enum Direction
        {
            Up,
            Down,
            Left,
            Right
        }

        private class BeamPoint : Point
        {
            public Direction Direction;
            public BeamPoint(int x, int y, Direction direction)
                : base(x, y)
            {
                Direction = direction;
            }

            public static BeamPoint Clone(BeamPoint point)
            {
                return new BeamPoint(point.X, point.Y, point.Direction);
            }
        }

        private class Point
        {
            public int X;
            public int Y;
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public override int GetHashCode()
            {
                return 1_000 * X + Y;
            }
        }


        public void Part1()
        {
            //_input = ".|...\\....\r\n|.-.\\.....\r\n.....|-...\r\n........|.\r\n..........\r\n.........\\\r\n..../.\\\\..\r\n.-.-/..|..\r\n.|....-|.\\\r\n..//.|....";

            var grid = _input
                .Split(new char[] { '\r', '\n' }, StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.ToArray())
                .ToArray();
            var topLeft = new BeamPoint(0, 0, Direction.Right);
            var points = new HashSet<Point> { topLeft };

            var beams = new Queue<List<BeamPoint>>();
            beams.Enqueue(new List<BeamPoint> {
                topLeft
            });
            var beamStarts = new List<BeamPoint>();

            while (beams.Count > 0)
            {
                var beam = beams.Dequeue();

                var currentPoint = beam[0];

                while (currentPoint.X >= 0 && currentPoint.X < grid[0].Length
                    && currentPoint.Y >= 0 && currentPoint.Y < grid.Length)
                {
                    var breakLoop = false;
                    switch (grid[currentPoint.Y][currentPoint.X])
                    {
                        case '|':
                            if (currentPoint.Direction == Direction.Up || currentPoint.Direction == Direction.Down)
                            {
                                break;
                            }

                            if (beamStarts.Any(b => b.X == currentPoint.X && b.Y == currentPoint.Y && b.Direction == Direction.Down))
                            {
                                breakLoop = true;
                                break;
                            }

                            var barDuplicatePoint = new BeamPoint(currentPoint.X, currentPoint.Y, Direction.Up);

                            beams.Enqueue(new List<BeamPoint> { barDuplicatePoint });
                            beamStarts.Add(barDuplicatePoint);

                            currentPoint.Direction = Direction.Down;
                            break;

                        case '-':
                            if (currentPoint.Direction == Direction.Left || currentPoint.Direction == Direction.Right)
                            {
                                break;
                            }

                            if (beamStarts.Any(b => b.X == currentPoint.X && b.Y == currentPoint.Y && b.Direction == Direction.Left))
                            {
                                breakLoop = true;
                                break;
                            }
                            var dashDuplicatePoint = new BeamPoint(currentPoint.X, currentPoint.Y, Direction.Left);
                            beams.Enqueue(new List<BeamPoint> { dashDuplicatePoint });
                            beamStarts.Add(dashDuplicatePoint);

                            currentPoint.Direction = Direction.Right;
                            break;

                        case '\\':
                            currentPoint.Direction = currentPoint.Direction switch
                            {
                                Direction.Up => Direction.Left,
                                Direction.Down => Direction.Right,
                                Direction.Left => Direction.Up,
                                Direction.Right => Direction.Down,
                                _ => throw new Exception(),
                            };
                            break;

                        case '/':
                            currentPoint.Direction = currentPoint.Direction switch
                            {
                                Direction.Up => Direction.Right,
                                Direction.Down => Direction.Left,
                                Direction.Left => Direction.Down,
                                Direction.Right => Direction.Up,
                                _ => throw new Exception(),
                            };
                            break;

                        default:
                            break;
                    }

                    if (breakLoop) { break; }

                    currentPoint = BeamPoint.Clone(currentPoint);
                    switch (currentPoint.Direction)
                    {
                        case Direction.Left:
                            currentPoint.X--;
                            break;
                        case Direction.Right:
                            currentPoint.X++;
                            break;
                        case Direction.Up:
                            currentPoint.Y--;
                            break;
                        case Direction.Down:
                            currentPoint.Y++;
                            break;
                        default:
                            throw new Exception();
                    }

                    if (beam.Any(x => x.X == currentPoint.X && x.Y == currentPoint.Y && x.Direction == currentPoint.Direction))
                    {

                        break;
                    }

                    if (!(currentPoint.X >= 0 && currentPoint.X < grid[0].Length
                        && currentPoint.Y >= 0 && currentPoint.Y < grid.Length))
                    {
                        continue;
                    }

                    if (!beam.Any(x => x.X == currentPoint.X && x.Y == currentPoint.Y))
                    {
                        if (!points.Any(x => x.X == currentPoint.X && x.Y == currentPoint.Y))
                        {
                            points.Add(currentPoint);
                        }
                        beam.Add(currentPoint);
                    }
                }
            }

            //for (var y = 0; y < grid.Length; y++)
            //{
            //    for (var x = 0; x < grid[y].Length; x++)
            //    {
            //        Console.Write(points.Any(p => p.X == x && p.Y == y) ? '#' : '.');
            //    }
            //    Console.Write('\n');
            //}

            Console.WriteLine(points.Count);
        }

        private IEnumerable<BeamPoint> GetStartingBeamPoints(char[][] grid)
        {
            for (var col = 0; col < grid.Length; col++)
            {
                yield return new BeamPoint(0, col, Direction.Right);
                yield return new BeamPoint(grid[0].Length - 1, col, Direction.Left);
            }

            for (int row = 0; row < grid[0].Length; row++)
            {
                yield return new BeamPoint(row, 0, Direction.Down);
                yield return new BeamPoint(row, grid.Length - 1, Direction.Up);
            }

        }

        public void Part2()
        {
            //_input = ".|...\\....\r\n|.-.\\.....\r\n.....|-...\r\n........|.\r\n..........\r\n.........\\\r\n..../.\\\\..\r\n.-.-/..|..\r\n.|....-|.\\\r\n..//.|....";
            var results = new ConcurrentBag<int>();

            var grid = _input
                .Split(new char[] { '\r', '\n' }, StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.ToArray())
                .ToArray();

            Parallel.ForEach(GetStartingBeamPoints(grid), startPoint =>
            //foreach (var startPoint in GetStartingBeamPoints(grid))
            {
                var points = new HashSet<Point> { startPoint };

                var beams = new Queue<List<BeamPoint>>();
                beams.Enqueue(new List<BeamPoint> {
                startPoint
            });
                var beamStarts = new List<BeamPoint>();

                while (beams.Count > 0)
                {
                    var beam = beams.Dequeue();

                    var currentPoint = beam[0];

                    while (currentPoint.X >= 0 && currentPoint.X < grid[0].Length
                        && currentPoint.Y >= 0 && currentPoint.Y < grid.Length)
                    {
                        var breakLoop = false;
                        switch (grid[currentPoint.Y][currentPoint.X])
                        {
                            case '|':
                                if (currentPoint.Direction == Direction.Up || currentPoint.Direction == Direction.Down)
                                {
                                    break;
                                }

                                if (beamStarts.Any(b => b.X == currentPoint.X && b.Y == currentPoint.Y && b.Direction == Direction.Up))
                                {
                                    breakLoop = true;
                                    break;
                                }

                                var barDuplicatePoint = new BeamPoint(currentPoint.X, currentPoint.Y, Direction.Up);

                                beams.Enqueue(new List<BeamPoint> { barDuplicatePoint });
                                beamStarts.Add(barDuplicatePoint);

                                currentPoint.Direction = Direction.Down;
                                break;

                            case '-':
                                if (currentPoint.Direction == Direction.Left || currentPoint.Direction == Direction.Right)
                                {
                                    break;
                                }

                                if (beamStarts.Any(b => b.X == currentPoint.X && b.Y == currentPoint.Y && b.Direction == Direction.Left))
                                {
                                    breakLoop = true;
                                    break;
                                }
                                var dashDuplicatePoint = new BeamPoint(currentPoint.X, currentPoint.Y, Direction.Left);
                                beams.Enqueue(new List<BeamPoint> { dashDuplicatePoint });
                                beamStarts.Add(dashDuplicatePoint);

                                currentPoint.Direction = Direction.Right;
                                break;

                            case '\\':
                                currentPoint.Direction = currentPoint.Direction switch
                                {
                                    Direction.Up => Direction.Left,
                                    Direction.Down => Direction.Right,
                                    Direction.Left => Direction.Up,
                                    Direction.Right => Direction.Down,
                                    _ => throw new Exception(),
                                };
                                break;

                            case '/':
                                currentPoint.Direction = currentPoint.Direction switch
                                {
                                    Direction.Up => Direction.Right,
                                    Direction.Down => Direction.Left,
                                    Direction.Left => Direction.Down,
                                    Direction.Right => Direction.Up,
                                    _ => throw new Exception(),
                                };
                                break;

                            default:
                                break;
                        }

                        if (breakLoop) { break; }

                        currentPoint = BeamPoint.Clone(currentPoint);
                        switch (currentPoint.Direction)
                        {
                            case Direction.Left:
                                currentPoint.X--;
                                break;
                            case Direction.Right:
                                currentPoint.X++;
                                break;
                            case Direction.Up:
                                currentPoint.Y--;
                                break;
                            case Direction.Down:
                                currentPoint.Y++;
                                break;
                            default:
                                throw new Exception();
                        }

                        if (beam.Any(x => x.X == currentPoint.X && x.Y == currentPoint.Y && x.Direction == currentPoint.Direction))
                        {
                            break;
                        }

                        if (!(currentPoint.X >= 0 && currentPoint.X < grid[0].Length
                            && currentPoint.Y >= 0 && currentPoint.Y < grid.Length))
                        {
                            continue;
                        }

                        if (!beam.Any(x => x.X == currentPoint.X && x.Y == currentPoint.Y))
                        {
                            if (!points.Any(x => x.X == currentPoint.X && x.Y == currentPoint.Y))
                            {
                                points.Add(currentPoint);
                            }
                            beam.Add(currentPoint);
                        }
                    }
                }

                //for (var y = 0; y < grid.Length; y++)
                //{
                //    for (var x = 0; x < grid[y].Length; x++)
                //    {
                //        Console.Write(points.Any(p => p.X == x && p.Y == y) ? '#' : '.');
                //    }
                //    Console.Write('\n');
                //}

                results.Add(points.Count);
            });
            //}

            Console.WriteLine(results.Max());
            Console.WriteLine(string.Join(",", results));
        }
    }
}
