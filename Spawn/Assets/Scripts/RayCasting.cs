using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//The object needs to instantiate with some force attached to it to make it fly.  You can either use the transform component or assign a rigidbody to your projectile to move it.  Either way, your script will need to access the component from the instantiated game object (we covered how to do this in class)
//There should be another object in the scene that the projectile can collide with. (Call this script “Enemy”)
//The enemy should take damage (maybe receive a little bit of knockback), record this damage change in the console using Debug.Log and the name of the variable you’re using to calculate health.
public class RayCasting : MonoBehaviour
{
   public GameObject Enemy;
   public LayerMask mask;
    public float health = 4;
    //The enemy should take damage (maybe receive a little bit of knockback),
    //record this damage change in the console using Debug.Log and the name of the variable you’re using to calculate health.
    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
         RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo, 75f, mask))
        {
            //draw line form input position to when hit
            Debug.DrawLine(transform.position, hitInfo.point, Color.red);
            health -= 1;

            if( health <= 0)
            {
                DestroyEnemy();
            }
        }
       else
        {
            Debug.DrawLine(ray.origin,  ray.origin + ray.direction * 75, Color.green);
        }
        void DestroyEnemy()
        {
            Destroy(Enemy);
        }
    }
}
