using UnityEngine;

public class ForLarge : MonoBehaviour
{
    //TODO (3): Specify damage
    public int damage = 25;
    public int points = 5;
    public GameObject medium;
    public Rigidbody2D rb2d;

    private Points pointsScript;
    void Start()
    {
        // Ranom arount of speed and roation
        rb2d.AddForce(new Vector2(Random.Range(-50, 50), Random.Range(-50, 50)));
        rb2d.AddTorque(Random.Range(-50, 50));
        pointsScript = FindObjectOfType<Points>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    #region Collision Detect
    //TODO (1): Import Collision Detection
    //Check if bullet collided
    void OnTriggerEnter2D(Collider2D collider2D)
    {
        
        //Checks if this collied with the id
        if (collider2D.CompareTag("Bullet"))
        {
            //This will get removed from game space
            Destroy(gameObject);
            for (int i = 0; i < 2; i++)
            {
                Instantiate(medium, transform.position, transform.rotation);
            }
            pointsScript.AddPoint(points);
        }
        //TODO (2): Create the same but with player and call meathod of damage through player script
        if (collider2D.CompareTag("Player"))
        {
            collider2D.GetComponent<Health>().AsteroidDamage(damage);
        }
    }
    #endregion

}
#region Resources
//RESOURCES USED: 
//TITLE: 
//URL: 
#endregion

#region Code Details
/*
 * CODE CREATED: 	Aaron Hamilton – 07/02/2021
 * COMMENTED:		Aaron Hamilton – 07/02/2021
 * COMPLETION:		Aaron Hamilton – 07/02/2021
 * DEBUGED ON:		Aaron Hamilton – 07/02/2021
 * SPELLING CHECK:	Aaron Hamilton – 07/02/2021
 **/
#endregion