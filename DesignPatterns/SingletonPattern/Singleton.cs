﻿
using System;

namespace SingletonPattern
{
    public class Singleton
    {
        private static Singleton _singleton = null;

        private Singleton() {}

        public static Singleton GetInstance()
        {
            if (_singleton == null)
            {
                _singleton = new Singleton();
            }
            return _singleton;
        }

        public void Login()
        {
            Console.WriteLine("Login successful!");
        }

    }
}
