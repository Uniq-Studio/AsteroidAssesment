using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOBullet : MonoBehaviour
{
    #region Variables
    //Create Variables to hold speed and time till despawn
    public float speed;
    float step;
    public float despawnTime = 10f;
    //Create a Variable to hold the bullet Prefab
    public Rigidbody2D bullet;
    public Transform player;
    UFO ufo;

    //Link the point script
    private Points pointsScript;

    //Add the points and gamage
    public int damage = 25;
    public int points = 7;
    #endregion

    #region Start
    void Start()
    {
        pointsScript = FindObjectOfType<Points>();
        ufo = FindObjectOfType<UFO>();
        //TODO (3): Move the bullet up of the ship times it by speed
        transform.position = Vector3.MoveTowards(transform.position, player.position, step);
    }
    #endregion

    #region Update
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, player.position, step);
        //TODO (4): Despawn after a while
        despawnTime -= Time.deltaTime;
        if (despawnTime <= 0f)
        {
            //TODO (5): Despawn Bullet
            Destroy(gameObject);
            ufo.BulletDead();
        }
    }
    #endregion

    #region Collision Detect
    //TODO (6): Check if bullet collided
    void OnTriggerEnter2D(Collider2D collider2D)
    {
        //Checks if this collied with the id
        if (collider2D.CompareTag("Player"))
        {
            //Run meathod of taking value from users life
            collider2D.GetComponent<Health>().AsteroidDamage(damage);
            //TODO (7): Remove bullet
            Destroy(gameObject);
            ufo.BulletDead();
        }
        if (collider2D.CompareTag("Bullet"))
        {
            //Call meathod to add points passing though value of points earnt
            pointsScript.AddPoint(points);
            Destroy(gameObject);
            ufo.BulletDead();
        }

    }
    #endregion
}
