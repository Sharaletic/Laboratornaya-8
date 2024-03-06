using Laboratornaya_8;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static Laboratornaya_8.Transformator;

namespace Laboratornaya_8
{
    public class Factory
    {
        public List<Customer> customers;    //агрегация
        public List<GentleSmartphone> gentleSmartphone;     //композиция

        public Factory() 
        {
            customers = new List<Customer>();
            gentleSmartphone = new List<GentleSmartphone>();
        }

        public void SaleSmartphone()
        {
            foreach (Customer customer in customers)
            {
                foreach (GentleSmartphone smartphone in gentleSmartphone)
                {
                    if ((smartphone.sensor.Sensitivity / customer.GentleRate <= 1.5) &&
                        (customer.GentleRate / smartphone.sensor.Sensitivity < 2))
                    {
                        customer.gentleSmartphone = smartphone;
                        gentleSmartphone.Remove(smartphone);
                        break;
                    }
                }
                if (customer.gentleSmartphone == null)
                {
                    foreach (GentleSmartphone smartphone in gentleSmartphone)
                    {
                        if (((smartphone.sensor.Sensitivity / 2) / customer.GentleRate <= 1.5) &&
                            (customer.GentleRate / (smartphone.sensor.Sensitivity / 2) <= 2.0))
                        {
                            customer.TransformatorModule = new Transformator();
                            customer.TransformatorModule.Type = TransformatorType.Divider;
                            customer.gentleSmartphone = smartphone;
                            gentleSmartphone.Remove(smartphone);
                            break;
                        }
                        else if ((customer.GentleRate / (smartphone.sensor.Sensitivity * 2.0) <= 2.0) &&
                            ((smartphone.sensor.Sensitivity * 2.0) / customer.GentleRate <= 1.5))
                        {
                            customer.TransformatorModule  = new Transformator();
                            customer.TransformatorModule.Type = TransformatorType.Multiplier;
                            customer.gentleSmartphone = smartphone;
                            gentleSmartphone.Remove(smartphone);
                            break;
                        }
                    }
                }
            }
            if (gentleSmartphone.Count > 0)
            {
                gentleSmartphone.Clear();
            }
        }
    }
}