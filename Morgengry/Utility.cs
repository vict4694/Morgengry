using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Utility
    {
        private double _lowQualityValue;
        public double LowQualityValue
        {
            get { return _lowQualityValue; }
            set { _lowQualityValue = 12.5; }
        }
        private double _mediumQualityValue = 20.0;
        public double MediumQualityValue
        { get { return _mediumQualityValue;}
        }
        private double _highQualityValue = 27.5;
        public double HighQualityValue
        {
            get { return _highQualityValue; }
        }

        public static double GetValueOfBook(Book book)
        {
            return book.Price;
        }

        public static double GetValueOfAmulet(Amulet amulet)
        {
            Level quality = amulet.Quality;
            if (quality == Level.low)
            {
                return 12.5;
                //return LowQualityValue;
            }
            else if (quality == Level.medium)
            {
                return 20.0;
            }
            else
            {
                return 27.5;
            }
        }

        public static double GetValueOfCourse(Course course)
        {
            int durationInHours = course.DurationInMinutes / 60;
            int remainingMinutes = course.DurationInMinutes - durationInHours * 60;
            if (remainingMinutes == 0)
            {
                return durationInHours * 875;
            }
            else
            {
                return (durationInHours + 1) *875;
            }
        }
    }
}
