﻿using System;

class Test
{
    static void Main()
    {
        int[] xlist = new int[] { 9,5,3,-2, 4, 5 };

        for (int x = 0; x <xlist.Length; x++)
        {
            if (xlist[x] == 3)
            {
                for (int y = x; y<xlist.Length - 1; y++)
                {
                    xlist[y] = xlist[y + 1];
                }
            }
        }

        foreach (int v in xlist)
        {
            Console.Write("{0} ", v);
        }
    }
}