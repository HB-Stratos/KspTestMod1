using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace KspTestMod1
{
    [KSPAddon(KSPAddon.Startup.Flight, false)]
    public class KspTestMod : MonoBehaviour
    {
        public void Update()
        {
            bool key = Input.GetKey(KeyCode.LeftAlt) && Input.GetKeyDown(KeyCode.Alpha1);
            if ( key)
            {
                List<Part> parts = FlightGlobals.ActiveVessel.parts;
                int index;
                System.Random rnd = new System.Random();
                index = rnd.Next(1, parts.Count); //we ignore the root part by starting at 1
                parts[index].explode();
            }
        }
    }
}
