using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //public GameObject ballPrefab;
    public GameObject Cannon;

   public GameObject DicePrefab;
    //The object needs to instantiate with some force attached to it to make it fly.You can either use the transform component or assign a rigidbody to your projectile to move it.  Either way, your script will need to access the component from the instantiated game object (we covered how to do this in class)

    // Update is called once per frame
void Update()
    {
       /** if(Input.GetButtonDown("Jump"))

        {

            GameObject ball;
            Rigidbody rb;

            //adds a ball prefab at current poition of spawner
            ball = Instantiate(ballPrefab, transform);

            rb = ball.GetComponent<Rigidbody>();

            rb.AddForce(Vector3.up * 10f, ForceMode.Impulse);
        } **/

        if(Input.GetKey(KeyCode.E))
        {
            GameObject Dice;

            Rigidbody rb;

            // Adds Dice at 
            Dice = Instantiate(DicePrefab, Cannon.transform);

            rb = Dice.GetComponent<Rigidbody>();

            rb.AddForce(Vector3.forward * 10f, ForceMode.Force);
        }
    }
}
