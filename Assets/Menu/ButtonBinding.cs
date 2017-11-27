using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Menu
{
    [ExecuteInEditMode]
    public class ButtonBinding : MonoBehaviour
    {
        public Button Button { get; set; }
        public UnityEngine.Events.UnityAction ClickAction { get; set; }
    }
}
