namespace companywage213
{

    public interface icompanyempwage
    {
        public void addcompanyempwage(string company, int emprateperhour, int numofworkingdays, int maxhourspermonth);
        public void computeempwage();
        public int gettotalwage(int company);
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
            }
            public void totalwage()
            {
                this.totalempwage = totalempwage;
            }
            public string tostring()
            {
                return "total emp wage for company:" + this.company + "is:" + this.totalempwage;
            }
        }
}