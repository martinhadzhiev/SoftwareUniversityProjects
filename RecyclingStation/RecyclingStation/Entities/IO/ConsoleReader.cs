﻿namespace RecyclingStation.Entities.IO
{
    using System;
    using Contracts;

    public class ConsoleReader : IReader
    {
        public string Read()
        {
            return Console.ReadLine();
        }
    }
}
