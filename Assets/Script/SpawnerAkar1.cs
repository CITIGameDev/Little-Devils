using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerAkar1 : MonoBehaviour
{
    public GameObject spawnnobj;
    public Transform spwns;
    public float timespwn;
    private float currspwn;
    public bool istimer;
    private Transform trget;
    GameObject karrs;
    // Start is called before the first frame update
    void Start()
    {

        currspwn = timespwn;
        karrs = GameObject.FindGameObjectWithTag("Enemy4");
    }

    // Update is called once per frame
    void Update()
    {

        if (istimer == true)
        {
            updatetimer();
        }
        if (karrs == null)
        {
            Destroy(this.gameObject);
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