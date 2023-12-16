namespace ConsoleApp1
{
    internal class Day7
    {
        private string _input = "8A7J7 301\r\n" +
            "QAAT7 677\r\n" +
            "J3K4K 622\r\n" +
            "KJJ62 577\r\n" +
            "49AAA 298\r\n" +
            "45585 855\r\n" +
            "33KKK 115\r\n" +
            "4Q777 438\r\n" +
            "7KK77 836\r\n" +
            "5T55T 397\r\n" +
            "85855 56\r\n" +
            "Q6Q38 157\r\n" +
            "AA8AA 85\r\n" +
            "32J33 293\r\n" +
            "KKQQA 247\r\n" +
            "888J4 944\r\n" +
            "2AJ2K 482\r\n" +
            "33777 338\r\n" +
            "KT434 696\r\n" +
            "K3K63 648\r\n" +
            "86866 136\r\n" +
            "93983 584\r\n" +
            "57857 489\r\n" +
            "5JJ2Q 76\r\n" +
            "82335 133\r\n" +
            "J25T4 559\r\n" +
            "9TQ2A 211\r\n" +
            "596J6 926\r\n" +
            "ATAAA 513\r\n" +
            "6KKKQ 277\r\n" +
            "AAA22 554\r\n" +
            "J2265 332\r\n" +
            "8Q3QQ 486\r\n" +
            "6735A 28\r\n" +
            "Q5555 595\r\n" +
            "J9888 262\r\n" +
            "5QQQ2 626\r\n" +
            "J7777 953\r\n" +
            "643TA 572\r\n" +
            "8579Q 99\r\n" +
            "23294 683\r\n" +
            "55J54 501\r\n" +
            "9JK93 567\r\n" +
            "64388 941\r\n" +
            "3J8T5 40\r\n" +
            "29K29 422\r\n" +
            "JQ4K2 401\r\n" +
            "AA6A3 78\r\n" +
            "2KK44 821\r\n" +
            "9AA2A 884\r\n" +
            "43434 386\r\n" +
            "J7A67 177\r\n" +
            "4JKKT 956\r\n" +
            "AA999 296\r\n" +
            "2A2T9 519\r\n" +
            "9T9KT 342\r\n" +
            "Q5J5A 19\r\n" +
            "QJK7A 925\r\n" +
            "AA9AA 337\r\n" +
            "4T2QT 751\r\n" +
            "77888 324\r\n" +
            "343QT 914\r\n" +
            "33229 576\r\n" +
            "J5Q5Q 169\r\n" +
            "22952 620\r\n" +
            "J4444 17\r\n" +
            "T9JTT 172\r\n" +
            "48888 729\r\n" +
            "28522 138\r\n" +
            "66363 302\r\n" +
            "68TTJ 778\r\n" +
            "5Q885 66\r\n" +
            "24KJ3 229\r\n" +
            "5A68K 731\r\n" +
            "A79A7 906\r\n" +
            "QQQAQ 698\r\n" +
            "J34AJ 109\r\n" +
            "TTTTJ 503\r\n" +
            "3J528 183\r\n" +
            "5A5AA 598\r\n" +
            "5AAAA 782\r\n" +
            "TT77J 968\r\n" +
            "24Q62 178\r\n" +
            "T6K7A 811\r\n" +
            "99788 53\r\n" +
            "494K6 560\r\n" +
            "7JQ87 327\r\n" +
            "Q9QQQ 597\r\n" +
            "496Q2 392\r\n" +
            "2252K 995\r\n" +
            "Q85TA 2\r\n" +
            "KT66Q 165\r\n" +
            "383T6 509\r\n" +
            "9997Q 724\r\n" +
            "4TT4T 368\r\n" +
            "35TQA 707\r\n" +
            "33534 24\r\n" +
            "KKKJ4 469\r\n" +
            "A9TAA 830\r\n" +
            "A445A 481\r\n" +
            "3Q63Q 192\r\n" +
            "AATAT 680\r\n" +
            "2225J 436\r\n" +
            "Q4869 471\r\n" +
            "A4JA4 330\r\n" +
            "5K35T 545\r\n" +
            "TK3A4 877\r\n" +
            "8K62J 596\r\n" +
            "9Q7T8 582\r\n" +
            "898KK 813\r\n" +
            "5AJJA 504\r\n" +
            "T5TKQ 289\r\n" +
            "6T88Q 359\r\n" +
            "A8AAJ 526\r\n" +
            "393J3 817\r\n" +
            "Q2Q22 212\r\n" +
            "Q8Q22 89\r\n" +
            "265T8 757\r\n" +
            "Q2584 807\r\n" +
            "T33TT 853\r\n" +
            "T22TA 391\r\n" +
            "46999 61\r\n" +
            "9AA9J 57\r\n" +
            "6T538 674\r\n" +
            "3T253 271\r\n" +
            "63TAJ 395\r\n" +
            "34943 323\r\n" +
            "6QQQQ 497\r\n" +
            "TA75K 938\r\n" +
            "4T467 141\r\n" +
            "36AQK 197\r\n" +
            "884A4 228\r\n" +
            "77277 453\r\n" +
            "AQ854 50\r\n" +
            "Q56QJ 456\r\n" +
            "T4TKT 319\r\n" +
            "K63Q4 30\r\n" +
            "79793 110\r\n" +
            "AJKQ6 421\r\n" +
            "22278 996\r\n" +
            "222TT 357\r\n" +
            "42J74 647\r\n" +
            "Q4QAT 634\r\n" +
            "66574 951\r\n" +
            "2KK22 446\r\n" +
            "Q65Q3 533\r\n" +
            "77887 267\r\n" +
            "58533 719\r\n" +
            "287K9 51\r\n" +
            "Q5656 199\r\n" +
            "564AQ 106\r\n" +
            "QJ579 77\r\n" +
            "9732T 46\r\n" +
            "JAK23 808\r\n" +
            "688K8 364\r\n" +
            "A993A 651\r\n" +
            "Q9QQ9 93\r\n" +
            "74777 929\r\n" +
            "QT722 723\r\n" +
            "76QAQ 621\r\n" +
            "8K836 573\r\n" +
            "77557 783\r\n" +
            "A5555 65\r\n" +
            "TTT6T 643\r\n" +
            "83595 933\r\n" +
            "J3J97 734\r\n" +
            "JTTA3 87\r\n" +
            "TTAQA 282\r\n" +
            "A555A 765\r\n" +
            "4TQTT 538\r\n" +
            "T777Q 763\r\n" +
            "T82J9 63\r\n" +
            "83359 213\r\n" +
            "AQQAQ 363\r\n" +
            "47AT9 311\r\n" +
            "96A9T 310\r\n" +
            "K5TK5 450\r\n" +
            "ATKK8 429\r\n" +
            "7K777 541\r\n" +
            "5TJAK 987\r\n" +
            "KAQ73 687\r\n" +
            "TTATA 874\r\n" +
            "J4TJ2 857\r\n" +
            "666KK 204\r\n" +
            "AA777 990\r\n" +
            "J98A8 946\r\n" +
            "7A95A 288\r\n" +
            "3K2K3 820\r\n" +
            "79K42 112\r\n" +
            "A65KT 300\r\n" +
            "596T8 266\r\n" +
            "J5664 585\r\n" +
            "75585 964\r\n" +
            "73AT2 491\r\n" +
            "2J2KT 375\r\n" +
            "6888T 480\r\n" +
            "A5765 992\r\n" +
            "KK555 224\r\n" +
            "AT2TA 514\r\n" +
            "TTTTQ 753\r\n" +
            "Q4348 273\r\n" +
            "KK66K 887\r\n" +
            "44JQ9 67\r\n" +
            "Q339Q 341\r\n" +
            "833Q8 574\r\n" +
            "K456T 766\r\n" +
            "J98KK 209\r\n" +
            "K4644 328\r\n" +
            "43935 79\r\n" +
            "8848K 380\r\n" +
            "K22A2 834\r\n" +
            "8654Q 703\r\n" +
            "4K2AT 96\r\n" +
            "K276J 863\r\n" +
            "8K64J 320\r\n" +
            "AAA7A 571\r\n" +
            "72747 950\r\n" +
            "4A4Q9 120\r\n" +
            "66636 814\r\n" +
            "33637 881\r\n" +
            "KK2AK 895\r\n" +
            "J8677 851\r\n" +
            "A48A8 430\r\n" +
            "56656 866\r\n" +
            "55355 976\r\n" +
            "66J77 370\r\n" +
            "3353J 896\r\n" +
            "56556 237\r\n" +
            "3KJ5Q 270\r\n" +
            "J22J2 261\r\n" +
            "AJ2AA 163\r\n" +
            "JJJJJ 517\r\n" +
            "48A28 819\r\n" +
            "K4443 799\r\n" +
            "TJTJ5 345\r\n" +
            "T3K9J 868\r\n" +
            "49AJ9 605\r\n" +
            "45455 741\r\n" +
            "KJJKK 754\r\n" +
            "63333 789\r\n" +
            "76677 989\r\n" +
            "AJ774 264\r\n" +
            "JKJ2A 531\r\n" +
            "TQQQT 809\r\n" +
            "Q6KJ6 411\r\n" +
            "KQK7Q 704\r\n" +
            "2A4Q5 410\r\n" +
            "68KK8 652\r\n" +
            "8K938 194\r\n" +
            "72J22 242\r\n" +
            "9J672 43\r\n" +
            "7Q6Q5 903\r\n" +
            "64666 95\r\n" +
            "J2372 798\r\n" +
            "A263T 781\r\n" +
            "JK598 909\r\n" +
            "55J92 625\r\n" +
            "A2567 343\r\n" +
            "4A7A7 174\r\n" +
            "8KA3J 68\r\n" +
            "JQTQ3 528\r\n" +
            "74444 127\r\n" +
            "QA5AT 306\r\n" +
            "T9K7T 254\r\n" +
            "75TT7 166\r\n" +
            "83388 325\r\n" +
            "888Q8 982\r\n" +
            "8Q7A6 84\r\n" +
            "2K7JA 663\r\n" +
            "T9959 937\r\n" +
            "3KA87 921\r\n" +
            "4KJ92 786\r\n" +
            "28A83 442\r\n" +
            "99T8J 699\r\n" +
            "TKKKK 457\r\n" +
            "25552 431\r\n" +
            "TTATK 862\r\n" +
            "QJQKK 664\r\n" +
            "QJQQ9 552\r\n" +
            "T4J77 206\r\n" +
            "Q7777 352\r\n" +
            "QJ747 534\r\n" +
            "9K9KK 656\r\n" +
            "44646 479\r\n" +
            "5T64Q 455\r\n" +
            "QQQQK 475\r\n" +
            "73478 827\r\n" +
            "Q3J33 975\r\n" +
            "Q655Q 930\r\n" +
            "7T7T7 231\r\n" +
            "53A72 409\r\n" +
            "3333A 833\r\n" +
            "29928 787\r\n" +
            "97J58 307\r\n" +
            "T2555 673\r\n" +
            "Q44A5 382\r\n" +
            "J5A57 144\r\n" +
            "7J447 131\r\n" +
            "8KK99 600\r\n" +
            "99555 349\r\n" +
            "43682 205\r\n" +
            "63259 518\r\n" +
            "AA3A8 591\r\n" +
            "J444J 58\r\n" +
            "52J23 772\r\n" +
            "5KK3K 660\r\n" +
            "5KT2K 329\r\n" +
            "54K6K 252\r\n" +
            "49J24 864\r\n" +
            "673Q5 780\r\n" +
            "TT848 333\r\n" +
            "227A5 424\r\n" +
            "JT9J5 675\r\n" +
            "7K9QJ 825\r\n" +
            "732Q7 461\r\n" +
            "24343 859\r\n" +
            "TJ333 604\r\n" +
            "T33AJ 149\r\n" +
            "KJ5KK 129\r\n" +
            "54555 249\r\n" +
            "25222 3\r\n" +
            "TQJA3 38\r\n" +
            "7Q7Q7 460\r\n" +
            "999J4 557\r\n" +
            "J6766 831\r\n" +
            "K4KKK 185\r\n" +
            "363K3 566\r\n" +
            "K888J 885\r\n" +
            "55855 488\r\n" +
            "97979 565\r\n" +
            "2597T 493\r\n" +
            "77456 233\r\n" +
            "Q9Q5Q 202\r\n" +
            "99K23 98\r\n" +
            "63763 7\r\n" +
            "TQ498 849\r\n" +
            "74626 590\r\n" +
            "K44KK 73\r\n" +
            "9AA97 498\r\n" +
            "Q6696 706\r\n" +
            "95555 697\r\n" +
            "69969 670\r\n" +
            "JQ294 203\r\n" +
            "24246 425\r\n" +
            "6QJ6A 16\r\n" +
            "AQAAA 916\r\n" +
            "6K6JK 313\r\n" +
            "9AK99 41\r\n" +
            "4T6J5 219\r\n" +
            "6Q6T6 549\r\n" +
            "96999 983\r\n" +
            "79977 522\r\n" +
            "57Q8A 732\r\n" +
            "AQ6AQ 156\r\n" +
            "284Q6 351\r\n" +
            "K88KJ 123\r\n" +
            "57A8A 606\r\n" +
            "4J97Q 592\r\n" +
            "5JTQ3 369\r\n" +
            "A467T 742\r\n" +
            "2878J 669\r\n" +
            "KKAJ6 668\r\n" +
            "T5TTT 570\r\n" +
            "8AA88 665\r\n" +
            "3238A 428\r\n" +
            "67286 979\r\n" +
            "88585 997\r\n" +
            "T6866 132\r\n" +
            "88T83 912\r\n" +
            "68888 832\r\n" +
            "A95TK 371\r\n" +
            "T8Q33 167\r\n" +
            "333K8 286\r\n" +
            "KK888 722\r\n" +
            "7TAK7 281\r\n" +
            "A7J77 216\r\n" +
            "9T85Q 969\r\n" +
            "54444 918\r\n" +
            "77822 151\r\n" +
            "9KJ2T 759\r\n" +
            "Q8483 536\r\n" +
            "9JJA9 788\r\n" +
            "J8Q8T 272\r\n" +
            "27KJQ 958\r\n" +
            "76666 671\r\n" +
            "5T932 182\r\n" +
            "887T4 628\r\n" +
            "6499T 607\r\n" +
            "447Q4 718\r\n" +
            "9736J 716\r\n" +
            "AQJAQ 611\r\n" +
            "T4933 690\r\n" +
            "3TJAJ 923\r\n" +
            "K7722 412\r\n" +
            "77737 22\r\n" +
            "775AQ 812\r\n" +
            "5QKQ5 362\r\n" +
            "448T8 114\r\n" +
            "A7A7A 502\r\n" +
            "4Q466 583\r\n" +
            "74744 749\r\n" +
            "7363J 939\r\n" +
            "88388 59\r\n" +
            "Q3KQT 861\r\n" +
            "42222 794\r\n" +
            "96669 294\r\n" +
            "54959 378\r\n" +
            "TTTTA 544\r\n" +
            "796JA 867\r\n" +
            "92KK9 238\r\n" +
            "9TJT9 848\r\n" +
            "8A2A2 309\r\n" +
            "687K3 515\r\n" +
            "KTKKT 610\r\n" +
            "J8659 210\r\n" +
            "22K4K 423\r\n" +
            "586Q9 55\r\n" +
            "AAA7K 599\r\n" +
            "33J73 198\r\n" +
            "K74KJ 936\r\n" +
            "55JJ5 943\r\n" +
            "Q6QJQ 801\r\n" +
            "5435J 137\r\n" +
            "QJ5QQ 553\r\n" +
            "AAA78 485\r\n" +
            "67676 404\r\n" +
            "34K33 376\r\n" +
            "8Q32J 326\r\n" +
            "A66KA 649\r\n" +
            "52K8Q 179\r\n" +
            "A32A2 561\r\n" +
            "JTQJQ 645\r\n" +
            "59KK7 11\r\n" +
            "6763Q 189\r\n" +
            "KKK88 426\r\n" +
            "8KTJ8 681\r\n" +
            "2222T 767\r\n" +
            "KK5J7 372\r\n" +
            "QQQ57 942\r\n" +
            "7A72J 904\r\n" +
            "2222J 467\r\n" +
            "7KQQQ 186\r\n" +
            "J3993 629\r\n" +
            "73437 952\r\n" +
            "8A37T 771\r\n" +
            "966J9 752\r\n" +
            "4KT29 710\r\n" +
            "82378 840\r\n" +
            "4QT72 785\r\n" +
            "3629T 934\r\n" +
            "JTK77 977\r\n" +
            "KKQ33 915\r\n" +
            "4242A 744\r\n" +
            "TQA9A 215\r\n" +
            "A6666 854\r\n" +
            "23333 170\r\n" +
            "TTT9T 587\r\n" +
            "J3377 34\r\n" +
            "6JJ66 835\r\n" +
            "A3AAA 897\r\n" +
            "96936 427\r\n" +
            "8JJJ4 686\r\n" +
            "32332 173\r\n" +
            "QJ868 640\r\n" +
            "67388 111\r\n" +
            "88988 613\r\n" +
            "4TJTT 435\r\n" +
            "T988T 702\r\n" +
            "K59K5 894\r\n" +
            "Q8Q88 688\r\n" +
            "5Q847 347\r\n" +
            "9J599 154\r\n" +
            "958K6 462\r\n" +
            "AAQQA 959\r\n" +
            "JKJKQ 846\r\n" +
            "7992T 72\r\n" +
            "9899A 510\r\n" +
            "22Q22 389\r\n" +
            "939J7 971\r\n" +
            "J4K4A 367\r\n" +
            "TT7TQ 816\r\n" +
            "KKKT3 297\r\n" +
            "97KK6 793\r\n" +
            "7QQQ7 824\r\n" +
            "ATQQA 102\r\n" +
            "J597K 797\r\n" +
            "78J88 473\r\n" +
            "87A87 42\r\n" +
            "828A7 527\r\n" +
            "K8777 107\r\n" +
            "8963J 949\r\n" +
            "29399 998\r\n" +
            "3TKA8 190\r\n" +
            "3TQ66 889\r\n" +
            "JJ5T5 985\r\n" +
            "J566T 568\r\n" +
            "T38K2 815\r\n" +
            "2J5KA 646\r\n" +
            "A8J32 184\r\n" +
            "622Q6 777\r\n" +
            "TK7QT 26\r\n" +
            "47766 790\r\n" +
            "2J5Q6 932\r\n" +
            "9K969 878\r\n" +
            "82235 64\r\n" +
            "3A3JK 152\r\n" +
            "49494 540\r\n" +
            "7JJJ7 350\r\n" +
            "39233 437\r\n" +
            "5466Q 239\r\n" +
            "Q3QQQ 961\r\n" +
            "A8J5Q 623\r\n" +
            "Q3333 739\r\n" +
            "4T396 90\r\n" +
            "25T2J 284\r\n" +
            "TK7T3 9\r\n" +
            "5555K 993\r\n" +
            "J2666 383\r\n" +
            "22292 250\r\n" +
            "J5T95 478\r\n" +
            "22T29 226\r\n" +
            "24242 126\r\n" +
            "99939 121\r\n" +
            "73373 414\r\n" +
            "78Q92 738\r\n" +
            "A5362 826\r\n" +
            "3KK2J 756\r\n" +
            "77877 291\r\n" +
            "T9TT9 879\r\n" +
            "3JJTT 145\r\n" +
            "3T363 524\r\n" +
            "6Q6QQ 619\r\n" +
            "Q2QQQ 8\r\n" +
            "8J58J 967\r\n" +
            "65KJK 398\r\n" +
            "KTA2T 464\r\n" +
            "T7JJJ 922\r\n" +
            "44888 948\r\n" +
            "2KJ2K 755\r\n" +
            "63858 353\r\n" +
            "49K4T 483\r\n" +
            "5833J 180\r\n" +
            "62822 105\r\n" +
            "99JK9 635\r\n" +
            "QAJAA 962\r\n" +
            "977T5 691\r\n" +
            "655KK 274\r\n" +
            "9966A 393\r\n" +
            "55J5T 303\r\n" +
            "284K5 589\r\n" +
            "27636 872\r\n" +
            "K29KK 774\r\n" +
            "K9JJ4 792\r\n" +
            "6JKTT 108\r\n" +
            "TK8TJ 745\r\n" +
            "T3A7K 400\r\n" +
            "9J3TQ 901\r\n" +
            "ATJKK 917\r\n" +
            "666A5 448\r\n" +
            "A5AT6 588\r\n" +
            "6T4J6 822\r\n" +
            "Q9A9A 260\r\n" +
            "594J3 241\r\n" +
            "Q3A34 279\r\n" +
            "A9999 220\r\n" +
            "7AQQ9 49\r\n" +
            "737Q3 999\r\n" +
            "JQQ8Q 882\r\n" +
            "78977 399\r\n" +
            "53333 689\r\n" +
            "2K2JQ 25\r\n" +
            "34848 800\r\n" +
            "2585T 334\r\n" +
            "5T799 908\r\n" +
            "69864 644\r\n" +
            "659TK 278\r\n" +
            "J4363 633\r\n" +
            "T9J97 101\r\n" +
            "QJ94T 615\r\n" +
            "363J6 373\r\n" +
            "J777J 379\r\n" +
            "99J93 966\r\n" +
            "TT26T 312\r\n" +
            "TA8T8 870\r\n" +
            "3J535 245\r\n" +
            "86A63 283\r\n" +
            "2KTK2 508\r\n" +
            "Q9Q2Q 162\r\n" +
            "59QJT 667\r\n" +
            "6JJKQ 71\r\n" +
            "55J25 200\r\n" +
            "89993 980\r\n" +
            "45474 581\r\n" +
            "Q4394 159\r\n" +
            "45697 346\r\n" +
            "KK99Q 496\r\n" +
            "J3J53 466\r\n" +
            "3QQ3Q 348\r\n" +
            "7843J 612\r\n" +
            "T733K 164\r\n" +
            "42589 818\r\n" +
            "Q9K36 232\r\n" +
            "QQ22Q 762\r\n" +
            "5AA3J 287\r\n" +
            "48KKK 449\r\n" +
            "7QQQJ 248\r\n" +
            "K5KJA 616\r\n" +
            "KQ387 965\r\n" +
            "Q4898 12\r\n" +
            "A3T9Q 227\r\n" +
            "K7KTT 269\r\n" +
            "JTJ22 768\r\n" +
            "85K88 875\r\n" +
            "6T666 624\r\n" +
            "97K7Q 586\r\n" +
            "7854J 804\r\n" +
            "T4TTT 609\r\n" +
            "8T44T 415\r\n" +
            "3T3KK 601\r\n" +
            "5AAAJ 258\r\n" +
            "8555K 828\r\n" +
            "4Q8JQ 593\r\n" +
            "JT823 396\r\n" +
            "J9K96 838\r\n" +
            "55565 632\r\n" +
            "7J77T 713\r\n" +
            "36353 578\r\n" +
            "5Q962 529\r\n" +
            "5KQ9T 181\r\n" +
            "82697 627\r\n" +
            "66654 88\r\n" +
            "7747J 919\r\n" +
            "A3AAJ 441\r\n" +
            "569KJ 805\r\n" +
            "TTQJ5 445\r\n" +
            "444T4 661\r\n" +
            "29959 37\r\n" +
            "62J26 955\r\n" +
            "Q4JT5 214\r\n" +
            "KQA4T 44\r\n" +
            "24424 758\r\n" +
            "2Q4AK 222\r\n" +
            "729A4 195\r\n" +
            "4Q35T 928\r\n" +
            "329T8 551\r\n" +
            "6T5T5 33\r\n" +
            "T25Q9 978\r\n" +
            "9Q9J9 407\r\n" +
            "A4KT7 911\r\n" +
            "27397 603\r\n" +
            "4244Q 490\r\n" +
            "JA255 384\r\n" +
            "2AAJ2 876\r\n" +
            "6222K 125\r\n" +
            "AA46A 360\r\n" +
            "J4343 672\r\n" +
            "JAJQ9 880\r\n" +
            "888J2 468\r\n" +
            "Q5K9J 268\r\n" +
            "A85Q9 387\r\n" +
            "J4A35 705\r\n" +
            "66A64 97\r\n" +
            "QAQQ8 700\r\n" +
            "55TJ4 31\r\n" +
            "88J58 650\r\n" +
            "693AK 679\r\n" +
            "259K2 806\r\n" +
            "9998J 176\r\n" +
            "6822T 235\r\n" +
            "9J699 913\r\n" +
            "7QQQQ 602\r\n" +
            "T7T4T 317\r\n" +
            "6226T 725\r\n" +
            "JJ9J9 316\r\n" +
            "55575 761\r\n" +
            "A6A66 796\r\n" +
            "K9T29 764\r\n" +
            "33334 608\r\n" +
            "KKK7K 893\r\n" +
            "99988 579\r\n" +
            "J8JJJ 259\r\n" +
            "4AJ89 390\r\n" +
            "9QQ84 14\r\n" +
            "9KJ3K 580\r\n" +
            "77736 433\r\n" +
            "KK22K 555\r\n" +
            "755J2 940\r\n" +
            "4JA9A 492\r\n" +
            "9Q555 484\r\n" +
            "6J687 542\r\n" +
            "99K53 910\r\n" +
            "6236J 36\r\n" +
            "9J999 54\r\n" +
            "6663J 454\r\n" +
            "85JJK 122\r\n" +
            "966J3 171\r\n" +
            "QJ2KK 747\r\n" +
            "KJA2A 676\r\n" +
            "788J5 858\r\n" +
            "78833 218\r\n" +
            "6KJ6J 308\r\n" +
            "T75AT 318\r\n" +
            "7JQ36 728\r\n" +
            "AJ8TA 354\r\n" +
            "96KTQ 899\r\n" +
            "52993 402\r\n" +
            "9K5AJ 898\r\n" +
            "Q7JQJ 748\r\n" +
            "5Q5QQ 48\r\n" +
            "A5858 148\r\n" +
            "85888 988\r\n" +
            "2TJ82 556\r\n" +
            "9AJK4 843\r\n" +
            "TJ26Q 406\r\n" +
            "2296K 356\r\n" +
            "22K22 18\r\n" +
            "KJ6KQ 253\r\n" +
            "T444T 117\r\n" +
            "6T257 715\r\n" +
            "AA444 113\r\n" +
            "39737 693\r\n" +
            "877QQ 521\r\n" +
            "TK454 735\r\n" +
            "38QA8 562\r\n" +
            "KT4A4 984\r\n" +
            "JKKKK 920\r\n" +
            "666J6 452\r\n" +
            "8JAJT 280\r\n" +
            "A62QJ 945\r\n" +
            "868TT 243\r\n" +
            "KQ66K 511\r\n" +
            "J3J33 512\r\n" +
            "T9K9K 160\r\n" +
            "66TT3 537\r\n" +
            "J3T48 234\r\n" +
            "44999 158\r\n" +
            "9876A 666\r\n" +
            "JJ73Q 546\r\n" +
            "85A3Q 20\r\n" +
            "3333K 750\r\n" +
            "6AJ73 381\r\n" +
            "Q3Q58 637\r\n" +
            "69644 654\r\n" +
            "J6669 641\r\n" +
            "8K2KK 733\r\n" +
            "33535 447\r\n" +
            "32K56 153\r\n" +
            "TA94Q 994\r\n" +
            "7979A 543\r\n" +
            "Q663Q 432\r\n" +
            "KQJ7Q 516\r\n" +
            "66K65 6\r\n" +
            "484T4 991\r\n" +
            "88387 15\r\n" +
            "96229 21\r\n" +
            "7AK62 499\r\n" +
            "88KK7 618\r\n" +
            "3K344 69\r\n" +
            "6A6KK 569\r\n" +
            "22J24 784\r\n" +
            "QKT53 837\r\n" +
            "7K2KK 1\r\n" +
            "87T95 810\r\n" +
            "2228Q 82\r\n" +
            "Q66AQ 548\r\n" +
            "J6Q66 366\r\n" +
            "5J42Q 465\r\n" +
            "8QQJ8 246\r\n" +
            "JAAKJ 630\r\n" +
            "5TT99 408\r\n" +
            "5T7Q6 779\r\n" +
            "768A7 631\r\n" +
            "22262 201\r\n" +
            "664AA 104\r\n" +
            "A96A6 128\r\n" +
            "T666K 5\r\n" +
            "3984K 684\r\n" +
            "3335K 208\r\n" +
            "79A77 891\r\n" +
            "K7K76 285\r\n" +
            "AQ8A6 678\r\n" +
            "36535 130\r\n" +
            "JT443 760\r\n" +
            "477T9 547\r\n" +
            "48A33 532\r\n" +
            "AA66A 321\r\n" +
            "56666 776\r\n" +
            "3AQKJ 888\r\n" +
            "K6Q68 83\r\n" +
            "2J727 902\r\n" +
            "3TT33 339\r\n" +
            "85Q6T 714\r\n" +
            "QT333 717\r\n" +
            "7T74T 335\r\n" +
            "J3A85 974\r\n" +
            "8J888 617\r\n" +
            "K974K 802\r\n" +
            "8777Q 947\r\n" +
            "A9Q6K 175\r\n" +
            "77757 75\r\n" +
            "7JA22 458\r\n" +
            "3K499 791\r\n" +
            "98TTJ 256\r\n" +
            "5555J 505\r\n" +
            "QTQQJ 70\r\n" +
            "T232T 506\r\n" +
            "Q9999 907\r\n" +
            "J4A88 74\r\n" +
            "A4K58 191\r\n" +
            "K3888 263\r\n" +
            "2QJ22 23\r\n" +
            "3368Q 155\r\n" +
            "QKKKQ 743\r\n" +
            "JK222 139\r\n" +
            "KQ84Q 905\r\n" +
            "T25T2 91\r\n" +
            "Q9TJJ 844\r\n" +
            "QQ8Q8 720\r\n" +
            "335KK 355\r\n" +
            "29T76 963\r\n" +
            "39AQ6 292\r\n" +
            "27222 276\r\n" +
            "88JJ8 388\r\n" +
            "52A22 134\r\n" +
            "7A95Q 86\r\n" +
            "7TTTA 314\r\n" +
            "9642K 187\r\n" +
            "A33A3 416\r\n" +
            "6Q66Q 92\r\n" +
            "93A23 403\r\n" +
            "77722 523\r\n" +
            "33J34 196\r\n" +
            "J8333 639\r\n" +
            "K8TJ5 736\r\n" +
            "222AA 116\r\n" +
            "JT3TT 970\r\n" +
            "87A65 225\r\n" +
            "82555 459\r\n" +
            "22JT2 255\r\n" +
            "Q2223 972\r\n" +
            "K63JA 143\r\n" +
            "8AQ86 653\r\n" +
            "JJ3J9 614\r\n" +
            "3A77A 365\r\n" +
            "KK9KT 47\r\n" +
            "5T959 385\r\n" +
            "7JKQ4 477\r\n" +
            "497T3 711\r\n" +
            "34A33 770\r\n" +
            "57557 869\r\n" +
            "777KJ 193\r\n" +
            "KKK5Q 892\r\n" +
            "9Q299 230\r\n" +
            "34J83 795\r\n" +
            "3KTTQ 692\r\n" +
            "66696 695\r\n" +
            "57472 960\r\n" +
            "77J26 841\r\n" +
            "TAT2T 685\r\n" +
            "33969 662\r\n" +
            "9Q393 295\r\n" +
            "QKQ88 142\r\n" +
            "TTT98 32\r\n" +
            "25555 374\r\n" +
            "265QK 924\r\n" +
            "JAAJA 440\r\n" +
            "9999K 257\r\n" +
            "346KT 500\r\n" +
            "JJ299 535\r\n" +
            "QJ4KA 135\r\n" +
            "7A422 305\r\n" +
            "A2T85 773\r\n" +
            "4T69J 52\r\n" +
            "73Q8A 463\r\n" +
            "KK6KK 420\r\n" +
            "8Q7QJ 251\r\n" +
            "QQK3K 168\r\n" +
            "66644 150\r\n" +
            "44424 444\r\n" +
            "84T53 299\r\n" +
            "AKAAK 240\r\n" +
            "6A952 35\r\n" +
            "Q5875 217\r\n" +
            "22888 829\r\n" +
            "38589 642\r\n" +
            "94848 417\r\n" +
            "32222 727\r\n" +
            "966Q9 27\r\n" +
            "JQ9QT 336\r\n" +
            "52K2T 886\r\n" +
            "J7787 721\r\n" +
            "AAQ3A 147\r\n" +
            "6K823 957\r\n" +
            "6668Q 839\r\n" +
            "AAA88 39\r\n" +
            "KJ33K 4\r\n" +
            "J5J5J 419\r\n" +
            "2A7T9 275\r\n" +
            "4A777 470\r\n" +
            "7KK7K 377\r\n" +
            "99992 418\r\n" +
            "93TA8 865\r\n" +
            "95T34 709\r\n" +
            "K34JA 322\r\n" +
            "94674 658\r\n" +
            "AJAA7 45\r\n" +
            "JQ22A 304\r\n" +
            "K83Q2 13\r\n" +
            "A6923 439\r\n" +
            "98977 331\r\n" +
            "689J6 769\r\n" +
            "99953 931\r\n" +
            "QQQJQ 94\r\n" +
            "J5AA5 871\r\n" +
            "TJTJT 413\r\n" +
            "ATA28 530\r\n" +
            "6T66T 564\r\n" +
            "KAKKK 873\r\n" +
            "T43QQ 657\r\n" +
            "TTTT2 563\r\n" +
            "9898J 118\r\n" +
            "QQQQ8 659\r\n" +
            "99997 236\r\n" +
            "88826 188\r\n" +
            "6KKK5 394\r\n" +
            "2QQJ2 495\r\n" +
            "8T864 900\r\n" +
            "888K8 655\r\n" +
            "28KQ4 361\r\n" +
            "33732 472\r\n" +
            "AA2A7 845\r\n" +
            "TTT7T 726\r\n" +
            "68A84 852\r\n" +
            "3KKKK 161\r\n" +
            "343Q2 358\r\n" +
            "75792 476\r\n" +
            "AAAJA 550\r\n" +
            "KK9A9 558\r\n" +
            "72569 737\r\n" +
            "4AT33 708\r\n" +
            "KKKQ9 119\r\n" +
            "8JJJ6 315\r\n" +
            "78A77 850\r\n" +
            "JJQJ7 140\r\n" +
            "3A5A5 740\r\n" +
            "78278 344\r\n" +
            "Q4Q44 103\r\n" +
            "44JA4 146\r\n" +
            "74T95 636\r\n" +
            "2A2AT 507\r\n" +
            "TK5Q5 474\r\n" +
            "7T982 712\r\n" +
            "AJ378 1000\r\n" +
            "75858 494\r\n" +
            "AAA99 746\r\n" +
            "72T94 981\r\n" +
            "TT77T 803\r\n" +
            "393K3 124\r\n" +
            "T8T95 265\r\n" +
            "AJA66 244\r\n" +
            "AA4TA 207\r\n" +
            "44777 638\r\n" +
            "68QT2 973\r\n" +
            "9K628 340\r\n" +
            "7595K 443\r\n" +
            "9A949 682\r\n" +
            "KJKTT 954\r\n" +
            "23T26 100\r\n" +
            "5KJ5T 434\r\n" +
            "66626 81\r\n" +
            "K33K3 856\r\n" +
            "J7555 525\r\n" +
            "JQJJ5 60\r\n" +
            "868J6 935\r\n" +
            "22299 823\r\n" +
            "J4445 539\r\n" +
            "9KKK7 890\r\n" +
            "JAA48 80\r\n" +
            "755Q5 520\r\n" +
            "4JQQJ 223\r\n" +
            "997T9 405\r\n" +
            "8A888 575\r\n" +
            "K369T 730\r\n" +
            "A5565 847\r\n" +
            "39JQ4 29\r\n" +
            "QQQJJ 694\r\n" +
            "86789 860\r\n" +
            "333J3 10\r\n" +
            "9A94A 221\r\n" +
            "J99JT 62\r\n" +
            "87888 701\r\n" +
            "AA6A2 290\r\n" +
            "T5QK4 775\r\n" +
            "35354 927\r\n" +
            "323Q3 451\r\n" +
            "25TA5 883\r\n" +
            "2954J 487\r\n" +
            "376J6 594\r\n" +
            "2K975 842\r\n" +
            "AAAA6 986";
        struct Result
        {
            public Result() { Cards = new List<char>(); }
            public List<char> Cards { get; set; }
            public char Card { get; set; }
            public char Card1 { get => Cards[0]; }
            public char Card2 { get => Cards[1]; }
            public char Card3 { get => Cards[2]; }
            public char Card4 { get => Cards[3]; }
            public char Card5 { get => Cards[4]; }

            public HandScore Rank { get; set; }
            public long Bet { get; set; }
            public int Count { get; set; }

        }
        // This makes it lowers value
        const char JOKER = '-';
        private enum HandScore
        {
            FiveKind = 7,
            FourKind = 6,
            FullHouse = 5,
            ThreeKind = 4,
            TwoPair = 3,
            Pair = 2,
            HighCard = 1,
        }

        private HandScore AddJokers(HandScore currentScore, string hand)
        {
            var jokerCount = hand.Where(x => x == JOKER).Count();

            if (currentScore == HandScore.FiveKind || jokerCount == 0)
            {
                return currentScore;
            }

            switch (currentScore)
            {
                case HandScore.FourKind:
                case HandScore.FullHouse:
                    return HandScore.FiveKind;

                case HandScore.ThreeKind:
                    return HandScore.FourKind;
                        
                case HandScore.TwoPair:
                    return jokerCount == 2 ? HandScore.FourKind : HandScore.FullHouse;

                case HandScore.Pair:
                    return HandScore.ThreeKind;
            }

            // high card, we know there's exactly 1 joker here becuase any more and it wouldn't be a high card, any fewer and it would hit the first if
            return HandScore.Pair;

        }

        private Result HandValue(string hand)
        {
            var x = hand.GroupBy(x => x,
                (x, matches) => new Result { Card = x, Count = matches.Count() })
                .OrderByDescending(x => x.Count)
                .ToArray();

            var result = x.First();

            result.Rank = x.Length switch
            {
                1 => HandScore.FiveKind,
                2 => result.Count == 4 ? HandScore.FourKind : HandScore.FullHouse,
                3 => result.Count == 3 ? HandScore.ThreeKind : HandScore.TwoPair,
                4 => HandScore.Pair,
                _ => HandScore.HighCard,
            };

            result.Cards = hand.ToList();

            return result;
        }

        private Result HandValueP2(string hand)
        {
            var x = hand.GroupBy(x => x,
                (x, matches) => new Result { Card = x, Count = matches.Count() })
                .OrderByDescending(x => x.Count)
                .ToArray();

            var result = x.First();

            result.Rank = x.Length switch
            {
                1 => HandScore.FiveKind,
                2 => result.Count == 4 ? HandScore.FourKind : HandScore.FullHouse,
                3 => result.Count == 3 ? HandScore.ThreeKind : HandScore.TwoPair,
                4 => HandScore.Pair,
                _ => HandScore.HighCard,
            };

            result.Rank = AddJokers(result.Rank, hand);
            result.Cards = hand.ToList();

            return result;
        }

        public void Part1()
        {
            //_input = "32T3K 765\r\nT55J5 684\r\nKK677 28\r\nKTJJT 220\r\nQQQJA 483\r\n";

            _input = _input
                .Replace('A', 'E')
                .Replace('K', 'D')
                .Replace('Q', 'C')
                .Replace('J', 'B')
                .Replace('T', 'A');

            var lines = _input.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            var results = new List<Result>();
            long output = 0;
            foreach (var line in lines)
            {
                var x = line.Split(' ');
                var hand = x[0];
                var bet = long.Parse(x[1]);

                var result = HandValue(hand);
                result.Bet = bet;
                results.Add(result);
            }

            var orderedResults = results
                .OrderBy(x => (int)x.Rank)
                //.ThenBy(x => x.Card)
                .ThenBy(x => x.Card1)
                .ThenBy(x => x.Card2)
                .ThenBy(x => x.Card3)
                .ThenBy(x => x.Card4)
                .ThenBy(x => x.Card5)
                .ToArray();

            for (var rank = 1; rank <= results.Count; rank++)
            {
                var result = orderedResults[rank - 1];
                output += result.Bet * rank;
            }

            Console.WriteLine(output);
        }

        public void Part2()
        {
            //_input = "32T3K 765\r\nT55J5 684\r\nKK677 28\r\nKTJJT 220\r\nQQQJA 483\r\n";

            _input = _input
                .Replace('A', 'E')
                .Replace('K', 'D')
                .Replace('Q', 'C')
                .Replace('J', JOKER)
                .Replace('T', 'A');

            var lines = _input.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            var results = new List<Result>();
            long output = 0;
            foreach (var line in lines)
            {
                var x = line.Split(' ');
                var hand = x[0];
                var bet = long.Parse(x[1]);

                var result = HandValueP2(hand);
                result.Bet = bet;
                results.Add(result);
            }

            var orderedResults = results
                .OrderBy(x => (int)x.Rank)
                //.ThenBy(x => x.Card)
                .ThenBy(x => x.Card1)
                .ThenBy(x => x.Card2)
                .ThenBy(x => x.Card3)
                .ThenBy(x => x.Card4)
                .ThenBy(x => x.Card5)
                .ToArray();

            for (var rank = 1; rank <= results.Count; rank++)
            {
                var result = orderedResults[rank - 1];
                output += result.Bet * rank;
            }

            Console.WriteLine(output);
        }
    }
}
