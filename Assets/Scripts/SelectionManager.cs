using UnityEngine;
using System.Collections;

public class SelectionManager : MonoBehaviour {
    public Camera MainCamera;

    private const int buildingLayerMask = 1 << 9;
    private const int unitLayerMask = 1 << 10;
    private GameObject selectedObject;

	// Use this for initialization
	void Start () {
	
	}
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo;
            Ray ray = MainCamera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hitInfo, 50f, buildingLayerMask | unitLayerMask))
            {
                // Deselect previous object if it's not null
                if (selectedObject != null)
                    selectedObject.GetComponent<SelectableObject>().Deselect();
                selectedObject = hitInfo.transform.gameObject;
                selectedObject.GetComponent<SelectableObject>().Select();
            }
        }
	}
}
