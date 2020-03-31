using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    interface IFactory
    {
        LeiFeng CreateLeiFeng();
    }
    class UndergraduateFactory : IFactory
    {
        public LeiFeng CreateLeiFeng()
        {
            return new Undergraduate();
        }
    }
    class VolunteerFactory : IFactory
    {
        public LeiFeng CreateLeiFeng()
        {
            return new Volunteer();
        }
    }
}
