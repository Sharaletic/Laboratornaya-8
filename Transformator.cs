using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya_8
{
    public class Transformator
    {
        public enum TransformatorType
        {
            Multiplier,
            Divider
        }
        public int SerialNumber {  get; set; }
        public TransformatorType Type { get; set; }
    }
}
