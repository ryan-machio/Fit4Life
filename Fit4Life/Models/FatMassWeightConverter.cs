namespace Fit4Life.Models
{
    public class FatMassWeightConverter
    {
        double fatMassPercent;
        double leanBodyMassPounds;
        double weightPounds;

        public double FatMassPounds
        {
            get { return fatMassPercent; }
            set { fatMassPercent = value; }
        }

        public double LeanBodyMassPounds
        {
            get { return leanBodyMassPounds; }
            set { leanBodyMassPounds = value; }
        }

        public double WeightPounds
        {
            get { return WeightPounds; }
            set { weightPounds = value; }
        }

        public FatMassWeightConverter(double FatMassPercent, double LeanBodyMassPounds, double WeightPounds)
        {
            fatMassPercent = FatMassPercent;
            leanBodyMassPounds = LeanBodyMassPounds;
            weightPounds = WeightPounds;
        }

        public double WeightLbsToKg()
        {
            double weightKg = weightPounds * 0.453592;
            return (weightKg);
        }

        public double FatMassConverter()
        {
            double fatMassKg = WeightLbsToKg() * (fatMassPercent / 100);
            return (fatMassKg);
        }

        public double LeanBodyMassConverter()
        {
            double lbmKg = WeightLbsToKg() - FatMassConverter();
            return lbmKg;
        }

        public string print()
        {
            return $"{WeightLbsToKg()}, {FatMassConverter()}, {LeanBodyMassConverter()}";
        }
    }
}