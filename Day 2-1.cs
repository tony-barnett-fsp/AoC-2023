private Dictionary<int, bool> _isValid = new Dictionary<int, bool> ();

private string[] _options = new string[]{ "blue", "green", "red" };

void Main() { 
	var input = "Game 1: 9 red, 2 green, 13 blue; 10 blue, 2 green, 13 red; 8 blue, 3 red, 6 green; 5 green, 2 red, 1 blue" +
"\nGame 2: 2 green, 2 blue, 16 red; 14 red; 13 red, 13 green, 2 blue; 7 red, 7 green, 2 blue" +
"\nGame 3: 6 red, 4 green, 7 blue; 7 blue, 9 red, 3 green; 2 red, 4 green; 6 red, 2 blue; 7 blue, 9 red, 5 green" +
"\nGame 4: 8 red, 2 green, 2 blue; 5 red, 2 blue, 3 green; 7 red, 9 green, 2 blue; 10 blue, 16 green, 1 red; 6 blue, 1 green, 8 red" +
"\nGame 5: 12 blue, 6 red, 1 green; 10 green, 8 blue, 15 red; 1 green, 12 red, 11 blue; 3 green, 11 blue, 1 red; 7 blue, 5 red, 5 green; 11 green, 2 blue" +
"\nGame 6: 3 blue, 10 green, 2 red; 5 green; 6 blue, 3 red" +
"\nGame 7: 3 green, 1 blue, 4 red; 3 red, 13 blue; 14 blue, 6 red; 7 green, 15 blue, 9 red; 1 green, 3 red, 9 blue" +
"\nGame 8: 19 red, 1 green, 4 blue; 14 blue; 2 red, 3 blue" +
"\nGame 9: 5 green, 14 blue, 3 red; 8 red, 16 blue, 5 green; 12 green, 15 red, 4 blue; 14 blue, 17 red; 6 red, 11 blue, 8 green" +
"\nGame 10: 9 red, 7 blue; 6 red, 3 blue, 4 green; 1 red, 5 green, 3 blue; 5 red, 9 green, 6 blue; 7 blue, 6 green" +
"\nGame 11: 2 blue, 10 green; 11 green; 2 green, 1 red, 2 blue; 2 blue, 1 green, 1 red; 2 blue, 18 green" +
"\nGame 12: 6 green, 2 red; 2 green; 11 red, 6 green, 1 blue" +
"\nGame 13: 1 blue, 10 red, 2 green; 2 green, 7 red; 9 green, 9 red; 1 red, 4 green" +
"\nGame 14: 7 red, 15 green, 17 blue; 10 green, 6 red, 12 blue; 3 blue, 7 red, 3 green" +
"\nGame 15: 8 green; 10 red, 17 green, 1 blue; 9 red, 1 blue; 6 green, 8 red; 1 green, 1 red; 17 green, 2 red" +
"\nGame 16: 3 blue, 2 green, 7 red; 12 blue, 9 red, 5 green; 8 green, 3 blue, 5 red; 6 red, 2 blue, 11 green; 3 green, 8 blue, 9 red; 1 green, 5 red, 12 blue" +
"\nGame 17: 2 green, 1 blue, 3 red; 1 blue, 1 green, 4 red; 2 blue, 2 green, 11 red; 1 red, 2 green; 2 blue, 10 red, 2 green" +
"\nGame 18: 3 blue, 3 red; 8 blue, 1 green, 5 red; 4 green, 6 blue, 3 red" +
"\nGame 19: 9 red, 3 green, 14 blue; 15 red, 2 blue, 1 green; 2 green, 15 red, 5 blue; 3 red, 3 blue, 1 green" +
"\nGame 20: 2 red, 1 blue, 5 green; 11 blue, 1 red, 4 green; 6 blue, 2 red, 2 green; 13 blue, 2 red, 10 green; 7 green, 13 blue" +
"\nGame 21: 3 red, 1 green, 1 blue; 3 red, 7 blue, 1 green; 1 green, 4 red, 7 blue; 1 green; 6 blue, 3 red; 2 red, 6 blue" +
"\nGame 22: 7 red, 5 green, 2 blue; 14 red; 2 blue, 5 green, 15 red; 1 blue, 5 green, 14 red; 13 red, 1 green; 3 red, 1 green" +
"\nGame 23: 2 green, 8 blue, 5 red; 3 blue, 9 red; 9 blue, 2 green; 9 red, 2 green, 5 blue; 5 red, 2 green" +
"\nGame 24: 14 green, 7 blue, 2 red; 7 blue, 3 red, 16 green; 1 blue, 5 red, 6 green; 3 blue, 7 red, 2 green; 7 red, 9 green" +
"\nGame 25: 3 blue, 8 red, 15 green; 2 red, 8 green, 2 blue; 16 red, 3 blue, 13 green" +
"\nGame 26: 1 blue, 9 red, 8 green; 6 green, 1 red, 3 blue; 7 red, 8 blue, 6 green; 9 red, 7 green" +
"\nGame 27: 6 red, 9 green, 1 blue; 8 green, 3 red, 1 blue; 8 green, 15 red; 14 red, 11 green, 2 blue; 11 green, 4 red, 2 blue; 1 blue, 16 red" +
"\nGame 28: 6 green, 10 blue, 4 red; 6 red, 2 blue, 6 green; 6 green, 14 blue, 17 red; 9 green, 1 red, 9 blue" +
"\nGame 29: 10 blue, 2 red; 3 red, 11 green, 7 blue; 8 green, 2 blue, 7 red; 17 green, 5 blue, 9 red; 19 green, 10 red, 9 blue" +
"\nGame 30: 6 blue, 9 green, 6 red; 17 green, 10 blue, 8 red; 17 green, 12 red, 7 blue" +
"\nGame 31: 9 red, 1 green, 1 blue; 3 red; 6 red, 1 blue, 1 green; 2 blue, 7 red" +
"\nGame 32: 3 green, 8 blue; 5 red, 4 green, 2 blue; 10 blue, 3 green; 2 green, 4 blue; 2 green, 16 blue, 2 red" +
"\nGame 33: 2 red, 8 blue; 2 green, 6 red, 1 blue; 7 red, 12 blue; 1 red, 1 green, 7 blue; 1 green, 3 red, 2 blue" +
"\nGame 34: 15 green; 1 red, 6 green; 6 blue, 1 red, 17 green; 14 green, 3 blue; 11 green, 1 red; 4 green, 1 blue" +
"\nGame 35: 4 red, 3 green, 12 blue; 20 blue, 2 red, 2 green; 4 red, 4 green, 8 blue" +
"\nGame 36: 8 red, 7 green; 15 red, 2 blue, 3 green; 2 red, 1 blue, 5 green; 4 green, 1 blue, 9 red; 14 red, 1 blue, 1 green; 11 green, 12 red" +
"\nGame 37: 3 red, 3 green, 8 blue; 3 blue; 1 green, 3 blue, 2 red; 1 red, 2 blue, 2 green" +
"\nGame 38: 18 red, 12 blue, 7 green; 7 blue, 10 red, 10 green; 1 green, 6 blue, 10 red; 7 red, 3 blue, 12 green; 9 green, 5 blue, 3 red" +
"\nGame 39: 2 blue, 2 green, 2 red; 5 blue, 1 green; 1 blue; 1 red, 5 blue, 2 green" +
"\nGame 40: 4 blue, 1 green; 5 blue, 1 red, 7 green; 2 red, 5 green, 5 blue" +
"\nGame 41: 15 blue, 3 green, 16 red; 16 blue, 18 red, 8 green; 8 green, 1 blue, 12 red; 11 blue, 5 green, 18 red; 5 green, 20 red, 17 blue" +
"\nGame 42: 7 red, 10 green; 1 blue, 5 red, 6 green; 6 red, 3 blue, 9 green; 6 green, 3 blue, 8 red; 4 green, 4 red, 2 blue; 2 blue, 1 green" +
"\nGame 43: 6 blue, 5 red, 1 green; 2 green; 2 blue, 1 red; 4 green, 5 blue, 2 red" +
"\nGame 44: 10 green; 8 green; 10 green, 2 blue, 10 red" +
"\nGame 45: 9 green, 3 red; 8 green, 2 blue; 2 green, 8 blue" +
"\nGame 46: 2 red, 9 blue, 9 green; 6 red, 10 green, 11 blue; 5 red, 4 green, 3 blue; 3 red, 2 green, 14 blue; 5 green, 5 red, 12 blue; 1 red, 9 green, 18 blue" +
"\nGame 47: 2 red, 3 blue; 2 green; 2 green, 3 blue" +
"\nGame 48: 9 green, 6 red, 1 blue; 3 blue, 12 green, 8 red; 4 red, 5 green, 5 blue; 14 green, 5 red; 1 red, 18 green, 4 blue" +
"\nGame 49: 11 red, 10 green, 12 blue; 4 green, 6 red, 6 blue; 9 red, 3 blue, 7 green; 6 red, 10 green, 14 blue; 8 blue, 10 red, 5 green; 6 blue, 17 green, 6 red" +
"\nGame 50: 8 blue, 4 green, 2 red; 1 red; 10 green, 4 blue, 1 red; 5 green, 8 blue, 2 red; 6 red, 1 blue, 3 green; 6 blue, 6 red, 1 green" +
"\nGame 51: 3 red, 3 blue, 2 green; 8 green, 5 red; 11 red, 11 green, 2 blue; 12 green, 2 blue, 19 red; 12 red, 1 blue, 12 green; 10 green, 1 blue, 3 red" +
"\nGame 52: 2 blue, 15 red; 19 red, 4 green; 11 red, 3 green, 6 blue; 1 green, 2 blue, 8 red; 3 blue, 6 red; 1 green, 7 blue, 1 red" +
"\nGame 53: 1 green; 2 green, 1 blue; 1 red" +
"\nGame 54: 1 red, 1 green, 12 blue; 1 green, 5 red, 12 blue; 2 green, 4 blue; 13 blue, 2 red, 2 green; 2 green, 10 blue, 1 red; 5 red, 1 green, 7 blue" +
"\nGame 55: 4 green, 16 blue, 11 red; 6 red, 15 blue; 6 blue, 4 green, 5 red; 10 blue, 10 red, 3 green" +
"\nGame 56: 3 red, 8 blue, 11 green; 9 green, 5 red, 4 blue; 1 blue, 4 red, 4 green" +
"\nGame 57: 3 red, 12 green, 7 blue; 13 green, 14 blue, 1 red; 4 red, 6 green, 9 blue; 12 blue, 13 green" +
"\nGame 58: 4 red, 4 blue, 3 green; 3 blue, 4 red; 11 green, 2 blue, 2 red" +
"\nGame 59: 12 green, 5 red, 1 blue; 7 red, 1 blue, 3 green; 17 green, 2 blue, 4 red; 12 red, 17 green; 7 red, 10 green, 2 blue" +
"\nGame 60: 5 blue, 3 green; 5 green, 11 red, 12 blue; 1 red, 2 blue, 15 green" +
"\nGame 61: 12 blue, 1 green, 12 red; 14 blue, 12 green, 5 red; 7 red, 12 blue, 16 green" +
"\nGame 62: 1 green, 8 red, 8 blue; 11 blue, 2 red; 1 green, 10 blue, 12 red; 7 red, 2 blue, 1 green; 6 red, 1 green, 11 blue; 1 green, 6 red, 6 blue" +
"\nGame 63: 17 green, 16 red, 10 blue; 9 red, 14 green, 11 blue; 5 green, 16 red" +
"\nGame 64: 12 red, 1 green, 1 blue; 4 blue, 7 red; 10 blue, 4 green, 6 red; 8 blue, 4 red, 13 green; 13 green, 9 blue, 9 red; 13 blue, 7 red, 3 green" +
"\nGame 65: 4 blue, 3 green, 4 red; 10 blue, 5 red, 7 green; 1 red, 4 blue, 3 green; 13 green, 1 red, 9 blue; 8 green, 3 blue" +
"\nGame 66: 17 green, 13 red, 3 blue; 15 green, 2 red, 4 blue; 10 red, 4 blue, 5 green; 6 red, 5 blue, 7 green; 3 red, 10 green, 1 blue" +
"\nGame 67: 10 blue; 4 blue, 4 red; 4 blue, 3 green, 3 red; 1 green, 5 blue, 3 red" +
"\nGame 68: 6 green, 6 blue, 3 red; 13 blue, 1 red; 14 blue, 6 red, 2 green; 14 blue, 7 red, 2 green" +
"\nGame 69: 2 green, 2 blue, 3 red; 1 red, 6 blue, 4 green; 8 green, 9 red; 2 green" +
"\nGame 70: 2 red, 7 green; 1 red, 10 green, 1 blue; 6 blue, 14 green; 6 green, 2 blue, 1 red; 5 blue, 10 green, 2 red; 2 blue, 11 green" +
"\nGame 71: 6 blue, 4 red, 7 green; 13 green, 6 red, 3 blue; 8 green, 2 blue, 4 red" +
"\nGame 72: 3 blue, 1 green, 11 red; 5 green, 11 blue, 4 red; 7 blue, 13 red; 14 blue, 12 red, 5 green" +
"\nGame 73: 8 red, 19 blue, 4 green; 15 green, 3 red, 16 blue; 7 blue, 9 red" +
"\nGame 74: 5 green, 8 red, 6 blue; 8 green, 9 red; 11 green, 6 blue" +
"\nGame 75: 1 green, 6 red, 4 blue; 2 green, 13 blue, 6 red; 10 red, 1 green, 10 blue" +
"\nGame 76: 3 blue, 6 green, 2 red; 7 red, 6 blue, 4 green; 5 blue, 6 red, 3 green" +
"\nGame 77: 17 red, 6 green; 7 green, 12 red, 4 blue; 4 red, 7 green, 14 blue" +
"\nGame 78: 1 green, 15 red, 5 blue; 16 green, 3 red, 18 blue; 13 blue, 1 red, 13 green" +
"\nGame 79: 7 red, 1 blue, 3 green; 2 green, 5 red; 5 green, 2 blue, 8 red; 11 red, 1 blue, 3 green" +
"\nGame 80: 9 blue, 4 red; 4 green, 3 blue, 4 red; 7 red, 9 blue, 4 green; 5 red, 9 blue, 4 green; 3 red, 11 blue, 5 green; 6 red, 4 green, 11 blue" +
"\nGame 81: 1 red, 16 green, 2 blue; 4 red, 15 green, 10 blue; 2 red, 9 blue, 17 green; 10 blue, 16 green" +
"\nGame 82: 4 blue, 3 green; 2 green, 3 blue; 4 blue, 2 red, 2 green; 2 red, 1 green" +
"\nGame 83: 10 blue, 8 red, 19 green; 8 red, 4 blue, 17 green; 2 blue, 9 red, 6 green; 11 blue, 2 red, 17 green; 1 red, 17 green, 8 blue" +
"\nGame 84: 4 blue, 1 red, 6 green; 7 blue, 10 green, 4 red; 1 green, 7 blue, 1 red" +
"\nGame 85: 1 blue, 2 red, 1 green; 5 blue, 2 green, 9 red; 1 green, 2 red, 10 blue" +
"\nGame 86: 17 blue, 9 green, 9 red; 19 red, 12 green, 11 blue; 19 red, 9 green, 17 blue" +
"\nGame 87: 11 green, 6 red; 1 green, 4 blue; 16 green, 5 red; 14 green, 1 red, 14 blue; 12 blue, 8 green, 6 red; 4 red, 11 blue, 2 green" +
"\nGame 88: 6 green, 7 red, 1 blue; 5 red, 1 green, 1 blue; 3 red, 6 green" +
"\nGame 89: 1 green, 8 blue, 1 red; 8 red, 1 green; 4 red, 6 blue; 4 red, 10 blue; 8 red, 9 blue, 1 green" +
"\nGame 90: 6 blue, 12 green; 1 red, 4 blue, 14 green; 5 red, 5 blue, 6 green; 1 blue, 3 red, 3 green; 7 green, 4 blue; 2 green, 2 red, 1 blue" +
"\nGame 91: 2 blue, 12 red, 4 green; 7 green, 6 red; 1 blue, 7 green, 6 red; 5 green, 5 red, 1 blue; 1 blue, 11 green, 9 red; 4 red, 1 blue, 2 green" +
"\nGame 92: 4 blue, 12 green; 6 red, 4 blue, 2 green; 5 blue, 1 red, 17 green; 6 red, 4 blue, 15 green; 3 blue, 5 red, 13 green" +
"\nGame 93: 8 green, 2 blue, 16 red; 7 green, 3 blue, 8 red; 9 green, 4 red, 3 blue; 13 red, 5 blue; 5 blue, 1 green, 10 red; 1 blue, 9 red" +
"\nGame 94: 7 blue, 5 red, 14 green; 8 green, 3 blue, 1 red; 4 blue, 8 red" +
"\nGame 95: 3 blue, 4 green, 10 red; 5 blue, 17 red, 2 green; 18 red, 2 green, 5 blue; 3 blue, 3 green, 2 red; 4 blue, 18 red; 6 red, 2 green" +
"\nGame 96: 1 blue, 9 green, 2 red; 3 red, 10 green; 2 red, 8 green, 4 blue; 17 green, 2 blue; 10 green, 1 blue, 1 red; 8 green, 1 blue, 3 red" +
"\nGame 97: 9 green, 1 blue; 1 blue, 6 green; 7 blue, 3 green; 3 red; 17 green, 5 red; 1 blue, 17 green, 5 red" +
"\nGame 98: 4 blue, 7 green, 2 red; 15 green, 10 blue, 1 red; 4 blue, 5 green; 1 green, 2 red, 5 blue" +
"\nGame 99: 2 green, 1 blue, 14 red; 11 red, 6 blue, 5 green; 10 red, 18 blue, 1 green; 5 green, 9 blue, 9 red" +
"\nGame 100: 5 blue, 5 green; 7 blue, 15 green; 4 red, 7 green, 12 blue; 7 green, 1 blue; 5 blue, 9 green, 1 red";

	var lines = input.Split(new char[]{ '\n', '\r' });
	
	foreach(var line in lines)
	{
		line.Dump();
		
		if(line.Length < 4 || line[..4] != "Game")
		{
			throw new Exception();
		}
		
		var colonPlace = line.IndexOf(":");
		var gameNumber = int.Parse(line[4..colonPlace]);
		
		var results = line[(colonPlace + 1)..];
		
		_isValid.Add(gameNumber, true);	
		
		foreach(var game in results.Split(';'))
		{
			var remainingResults = new Dictionary<string, int>
			{
				{ "blue", 14 },
				{ "green", 13 },
				{ "red", 12 },
			};
			
			foreach(var result in game.Split(new char[]{ ','}))
			{
				var colour = _options.Where(o => result.Contains(o)).Single();
				var spacePlace = result.Trim().IndexOf(' ');
				var resultNumber = int.Parse(result.Trim()[..spacePlace]);
				
				remainingResults[colour] -= resultNumber;
				//colour.Dump();
				//remainingResults.Dump();
				if(remainingResults[colour] < 0)
				{
					_isValid[gameNumber] = false;
					break;
				}
			}
		}
	}
	
	_isValid.Dump();
	_isValid.Where(i => i.Value).Dump();
	_isValid.Where(i => i.Value).Sum(x => x.Key).Dump();
}