﻿
namespace companywage213
{
    class program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("welcome to company employye wage");


            employeecheck.checkattendance();
            empwage.checkwage();
            parttime.isparttime();
            switchcase.switchcases();
            wageformonth.monthwages();
            condition.conditions();
            computeempwage.calcomputewage();
            multiplecompany.multipleempwage("dmart", 20, 2, 10);
            multiplecompany.multipleempwage("reliance", 10, 4, 20);
            savetotalwage dmart = new savetotalwage("dmart", 20, 2, 10);
            savetotalwage reliance = new savetotalwage("reliance", 10, 4, 20);
            dmart.empwage();
            Console.WriteLine(dmart.ToString());
            reliance.empwage();
            Console.WriteLine(reliance.ToString());
            

        }
    }
} 
        
