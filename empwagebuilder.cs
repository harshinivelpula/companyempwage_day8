using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace companywage213
{
    public class empwagebuilder: final
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private LinkedList<companyempwage> companyempwagelist;
        private Dictionary<string, companyempwage> companytoempwagemap;

        public empwagebuilder()
        {
            this.companyempwagelist = new LinkedList<companyempwage>();
            this.companytoempwagemap = new Dictionary<string, companyempwage>();
        }
        public void addcompanyempwage(string company, int emprateperhour, int numofworkingdays, int maxhourspermonth)
        {
            companyempwage companyempwage = new companyempwage(company, emprateperhour, numofworkingdays, maxhourspermonth);
            this.companyempwagelist.AddLast(companyempwage);
            this.companytoempwagemap.Add(company, companyempwage);
        }
        public void computeempwage()
        {
            foreach(companyempwage companyempwage in this.companyempwagelist)
            {
                int totalempwage = this.computeempwage(companyempwage);
                Console.WriteLine(companyempwage.tostring());
            }
        }
        private int computeempwage(companyempwage companyempwage)
        {
            
                return 0;
            
        }
            public int gettotalwage(string company)
        {
            return this.companytoempwagemap[company].totalempwage;
        }
    }
    
}
