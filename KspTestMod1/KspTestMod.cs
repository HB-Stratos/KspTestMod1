using DebugStuff;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


namespace KspTestMod1
{
    [KSPAddon(KSPAddon.Startup.Flight, false)]
    public class KspTestMod : MonoBehaviour
    {
        public GameObject[] cubes;
        public void Update()
        {
            bool key = Input.GetKey(KeyCode.LeftAlt) && Input.GetKeyDown(KeyCode.Alpha1);
            if (key)
            {
                List<Part> parts = FlightGlobals.ActiveVessel.parts;
                int index;
                System.Random rnd = new System.Random();
                index = rnd.Next(1, parts.Count); //we ignore the root part by starting at 1
                //parts[index].explode();
                DebugDrawer.DebugLine(parts[0].transform.position, parts[index].transform.position, Color.red);
                cubes.Append(GameObject.CreatePrimitive(PrimitiveType.Cube));
                cubes.Last().transform.position = parts[0].transform.position;
                BoxCollider cubeCollider = cubes.Last().GetComponent<BoxCollider>();
                cubeCollider.enabled = false;
            }
            foreach (GameObject cube in cubes)
            {
                //cube.transform.position =
            }
        }
    }
}
