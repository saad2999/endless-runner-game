using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public player players;
    public GameObject Oprefab;
    Vector3 spwanpos = new Vector3(18f, -7, -5.5f);
    int spawned = 0;
    // Start is called before the first frame update
    void Start()
    {
        players = FindObjectOfType<player>();
       
            InvokeRepeating(nameof(obstaclespawn), 2, 7);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void obstaclespawn()
    {
        if (!players.isgameover)
        {
            spawned++;
            Instantiate(Oprefab, spwanpos, Oprefab.transform.rotation);
            Debug.Log("spawned objects: " + spawned);
        }
            
    }
}
