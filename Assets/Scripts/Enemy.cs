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

    // Start is called before the first frame update
    void Start()
    {

        enemyLayout();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void enemyLayout()
    {
        GameObject enemyInst;

        if (this.gameObject.name == "Enemy C")
        {
            enemyInst = GameObject.Instantiate(C, parentTransform);
            enemyInst.transform.localPosition = new Vector2(parentTransform.position.x, 0);
        }
    }


}
