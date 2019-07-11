using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class Tweet
    {
        static int CURRENT_ID;
        public string From {  get; }
        public string To {  get; }
        public string Body { get; }
        public string Tag { get; }
        public string Id { get; }

        public Tweet(string from, string to, string body, string tag)
        {
            From = from;
            To = to;
            Body = body;
            Tag = tag;
            Id = CURRENT_ID.ToString();
            CURRENT_ID++;
        }
        public Tweet(string from, string to, string body, string tag, string id)
        {
            From = from;
            To = to;
            Body = body;
            Tag = tag;
            Id = id;
            
        }
        public override string ToString()
        {        
            return $"{From}{To}{Body.Substring(0,12)}{Tag}{Id}";
        }
        public static Tweet Parse(string line)
        {
            string [] split= line.Split(new char[]{ '\t'});
            Tweet tweet = new Tweet(split[0], split[1], split[2], split[3]);
            return tweet;
        }
    }
}
