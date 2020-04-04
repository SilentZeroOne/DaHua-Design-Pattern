using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    class WebsiteFactory
    {
        private Hashtable flyweights = new Hashtable();
        public Website GetWebsiteCategory(string key)
        {
            if (!flyweights.ContainsKey(key))
            {
                flyweights.Add(key, new ConcreteWebSite(key));
            }
            return (Website)flyweights[key];
        }
        public int GetCount()
        {
            return flyweights.Count;
        }

    }
}
