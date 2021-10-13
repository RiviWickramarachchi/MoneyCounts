using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cash_counter_actions : MonoBehaviour
{

    public int total = 0;
    GameObject objSpawner;  
    
    
    



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Note")
        {
            Debug.Log("Hit");
            total = total + collision.GetComponent<note>().noteVal;
            objSpawner = GameObject.FindGameObjectWithTag("Player");
            print(objSpawner.GetComponent<note_spawner>().getNoteCount());
            print(total);
            
        }
       
    }
    
   
}
