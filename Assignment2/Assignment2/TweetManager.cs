using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Assignment2
{
    class TweetManager
    {
        static List<Tweet> TWEETS;
        static string FILENAME="test.txt";
        static TweetManager()
        {
            List<Tweet> tweets = new List<Tweet>();
            TextReader reader = new StreamReader(FILENAME);
            string input = reader.ReadLine();                
           
            while (input != null)
            {
                    input = reader.ReadLine();
                tweets.Add(Tweet.Parse(input));
            }
            reader.Close();
             static void Initialize()
            {
                Tweet tweet01 = new Tweet("Andrey", "Lovely", "Hi there", "1520");
                Tweet tweet02 = new Tweet("Chu", "Kacy", "SDS", "205");
                Tweet tweet03 = new Tweet("Ann", "Bro", "Sun is up", "312");
                Tweet tweet04 = new Tweet("Ash", "Tan", "Sun is down", "252");
                Tweet tweet05 = new Tweet("Mil", "Pret", "Midnight", "712");
                TWEETS.Add(tweet01);
                TWEETS.Add(tweet02);
                TWEETS.Add(tweet03);
                TWEETS.Add(tweet04);
                TWEETS.Add(tweet05);
            }
            public static void ShowAll()
            {
                foreach (Tweet tweet in TWEETS)
                {
                    Console.WriteLine(tweet);
                }

            }
            public static void ShowAll(string tag)
            {

                foreach (Tweet tweet in TWEETS)
                {

                    if (tweet.Tag == tag)
                        Console.WriteLine(tweet);
                }

            }
        }
    }
}
