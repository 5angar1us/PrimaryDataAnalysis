using System;

namespace DataAnalyzers.Data
{
    public class FrequencyRange
    {
        //Вариация
        public double Variation { private set; get; }
        //Частота
        public int Frequency { private set; get; }

        public FrequencyRange( double variation, int frequency)
        {
            Variation = variation;
            Frequency = frequency;
        }

        public int CompareTo(object obj)
        {
            if (obj is FrequencyRange o)
            {
                return this.Frequency.CompareTo(o.Frequency);
            }
            else
                throw new NullReferenceException();
        }
    }
}
