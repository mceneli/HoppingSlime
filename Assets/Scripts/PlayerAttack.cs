using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject enemy;
    public GameObject player;
    void Awake()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy");
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.GetType() == typeof(CapsuleCollider))
        {
            collision.gameObject.GetComponent<EnemyHealth>().TakeDamage(100);
            player.GetComponent<PlayerHealth>().TakeDamage(-20);
            //ScoreManager.score += 10;
            //Destroy(enemy);
        }
    }

}
