using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCannon : MonoBehaviour
{
  
    // public GameObject Cannon;
    //public Transform cannonShoots;

    public GameObject BallPrefab;
    public LayerMask mask;

    // Update is called once per frame
    void Update()
    {
        //Checks if porjectile hits the enemy using Raycasting
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hitInfo;
        // Creates projectile that fires from cannon when space is pressed
        if (Input.GetButtonDown("Jump"))
        {
            GameObject projectile;

            // Adds projectiles 
            projectile = Instantiate(BallPrefab, transform );

         projectile.GetComponent<Rigidbody>().AddForce(Vector3.left *10f, ForceMode.Impulse);
 
        }

      

        if (Physics.Raycast(ray, out hitInfo, 75f, mask))
        {
            //draw line form input position to when hit
            Debug.DrawLine(transform.position, hitInfo.point, Color.red);
        }
        else
        {
            Debug.DrawLine(ray.origin, ray.origin + ray.direction * 75, Color.green);
        }
    }
}

