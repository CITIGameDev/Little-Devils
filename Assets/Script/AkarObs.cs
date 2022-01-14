using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AkarObs : MonoBehaviour
{
    Animator anims;
    GameObject trn;
    bool istrn;
    // Start is called before the first frame update
    void Start()
    {
        anims = GetComponent<Animator>();
        trn = GameObject.FindGameObjectWithTag("Enemy4");
    }

    // Update is called once per frame
    void Update()
    {
        if (trn == null)
        {
            anims.SetTrigger("Turun");
        }
    }
}
