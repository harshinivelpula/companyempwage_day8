

namespace companywage213
{
    public class empwagebuildarray: icompanyempwage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private int numofcompany = 0;

        public int[] a = new int[5];
        private companyempwage[] companyempwagearray;

        public empwagebuildarray()
        {
            this.companyempwagearray = new companyempwage[5];
        }
        public void addcompanyempwage(string company, int emprateperhour, int numofworkingdays, int maxhourspermonth)
        {
            companyempwagearray[this.numofcompany] = new companyempwage(company, emprateperhour, numofworkingdays, maxhourspermonth);
            numofcompany++;
        }

        public void computeempwage()
        {
            for(int i=0;i<numofcompany;i++)
            {
                int totalempwage = this.computeempwage(this.companyempwagearray[i]);
                Console.WriteLine(this.companyempwagearray[i].ToString());
            }
        }

        private int computeempwage(companyempwage companyempwage)
        {
            return 0;
        }
        public int gettotalwage(int company)
        {
            return this.companyempwagearray[company].totalempwage;
        }

    }
}