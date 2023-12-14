using System.Collections.Concurrent;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Day5
    {
        private string _input = "seeds: 2019933646 2719986 2982244904 337763798 445440 255553492 1676917594 196488200 3863266382 36104375 1385433279 178385087 2169075746 171590090 572674563 5944769 835041333 194256900 664827176 42427020\r\n\r\nseed-to-soil map:\r\n3566547172 3725495029 569472267\r\n2346761246 1249510998 267846697\r\n1812605508 937956667 271194541\r\n1421378697 1209151208 40359790\r\n2083800049 2788751092 262961197\r\n2938601691 473979048 463977619\r\n473979048 1517357695 947399649\r\n4136019439 3566547172 158947857\r\n1461738487 3051712289 350867021\r\n2614607943 2464757344 323993748\r\n\r\nsoil-to-fertilizer map:\r\n3107230831 2583931429 576709409\r\n970181981 608291332 1441137369\r\n743954495 3859046283 158951815\r\n3683940240 3227916509 91282070\r\n608291332 2448268266 135663163\r\n3775222310 2049428701 398839565\r\n2411319350 3319198579 539847704\r\n2951167054 4017998098 156063777\r\n902906310 3160640838 67275671\r\n\r\nfertilizer-to-water map:\r\n1257642402 395703749 69589612\r\n1800674 2215701547 90550534\r\n2757853693 358464863 37238886\r\n3285451399 181079109 43937782\r\n2346544130 3513448371 192150886\r\n3866348216 4231433060 63534236\r\n1327232014 1560332334 90281838\r\n2538695016 616206288 114467702\r\n255018176 225016891 46372244\r\n1171065990 3705599257 27021880\r\n1070753744 730673990 442780\r\n221369008 3479799203 33649168\r\n2987721226 271389135 80072982\r\n1198087870 732917444 24556356\r\n199036270 2306252081 22332738\r\n0 731116770 1800674\r\n3929882452 3989920675 212758268\r\n631506549 757473800 322942578\r\n301390420 0 157952443\r\n2795092579 157952443 1997721\r\n1222644226 2619085211 34998176\r\n954449127 499901671 116304617\r\n1429766246 159950164 21128945\r\n2205492221 2074649638 141051909\r\n2749302577 3732621137 8551116\r\n459342863 1219863414 57737723\r\n3329389181 3741172253 59047790\r\n2797090300 2328584819 190630926\r\n3278448653 351462117 7002746\r\n126959518 1277601137 72076752\r\n92351208 465293361 34608310\r\n4142640720 3866348216 123572459\r\n2143980560 1080416378 43307177\r\n1450895191 2672287871 693085369\r\n517080586 3365373240 114425963\r\n3388436971 1662866566 411783072\r\n2187287737 2654083387 18204484\r\n1417513852 1650614172 12252394\r\n3067794208 1349677889 210654445\r\n4266213179 4202678943 28754117\r\n2653162718 1123723555 96139859\r\n1071196524 2519215745 99869466\r\n\r\nwater-to-light map:\r\n512627839 90187036 1196629\r\n3379634653 2059506154 33434334\r\n3286651054 4276482087 18485209\r\n4233695090 28914830 61272206\r\n3413068987 3322576776 23288997\r\n3736304424 3345865773 43267308\r\n1246285471 2994853001 251748584\r\n3779571732 1946298040 113208114\r\n390808412 3287769466 34807310\r\n1881283842 2879009693 106527924\r\n3964031050 2506138169 12994476\r\n3436357984 793897944 162691614\r\n2255160753 2092940488 151061610\r\n853985057 3506201042 119010035\r\n301385394 1856875022 89423018\r\n972995092 658665705 34308693\r\n4159948022 1315925500 65322692\r\n640912738 250463411 213072319\r\n1761800914 91383665 102591221\r\n450345319 3246601585 5793995\r\n3186220306 4173678310 91115364\r\n28914830 3633635453 176360375\r\n456139314 193974886 56488525\r\n2523290324 3809995828 187303152\r\n2406222363 3389133081 117067961\r\n205275205 2782899504 96110189\r\n2135785589 1100569535 119375164\r\n1121466033 533846267 124819438\r\n1007303785 2244002098 114162248\r\n3599049598 3997298980 137254826\r\n4077949072 463535730 70310537\r\n4225270714 3625211077 8424376\r\n1498034055 2519132645 263766859\r\n2710593476 1381248192 475626830\r\n3977025526 692974398 100923546\r\n4148259609 4264793674 11688413\r\n1987811766 2358164346 147973823\r\n3892779846 1244674296 71251204\r\n3340510149 4134553806 39124504\r\n1864392135 956589558 16891707\r\n425615722 1219944699 24729597\r\n513824468 973481265 127088270\r\n3277335670 2985537617 9315384\r\n3305136263 3252395580 35373886\r\n\r\nlight-to-temperature map:\r\n1094191559 698410082 28110394\r\n383870732 1189042355 107231661\r\n3711052230 2164474756 34756304\r\n745558539 170241759 7170863\r\n491102393 503970250 194439832\r\n4034618875 3142749029 146609939\r\n3781998432 1718948669 129329785\r\n2440091414 3071819711 70929318\r\n1301358031 55123603 115118156\r\n0 2789116652 87933685\r\n770729148 177412622 48955790\r\n3772681560 3886204605 9316872\r\n752729402 37123857 17999746\r\n3745808534 2137385460 7147939\r\n2028807236 3677936618 208267987\r\n2237075223 3289358968 92979022\r\n88764920 1960439220 176946240\r\n3568470355 2258695303 142581875\r\n3276170082 1848278454 112160766\r\n2637902204 1129503077 39814191\r\n3000547589 892603630 188042422\r\n2511020732 226368412 126881472\r\n1122301953 1296274016 52818372\r\n1440958847 1353023078 243104929\r\n2963423732 0 37123857\r\n3388330848 2199231060 48304954\r\n1175120325 377732544 126237706\r\n819684938 1349092388 3930690\r\n3752956473 1169317268 19725087\r\n3911328217 2144533399 19941357\r\n1416476187 353249884 24482660\r\n2677716395 3895521477 285707337\r\n265711160 2413138935 118159572\r\n685542225 1080646052 48857025\r\n3556608598 2401277178 11861757\r\n734399250 2247536014 11159289\r\n87933685 3677105383 831235\r\n3188590011 1596128007 87580071\r\n836373414 2531298507 257818145\r\n3471876393 2877050337 84732205\r\n1684063776 726520476 166083154\r\n823615628 3560998296 12757786\r\n3436635802 1683708078 35240591\r\n3931269574 3573756082 103349301\r\n1850146930 3382337990 178660306\r\n2330054245 2961782542 110037169\r\n\r\ntemperature-to-humidity map:\r\n1773059646 4122818507 172148789\r\n2417158855 2859734866 110076859\r\n977168274 1576624124 28149321\r\n4275291678 3797606290 19675618\r\n1141296808 749646180 267286171\r\n3592756112 2969811725 273274339\r\n0 19621130 7167651\r\n2059084943 2697725300 48133058\r\n2107218001 3920609496 145140777\r\n1453481278 1152911564 151292167\r\n1408582979 1465584228 44898299\r\n7167651 0 19621130\r\n2907567891 1829621431 240604380\r\n2252358778 3652347291 145258999\r\n1005317595 1016932351 135979213\r\n1945208435 2745858358 113876508\r\n2397617777 4065750273 16506015\r\n3251499859 1776094709 53526722\r\n2867005672 4082256288 40562219\r\n26788781 1304203731 161380497\r\n3305026581 2409995769 287729531\r\n3866030451 3243086064 409261227\r\n2414123792 1773059646 3035063\r\n911026677 1510482527 66141597\r\n3148172271 3817281908 103327588\r\n2527235714 2070225811 339769958\r\n188169278 26788781 722857399\r\n\r\nhumidity-to-location map:\r\n3907319746 3137303541 31421983\r\n3085093695 1018495475 286155292\r\n2898003508 2491485887 87665522\r\n2546787368 2901838353 7997221\r\n3835317650 2829836257 72002096\r\n2554784589 3509894030 133012322\r\n3487595595 3719561871 104747874\r\n3714670750 2667334372 120646900\r\n975094571 2909835574 227467967\r\n2985669030 3864000834 99424665\r\n3672962118 2449777255 41708632\r\n3631107133 2787981272 41854985\r\n3938741729 3963425499 15057061\r\n3447904506 3824309745 39691089\r\n1824175159 1304650767 641793976\r\n242892183 0 6504921\r\n3371248987 3642906352 76655519\r\n1698833898 2258930589 81940357\r\n0 6504921 242892183\r\n2465969135 3978482560 80818233\r\n3592343469 4256203632 38763664\r\n3953798790 3168725524 341168506\r\n2775979874 4134179998 122023634\r\n1780774255 975094571 43400904\r\n1311468847 1946444743 312485846\r\n2687796911 2579151409 88182963\r\n1202562538 2340870946 108906309\r\n1623954693 4059300793 74879205";

        private Dictionary<string, Dictionary<string, Dictionary<(long, long), long>>> BuildMap(IEnumerable<string> lines)
        {
            var map = new Dictionary<string, Dictionary<string, Dictionary<(long, long), long>>> { };
            var source = "";
            var dest = "";
            var re = new Regex(@"(?<source>\w+)-to-(?<destination>\w+)");

            foreach (var line in lines)
            {
                var m = re.Match(line);
                if (m.Success)
                {
                    source = m.Groups["source"].Value;
                    dest = m.Groups["destination"].Value;
                    var x = new Dictionary<string, Dictionary<(long, long), long>> { { dest, new Dictionary<(long, long), long>() } };
                    map.Add(source, x);

                    Console.WriteLine($"mapping {source} to {dest}");
                    continue;
                }

                var parsedLine = line.Split(' ', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries).Select(x => long.Parse(x)).ToArray();
                var sourceMapValue = parsedLine[1];
                var destinationMapValue = parsedLine[0];
                var length = parsedLine[2];
                map[source][dest].Add((sourceMapValue, sourceMapValue + length), destinationMapValue - sourceMapValue);

            }
            return map;

        }

        public void Part1()
        {
            //_input = "seeds: 79 14 55 13\r\n\r\nseed-to-soil map:\r\n50 98 2\r\n52 50 48\r\n\r\nsoil-to-fertilizer map:\r\n0 15 37\r\n37 52 2\r\n39 0 15\r\n\r\nfertilizer-to-water map:\r\n49 53 8\r\n0 11 42\r\n42 0 7\r\n57 7 4\r\n\r\nwater-to-light map:\r\n88 18 7\r\n18 25 70\r\n\r\nlight-to-temperature map:\r\n45 77 23\r\n81 45 19\r\n68 64 13\r\n\r\ntemperature-to-humidity map:\r\n0 69 1\r\n1 0 69\r\n\r\nhumidity-to-location map:\r\n60 56 37\r\n56 93 4";
            var result = long.MaxValue;
            var seedNumbers = _input
                .Substring(
                    _input.IndexOf(':') + 1,
                    _input.IndexOfAny(new char[] { '\n', '\r' }) - _input.IndexOf(':') + 1)
                .Split(' ', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries)
                .Select(x => long.Parse(x))
                .ToArray();

            var lines = _input.Substring(_input.IndexOfAny(new char[] { '\n', '\r' })).Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            var map = BuildMap(lines);


            Console.WriteLine("starting on run");

            foreach (var seedNumber in seedNumbers)
            {
                var currentNumber = seedNumber;
                var key = "seed";
                while (key != "location")
                {
                    var val = map[key];

                    var next = val.Keys.First();

                    var k = map[key][next].Keys.Where(k => k.Item1 <= currentNumber && k.Item2 > currentNumber).FirstOrDefault();
                    if (k != default)
                    {
                        currentNumber += map[key][next][k];
                    }

                    key = next;
                }

                result = Math.Min(result, currentNumber);
            }

            Console.WriteLine(result);
        }

        public void Part2()
        {
            //_input = "seeds: 79 14 55 13\r\n\r\nseed-to-soil map:\r\n50 98 2\r\n52 50 48\r\n\r\nsoil-to-fertilizer map:\r\n0 15 37\r\n37 52 2\r\n39 0 15\r\n\r\nfertilizer-to-water map:\r\n49 53 8\r\n0 11 42\r\n42 0 7\r\n57 7 4\r\n\r\nwater-to-light map:\r\n88 18 7\r\n18 25 70\r\n\r\nlight-to-temperature map:\r\n45 77 23\r\n81 45 19\r\n68 64 13\r\n\r\ntemperature-to-humidity map:\r\n0 69 1\r\n1 0 69\r\n\r\nhumidity-to-location map:\r\n60 56 37\r\n56 93 4";
            var result = long.MaxValue;
            var seedNumbers = _input
                .Substring(
                    _input.IndexOf(':') + 1,
                    _input.IndexOfAny(new char[] { '\n', '\r' }) - _input.IndexOf(':') + 1)
                .Split(' ', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries)
                .Select(x => long.Parse(x))
                .ToArray();

            var sn = new List<(long, long)>();
            for (var i = 0; i < seedNumbers.Length; i += 2)
            {
                sn.Add((seedNumbers[i], seedNumbers[i + 1]));
            }

            var lines = _input.Substring(_input.IndexOfAny(new char[] { '\n', '\r' })).Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            var map = BuildMap(lines);

            Console.WriteLine("starting on run");

            var options = new string[]{
                "location",
                "humidity",
                "temperature",
                "light",
                "water",
                "fertilizer",
                "soil",
                "seed",
            };

            //for(var i = 0; i < options.Length - 1 ; i++)
            //{
            //    var source = options[i];
            //    var destination = options[i+1];
            //    var min = map[destination][source].Min(x => x.Value);
            //    var lowestOptions = map[destination][source].Where(x => x.Value == min).First();
            //}
            var foo = new ConcurrentBag<long>();
            Parallel.ForEach(sn, x =>
            {
                var startTimestamp = Stopwatch.GetTimestamp();

                var minVal = long.MaxValue;
                var start = x.Item1;
                var count = x.Item2;
                Console.WriteLine($"starting from {start} and trying {count} times");

                for (var seedNumber = start; seedNumber < start + count; seedNumber++)
                {
                    var currentNumber = seedNumber;
                    var key = "seed";
                    while (key != "location")
                    {
                        var val = map[key];

                        var next = val.Keys.First();

                        var k = map[key][next].Keys.Where(k => k.Item1 <= currentNumber && k.Item2 > currentNumber).FirstOrDefault();
                        if (k != default)
                        {
                            currentNumber += map[key][next][k];
                        }

                        key = next;
                    }
                    //Console.WriteLine($"comparing {result} to {currentNumber}");
                    minVal = Math.Min(result, currentNumber);
                }

                Console.WriteLine($"minVal found for this was {minVal} in {Stopwatch.GetElapsedTime(startTimestamp)}");
                foo.Add(minVal);
            });

            //Console.WriteLine(string.Join('\n', seedNumbers));
            Console.WriteLine(result);
        }
    }
}