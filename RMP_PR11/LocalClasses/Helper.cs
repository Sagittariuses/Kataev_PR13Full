using RMP_PR11.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMP_PR11.LocalClasses
{
    public class Helper
    {
        private static AirlineEntities ConObj;
        public static AirlineEntities GetContext()
        {
            if (ConObj == null)
                ConObj = new AirlineEntities();
            return ConObj;

        }
    }
}
