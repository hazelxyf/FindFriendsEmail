using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindFriendsEmail
{
    class Program
    {
        public static int Main(string[] args)
        {
            // array of friendList
            string[] friendsEmail =
                { "friend@catena-technologies.com",
                "bff@uni.edu.sg",
                "provost@uni.edu.sg",
                "john@doe.com" };

            // array of allEmails
            string[] allEmails =
                { "enemy@uni.edu.sg",
                "bff@uni.edu.sg",
                "evil@spam.com",
                "bff@uni.edu.sg",
                "friend@catena-technologies.com" };

            List<string> friendsList = new List<string>(friendsEmail);
            List<string> allEmailsList = new List<string>(allEmails);

            // return number of emails in allEmailsList that are from a friend
            int numOfFriends = numOfFriendsEmail(friendsList, allEmailsList);
            Console.WriteLine(numOfFriends);
            Console.Read();
            return numOfFriends;
        }

        // function to find number of emails from a friend
        protected static int numOfFriendsEmail(List<string> FriendsList, List<string> AllEmailsList)
        {
            int count = AllEmailsList.Where(email => FriendsList.Contains(email)).Count();

            return count;
        }
    }
}
