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
    public GameObject CylinderPrefab;




    public void Awake()
    {
        cam = FindObjectOfType<Camera>();
    } 
    // Update is called once per frame
    void Update()
    {
        //creates ray at point where mouse is, looking through camera
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);

        //
        RaycastHit hitInfo;

        //if Raycast hits something
        if(Physics.Raycast(ray, out hitInfo,Mathf.Infinity, mask))
        {
            //place instance of object at place hit
            placeableObject.position = hitInfo.point + new Vector3(0, 0.5f, 0);

            //roatate on upward facing direction
            placeableObject.rotation = Quaternion.FromToRotation(Vector3.up, hitInfo.normal);

            // when you left click with your mouse, the object will be placed at its location and stay there, 
            if (Input.GetButtonDown("Fire1"))
            {

               // GameObject cyl;
               // cyl = Instantiate(CylinderPrefab, transform);

              
                // Instantiate at position (0, 0, 0) and zero rotation.
               // Instantiate(CylinderPrefab, new Vector3(0, 0.5f, 0), placeableObject.rotation);
            }
            //right clicking will instantiate a new object that you can place.
           // else if (Input.GetButtonDown("Fire2"))
           // {
                //CylinderPrefab

             
           // }
        
        }
      
    }
}
