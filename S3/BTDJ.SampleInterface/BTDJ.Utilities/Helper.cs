using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDJ.Utilities
{
    [Serializable]
    public class Helper
    {
        public string AgeGrp(int age)
        {
            string agegroup = "";
            if (age < 15)
            {
                agegroup = "Level1";
            }
            else if (age >= 15 && age < 35)
            {
                agegroup = "Level2";

            }
            else if (age >= 35 && age < 55)
            {
                agegroup = "Level3";

            }
            else if (age >= 55 && age < 65)
            {
                agegroup = "Level4";

            }
            else
            {
                agegroup = "Level5";
            }
            return agegroup;
        }
    }
}
