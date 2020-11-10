using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableVsObject
{
    class Program
    {
        static void Main(string[] args)
        {


            /*
            
            1. Variable Type vs Object Type
            Which of the followings is considered boxing?

            a. double dblx = fx;
            b. float fx = ix;
            c. object myobjx = fx; //This one is considered boxing
            d. int ix = objy;
            
            
            2. Which of the followings is considered unboxing?

            a. string str = ix.ToString();
            b. double dblx =(double) floatVal; //This might be unboxing?
            c. object myobjx = fx;
            d. int ix = (int) objy; //This might be unboxing?
            

            */

            //3. Object objdblx is of type double. Assign the value of this object to a variable of type float.

            float fx = objdblx;
            float fx = (float)(double)objdblx;

            //4. Object objflx is of type float. Assign the value of this object o another variable of type double.

            double dx = objflx;
            double dx = (double)(float)objflx;
            
            //5. Convert the string strx to a double dblx:

            double dblx =
            double dblx = double.Parse(strx);
            
            //6. Convert the integer ix to a float fx:

            float fx =
            float fx = ix;
            
            //7. Convert the double dblx to a string strx:

            string strx =
            
            //8. Object is the _base_ class of all other data types.

            //9. What is an object (the definition)?

                //objects are things 

            //10. How do you declare an object in C#?
            object myObject = 1;
            //11. What is the difference between an object and a variable?

            //12. What if we want to grab and store a string from an object that contains a string and convert it into something numeric say into a double?
            object objstr = "23.5";
            
            double myDouble = double.Parse(objstr.ToString());
            
 
          
        }
    }
}
