﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    abstract  class UnitedNations
    {
        public abstract void Declare(string message, Country country);
    }
    class Council : UnitedNations
    {
        private USA country1;
        private Iraq country2;

        public USA Country1
        {
            set { country1 = value; }
        }
        public Iraq Country2
        {
            set { country2 = value; }
        }
        public override void Declare(string message, Country country)
        {
            if (country == country1)
            {
                country2.GetMessage(message);
            }
            else
            {
                country1.GetMessage(message);
            }
        }
    }
}
