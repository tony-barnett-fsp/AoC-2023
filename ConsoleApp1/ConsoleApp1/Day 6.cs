using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Day6
    {
        private string _input = "Time:        40     70     98     79\r\nDistance:   215   1051   2147   1005";

        public void Part1()
        {
            //_input = "Time:      7  15   30\r\nDistance:  9  40  200";

            var lines = _input.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            var times = lines[0].Substring(lines[0].IndexOf(':') + 1).Split(' ', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            var distances = lines[1].Substring(lines[1].IndexOf(':') + 1).Split(' ', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            var output = 1;
            for (var i = 0; i< times.Length; i++)
            {
                var time = times[i];
                var distance = distances[i];
                var distanceTraveled = 0;
                var waysToBeatRecord = 0;

                for(var x = 0; x < time; x++)
                {
                    distanceTraveled = (time - x) * x;
                    if(distanceTraveled > distance) { waysToBeatRecord++; }
                }

                output *= waysToBeatRecord;
            }

            Console.WriteLine(output);
        }

        public void Part2() {
            //_input = "Time:      7  15   30\r\nDistance:  9  40  200";

            var lines = _input.Replace(" ", "").Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            var times = lines[0].Substring(lines[0].IndexOf(':') + 1).Split(' ', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries).Select(x => long.Parse(x)).ToArray();
            var distances = lines[1].Substring(lines[1].IndexOf(':') + 1).Split(' ', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries).Select(x => long.Parse(x)).ToArray();
            long output = 1;
            for (var i = 0; i< times.Length; i++)
            {
                var time = times[i];
                var distance = distances[i];
                long distanceTraveled = 0;
                long waysToBeatRecord = 0;

                for(long x = 0; x < time; x++)
                {
                    distanceTraveled = (time - x) * x;
                    if(distanceTraveled > distance) { waysToBeatRecord++; }
                }

                output *= waysToBeatRecord;
            }

            Console.WriteLine(output);
        }
    }
}
