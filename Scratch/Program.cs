// File: VerySimple.cs
using System;

class VerySimple
{
    int simpleValue;

    public VerySimple()
    {
        simpleValue = 10;
    }
}

class TestVerySimpleClass
{
    static void Main()
    {
        VerySimple ver; // notice that ver is null

        ver = new VerySimple();
    }
}