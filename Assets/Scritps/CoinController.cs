using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    float spinSpeed = 1f;
    

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * spinSpeed);  
    }

    private void OnTriggerEnter(Collider other)
    {
        {
            if(other.CompareTag("Player"))
            {
                PlayerCollectable player = other.gameObject.GetComponent<PlayerCollectable>();
                player.coins += 1;
                
            }
        }
    }
}
