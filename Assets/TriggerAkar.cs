using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAkar : MonoBehaviour
{
    // Start is called before the first frame update

    public SpawnerAkar spwn;
    

    private void Start()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            spwn.updatetimer();
        }
            
            
        
    }
}
