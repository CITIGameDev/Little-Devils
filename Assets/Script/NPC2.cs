using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC2 : MonoBehaviour
{
    public DialogTrigger1 dg;
    PlayerHealth ph;
    AttackPoint at;
    GameObject ply;
    GameObject atp;
    // Start is called before the first frame update
    void Start()
    {
        atp = GameObject.FindGameObjectWithTag("htp");
        ply = GameObject.FindGameObjectWithTag("Player");
        ph = ply.GetComponent<PlayerHealth>();
        at = atp.GetComponent<AttackPoint>();
        dg = GetComponent<DialogTrigger1>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            dg.StartDialog();
        }
    }
}
