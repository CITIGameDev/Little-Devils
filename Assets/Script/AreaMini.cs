using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaMini : MonoBehaviour
{
    MiniBoss mb;
    GameObject mbs;
    AkarObs1 akrs,aks;
    GameObject kars,kars2;

    // Start is called before the first frame update
    void Start()
    {
        mbs =  GameObject.FindGameObjectWithTag("Minibos");
        kars = GameObject.FindGameObjectWithTag("Akar");
        kars2 = GameObject.FindGameObjectWithTag("Akar2");
        mb = mbs.GetComponent<MiniBoss>();
        akrs = kars.GetComponent<AkarObs1>();
        aks = kars2.GetComponent<AkarObs1>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            mb.isdet = true;
            akrs.anims.SetTrigger("Naik");
            aks.anims.SetTrigger("Naik");

        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            mb.isdet = false;
            
        }
    }
}
