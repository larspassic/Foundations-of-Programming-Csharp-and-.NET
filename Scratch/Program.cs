// File: VerySimple.cs
using System;



//Back-end architect developers who create tools and classes for us to use
class VerySimple //This is a class
{
    public int simpleValue; //Field - added the "public" to make it available in the test below

    public VerySimple() //Constructor
    {
        //initializers : superintendents of the class
        simpleValue = 10; //This is the starting point of the value, determined here in the constructor

    }
}





//Clients and end-users who want to access the architect tools
class TestVerySimpleClass //The class user has to follow the access rules
{
    static void Main()
    {
        //This is called instantiation: creating an object of type class that you are accessing

        VerySimple ver = new VerySimple();

        //Name of the class you are instantiating from: VerySimple
        //create a name called "ver" which is the name of the instantiated object
        //you have to use the key word "new" : instantiation of the object being created
        //VerySimple() is the call for the constructor (if any)

        var x = ver.simpleValue; //This value was recently made available by adding public to simpleValue above
        
    }
}