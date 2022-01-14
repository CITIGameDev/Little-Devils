using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAkar : MonoBehaviour
{
    GameObject bs;
    DewaHealth dh;
    Dewa dw;
    bool isatt;
    bool attnow;
    bool cantt;
    private float timeat;
    private float cd = 2;
    // Start is called before the first frame update
    void Start()
    {
        bs = GameObject.FindGameObjectWithTag("Boss");
        dh = bs.GetComponent<DewaHealth>();
        dw = bs.GetComponent<Dewa>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            dw.isdal1 = true;
            
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            dw.isdal1 = false;
        }
    }
}
