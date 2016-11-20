using UnityEngine;
using System.Collections;

public class SelectionManager : MonoBehaviour {
    public Camera MainCamera;

    private const int buildingLayerMask = 1 << 9;
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
            if (Physics.Raycast(ray, out hitInfo, 50f, buildingLayerMask))
            {
                // Deselect previous object if it's not null
                if (selectedObject)
                    selectedObject.GetComponent<BuildingBehavior>().Deselect();
                selectedObject = hitInfo.transform.gameObject;
                selectedObject.GetComponent<BuildingBehavior>().Select();
            }
        }
	}
}
