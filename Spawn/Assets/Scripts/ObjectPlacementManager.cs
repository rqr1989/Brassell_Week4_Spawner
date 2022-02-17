using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPlacementManager : MonoBehaviour
{
    //Detect whether the mouse is over terrain
    //Instantiate the object and have it slide along the terrain using raycasting
    //Assigned in inspector
    public Camera cam;
    public Transform placeableObject;
    public LayerMask mask;
   //  public GameObject cylinderPrefab;

   // public GameObject cyl;

    public void Awake()
    {
        cam = FindObjectOfType<Camera>();
    } 
    // Update is called once per frame 
    void Update()
    {
        //creates ray at point where mouse is, looking through camera
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);

        RaycastHit hitInfo;


        //if Raycast hits something
        if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity, mask))
        {
            //place instance of object at place hit
            placeableObject.position = hitInfo.point + new Vector3(0, 0.5f, 0);

            //roatate on upward facing direction
            placeableObject.rotation = Quaternion.FromToRotation(Vector3.up, hitInfo.normal);
            if (Input.GetButtonDown("Fire1"))
            {

                // Adds cylinder
                placeableObject = Instantiate(placeableObject, placeableObject.position, placeableObject.rotation);
            }
            else if (Input.GetButtonDown("Fire2"))
            {

               placeableObject= Instantiate(placeableObject);
            }


        }
      
    }
}
