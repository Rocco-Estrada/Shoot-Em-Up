using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject A;
    public GameObject B;
    public GameObject C;
    public GameObject D;

    public Transform parentTransform;

    private int numEnemy = 11;
    private int row = 4;

    public ScoreManager score;


    // Start is called before the first frame update
    void Start()
    {
        score = gameObject.AddComponent<ScoreManager>();
        InstantiateEnemyRow();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void InstantiateEnemyRow()
    {
        GameObject enemyInst;
        GameObject enemyType;
        for(int j = 0; j < row; j++)
        {
            for (int i = 0; i < numEnemy; i++)
            {
                if(j == 0) { enemyType = C; }
                else if(j > 0 && j < 3) { enemyType = B; }
                else if(j > 2 && j < 5) { enemyType = A; }
                else { enemyType = D; }
                enemyInst = GameObject.Instantiate(enemyType, parentTransform);
                enemyInst.transform.localPosition = new Vector2(i + 1, -j);
            }
        }   
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            score.Update(name);
           
        }
    }

}