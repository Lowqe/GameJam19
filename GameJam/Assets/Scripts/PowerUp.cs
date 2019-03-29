using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
       
        
        if (other.CompareTag("Player"))
        {
            Player player = other.GetComponent<Player>();
            player.AddCake();
            Pickup();
        }
    }

    void Pickup()
    {
        Destroy(this.gameObject);
        Debug.Log("Power up picked up");
    }
}
