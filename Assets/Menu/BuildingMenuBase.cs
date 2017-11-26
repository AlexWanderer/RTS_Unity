using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Menu
{
    public class BuildingMenuBase
    {
        public void OnGUI()
        {
            // Make a background box
            GUI.Box(new Rect(300, 80, 200, 180), "Menu");

            if (GUI.Button(new Rect(320, 110, 150, 20), "1st Choice"))
            {
                Debug.Log("Button 1 pressed!");
            }
        }
    }
}
