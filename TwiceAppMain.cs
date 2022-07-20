using System.IO;
using System.Collections.Generic;
using TwiceProfile;
using SongsProfile;

public class TwiceAppMain
{
    public static void Main(string[] args)
    {
        bool x = true;
        Console.Clear();
        Console.WriteLine("\nAnnyeonghaseyo!!! Welcome to ONCE knowing TWICE!!! <3");
        TwiceGreeting.TwiceLogo();
        Divider.EnterKey();
        while (x)
        {
        MainMenu:
            Console.WriteLine("\nWhat do you want to do?\n[1] Know how they became TWICE\n[2] Know TWICE members\n[3] Know the lyrics of a title track\n[4]Exit");
            int userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput == 1)
            {
                Console.Clear();
                Console.Write("Oh! You wanna know the start of it??? Let's go!\n");
                Divider.EnterKey();

                string[] lines = File.ReadAllLines(@"C:\Users\jhoanne.alegro\Documents\GitHub\alegro-jhoanne\MSP101\ProjectDay\AllAboutTwice\TwiceHistory.txt");
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else if (userInput == 2)
            {
                bool y = true;
                Console.Clear();
                Console.Write("Be ready to fall in love with these beautiful ladies!!! <3\n");
                while (y)
                {
                    List<string> twicemembers = TwiceInfo.GetMembers();
                    foreach (string info in twicemembers)
                    //for (int n = 0; n < name.Count; n++)
                    {
                        Console.WriteLine(info);
                    }
                    Console.WriteLine("\nPlease type the name of your member choice :)\nInput 'All' if you want to display all member's profile\nInput 'Back' if you want to go back to Main Menu");
                    string namePick = Console.ReadLine()!;

                    List<TwiceProfile.TwiceProfile> member = new List<TwiceProfile.TwiceProfile>();
                    //var memberinfo = member.ToString();
                    member.Add(new NayeonProfile("Nayeon", "Im Na Yeon", "Korean", "Seoul, South Korea", "Lead Vocalist, Lead Dancer, Center, Face of the Group", "September 22, 1995", 26, 163, "A", "ESFP"));
                    member.Add(new JeongyeonProfile("Jeongyeon", "Yoo Kyung Wan (Legalized to 'Yoo Jeong Yeon')", "Korean", "Suwon, South Korea", "Lead Vocalist", "November 1, 1996", 25, 169, "O", "ISFJ"));
                    member.Add(new MomoProfile("Momo", "Hirai Momo", "Japanese", "Kyoto, Japan", "Main Dancer, Sub Vocalist, Sub Rapper", "November 9, 1996", 25, 167, "A", "INFP-T"));
                    member.Add(new SanaProfile("Sana", "Minatozaki Sana", "Japanese", "Osaka, Japan", "Sub Vocalist", "December 21, 1996", 24, 163, "B", "ENFP"));
                    member.Add(new JihyoProfile("Jihyo", "Park Ji Soo (Legalized to 'Park Ji Hyo')", "Korean", "Gyeonggi-do, South Korea", "Leader, Main Vocalist", "February 1, 1997", 24, 160, "O", "ISFP-T"));
                    member.Add(new MinaProfile("Mina", "Myoui Mina", "Japanese", "Texas, United States", "Main Dancer, Sub Vocalist", "March 24, 1997", 24, 163, "A", "ISFP-T"));
                    member.Add(new DahyunProfile("Dahyun", "Kim Da Hyun", "Korean", "Gyeonggi-do, South Korea", "Lead Rapper, Sub Vocalist", "May 28, 1998", 23, 161, "O", "ESFJ-T"));
                    member.Add(new ChaeyoungProfile("Chaeyoung", "Son Chae Young", "Korean", "Seoul, South Korea", "Main Rapper, Sub Vocalist", "April 23, 1998", 22, 159, "B", "INFP-T"));
                    member.Add(new TzuyuProfile("Tzuyu", "Chou Tzuyu", "Taiwanese", "Tainan, South Korea", "Lead Dancer, Sub Vocalist, Visual, Maknae", "June 14, 1999", 22, 170, "A", "ISFP-A"));
                    Console.Clear();

                    if (namePick == "All")
                    {
                        for (int m = 0; m < member.Count; m++)
                        {
                            TwiceProfile.TwiceProfile t = member[m];
                            Console.WriteLine(t.ToString());
                        }
                    }
                    else if (namePick == "Nayeon")
                    {
                        if (member[0] is NayeonProfile)
                        {
                            Console.Clear();
                            Console.WriteLine(member[0].ToString());
                        }
                    }
                    else if (namePick == "Jeongyeon")
                    {
                        if (member[1] is JeongyeonProfile)
                        {
                            Console.Clear();
                            Console.WriteLine(member[1].ToString());
                        }
                    }
                    else if (namePick == "Momo")
                    {
                        if (member[2] is MomoProfile)
                        {
                            Console.Clear();
                            Console.WriteLine(member[2].ToString());
                        }
                    }
                    else if (namePick == "Sana")
                    {
                        if (member[3] is SanaProfile)
                        {
                            Console.Clear();
                            Console.WriteLine(member[3].ToString());
                        }
                    }
                    else if (namePick == "Jihyo")
                    {
                        if (member[4] is JihyoProfile)
                        {
                            Console.Clear();
                            Console.WriteLine(member[4].ToString());
                        }
                    }
                    else if (namePick == "Mina")
                    {
                        if (member[5] is MinaProfile)
                        {
                            Console.Clear();
                            Console.WriteLine(member[5].ToString());
                        }
                    }
                    else if (namePick == "Dahyun")
                    {
                        if (member[6] is DahyunProfile)
                        {
                            Console.Clear();
                            Console.WriteLine(member[6].ToString());
                        }
                    }
                    else if (namePick == "Chaeyoung")
                    {
                        if (member[7] is ChaeyoungProfile)
                        {
                            Console.Clear();
                            Console.WriteLine(member[7].ToString());
                        }
                    }
                    else if (namePick == "Tzuyu")
                    {
                        if (member[8] is TzuyuProfile)
                        {
                            Console.Clear();
                            Console.WriteLine(member[8].ToString());
                        }
                    }
                    else if (namePick == "Back")
                    {
                        goto MainMenu;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid input, please enter a member's name\nMake sure the first letter is a capital letter\n");
                    }
                }
            }
            else if (userInput == 3)
            {
                bool z = true;
                Console.Clear();
                Console.Write("\nGet ready to sing along with these meaningful lyrics!\n");
                while (z)
                {
                    List<string> twicesongs = TwiceInfo.GetSongs();
                    foreach (string songs in twicesongs)
                    {
                        Console.WriteLine(songs);
                    }
                    Console.WriteLine("\nPlease type the name of your song choice :)\nShown are only title tracks\nInput 'Back' if you want to go back to Main Menu\n");
                    string songPick = Console.ReadLine()!;

                    List<SongsProfile.SongsProfile> track = new List<SongsProfile.SongsProfile>();
                    track.Add(new LikeOhhAhh("Like Ohh Ahh", "Korean (Romanized)", 2015, "The Story Begins"));
                    track.Add(new CheerUp("Cheer Up", "Korean (Romanized)", 2016, "PAGE TWO"));
                    track.Add(new TT("TT", "Korean (Romanized)", 2016, "TWICEcoaster: LANE 1"));
                    track.Add(new KnockKnock("Knock Knock", "Korean (Romanized)", 2017, "TWICEcoaster: LANE 2"));
                    track.Add(new Signal("Signal", "Korean (Romanized)", 2017, "Signal"));
                    track.Add(new Likey("Likey", "Korean (Romanized)", 2017, "twicetagram"));
                    track.Add(new HeartShaker("Heart Shaker", "Korean (Romanized)", 2017, "Merry & Happy"));
                    track.Add(new WhatIsLove("What is Love?", "Korean (Romanized)", 2018, "What is Love?"));
                    track.Add(new DanceTheNightAway("Dance The Night Away", "Korean (Romanized)", 2018, "Summer Nights"));
                    track.Add(new YesOrYes("YES or YES", "Korean (Romanized)", 2018, "YES or YES"));
                    track.Add(new TheBestThingIEverDid("The Best Thing I Ever Did", "Korean (Romanized)", 2018, "The year of 'YES'"));
                    track.Add(new Fancy("Fancy", "Korean (Romanized)", 2019, "FANCY YOU"));
                    track.Add(new FeelSpecial("Feel Special", "Korean (Romanized)", 2019, "Feel Special"));
                    track.Add(new MoreAndMore("MORE & MORE", "Korean (Romanized)", 2020, "MORE & MORE"));
                    track.Add(new ICantStopMe("I CAN'T STOP ME", "Korean (Romanized)", 2020, "Eyes Wide Open"));
                    track.Add(new CryForMe("CRY FOR ME", "Korean (Romanized)", 2020, "*Special Release*"));
                    track.Add(new AlcoholFree("Alcohol Free", "Korean (Romanized)", 2021, "Taste of Love"));
                    track.Add(new TheFeels("The Feels", "English", 2021, "The Feels"));
                    track.Add(new Scientist("SCIENTIST", "Korean (Romanized)", 2021, "Formula of Love"));
                    Console.Clear();

                    if (songPick == "Like Ohh Ahh")
                    {
                        if (track[0] is LikeOhhAhh)
                        {
                            Console.Clear();
                            Console.WriteLine(track[0].ToString());
                            string[] lines = File.ReadAllLines(@"C:\Users\jhoanne.alegro\Documents\GitHub\alegro-jhoanne\MSP101\ProjectDay\AllAboutTwice\LikeOhhAhh.txt");
                            foreach (string line in lines)
                            {
                                Console.WriteLine(line);
                            }
                        }

                    }
                    else if (songPick == "Cheer Up")
                    {
                        if (track[1] is CheerUp)
                        {
                            Console.Clear();
                            Console.WriteLine(track[1].ToString());
                            string[] lines = File.ReadAllLines(@"C:\Users\jhoanne.alegro\Documents\GitHub\alegro-jhoanne\MSP101\ProjectDay\AllAboutTwice\CheerUp.txt");
                            foreach (string line in lines)
                            {
                                Console.WriteLine(line);
                            }
                        }
                    }
                    else if (songPick == "TT")
                    {
                        if (track[2] is TT)
                        {
                            Console.Clear();
                            Console.WriteLine(track[2].ToString());
                            string[] lines = File.ReadAllLines(@"C:\Users\jhoanne.alegro\Documents\GitHub\alegro-jhoanne\MSP101\ProjectDay\AllAboutTwice\TT.txt");
                            foreach (string line in lines)
                            {
                                Console.WriteLine(line);
                            }
                        }
                    }
                    else if (songPick == "Knock Knock")
                    {
                        if (track[3] is KnockKnock)
                        {
                            Console.Clear();
                            Console.WriteLine(track[3].ToString());
                            string[] lines = File.ReadAllLines(@"C:\Users\jhoanne.alegro\Documents\GitHub\alegro-jhoanne\MSP101\ProjectDay\AllAboutTwice\KnockKnock.txt");
                            foreach (string line in lines)
                            {
                                Console.WriteLine(line);
                            }
                        }
                    }
                    else if (songPick == "Signal")
                    {
                        if (track[4] is Signal)
                        {
                            Console.Clear();
                            Console.WriteLine(track[4].ToString());
                            string[] lines = File.ReadAllLines(@"C:\Users\jhoanne.alegro\Documents\GitHub\alegro-jhoanne\MSP101\ProjectDay\AllAboutTwice\Signal.txt");
                            foreach (string line in lines)
                            {
                                Console.WriteLine(line);
                            }
                        }
                    }
                    else if (songPick == "Likey")
                    {
                        if (track[5] is Likey)
                        {
                            Console.Clear();
                            Console.WriteLine(track[5].ToString());
                            string[] lines = File.ReadAllLines(@"C:\Users\jhoanne.alegro\Documents\GitHub\alegro-jhoanne\MSP101\ProjectDay\AllAboutTwice\Likey.txt");
                            foreach (string line in lines)
                            {
                                Console.WriteLine(line);
                            }
                        }
                    }
                    else if (songPick == "Heart Shaker")
                    {
                        if (track[6] is HeartShaker)
                        {
                            Console.Clear();
                            Console.WriteLine(track[6].ToString());
                            string[] lines = File.ReadAllLines(@"C:\Users\jhoanne.alegro\Documents\GitHub\alegro-jhoanne\MSP101\ProjectDay\AllAboutTwice\HeartShaker.txt");
                            foreach (string line in lines)
                            {
                                Console.WriteLine(line);
                            }
                        }
                    }
                    else if (songPick == "What is Love")
                    {
                        if (track[7] is WhatIsLove)
                        {
                            Console.Clear();
                            Console.WriteLine(track[7].ToString());
                            string[] lines = File.ReadAllLines(@"C:\Users\jhoanne.alegro\Documents\GitHub\alegro-jhoanne\MSP101\ProjectDay\AllAboutTwice\WhatIsLove.txt");
                            foreach (string line in lines)
                            {
                                Console.WriteLine(line);
                            }
                        }
                    }
                    else if (songPick == "Dance the Night Away")
                    {
                        if (track[8] is DanceTheNightAway)
                        {
                            Console.Clear();
                            Console.WriteLine(track[8].ToString());
                            string[] lines = File.ReadAllLines(@"C:\Users\jhoanne.alegro\Documents\GitHub\alegro-jhoanne\MSP101\ProjectDay\AllAboutTwice\DanceTheNightAway.txt");
                            foreach (string line in lines)
                            {
                                Console.WriteLine(line);
                            }
                        }
                    }
                    else if (songPick == "Yes or Yes")
                    {
                        if (track[9] is YesOrYes)
                        {
                            Console.Clear();
                            Console.WriteLine(track[9].ToString());
                            string[] lines = File.ReadAllLines(@"C:\Users\jhoanne.alegro\Documents\GitHub\alegro-jhoanne\MSP101\ProjectDay\AllAboutTwice\YesOrYes.txt");
                            foreach (string line in lines)
                            {
                                Console.WriteLine(line);
                            }
                        }
                    }
                    else if (songPick == "The Best Thing I Ever Did")
                    {
                        if (track[10] is TheBestThingIEverDid)
                        {
                            Console.Clear();
                            Console.WriteLine(track[10].ToString());
                            string[] lines = File.ReadAllLines(@"C:\Users\jhoanne.alegro\Documents\GitHub\alegro-jhoanne\MSP101\ProjectDay\AllAboutTwice\TheBestThingIEverDid.txt");
                            foreach (string line in lines)
                            {
                                Console.WriteLine(line);
                            }
                        }
                    }
                    else if (songPick == "Fancy")
                    {
                        if (track[11] is Fancy)
                        {
                            Console.Clear();
                            Console.WriteLine(track[11].ToString());
                            string[] lines = File.ReadAllLines(@"C:\Users\jhoanne.alegro\Documents\GitHub\alegro-jhoanne\MSP101\ProjectDay\AllAboutTwice\Fancy.txt");
                            foreach (string line in lines)
                            {
                                Console.WriteLine(line);
                            }
                        }
                    }
                    else if (songPick == "Feel Special")
                    {
                        if (track[12] is FeelSpecial)
                        {
                            Console.Clear();
                            Console.WriteLine(track[12].ToString());
                            string[] lines = File.ReadAllLines(@"C:\Users\jhoanne.alegro\Documents\GitHub\alegro-jhoanne\MSP101\ProjectDay\AllAboutTwice\FeelSpecial.txt");
                            foreach (string line in lines)
                            {
                                Console.WriteLine(line);
                            }
                        }
                    }
                    else if (songPick == "More & More")
                    {
                        if (track[13] is MoreAndMore)
                        {
                            Console.Clear();
                            Console.WriteLine(track[13].ToString());
                            string[] lines = File.ReadAllLines(@"C:\Users\jhoanne.alegro\Documents\GitHub\alegro-jhoanne\MSP101\ProjectDay\AllAboutTwice\MoreAndMore.txt");
                            foreach (string line in lines)
                            {
                                Console.WriteLine(line);
                            }
                        }
                    }
                    else if (songPick == "I Cant Stop Me")
                    {
                        if (track[14] is ICantStopMe)
                        {
                            Console.Clear();
                            Console.WriteLine(track[14].ToString());
                            string[] lines = File.ReadAllLines(@"C:\Users\jhoanne.alegro\Documents\GitHub\alegro-jhoanne\MSP101\ProjectDay\AllAboutTwice\ICantStopMe.txt");
                            foreach (string line in lines)
                            {
                                Console.WriteLine(line);
                            }
                        }
                    }
                    else if (songPick == "Cry For Me")
                    {
                        if (track[15] is CryForMe)
                        {
                            Console.Clear();
                            Console.WriteLine(track[15].ToString());
                            string[] lines = File.ReadAllLines(@"C:\Users\jhoanne.alegro\Documents\GitHub\alegro-jhoanne\MSP101\ProjectDay\AllAboutTwice\CryForMe.txt");
                            foreach (string line in lines)
                            {
                                Console.WriteLine(line);
                            }
                        }
                    }
                    else if (songPick == "Alcohol Free")
                    {
                        if (track[16] is AlcoholFree)
                        {
                            Console.Clear();
                            Console.WriteLine(track[16].ToString());
                            string[] lines = File.ReadAllLines(@"C:\Users\jhoanne.alegro\Documents\GitHub\alegro-jhoanne\MSP101\ProjectDay\AllAboutTwice\AlcoholFree.txt");
                            foreach (string line in lines)
                            {
                                Console.WriteLine(line);
                            }
                        }
                    }
                    else if (songPick == "The Feels")
                    {
                        if (track[17] is TheFeels)
                        {
                            Console.Clear();
                            Console.WriteLine(track[17].ToString());
                            string[] lines = File.ReadAllLines(@"C:\Users\jhoanne.alegro\Documents\GitHub\alegro-jhoanne\MSP101\ProjectDay\AllAboutTwice\TheFeels.txt");
                            foreach (string line in lines)
                            {
                                Console.WriteLine(line);
                            }
                        }
                    }
                    else if (songPick == "Scientist")
                    {
                        if (track[18] is Scientist)
                        {
                            Console.Clear();
                            Console.WriteLine(track[18].ToString());
                            string[] lines = File.ReadAllLines(@"C:\Users\jhoanne.alegro\Documents\GitHub\alegro-jhoanne\MSP101\ProjectDay\AllAboutTwice\Scientist.txt");
                            foreach (string line in lines)
                            {
                                Console.WriteLine(line);
                            }
                        }
                    }
                    else if (songPick == "Back")
                    {
                        goto MainMenu;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid input, please enter your song choice\nMake sure the first letter is a capital letter\n");
                    }
                }
            }
            else if (userInput == 4)
            {
                Console.Clear();
                Console.WriteLine("Thank you very much for taking time to know TWICE! <3\n");
                goto Exit;
            }
            else
            {
                Console.Write("\nInvalid Input, please choose from the options.\n");
            }
        }
    Exit:
        Console.WriteLine("STAN TWICE!!!");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Sources: https://kpop.fandom.com/wiki/TWICE");
        Console.WriteLine("Sources: https://vockpopcclyrics.wordpress.com/");
    }
}