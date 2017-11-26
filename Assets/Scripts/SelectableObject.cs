using UnityEngine;
using System.Collections;
using Assets.Menu;

public class SelectableObject : MonoBehaviour {
    public readonly Color HighlightColor = Color.grey;

    private Color starterColor;
    private bool selected;
    public bool Selected { get { return selected; } }
    public GameObject Menu;

	// Use this for initialization
	void Start () {
        starterColor = gameObject.GetComponent<Renderer>().material.color;
        Menu = GameObject.Instantiate<GameObject>(Menu);
        Menu.SetActive(false);
	}
	// Update is called once per frame
	void Update () {
	}
    public void Select()
    {
        gameObject.GetComponent<Renderer>().material.color = HighlightColor;
        SetChildrenToColor(HighlightColor);
        selected = true;
        Menu.SetActive(selected);
    }
    public void Deselect()
    {
        gameObject.GetComponent<Renderer>().material.color = starterColor;
        SetChildrenToColor(starterColor);
        selected = false;
        Menu.SetActive(selected);
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
