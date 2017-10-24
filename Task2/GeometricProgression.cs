using System;

namespace Task2
{
    public class GeometricProgression : ISeries
    {
        double initialValue, commonRatio;
        int currentIndex;

        public GeometricProgression(double initialValue, double commonRatio)
        {
            this.initialValue = initialValue;
            this.commonRatio = commonRatio;
            this.currentIndex = 1;
        }

        public double GetCurrent()
        {
            return initialValue * Math.Pow(commonRatio, currentIndex - 1);
        }

        public bool MoveNext()
        {
            currentIndex++;
            return true;
        }

        public void Reset()
        {
            currentIndex = 1;
        }
    }
}
