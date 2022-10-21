
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

        }
    }
} 
        
