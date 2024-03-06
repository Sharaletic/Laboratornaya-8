using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya_8
{
    public class GentleSmartphone
    {
        public int SeriaNumber {  get; set; }

        
        //композиция: если есть телефон, значит есть чувствительность телефона
        public TactileSensor sensor { get; set; }
        public GentleSmartphone()
        {
            sensor = new TactileSensor();
        }
    }
}
