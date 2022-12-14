using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parrent : MonoBehaviour
{
    player Player;
    
    // Start is called before the first frame update
    void Start()
    {
        Player = FindObjectOfType<player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Player.scores++;

        }
    }
}
