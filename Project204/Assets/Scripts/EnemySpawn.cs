using System.Collections;
using System.Collections.Generic;
using System.Security;
using System.Security.Principal;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;

    [SerializeField] private float spawnstarttimef;

    [SerializeField] private float spawningdurationf;


    private void Start()
    {
        InvokeRepeating(nameof(Spawn), spawnstarttimef, spawningdurationf);
    }
    void Spawn()
    {
        Instantiate(enemy, transform.position, Quaternion.identity);
    }
}
