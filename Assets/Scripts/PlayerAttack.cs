using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    GameObject enemy;

    void Awake()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy");
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.GetType() == typeof(CapsuleCollider))
        {
            Debug.Log("degdi");
            Destroy(enemy);
        }
    }

}
