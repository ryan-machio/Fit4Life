namespace Fit4Life.Models
{
    public class BmrCalculator
    {
        class BasalMetabolicRateData
        {
            double leanBodyMass;
            double fatMass;
            double age;
            double staticNumber = 675;
            double sex;

            public double LeanBodyMass
            {
                get { return leanBodyMass; }
                set { leanBodyMass = value * 13.597; }
            }

            public double FatMass
            {
                get { return fatMass; }
                set { fatMass = value * 9.613; }
            }

            public double Age
            {
                get { return age; }
                set { age = value * 3.351; }
            }

            public double StaticNumber
            {
                get { return staticNumber; }
            }

            public double Sex
            {
                get { return sex; }
                set { sex = value * 198; }
            }

            public BasalMetabolicRateData(double LeanBodyMass, double FatMass, double Age, double Sex)
            {
                leanBodyMass = LeanBodyMass;
                fatMass = FatMass;
                age = Age;
                sex = Sex;
            }

            public double MuellerEquation()
            {
                return (13.597 * LeanBodyMass) + (9.613 + FatMass) + (198 * Sex) + (3.351 * Age) + StaticNumber;
            }
        }
    }
}