using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniAttack : MonoBehaviour
{
    MiniBoss mb;
    GameObject mbs;
    bool isatt;
    bool attnow;
    private float timeat;
    private float cd = 2;

    // Start is called before the first frame update
    void Start()
    {
        mbs = GameObject.FindGameObjectWithTag("Minibos");
        mb = mbs.GetComponent<MiniBoss>();
    }

    // Update is called once per frame
    void Update()
    {
       if (attnow == true)
        {
            attc();
        }
    }
    public void attc()
    {
        if (!isatt)
        {
            timeat += Time.deltaTime;
        }
        if (timeat >= cd)
        {
            isatt = true;
        }
        if (isatt == true)
        {
            isatt = false;
            timeat = 0;
            mb.anims.SetTrigger("Attack");
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            attnow = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            mb.isatt = false;

        }
    }
}
