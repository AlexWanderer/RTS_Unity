using UnityEngine;
using System.Collections;

public class BuildManager : MonoBehaviour {
    public GameObject BasePrefab;
    public GameObject BarracksPrefab;
    public Camera MainCamera;

    private GameObject activeObject;
    private const int groundLayerMask = 1 << 8;

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
            if (Physics.Raycast(ray, out hit, 50f, groundLayerMask))
            {
                Vector3 groundedHit = new Vector3(hit.point.x, 0.75f, hit.point.z);
                activeObject.transform.position = groundedHit;

                if (Input.GetMouseButtonDown(0))
                {
                    activeObject.transform.position = groundedHit;
                    activeObject = null;
                }
            }
        }
	}
    public void CreateBase()
    {
        activeObject = GameObject.Instantiate<GameObject>(BasePrefab);
        activeObject.transform.position = MainCamera.ScreenToWorldPoint(Input.mousePosition);
    }
}