using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerAkar : MonoBehaviour
{
    public GameObject spawnnobj;
    public Transform spwns;
    public float timespwn;
    private float currspwn;
    public bool istimer;
    private Transform trget;
    // Start is called before the first frame update
    void Start()
    {

        currspwn = timespwn;
    }

    // Update is called once per frame
    void Update()
    {

        if (istimer == true)
        {
            updatetimer();
        }
    }

    public void updatetimer()
    {
        if (currspwn > 0)
        {
            currspwn -= Time.deltaTime;
        }
        else
        {
            spwnobj();
            
            currspwn = timespwn;
            




        }
    }

    void destroyss()
    {
        Destroy(gameObject); 
    }

    public void spwnobj()
    {
        Instantiate(spawnnobj, spwns.localPosition, spwns.localRotation);
    }

    

    public void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            istimer = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            istimer = false;
        }
    }
}