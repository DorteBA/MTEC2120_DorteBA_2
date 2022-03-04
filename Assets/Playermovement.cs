using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public Rigidbody rb;

    public float fowardForce = 2000f;
    public float sidewaysForce = 500f;
 

    // We marked this as "Fixed" Update because we
    // are using it to mess with physics.
    void FixedUpdate()
    {
        // Add a forward force
        rb.AddForce(0, 0, fowardForce * Time.deltaTime); 

        if (Input.GetKey("d"))
        {
            // Only executed if conditon is met
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }
          if (Input.GetKey("a"))
        {
            // Only executed if conditon is met
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}
