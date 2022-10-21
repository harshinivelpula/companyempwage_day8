using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace companywage213
{
    public class final
    {
        public interface icomputeempwage
        {
            public void addcompanyempwage(string company, int emprateperhour, int numofworkingdays, int maxhourspermonth);
            public void computeempwage();
            public void gettotalwage(string company);
        }
        public class companyempwage
        {
            public string company;
            public int emprateperhour;
            public int numofworkingdays;
            public int maxhourspermonth;
            public int totalempwage;

            public companyempwage(string company, int emprateperhour, int numofworkingdays, int maxhourspermonth)
            {
                this.company = company;
                this.emprateperhour = emprateperhour;
                this.numofworkingdays = numofworkingdays;
                this.maxhourspermonth = maxhourspermonth;
                this.totalempwage = 0;
            }
            public void settotalempwage(int totalempwage)
            {
                this.totalempwage = totalempwage;
            }
            public string tostring()
            {
                return "total emp wage for company:" + this.company + "is:" + totalempwage;
            }
        }
    }
}
