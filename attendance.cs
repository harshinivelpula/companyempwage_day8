﻿

namespace companywage213
{
    public class employeecheck
    {
        public static void checkattendance()
        {
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            if(empcheck == IS_FULL_TIME)
            {
                Console.WriteLine("employee is present");
            }
            else
            {
                Console.WriteLine("employee is absent");
            }
        }
    }
}
