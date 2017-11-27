using UnityEngine;
using System.Collections;
using Assets.Menu;
using System.Linq;

public class SelectableObject : MonoBehaviour {
    public bool Selected { get { return selected; } }
    public readonly Color HighlightColor = Color.grey;
    public GameObject Menu;
    public ButtonBinding ButtonBindings;

    private BuildingBehavior buildingBehaviorRef;
    private bool selected;
    private Color starterColor;

	void Start()
    {
        starterColor = gameObject.GetComponent<Renderer>().material.color;
        buildingBehaviorRef = gameObject.GetComponent<BuildingBehavior>();
        Menu = GameObject.Instantiate<GameObject>(Menu);
        Menu.SetActive(false);
        //foreach (var binding in ButtonBindings)
        //{
        //    binding.Button.onClick.AddListener(binding.ClickAction);
        //}
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
