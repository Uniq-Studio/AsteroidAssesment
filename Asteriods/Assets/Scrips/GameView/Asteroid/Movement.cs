using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
public Rigidbody2D RandomMovement(int speed, int rotation, Rigidbody2D rb2d)
    {
        // Ranom arount of speed and roation
        rb2d.AddForce(new Vector2(Random.Range(-speed, speed), Random.Range(-speed, speed)));
        rb2d.AddTorque(Random.Range(-rotation, rotation));
        return rb2d;
    }

    //https://www.youtube.com/watch?v=SAp5_Trb3HM&list=PLa5_l08N9jzMKA8gNHG42Mv3idfIkztBU&index=3
}
