using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC1 : MonoBehaviour
{
    PlayerHealth ph;
    GameObject ply;
    public DialogTrigger dgtrigger;
    public DialogManager dgmanag;
    public GameObject partic;
    // Start is called before the first frame update
    void Start()
    {
        ply = GameObject.FindGameObjectWithTag("Player");
        ph = ply.GetComponent<PlayerHealth>();
        dgtrigger = GetComponent<DialogTrigger>();
        dgmanag = GetComponent<DialogManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            dgtrigger.StartDialog();
        }
    }
}
