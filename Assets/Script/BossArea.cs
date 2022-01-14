using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossArea : MonoBehaviour
{
    GameObject bs;
    DewaHealth dh;
    Dewa dw;
    bool isatt;
    bool attnow;
    bool cantt;
    private float timeat;
    private float cd = 2;
    public AudioClip bossaudio;
  
    private AudioManager ams;
    // Start is called before the first frame update
    void Start()
    {
        bs = GameObject.FindGameObjectWithTag("Boss");
        dh = bs.GetComponent<DewaHealth>();
        dw = bs.GetComponent<Dewa>();
        ams = FindObjectOfType<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (bossaudio != null)
            {
                ams.chgbgm(bossaudio);
            }
            dw.cantt = true;
            UIFlow.Instance.dewa();
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            
            cantt = false;
            UIFlow.Instance.dewas();

        }
    }
}
