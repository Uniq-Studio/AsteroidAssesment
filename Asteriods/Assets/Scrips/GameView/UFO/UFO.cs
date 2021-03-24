using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFO : MonoBehaviour
{
    //Specify damage and points
    public int damage = 15;
    public int points = 5;
    public GameObject ufo;
    public Rigidbody2D rb2d;
    public GameObject Bullet;

    private Points pointsScript;
    private SpawnIn setToDead;

    bool bulletAlive;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Movement());
        pointsScript = FindObjectOfType<Points>();
        setToDead = FindObjectOfType<SpawnIn>();

    }

    private void Update()
    {
        if (bulletAlive == false)
        {
            Instantiate(Bullet, rb2d.transform.position, rb2d.transform.rotation);
            bulletAlive = true;
        }
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
                //Call meathod to add points passing though value of points earnt
                pointsScript.AddPoint(points);
                setToDead.UFODead();
            }
            //TODO (2): Create the same but with player and call meathod of damage through player script
            if (collider2D.CompareTag("Player"))
            {
                //Run meathod of taking value from users life
                collider2D.GetComponent<Health>().AsteroidDamage(damage);
            }


        }
    #endregion

    IEnumerator Movement()
    {
        rb2d.AddForce(new Vector2(Random.Range(-50, 50), Random.Range(-50, 50)));
        yield return new WaitForSeconds(10);
        rb2d.velocity = new Vector2(0, 0);
    }

    public void BulletDead()
    {
        bulletAlive = false;
    }

}

//

#region Resources
//RESOURCES USED: Unity Documentation
//TITLE: Wait For Seconds
//URL: https://docs.unity3d.com/ScriptReference/WaitForSeconds.html
#endregion

#region Code Details
/*
 * CODE CREATED: 	Aaron Hamilton – 19/03/2021
 * COMMENTED:		Aaron Hamilton – 19/03/2021
 * COMPLETION:		Aaron Hamilton – 19/03/2021
 * DEBUGED ON:		Aaron Hamilton – 19/03/2021
 * SPELLING CHECK:	Aaron Hamilton – 19/03/2021
 **/
#endregion
