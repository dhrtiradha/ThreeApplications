using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    public class WateringSchedule
    {
        private DateTime _currentDate;

        public WateringSchedule(DateTime currentDate)
        {
            this._currentDate = currentDate;
        }

        public DateTime GetNextWateringDate(IFlower flower)
        {
            return _currentDate.AddDays(flower.WateringFrequency);
        }

        public List<DateTime> GetWateringDates(IFlower flower, int daysAhead)
        {
            List<DateTime> dates = new List<DateTime>();
            for (int i = 0; i < daysAhead; i += flower.WateringFrequency)
            {
                dates.Add(_currentDate.AddDays(i));
            }
            return dates;
        }

        public void UpdateCurrentDate(DateTime newDate)
        {
            _currentDate = newDate;
        }
    }
}
