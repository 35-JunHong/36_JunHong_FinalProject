using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private Animator enemyAnim;

    private float enemySpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemyAnim.SetBool("enemyRun", true);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            enemyAnim.SetTrigger("trigEnemyDeath");
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
