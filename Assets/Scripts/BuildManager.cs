using UnityEngine;
using System.Collections;

public class BuildManager : MonoBehaviour {
    public GameObject BasePrefab;
    public GameObject BarracksPrefab;
    public Camera MainCamera;

    private GameObject activeObject;
    private const int buildingLayerMask = 1 << 9;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (activeObject)
        {
            RaycastHit hit;
            Ray ray = MainCamera.ScreenPointToRay(Input.mousePosition);
            Physics.Raycast(ray, out hit, 50f, buildingLayerMask);
            activeObject.transform.position = hit.point;
            //if (Input.GetMouseButtonDown(0) && !firstClick)
            //{
            //    activeObject.transform.position = MainCamera.ScreenToWorldPoint(Input.mousePosition);
            //    activeObject = null;
            //}
        }
	}

    public void CreateBase()
    {
        activeObject = GameObject.Instantiate<GameObject>(BasePrefab);
        activeObject.transform.position = MainCamera.ScreenToWorldPoint(Input.mousePosition);
    }
}