﻿using System;


/*The observer pattern is a software design pattern in which an object maintains a list of its dependents, called observers, 
 * and notifies them automatically of any state changes, usually by calling one of their methods. It is mainly used to implement distributed event
 * handling systems.
 * 
 * Example: YouTube
 */

namespace ObserverPattern
{
    class Program
    {
        static void Main()
        {
            var youtubeChannel = YoutubeChannel.GetInstance();

            var user1 = new User("User 1");
            var user2 = new User("User 2");
            var user3 = new User("User 3");
            var moderator1 = new Moderator("Moderator 1");

            youtubeChannel.Subscribe(user1);
            youtubeChannel.Subscribe(user2);
            youtubeChannel.Subscribe(user3);
            youtubeChannel.Subscribe(moderator1);

            user1.Upload(); //whenever user uploads, notify all the subscribers about the upload
            
            //Console.WriteLine("");
            //youtubeChannel.Notify();
            //Console.WriteLine("");
            
            //youtubeChannel.UnSubscribe(user1);
            //youtubeChannel.UnSubscribe(user2);
            //youtubeChannel.Notify();

            Console.ReadKey();
        }
    }
}
