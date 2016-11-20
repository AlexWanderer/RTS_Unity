using UnityEngine;
using System.Collections;

public class BuildingBehavior : MonoBehaviour {
    public Color HighlightColor;
    private Color starterColor;

	// Use this for initialization
	void Start () {
        starterColor = gameObject.GetComponent<Renderer>().material.color;
	}
	// Update is called once per frame
	void Update () {
	
	}
    public void Select()
    {
        gameObject.GetComponent<Renderer>().material.color = HighlightColor;
        SetChildrenToColor(HighlightColor);
    }
    public void Deselect()
    {
        gameObject.GetComponent<Renderer>().material.color = starterColor;
        SetChildrenToColor(starterColor);
    }
    void SetChildrenToColor(Color setColor)
    {
        Renderer[] rends = gameObject.GetComponentsInChildren<Renderer>();
        if (rends != null)
        {
            foreach (var child in rends)
            {
                child.material.color = setColor;
            }
        }
    }
}
