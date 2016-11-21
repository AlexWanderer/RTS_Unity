using UnityEngine;
using System.Collections;

public class SelectableObject : MonoBehaviour {
    public readonly Color HighlightColor = Color.grey;

    private Color starterColor;
    private bool selected;
    public bool Selected { get { return selected; } }

	// Use this for initialization
	void Start () {
        starterColor = gameObject.GetComponent<Renderer>().material.color;
	}
	// Update is called once per frame
	void Update () {
        if (selected)
        {
        }
	}
    public void Select()
    {
        gameObject.GetComponent<Renderer>().material.color = HighlightColor;
        SetChildrenToColor(HighlightColor);
        selected = true;
    }
    public void Deselect()
    {
        gameObject.GetComponent<Renderer>().material.color = starterColor;
        SetChildrenToColor(starterColor);
        selected = false;
    }
    void SetChildrenToColor(Color setColor)
    {
        Renderer[] rends = gameObject.GetComponentsInChildren<Renderer>();
        if (rends != null)
        {
            foreach (var renderer in rends)
            {
                renderer.material.color = setColor;
            }
        }
    }
}
