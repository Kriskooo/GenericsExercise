﻿using System;
using System.Collections.Generic;

namespace GenericCountMethodString
{
    public class Box<T>
        where T : IComparable
    {
        public List<T> StoreElement { get; set; }
        public Box()
        {

            this.StoreElement = new List<T>();
        }
        public int GreaterThan(T compareElement)
        {
            int count = 0;
            foreach (var element in this.StoreElement)
            {
                if (element.CompareTo(compareElement) > 0)
                {
                    count++;
                }
            }
            return count;
        }

    }
}