using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cash_counter_actions : MonoBehaviour
{

    public int total = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Note")
        {
            Debug.Log("Hit");
            total = total + collision.GetComponent<note>().noteVal;
            print(total);
        }
       
    }
}
