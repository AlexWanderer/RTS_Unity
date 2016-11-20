using UnityEngine;
using System.Collections;

public class BuildingBehavior : MonoBehaviour {
    public Color HighlightColor;
    private Color starterColor;

	// Use this for initialization
	void Start () {
        starterColor = gameObject.GetComponent<Material>().color;
	}
	// Update is called once per frame
	void Update () {
	
	}
    public void Select()
    {
        gameObject.GetComponent<Material>().color = HighlightColor;        
    }
    public void Deselect()
    {
        gameObject.GetComponent<Material>().color = starterColor;
    }
}
