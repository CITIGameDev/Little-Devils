using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AkarObs1 : MonoBehaviour
{
    public Animator anims;
    public GameObject trn;
    public bool istrn;
    // Start is called before the first frame update
    void Start()
    {
        anims = GetComponent<Animator>();
        trn = GameObject.FindGameObjectWithTag("Minibos");
    }

    // Update is called once per frame
    void Update()
    {
        if (trn == null)
        {
            anims.SetTrigger("Turun");
        }
        if (istrn == true)
        {
            anims.SetTrigger("Naik");
        }
    }
}
