﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class ListExtention
    {
        public static List<T> Shuffle<T>(this IList<T> list)
        {
            Random random = new Random();
            List<T> newList = new List<T>();

            for (int i = 0; i < list.Count;)
            {
                int number = random.Next(0, list.Count);
                newList.Add(list[number]);
                list.RemoveAt(number);
            }

            return newList;
        }
    }
}
