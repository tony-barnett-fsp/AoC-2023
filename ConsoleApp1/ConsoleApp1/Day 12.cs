﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Day12
    {
        private string _input = "??.?#??#?#??##???? 2,4,6,1\r\n?????#?..?#? 2,2,2\r\n???#???#.?#?????.# 5,1,1,1,2,1\r\n???#???#.#??#??##?? 1,1,1,1,9\r\n????###??.????#.# 5,1,2,1\r\n.?##?##?.?????#?#?. 6,6\r\n?????#???#??#???? 3,8\r\n???#????.?? 3,1,1\r\n?#?#???????#?#?.. 5,4\r\n??????##????.#?? 1,9,1,1\r\n#??????..???#?????? 2,4,1,3,1\r\n.#.???.#?#?#??##??. 1,1,5,4\r\n??????#.?????#?#???. 5,1,1,6,1\r\n#?????###??#?. 1,7,2\r\n.???????#. 1,6\r\n??#?#..?... 4,1\r\n?##?#?????##??#?# 5,2,5,1\r\n???#.?.?#???? 1,1,1,6\r\n#????.??.?. 4,1\r\n??##??#???? 4,1,1\r\n?#???#??????????? 1,9,1\r\n??????..??????#?#?# 1,2,1,1,6,1\r\n?.?.#?#?#??????#??. 1,1,5,3,1,1\r\n#???.????.??? 3,2,2\r\n.????????#??##??#??? 1,13,1\r\n????#??????. 1,2,3\r\n..?##.????#? 3,1,1\r\n??##??##?#???? 1,11\r\n???????????#???????? 6,5,1,1\r\n?####?#??#?.. 7,1\r\n.??#?#??##??????.##? 11,3\r\n???????????? 2,2,1,1\r\n??????.?.?????? 4,3\r\n?#.??#??.?#??? 1,2,1,1\r\n???????..??? 2,1,1\r\n???.#?.?????. 1,1,4\r\n?#??.?..?#???... 2,5\r\n.#?.#?#.?????..##??? 1,1,1,1,1,5\r\n???.?.?..?.???#. 3,1,1,2\r\n??????????.?..#??? 2,2\r\n?#???##????#?.?????# 1,1,2,4,2,1\r\n.?#????#?????#??. 2,1,3,5\r\n?.##.?#?##?#.??? 2,6,2\r\n?.???????.?.###??#?? 3,2,1,8\r\n???#?????.??.??.#? 5,1,2,1,1\r\n#?..???????#?#. 1,3,3,1\r\n???#???...? 4,1\r\n?.??#..??..???. 2,2\r\n...????????#.? 4,4\r\n????.????? 3,1\r\n.???.??#?#?? 3,1,1,3\r\n.??.#???.?#?????###? 1,4,3,5\r\n?#?.?????????.??##.? 1,2,4,2\r\n???.???#..??.?? 2,1,1,1,1\r\n???#????##?????.#? 6,2,3,1\r\n?????..????##??? 3,1,7\r\n???????.#.?????.?.?? 1,4,1,3,2\r\n?#??????.???#?#????? 1,5,10\r\n.??????????#?? 1,1,2,3\r\n?#??..???#.??##.?# 1,1,1,1,4,1\r\n???#?????.???#? 2,1,1,1,1\r\n?.##?#???.???#?#?## 6,1,7\r\n.??#??#?##?????? 3,4,1,1\r\n..??.?.??? 2,1\r\n??????#?#??#??.???# 1,1,7,1,2,1\r\n???.?..#???#?.###?? 2,5,5\r\n???#.#..?######.??? 1,1,1,7,1,1\r\n??#?#..#?.?.??## 5,2,1,4\r\n??#.#.?????#???#? 1,1,1,1,8\r\n?????#?????.. 2,1\r\n..?????????? 1,3,1\r\n?.????????#.??####? 1,1,2,1,1,5\r\n#???#?????.???#? 1,2,3,2\r\n??.?#???????. 4,1\r\n#?.#?#????. 1,1,5\r\n??????#????##??? 1,9\r\n.??.???????? 2,1,2\r\n???.#???#?????#?? 1,1,7,2\r\n???.##??.???#???? 1,4,4,1\r\n???...?.??##?##..??. 7,1\r\n?????#.?????##?##?? 1,1,9\r\n.??.?.????. 1,2,1\r\n??.#??????###???. 10,1\r\n?#???#????????? 2,2,1,1,1\r\n???.?????????#. 3,4\r\n?..????##?????..? 1,8,1,1\r\n?#???????# 1,1,1\r\n??#????#?.?#?.#??.? 9,1,2\r\n?#..?.??#.#.?#????? 1,1,2,1,1,4\r\n?.?#.?..??# 1,1,1\r\n??.#??.#.???#????? 1,2,1,1,3,1\r\n??#.??#??##??.??#?. 3,3,5,1\r\n.?.?????#???????# 1,8,1,2\r\n?#?##?#?????##???..? 9,5\r\n#..?..#?????#???. 1,10\r\n??#?#??.#?????# 2,2,7\r\n???????#??????.?#. 1,1,2,5,1\r\n??.#???#??##???.# 1,6,4,1\r\n?????????.?.#???#?.. 4,5\r\n?????####.. 1,5\r\n?#???#??#.#???.? 6,1,1,1\r\n????.?.??.???. 2,1\r\n?????.?#?.?#??###?? 1,1,1,3,8\r\n??????##????#??????# 6,1,1,1,3\r\n???.???#?.?? 1,3,1\r\n?#??????.?#??#?#? 6,7\r\n????????#?#?????? 1,2,1,3,3\r\n.???.?????..# 2,1,1,1\r\n#????????.?.? 6,1\r\n#??###???????# 1,3,1,1\r\n#???.?#?#?? 2,5\r\n.???????????????# 1,3,1,4,1\r\n????#???..#.#???.. 1,1,1,1,2,1\r\n.?????.?#???# 2,1,4,1\r\n???##??.???? 4,2\r\n????????#?#?.??#?#. 1,3,3,5\r\n?????#??#?????.?#? 11,2\r\n???.?#?#???#? 1,9\r\n?#???##?.?.??##??.?. 7,6\r\n#?#.????#??#. 3,1,5\r\n##???..????#??.? 4,6\r\n?.?#?#?.??? 1,5,1\r\n?#????.?#??.? 1,1,4,1\r\n?#????#?#??#.??? 8,2,1,1\r\n??????#????# 5,1\r\n???????#??????????. 2,2,4\r\n.#.?.??.??#? 1,1,1,1\r\n?.#??.?#????#?#? 1,2,9\r\n?.??..?.???##?.???. 2,1,3,2\r\n?#??.?.?????? 2,1,1,1\r\n.?#?.#.??? 1,1,1\r\n?#???##????.?. 7,1,1\r\n?.??????.#? 3,2\r\n??##?.??##??.? 2,6\r\n???##?..??? 4,1\r\n?#?#??????.? 1,1,4,1\r\n?#?.#?#????#.?#???## 1,1,3,1,7\r\n???#??????#?#?##? 1,2,1,4,4\r\n.??????.????? 1,1,2,2\r\n??#??????###???..?#? 13,1\r\n???#??.??????????.# 5,4,1,1,1\r\n.?##?????????????# 3,1,2,2,2\r\n????????## 2,2\r\n??????.???? 1,1,3\r\n?#.#?#??#.?#?? 1,6,2\r\n??.?????.??..?#.#?? 1,1,2,1,1,1\r\n?##??####?????. 4,4,1\r\n.?#???????#??.??.? 4,3,1\r\n??.?.?????#? 1,5\r\n##???#?#??????.? 2,3,5,1\r\n?#??#???#?#??#? 2,3,4,1\r\n#????.##??.??????? 1,1,1,4,1,3\r\n???.????.??#??# 2,3,1,1\r\n?????????. 2,4\r\n#??.???#???# 2,5,1\r\n##?.#???.#..?.????#? 3,1,1,1,1,4\r\n??#.?????#????#??? 2,1,4,3\r\n?#?????????.???? 11,1,1\r\n??##?????.???#??### 9,1,6\r\n?.?###?#?.???# 7,4\r\n?.#?##?#.##?#? 6,5\r\n.#????#?.?? 1,3,1\r\n????.#??#. 2,1,2\r\n??#????????##??.? 6,6\r\n??#.#??#?.?##..?#? 1,1,5,3,2\r\n?.?.?#?????.?? 1,7,1\r\n??#??#?#??#??#? 1,7,1,2\r\n??.????.??###? 1,3,3\r\n.#???????###????. 5,5,1\r\n?.???????????#?? 1,1,1,1,3\r\n.#????#.?.##????? 1,3,2,1,1\r\n?#??????.????#?? 5,2,1,4\r\n...#?????????.?? 3,3,1\r\n..????#???? 2,3,1\r\n?#????..??#.#? 1,1,3,1\r\n??#?????##????#.???? 12,1,1,1\r\n???#??..?#? 4,1\r\n?????.?#????# 1,1,3,1\r\n???#????.##?##??? 2,3,1,5,1\r\n??#??.????? 4,1,1\r\n?.???###??????.#?# 1,11,1,1\r\n?#?#?????????#?#. 8,1,3\r\n#.?.?#???????#?##?.. 1,6,6\r\n???.????#???#? 1,1,3,2\r\n?????????? 1,1,2\r\n.??.??.????. 1,1,1\r\n?###??#?###??? 10,2\r\n???#?..??.. 4,2\r\n#?##.##.??#??#?.???? 4,2,1,1,2,3\r\n.??.?.????#????. 1,6\r\n???#?#???. 4,4\r\n??#?#???.???.???##?? 8,3,4,1\r\n?#????##?.?.? 3,4,1,1\r\n#?.?????#???#.?????? 1,1,1,2,2,5\r\n#?.???#??#???? 2,2,2,1\r\n???????.?.#?##??? 5,1,4\r\n?????.?#.???# 2,2,3\r\n#.?.#???????#??#.. 1,4,6\r\n??#?#??#?#??.??????? 1,4,1,1,1,2\r\n?.???#?.##?. 1,4,2\r\n????????##???.?.??? 1,2,7,1\r\n#.?.?#?#.?.?????#?#? 1,1,3,1,1,4\r\n???..##??#????? 5,1\r\n???..#?.?.? 2,2\r\n?.??#?#?#??#??..? 3,8\r\n.#????##???#????. 2,7,1\r\n??###??#????? 3,3\r\n#??????##.?#?? 9,2\r\n?#?.?????? 1,1,1\r\n?.?????#?#???#?# 8,3\r\n?.??????#?#?#???? 1,1,3,1,6\r\n?#.???#?..?. 1,3,1\r\n#????#??#?. 1,2,2\r\n?.#???#?#?? 1,5,2\r\n?????#.???#???? 4,1,1,1\r\n?#.??.????? 2,1,2\r\n.#??.?????#??? 3,1,5\r\n????..????#.?..??? 1,1,1,1,1,3\r\n?##??????#? 3,5\r\n??????...?# 1,2,2\r\n.??????.?#.? 2,1,1\r\n??????#???????#? 2,2,6\r\n.??#????#???????.#? 1,2,6,1,1\r\n???.???.??????#? 3,4\r\n???#?.#????#?. 4,7\r\n????##?#?.##?.? 1,5,2\r\n??#??#.?#..#??.# 1,4,1,2,1\r\n?????.?#?????#???.?? 2,8,1,1\r\n?.???.#???.. 1,1,1,1\r\n???#??#?##????#. 13,1\r\n.?#?.?#?#?#????? 2,4,5\r\n????##???#????? 1,8,1\r\n?#?#??#?????????.?? 2,7,1,1,1,1\r\n??????#?#?? 8,1\r\n?.???##.#?#????#?. 1,4,9\r\n??.?????????????..? 8,1\r\n?#?###?..#?.?##??.? 6,2,5\r\n????.??#??????????? 3,3,9\r\n####.?.??.????? 4,1,1,2\r\n.??#...?.??#? 2,3\r\n?#??????#?# 1,7\r\n?.???#.#?# 1,1,3\r\n????.#??..???# 1,3,1,1\r\n?#??#??????? 5,1\r\n???.??.???#???????.# 1,1,9,1\r\n??#???.?#?.????#?? 4,2,1,1\r\n????.?#.?????#?#. 4,1,2,5\r\n.?????#?##??????? 10,2\r\n??#???.?.??? 4,1,1\r\n.?????#??????###?#?? 3,12\r\n??#?#????#?.??? 10,1\r\n???????????? 4,1,1\r\n???##????#?.???. 8,2,2\r\n????##?##. 1,1,5\r\n????#?#?#?#.?#.?? 1,1,7,1,1\r\n?#??#?..???? 5,1\r\n.???..???? 3,1\r\n..???.????.##?? 3,2\r\n??##?.#??????????# 1,2,2,2,1,2\r\n..??.??.?##??.? 2,4\r\n?#????#.?.#?? 7,2\r\n??##?.???#? 2,3\r\n?????.#??#??..? 1,2,6\r\n.?????.?.# 3,1\r\n??.?????#.???#? 2,1,1,1,3\r\n#?.?.????#????.????. 2,1,7,3\r\n??.##?#..??#??#?? 1,2,1,8\r\n???#?.?????? 1,1,1,1\r\n????????#?.??#. 1,5,1,1\r\n.???##??#???#?#? 5,3,3\r\n??#???#..???#?#?? 2,1,1,7\r\n?#?????#???? 7,1\r\n?????#???? 3,1,1\r\n.????.??????#?##? 4,1,6\r\n??.?.????? 1,3\r\n?#?.??????? 3,1,1\r\n?.?.??.?.?###? 1,1,1,5\r\n?#??##????.?? 8,2\r\n..?#???#?????? 6,2\r\n????.????.? 2,2,1\r\n???.???.??? 2,3\r\n?#?#??#.##?#?. 6,2,1\r\n.??#?????#??#?..#? 13,1\r\n#?#??.?????#??.? 4,5\r\n#?#?????????##?? 1,1,3,5\r\n??#??.#?#?? 2,1,1\r\n?###.#.??.???#.??? 3,1,2,1,1,1\r\n?.?.?#?#???#????.??? 1,1,1,6,1,1\r\n??.#????##???#.? 7,2\r\n????.??????# 1,1,1,1\r\n?????#??.?# 2,3,1\r\n?????.???#? 1,4\r\n?#.????#.?.#? 2,1,2,1\r\n?.?????#??#?.. 3,2,2\r\n#?.?????#?? 2,2,4\r\n.????.?.#???.??? 3,1,3,1\r\n??.????.?#???##??? 2,2,7\r\n.?.????#??????#?? 1,1,5,1,3\r\n??.???##?#? 1,7\r\n#..??????.? 1,4,1\r\n????#??#.???#??? 6,2,1\r\n??#?.????..??..??? 3,1,2,1,1,1\r\n#??#????#??#??? 1,10,1\r\n??????#????????? 1,8,2\r\n?##.??#?.? 2,2\r\n?.#?????.?.##?#? 1,1,3,1,4\r\n?#..?##????..?? 1,7,2\r\n?.??#?#??.??????# 1,7,1,1,2\r\n##???##?#??### 9,3\r\n?#.?#?????????.?#? 1,1,2,1,1,2\r\n.?#?.???.???? 2,3,1\r\n.????.??#?? 1,3\r\n??..#.??##????## 1,1,10\r\n##.???.?#?#..??. 2,1,2,1,1\r\n??##???##??? 5,2,1\r\n???#????#?.? 5,2\r\n???????.???.? 2,1,1,1\r\n??????#?????. 2,8\r\n?#???.?.??.?#??## 2,1,1,6\r\n?#.????##????? 1,1,8\r\n.??#???#?????????? 8,4\r\n???.?#???.??????? 1,4,2\r\n.?.??#?#???#?? 1,3,5,1\r\n??#??.?#?????#### 3,1,6\r\n????????#.? 1,1,1\r\n?.?##????.?. 3,1\r\n?.?#?????.. 3,3\r\n.?#?#?#???#.. 6,1\r\n.??????#???????#?.? 3,5,1,1,1\r\n?.?.??#????#?. 1,7\r\n???????#????#???. 6,2\r\n.??????#????????# 1,1,1,4,1\r\n???.?..???????#???. 1,2,7\r\n#??????#?#.? 2,2,3,1\r\n?????????#??????#?. 2,1,1,1,5\r\n??????#.??#? 5,1,1,1\r\n#?.##????? 1,3,1\r\n..#??????#?? 1,2,2\r\n#?#???##??.? 3,4\r\n???#??????# 3,4,1\r\n??.#????#?#??#???. 1,1,8,1\r\n.????????##? 1,7\r\n#??..????#??? 2,2,1,2\r\n?.#??#???#????#.??? 13,2\r\n?????..#???????? 3,3,2,2\r\n?#????.??# 3,1,3\r\n?#????##??#??.??#?? 3,6,1,2\r\n????###.??????? 6,1\r\n???#??#?#?#?####.. 1,14\r\n???.??.#?? 2,1,2\r\n.##???..?#? 2,2\r\n...???#???????? 9,1\r\n?#????#???.?#??#? 1,6,1,3\r\n???#???????#????? 4,1,9\r\n??????.#?? 1,2,2\r\n#????????#?.#???? 1,5,3,1,2\r\n???#?#??##?.??? 5,3,1\r\n??.??##???? 1,4\r\n???????.?????.### 5,1,1,3\r\n???..????? 3,1,2\r\n?###?#???#??????#??? 5,2,4\r\n.???#??.????##?? 6,3\r\n?#?.?????#? 1,2,3\r\n???????.??####?????? 4,1,1,8,1\r\n????.????? 1,1,1\r\n???.#???####?#.? 1,1,1,6\r\n??????##??????.?? 12,1\r\n??#?#???#???. 6,2,1\r\n#?#..#?#???? 3,7\r\n???.??#?#?????#?#? 1,8,4\r\n?##.???.#??? 3,1,1,1\r\n????#?#?#?????#??#.. 11,1,1\r\n??????????#?# 1,8,1\r\n#??.?##??????#?.??? 1,10,1\r\n.#??.###???#? 3,4,1\r\n.??.????## 1,2,3\r\n?????#????.??????##? 3,2,1,1,2,2\r\n??##?????..?#??? 6,2,2,1\r\n??????#???? 1,5\r\n???#????????#?? 4,5\r\n??#??.???? 2,1,1\r\n?????..???#?# 1,5\r\n#?.?##?#??#??.???. 1,10,1,1\r\n?????.??..???# 2,1,1,2\r\n.?????#???? 2,3\r\n.????.????? 1,2\r\n.???#.??#??#..#?? 1,1,5,1\r\n.#?.??#????? 2,1,1,4\r\n?.???.?.#?. 2,2\r\n..??????#????? 1,2,3,1\r\n.?..?#??#? 1,3,1\r\n??.#######???? 1,8\r\n?#??.#??#?.??? 2,4,1\r\n.#??.?#?.?? 1,2\r\n#??.???..???#??? 3,2,5\r\n?.?????..???#####. 3,8\r\n??#??#?.#? 4,1\r\n##?.?#????# 3,1,3\r\n????????.??# 2,1\r\n?#??#??#???????#??? 9,4\r\n????##????#?.? 5,3\r\n#??##??????..? 6,2,1\r\n?.??#..??.#??? 3,2\r\n????????#?. 2,3\r\n?????.?#???.?? 2,1,4,1\r\n???????????#?? 1,1,1,6\r\n?.?????????? 2,5\r\n.#?.?#.??#?????# 1,2,3,3\r\n??#.#????????? 1,5,1\r\n?..#?.?#?# 2,3\r\n??#??.?.????. 3,2\r\n.??.?.##?????#?#. 1,10\r\n???#???????? 1,1,1,3\r\n??.??????.?.???.? 1,5,1,2,1\r\n.??#?.?#.???? 2,2,1,1\r\n..?????????? 2,1\r\n.?#??????.?##???..? 6,5\r\n?.???.#????# 1,2,1,1\r\n???????.???.??? 2,1\r\n????????#? 1,1,2\r\n?#?.#????? 2,5\r\n.???#??#?????????? 6,2\r\n.????????##?#? 2,10\r\n?#.?#????? 1,4\r\n##.#?.#???????????? 2,2,7,1\r\n??#????.??.??? 7,1,1\r\n.?##????.??. 3,1,2\r\n?.?###.???#????????. 4,10\r\n?#?#???#?? 3,2\r\n??..?#?#???? 1,3,1\r\n??????..??.. 6,2\r\n.?#???..#??. 4,2\r\n??#?##????##????##?? 4,9\r\n??#??.????#???? 4,1,1,1\r\n.???.???#?# 1,6\r\n#?.??#??.???? 1,1,2,1\r\n??..??#??#??????# 1,1,1,3,2\r\n?.??.??#.???? 1,1,1,2\r\n???.???.?#??????.# 1,3,3,1,1\r\n#??#??????. 4,1\r\n?#.???.??#?.#??.?? 2,2,1,2,1,1\r\n??.???#?????#??? 1,4,1,3\r\n????.#??#??#???## 1,1,1,5,4\r\n?#?.#??#?..#??##? 2,1,1,5\r\n?##?.??????#.?. 3,4,1,1\r\n.??.???#??.??.#?#? 1,4,2,3\r\n???.?#????##????.#? 1,1,2,9,1\r\n?????????#?#? 3,1,1,1\r\n??#?????.#? 1,2,1\r\n.???????????? 1,1,1,3\r\n??????????.???.??.?? 1,1\r\n#????#.????? 1,4,1\r\n??????.?.?..#?????? 3,1,1,1,1,3\r\n??.?????#?###??? 1,1,1,7\r\n#.#??#????.??. 1,4,2\r\n????.?.?#?. 3,1,2\r\n??????#?.????? 8,1\r\n?###??#??##?..#?..#? 12,2,2\r\n?#??????.??.???##.?? 6,1,1,3,2\r\n.?????????#?????# 2,9,2\r\n??#??#?.???.? 6,1\r\n?.?.??#????#?????. 1,1,3,2,1,1\r\n??.?.?...? 1,1\r\n?.?????.???.?#?#? 1,3\r\n?.#?#??.?.?#?#?#.. 5,5\r\n???#?#?#?????#? 9,4\r\n?#????##?##???. 2,7\r\n????#??.?????# 7,3,1\r\n..?.???????? 1,1,3\r\n?#???#??.??.#??. 7,1,3\r\n?#???#???#??.?#? 1,2,4,1\r\n..???.?#???#??#????# 1,1,9,1\r\n??##?????# 3,1\r\n?#???#???#..???##??. 9,4\r\n?##?#..#?.??# 4,1,2\r\n#??.#????????#? 3,3,1,1,2\r\n?#???###..#?#.?.#?#? 3,3,1,1,4\r\n???#?.????#???.? 1,8\r\n.?????##?????.#? 1,2,1,1,2\r\n????#..?.#?#?..?# 5,1,4,1\r\n??????..???#??.???? 1,1,1,1,3,2\r\n?###???##????.?? 13,1\r\n.?#????????.?.#. 4,4,1\r\n??##?##????.#??.? 1,9,3\r\n..???#??????????#?. 1,1,10\r\n.###.?#..????? 3,1,2,1\r\n?#?.??????##??#? 2,11\r\n.?#????.?? 2,2,1\r\n??#?#####????#.???? 1,1,8,1,1,1\r\n.???..??????#?.? 2,5\r\n??#?????##???.??. 1,1,7,1\r\n???.?..##.?.?#?.?? 3,1,2,1,1,1\r\n..#????.#??.#?## 2,1,1,4\r\n?#?##??????????? 6,6\r\n?.#??.#.?... 2,1\r\n.??#??.??#??# 2,1,2,1\r\n??.??#?#?.???.#???? 1,5,1,1,2\r\n?#?.??.?#??????????. 2,1,11\r\n?????##???? 1,6\r\n.??.?##???.???.?. 1,4,1,3,1\r\n?#.??????####???.? 1,4,8\r\n???#????#?????.? 8,1\r\n?.???????? 1,1,1\r\n???#??#?#??#?#.?? 1,2,4,3,2\r\n#.?????#??##.?.? 1,1,6,1\r\n?#?.?##..???# 2,2,3\r\n#??#???#?.?.??? 4,1,1,1\r\n#?#???.????#?##?? 1,1,1,9\r\n.???#?#?.?..?# 4,1\r\n.????##?#?#??? 1,9\r\n#??.?####?.?.??.?? 3,5,2,1\r\n???#?????..?##?##?? 6,5\r\n..?.#????#?#.?? 2,2,1\r\n?????.??.?#.# 1,2,1,1\r\n.?#??#??#.?.?? 2,5,1\r\n???????#?????##??.? 8,6\r\n?#??????.#?##?? 4,1,5\r\n?.?????.?? 4,1\r\n?#?#???.??. 5,1\r\n?.????.??? 4,1\r\n?#???#??#.??..?# 2,3,1,1,2\r\n??????####?.? 1,6\r\n.?#?.?#??#???? 2,5\r\n??.??#???????#??? 1,13\r\n?#??##??.??#?????. 6,6\r\n?????#??#????? 5,4\r\n#???#?#?#???#?..???? 7,1,3,2\r\n?#??#??#?#????????? 11,2\r\n#?????.???? 2,3,2\r\n.#??.????##.?. 3,1,2,1\r\n????????#?????##? 3,4,1,3\r\n??##?#?#.?????? 7,1\r\n.#???#???#???#?# 7,1,1,1,1\r\n??.?.?.?.??#??.? 1,1,5\r\n??????#??#??##? 1,1,9\r\n...#.??#???#??. 1,3,3\r\n????#?????. 7,2\r\n????#???????.#?#..# 1,1,8,1,1,1\r\n?#?#??.?#?? 2,3,1\r\n??#?.?#.???????.?? 3,1,1,1,1,1\r\n.?#?#?.??##? 5,3\r\n?##??#?.#? 2,1,2\r\n#???#????##.???. 3,7,2\r\n.??##??#????????. 8,1\r\n??#????#?..#?#????. 5,2,1,4\r\n???#????..????. 5,2\r\n??.???.??.#?.? 1,1\r\n?#??.????? 1,1,1\r\n???#?????.?..#. 4,3,1,1\r\n??#?#???##?????????# 7,2,3,1,2\r\n???##???#.??? 1,3,2,3\r\n#.???????# 1,3,2\r\n..#???.#????? 2,4\r\n?#?.??.?.??#.? 2,1,1,2\r\n??.?.???#???# 1,1,6\r\n#??????????#??.?.? 1,2,5,2,1,1\r\n.??????????#???#? 8,6\r\n??????????#?#???? 1,10\r\n???#???..??.?.?? 4,1\r\n.???#???#???#?? 1,1,2,1,1\r\n???.?.#???#???. 1,1,6\r\n..??#??????.. 3,4\r\n#??.?#.????##??#? 2,2,1,2,3\r\n???#?.?.?.?.??? 2,1,1,1,1\r\n??????#?????.? 1,5,1\r\n?##.??..?#??#???## 3,1,5,3\r\n???#?#?????????#?? 10,2,1\r\n.??##?#??#??#?????? 1,2,2,4,1\r\n.???????#?. 5,1\r\n#?#?#??.???#???#.## 1,1,2,8,2\r\n???##???.??????????? 7,3,4\r\n?#?????.???????## 2,1,3,4\r\n???#..?????. 1,1,1,1\r\n.???#??.?#?# 1,3,4\r\n.?###???????.??? 9,1,1\r\n???????##??.?? 10,1\r\n.??.????#??.?? 1,2,2,1\r\n?????##?#??? 2,5\r\n?.???????.?# 1,2,1,1\r\n?..?????#? 1,7\r\n??...?..?????.?? 1,3\r\n.???????.#?.??? 6,2\r\n?????.??#???.?#? 1,1,4,1\r\n??#.?.?#??#? 1,1,6\r\n.??..##..???#?#? 2,2,6\r\n?.??#????? 1,1,2\r\n???##???#??#?#??? 1,2,1,7,1\r\n#??.???????#? 2,5,1\r\n#????#??#..?.? 3,1,1,1\r\n???#??#??..?????#??? 1,6,1,4,1\r\n?.??#..????#????. 1,3\r\n???#??.#.?##?#??#??? 1,1,1,1,8,1\r\n????##???????#? 3,4,3\r\n#.?????#????.? 1,8\r\n?.#???????.?? 3,2\r\n?#??????#? 3,4\r\n#???#??.??#???.??#? 1,1,1,1,5,1\r\n????##??#?.???#?.. 4,2,1,2\r\n?.???#???????#???? 7,5\r\n.??#????????#.?. 1,1,1,1,3\r\n?????????..?####??? 6,6\r\n???.?????? 2,3\r\n?.?#???.?..?.???#.#? 1,4,1,3,1\r\n??.??#.?.?#??? 1,1,5\r\n?#.?#?.#????.?# 1,3,1,1,1\r\n.?#?????.??? 3,1,1\r\n??#?.?.?..#?? 3,1,2\r\n??#??#?####.????. 1,1,7,1,2\r\n#?????#?#? 1,1,3\r\n?##.??????#.. 2,7\r\n..??????.??##?#?# 1,1,1,7\r\n.?.?????#? 1,2,1\r\n??????##???.?..????. 5,2\r\n???????#?... 1,2\r\n???#????????. 1,3,2\r\n.?#???###??#???? 8,3\r\n???#.??#??????? 2,8\r\n???#???.??.??###?? 1,1,1,1,7\r\n#??.?????.###? 1,1,2,3\r\n#.?#????#???#?.?#??? 1,2,4,2,4\r\n?.?#???.##?? 2,2\r\n???#??..?#.???? 2,2\r\n???????????##?????? 5,10\r\n.?????#.????##? 4,6\r\n????????????? 8,1\r\n?..???#?.#??.#? 1,1,2,2\r\n??.???#?#??# 1,1,1,2\r\n?#?##?????????##? 4,2,4\r\n?#?????????????? 9,2\r\n?#.###????#???? 2,3,3,1\r\n.????????.?#??#?? 2,1,1,2,3\r\n???##???.??#??.???? 7,2,3\r\n??#????#???.?????? 2,3,3\r\n#?.????##? 2,1,3\r\n?#??????#??####?. 1,2,1,5\r\n.?...??.?#???.???. 1,2\r\n.???.#???.#?#???.?? 1,1,1,5,2\r\n?????#??### 1,7\r\n????#?..????##??.?? 5,6\r\n???????.##??..# 1,1,1,4,1\r\n???.?##?..??.?#??? 3,4\r\n??#???????#????#? 3,1,7\r\n??..???..##. 2,2,2\r\n???.?#??#???? 2,5\r\n??#.?#??#?? 1,1,3\r\n????#.#?#???????# 1,1,7,1,1\r\n???##?##???.?#????#? 8,3,2\r\n??????#??...??????#? 3,4,7\r\n?#?##??.????????.. 4,1\r\n???#?#?####?. 2,1,5\r\n???#?#.##????..?? 3,1,3,1,1\r\n??#???#?##????.???? 3,7,2,3\r\n??.???.???.#.? 1,1,1,1\r\n.#????.??#?#?????? 5,5,2\r\n.?#??.???.??? 4,1,1\r\n??????#??????###? 3,6,4\r\n.#?.???#?? 2,1\r\n?????#?????.?.???? 7,1,1,2\r\n??#?##???.? 8,1\r\n???###???#??.??????? 9,1\r\n..?##..#???#?#?#?#?? 2,7,3\r\n???#?????.#????? 4,5\r\n?.?#????#?????#??#? 2,11\r\n.#?#??.?##?...?? 1,1,4,2\r\n????.??.?.??# 1,1,1,2\r\n##???.#?#. 4,3\r\n?????##?##?#????#. 1,6,1,3\r\n??????.#??# 1,1,4\r\n#???.??.#? 1,1,1\r\n##??????..??? 4,1,1,2\r\n??#?????????#?#? 2,4,6\r\n?.??????#??#? 1,1,1,2\r\n???.#??#???????.?? 2,1,1,1,4,1\r\n???.?????. 1,1,1\r\n???###???????#?#???? 6,8\r\n???????.?????#?#? 5,1,1,4\r\n?###??#...###???#?#? 4,1,7,1\r\n#.?.?#?.?.?????# 1,1,2,4,1\r\n??.??.????#??#?#? 1,1,1,5,1\r\n?#.??????? 2,1,1\r\n??????#?#???.????? 2,4,2\r\n.???#?????.??.#?# 9,3\r\n?.?..?????? 1,2,1\r\n??????.?.?.#?????? 6,1,7\r\n#??????##???. 1,9\r\n?#????????.?.?.#? 5,1,1\r\n?#??#???#?????? 1,3,5\r\n.?????##????.??## 2,7,4\r\n##?.??.??? 2,2,1\r\n?.?#????##??. 1,3\r\n.????.?#?? 1,2\r\n.?##??.#????#?? 2,7\r\n?.?.?#????##?##. 1,2,5,2\r\n?????.???.#? 1,1,1\r\n?##???.?.? 5,1,1\r\n?#?#?..?.?##?? 5,1,4\r\n.?#..??#????#?? 1,8\r\n??.#??#????? 1,4,1,2\r\n?#.????????. 2,1,2\r\n#?????.?????##???# 6,1,4,1\r\n????...????? 2,3\r\n???#??.??????? 1,3,2,1\r\n##???????#??? 2,8\r\n?#?#???????#????#?.? 1,6,8,1\r\n.??.?.??#??.? 1,1,4,1\r\n??????#?..??. 6,1\r\n.???#?????????? 1,3,1,3,2\r\n??.?#?.???..?#? 2,1,1,1,2\r\n#?#??????###?#???? 14,1\r\n????.????? 2,1,1\r\n##.?????#??#?. 2,2,1,2\r\n.??#?.?#?#.? 2,4\r\n??????#?#?? 2,5\r\n??.???#???????.???? 1,4,2,1,1,1\r\n?#.??#?.#???#???? 1,3,1,1,2\r\n?#???..??? 1,1,1\r\n?.??.????.. 2,1\r\n#?.????#.??.???????# 2,1,1,1,1,4\r\n#?##????##?????? 1,4,2,3,1\r\n#??##?????#??? 1,4,1,1\r\n.?????#????#?#?#?? 1,1,4,5,1\r\n????.??????. 1,3\r\n???.#??????????. 1,4,2,3\r\n??##?#?#??????????? 11,2,3\r\n??.??##??.? 1,4\r\n????????.#.?. 7,1\r\n???????????????.?#?? 1,1,4,3,2\r\n????.?????..???. 5,1\r\n?????#?#?.?##???. 3,5\r\n..??..????##.?.???. 6,2\r\n?????##?.#?????#?.?? 6,1,1,3,1\r\n????.????.# 2,2,1\r\n??#????????.?? 6,1,1,1\r\n???????..#????#??.#? 3,1,7,1\r\n??...##??? 2,3\r\n????##???#????.?? 2,7,1,2\r\n????##????.??#??#. 6,5\r\n???.?#??.?#?#?#?. 2,4,3,1\r\n.#.??.???? 1,1,1\r\n??.?#..?.??##?.???.? 1,3\r\n??#?.????. 2,1\r\n???#?#.###?#.?.??? 5,5,1,1\r\n#????????????? 4,1,3\r\n.#???????? 1,1,1\r\n??????#????#?#? 1,1,9\r\n????#?.#?? 3,1\r\n??#.#?..#.?#.??.?? 3,2,1,1,1,1\r\n?.?????#??????.?. 2,4,1\r\n.???..?.????#? 3,1,1,1\r\n.#?#??#??????????## 4,4,1,3\r\n.#?..?#?????.? 1,3,2\r\n???.??????#??..#.??. 7,1\r\n???.??????.?? 1,1,3,1\r\n??????#??#??#? 1,1,5,1\r\n?#???##??#?.?.??.?.? 3,6,1,1,1,1\r\n???#?#???.??#???. 5,2\r\n??##?#??????.. 6,2\r\n.??????????#? 1,5\r\n?#?#??#?## 6,2\r\n?#.?.#????#??#? 1,1,1,7\r\n??????#??? 1,1,1\r\n?.##???#??. 2,3\r\n??..#??#??## 1,2,1,2\r\n?#?..?????#??#? 3,9\r\n??#..#?#????????? 1,1,1,1,8\r\n#??#?????????####? 1,1,6,6\r\n#?#?#??.???????#??# 5,1,1,3,1,2\r\n.????##?.???#????#? 7,4,1,2\r\n?#??..??#. 1,1,1\r\n??????..#??. 3,2\r\n??#????.????#??.? 3,1,1,4,1\r\n??????????#???..? 1,4,1,1,1\r\n.#??.?#????#.?#? 1,2,4,1\r\n????###????? 5,2\r\n?????#?.?? 6,1\r\n.?.?##??.????? 1,4,1,2\r\n????#.????????? 4,1,2,2\r\n??.???#????##??????? 10,4\r\n?#?????#?.?? 1,1,1,1\r\n.?.?.?..??#???.? 1,1,1,4,1\r\n??????..#.#??? 2,1,2\r\n.??##??#?. 3,3\r\n?.?#???#?????#??# 1,2,3,5\r\n???##????#???.?#??#? 7,2,1,1,2\r\n##???..????. 3,1,4\r\n#?##?.????????.?? 4,7\r\n.??.#???.. 1,3\r\n??#???##????#????? 1,3,2,1,2\r\n#....??#?.#?# 1,3,3\r\n???.?????????? 2,2,3\r\n?#.#.?#.?#?? 1,1,1,2\r\n?.?#??##??????.? 6,2\r\n#???#??????.???? 5,1,3\r\n.???#?#???????#???#? 1,4,2,3,1,2\r\n.????..???..? 4,3,1\r\n?#????.???#??? 4,1,1,1\r\n.??????.?#.?? 2,1,2,1\r\n.???..??.# 1,1,1\r\n#??.?#?#??? 1,6\r\n???#??????????..?. 9,2,1\r\n.#????.??#?.?? 2,1,3\r\n.????#.???? 5,2\r\n?.#????#.????? 2,2,1,2\r\n#?????#?#?????? 1,8,1\r\n??????#?#?? 2,3,2\r\n??.???.?.???????? 1,3\r\n???.#???.?#???? 3,1,1,1,1\r\n.??.????#???.?. 1,7\r\n????.#??????? 1,2,4\r\n?????###??? 1,7\r\n???#???###.???.?? 8,2\r\n??#?????#???? 2,2,1,2\r\n#####????.????? 6,1,1\r\n??#??#???????#? 6,1,2\r\n?#?#???????#??? 5,3,1,1\r\n?.?#?#???#???..??? 1,1,7,1,1\r\n?#.#????????###?? 1,12\r\n?.???????.#? 1,3,2,2\r\n.?????.#??? 4,1\r\n#???..?????? 4,1,3\r\n?.#####????..?? 6,2\r\n?#?..?.#?.?????.? 2,1,2,4\r\n???.??.????. 1,1,1,1\r\n.?##????#? 4,2\r\n??????????.??? 2,1,2,1\r\n?????????#?#?## 2,3,1,4\r\n.?..???#??? 4,1\r\n??#?.?###? 2,3\r\n..#?..??#??##### 2,3,6\r\n??#???.????#? 4,1,3\r\n????#?#??.?#?.?### 7,1,3,3\r\n?#????#?#. 1,3,1\r\n??#???#?##?..#.??. 11,1,1\r\n????#??#?????#????.? 2,6,4,1\r\n.??#?.???????????.?. 1,1,5,3\r\n.??####?#?????#.? 10,1\r\n?#???????#????????? 10,5\r\n.#??????#. 1,4\r\n?.#???????. 4,1\r\n#??????#???.?#? 2,1,1,1,2\r\n???#?????? 4,1,1\r\n?#????#????????????? 2,6,1,1,1,1\r\n#????##???#???#??? 1,1,2,6,1\r\n.?.?#?#???.??#???? 1,4,1,1,2,1\r\n??????#?###????? 6,2\r\n?...?#??#???? 5,1\r\n?.?????.?? 1,1,1\r\n.??...?### 1,4\r\n??????.????#??##?? 1,1,1,3,4\r\n#?.?.??#.?#? 1,1,3,3\r\n????#.?????#?????# 1,1,11\r\n??.???.??..#?.# 1,1,2,2,1\r\n?#??.????###?##?.?.# 2,1,1,7,1,1\r\n???##???#?.? 5,3\r\n??#????????.?.?.?? 6,1,1,2\r\n#.?.?#.?.??? 1,1,1,2\r\n??.?#####?#??#?#??.? 15,1\r\n#.?.?..##?#?. 1,1,5\r\n?????#?##????.? 1,8,1\r\n??#??????#??.? 2,8\r\n?#?#??#???? 5,3\r\n????.?#???? 1,2,1\r\n.??#???#???# 2,6\r\n..?#????????.. 4,2\r\n??.?#??#?? 2,1\r\n?.?????##? 1,6\r\n.????#??#.?#.?? 7,1,1\r\n.#????????#??#???#?? 11,1,1,1\r\n??##??#??????? 5,2\r\n.?????#.#?#??#?#?? 1,1,1,6,1,1\r\n###??.#.#?#.#..?? 5,1,3,1,1\r\n???#?.??.?#??#? 1,3,1,1,2\r\n.?#.?#??#????.?.. 2,4,2\r\n.????#?##????????##? 15,2\r\n#.???#?#???.??????? 1,7,1,1,1,1\r\n??.?.?##??.?###.???. 2,4\r\n?.????.#?#? 2,3\r\n.????.??#?#? 2,5\r\n?.?.#????? 1,3\r\n.#?#??.??#?#???# 1,2,9\r\n????#???#? 5,1\r\n#????..?#????????#?? 1,1,11\r\n#..????.?#???.?? 1,2,2,2,1\r\n??.#.????.? 1,1\r\n?.##.###??.????#. 1,2,4,1,1\r\n##???????.???# 9,1,1\r\n?#??????.? 2,1\r\n????.?#?#???.#.?#?. 2,4,2,1,2\r\n???#?.??.?.??##?.?? 4,2,1,3,2\r\n????##??#?.??? 6,2\r\n?????#??????#??#? 2,2,9\r\n????????.??? 4,1,1\r\n?.?...?.#????#?????? 1,1,1,4,1,2\r\n??#?.??##?. 4,5\r\n.?#?#?????#?#????# 1,1,1,8\r\n??????#.???. 1,1,1,1\r\n.???????????#? 10,2\r\n??##?????.?#?? 6,3\r\n?..??????????.#????? 2,2,4\r\n.??#???.??? 1,3,2\r\n?.???????.?? 1,1,4\r\n???.?#.#?###???? 1,1,9\r\n?#?????.###??.? 4,5\r\n????#?###?????? 10,2\r\n#????#?#??????##?#? 1,16\r\n.?#?.??.?..?# 2,1,1,1\r\n???#??#??????#?????? 4,7\r\n?##??#????.???? 3,1,1,1,2\r\n???????..?? 1,2,1\r\n??.?##.?.??#??.?. 2,4\r\n?.?#?.????#??#?#???. 1,3,1,10\r\n???????????? 1,3\r\n?.?.#????#????? 1,1,6\r\n.?.??????.?# 1,2,2,1\r\n#??##????#????..? 2,7,2,1\r\n?#?#???????.?? 6,3,1\r\n.??##?##??????#?? 8,1,1,1,1\r\n???######.?.?? 8,1\r\n??#?.?????? 3,1,1\r\n.??##?.?????#?? 5,1,1,1\r\n?.???..????#??? 1,1,1,2,1\r\n.#???.?#??#.?#? 3,3,1,1\r\n?.?#?.??#??##?????.? 3,2,4,3\r\n#???????##?#?? 3,6\r\n.?#?#.?##.??. 4,3,2\r\n????????????#????.# 1,1,1,3,6,1\r\n??##????.???##? 4,1,6\r\n?#??.?#?##?.. 1,4\r\n???#??????#?#?.???? 2,2,1,5,2,1\r\n????#??#?#.#??????. 1,7,2,1,1\r\n.???#?.?##???#??#?? 5,3,4,1\r\n??##?.#..?#?????# 4,1,5,1\r\n???#???..? 4,2\r\n???????????##?##??#? 5,2,6,2\r\n???#???.????.. 6,2\r\n?.#.#???#?#?? 1,1,7\r\n.??.?#??..???#???.? 2,6\r\n#????????#??#??#? 1,14\r\n..??#????????#?? 6,3\r\n.???.?#..##???.?? 1,1,4\r\n??.??????.#?#?#..??? 1,5\r\n?#??#?#???? 1,5,2\r\n..??????.. 2,1\r\n?.#?.??#..???#? 2,1,1,1,1\r\n..??????????? 1,2,1\r\n???#?.????? 2,5\r\n??##?????#?.?????? 3,1,3,3,1\r\n#?.??.??#..? 2,1,1,1\r\n?#?????#????##???? 1,12\r\n?#??????.??????###?? 2,2,1,7,1\r\n???...#.?##.#? 2,1,2,1\r\n??????.???##???.? 2,3,7\r\n?.????###?????. 8,1\r\n?.???????.?????????? 1,1,2,8,1\r\n?????????? 1,1,2\r\n?#?#??##?#?#???.?#?. 5,6,2\r\n.?#..???#.?????. 2,2,1,1\r\n???????????.#??? 3,3,1\r\n?.??##.??????? 1,2,3,1\r\n.????#??#?#?##?????? 11,1\r\n.?#???#.?##?#?.?#?? 6,4,2\r\n?#?#?.#.#???..??? 4,1,4,1,1\r\n?##??#???###??#?. 6,6\r\n.#????.#?. 2,1,1\r\n?????##??##?. 2,7\r\n?.??????#?#? 1,1,5\r\n.???#????????#? 2,3,3\r\n.?#?????#?#??##.? 3,9,1\r\n.?..??##????????? 1,5,3,1\r\n??.??#?????? 2,5\r\n#?.??#?.#.?.??????# 1,4,1,1,7\r\n#????#????.????#? 1,1,3,4\r\n.?##????#.??? 3,2\r\n??.????###????.??#? 1,8,1,1,1\r\n?#??????????##.## 4,1,1,3,2\r\n?????#?#.#?.??.? 2,2,1,1,1\r\n.?.?#???.?#????#?#? 3,1,7,1\r\n?.?##????#???#..? 1,6,1,1,1\r\n#?#?.??#?#.. 3,1,1\r\n????#??.???? 2,2,1,1\r\n?.?????#?.??.? 1,2\r\n##????.??.?. 4,1\r\n.?#?????.? 1,1,1\r\n??.?????????.. 3,1\r\n.#??#?#??.?#? 6,1,3\r\n???#?????? 1,1,1\r\n?.?.??.??? 1,3\r\n?????#??#?#??..#? 9,1,1\r\n##??.???#??##?? 4,1,2,1\r\n?.#??????.?#???.?#. 4,3,2\r\n#??##??.???????????? 7,4,1,1\r\n?????..??..?. 1,1\r\n#??#.???.?.#? 4,1,1\r\n????#?#??.??#?.?#?? 6,3,2\r\n?#??#?.???????? 1,3,7\r\n????###???#??????# 11,1\r\n##??.??#?#???#???#? 4,1,9\r\n.??#???..#?#???#???? 1,1,2,1,1,4\r\n??.??..??#?????# 1,7,1\r\n#?.?.#????????# 2,2,3,1,1";

        // Basically a binary counter where '.' is 0 and '#' is 1
        private char[] getNextPattern(char[] currentPattern)
        {
            var toggleNext = true;
            var counter = currentPattern.Length - 1;

            while (toggleNext && counter >= 0)
            {
                var c = currentPattern[counter];

                switch (c)
                {
                    case '.':
                        currentPattern[counter] = '#';
                        toggleNext = false;
                        break;
                    case '#':
                        currentPattern[counter] = '.';
                        break;
                }
                counter--;
            }

            return (char[])currentPattern.Clone();
        }

        // Basically a binary counter where '.' is 0 and '#' is 1
        private char[] getNextPattern(char[] currentPattern, int hashesRequired)
        {
            var p = (char[])currentPattern.Clone();
            do
            {
                var counter = p.Length - 1;
                var toggleNext = true;

                while (toggleNext && counter >= 0)
                {
                    var c = p[counter];

                    switch (c)
                    {
                        case '.':
                            p[counter] = '#';
                            toggleNext = false;
                            break;
                        case '#':
                            p[counter] = '.';
                            break;
                    }
                    counter--;
                }
            }
            while (p.Count(c => c == '#') != hashesRequired);

            return p;
        }

        private bool PatternIsPossible(char[] testPattern, string line, int[] pattern)
        {
            var i = 0;
            var parsedLine = string.Concat(line.Select(c => c == '?' ? testPattern[i++] : c));

            var x = parsedLine.Split('.', StringSplitOptions.RemoveEmptyEntries);

            if (x.Length != pattern.Length)
            {
                return false;
            }
            for (int index = 0; index < pattern.Length; index++)
            {
                int group = pattern[index];
                if (group != x[index].Length)
                {
                    return false;
                }
            }
            return true;
        }

        public void Part1()
        {
            //_input = "???.### 1,1,3\r\n.??..??...?##. 1,1,3\r\n?#?#?#?#?#?#?#? 1,3,1,6\r\n????.#...#... 4,1,1\r\n????.######..#####. 1,6,5\r\n?###???????? 3,2,1";
            var start = Stopwatch.GetTimestamp();
            var lines = _input.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var output = 0;

            foreach (var line in lines)
            {
                var currentOutput = 0;
                var x = line.Split(new char[] { ' ', }, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
                var pattern = x[1].Split(',').Select(int.Parse).ToArray();
                var y = x[0];

                var unknownCount = y.Where(x => x == '?').Count();
                var testPattern = Enumerable.Range(0, unknownCount).Select(na => '#').ToArray();
                do
                {
                    testPattern = getNextPattern(testPattern);
                    if (PatternIsPossible(testPattern, y, pattern))
                    {
                        currentOutput++;
                    }
                }
                while (!testPattern.All(c => c == '#'));

                output += currentOutput;
            }

            Console.WriteLine($"After {Stopwatch.GetElapsedTime(start)} got output of {output}");
        }

        private IEnumerable<char[]> GetTestPatterns(int unknownCount, int hashesRequired)
        {
                var testPattern = Enumerable.Range(0, unknownCount).Select(na => '#').ToArray();
                
                do
                {
                    testPattern = getNextPattern(testPattern);
                    if (testPattern.Count(c => c == '#') == hashesRequired)
                    {
                        yield return (char[])testPattern.Clone();
                    }
                }
                while (!testPattern.All(c => c == '#'));

        }

        public void Part2()
        {
            _input = "???.### 1,1,3\r\n.??..??...?##. 1,1,3\r\n?#?#?#?#?#?#?#? 1,3,1,6\r\n????.#...#... 4,1,1\r\n????.######..#####. 1,6,5\r\n?###???????? 3,2,1";
            //_input = "???.### 1,1,3";

            var lines = _input.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var output = new ConcurrentBag<int>();

            Parallel.ForEach(lines, line =>
            {
                var start = Stopwatch.GetTimestamp();
                var currentOutput = 0;
                var x = line.Split(new char[] { ' ', }, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
                var pattern = string.Join(",", Enumerable.Range(1, 5).Select(s => x[1])).Split(',').Select(int.Parse).ToArray();
                var y = string.Join('?', Enumerable.Range(1, 5).Select(s => x[0]));

                var hashesRequired = pattern.Sum() - (x[0].Where(c => c == '#').Count() * 5);

                var unknownCount = y.Where(x => x == '?').Count();
                var successes = new ConcurrentBag<int>();

                var patterns = Math.Pow(2, unknownCount);

                var testPatterns = GetTestPatterns(unknownCount, hashesRequired);

                Parallel.ForEach(testPatterns, (tp) =>
                {
                    if (PatternIsPossible(tp, y, pattern))
                    {
                        successes.Add(1);
                    }
                });

                currentOutput = successes.Count;
                output.Add(currentOutput);
                Console.WriteLine($"for pattern {x[0]} got {currentOutput} in {Stopwatch.GetElapsedTime(start)}");
            });
            
            //Parallel.ForEach(lines, line =>
            //{
            //    var start = Stopwatch.GetTimestamp();
            //    var currentOutput = 0;
            //    var x = line.Split(new char[] { ' ', }, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            //    var pattern = string.Join(",", Enumerable.Range(1, 5).Select(s => x[1])).Split(',').Select(int.Parse).ToArray();
            //    var y = string.Join('?', Enumerable.Range(1, 5).Select(s => x[0]));

            //    var hashesRequired = pattern.Sum() - (x[0].Where(c => c == '#').Count() * 5);

            //    var unknownCount = y.Where(x => x == '?').Count();
            //    var testPattern = Enumerable.Range(0, unknownCount).Select(na => '#').ToArray();
            //    var successes = new ConcurrentBag<int>();

            //    var patterns = Math.Pow(2, unknownCount);
            //    var testPatterns = new ConcurrentQueue<char[]>();
            //    for (var i = (long)0; i < patterns; i++)
            //    {
            //        testPattern = getNextPattern(testPattern);
            //        if (testPattern.Count(c => c == '#') == hashesRequired)
            //        {
            //            testPatterns.Enqueue((char[])testPattern.Clone());
            //        }
            //    }
            //    var testPatternCount = testPatterns.LongCount();

            //    Parallel.For(0, testPatternCount, (z) =>
            //    {
            //        char[] tp;
            //        if (!testPatterns.TryDequeue(out tp))
            //        {
            //            throw new Exception();
            //        }
            //        if (PatternIsPossible(tp, y, pattern))
            //        {
            //            successes.Add(1);
            //        }
            //    });

            //    currentOutput = successes.Count;
            //    output.Add(currentOutput);
            //    Console.WriteLine($"for pattern {x[0]} got {currentOutput} in {Stopwatch.GetElapsedTime(start)}");
            //});

            //foreach (var line in lines)
            //{
            //    var currentOutput = 0;
            //    var x = line.Split(new char[] { ' ', }, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            //    var pattern = string.Join(",", Enumerable.Range(1,5).Select(s => x[1])).Split(',').Select(int.Parse).ToArray();
            //    var y = string.Join('?', Enumerable.Range(1, 5).Select(s => x[0]));

            //    var unknownCount = y.Where(x => x == '?').Count();
            //    var testPattern = Enumerable.Range(0, unknownCount).Select(na => '#').ToArray();
            //    do
            //    {
            //        testPattern = getNextPattern(testPattern);
            //        if (PatternIsPossible(testPattern, y, pattern))
            //        {
            //            currentOutput++;
            //        }
            //    }
            //    while (!testPattern.All(c => c == '#'));

            //    output += currentOutput;
            //}

            Console.WriteLine(output);
        }
    }
}
