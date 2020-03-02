using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform player;

    public GameObject bullet;

    [SerializeField] private float amplitude = 0.25f;

    [SerializeField] private float speedBullet = 2;

    private float velocityPlayer = 0;

    
    

    // Update is called once per frame
    void Update()
    {
        velocityPlayer = Input.GetAxis("Horizontal");
        Fire();
    }

    void FixedUpdate()
    {
        MovePlayer(new Vector3(velocityPlayer, 0, 0), player);
    }

    void MovePlayer(Vector3 direction, Transform player)
    {
        player.Translate(direction * amplitude);
    }

    void Fire()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject instBullet = Instantiate(bullet, player.transform.position, Quaternion.identity) as GameObject;
            Rigidbody instBulletRigidBody = instBullet.GetComponent<Rigidbody>();
            instBulletRigidBody.AddForce(transform.up * speedBullet);
        }
    }

}

