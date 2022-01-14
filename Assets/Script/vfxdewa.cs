using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vfxdewa : MonoBehaviour
{
    PlayerHealth darahmc;
    public int attackDamage = 5;
    GameObject playerss;
    public float timer;
    EnemyHealth1 ehee1;
    GameObject akarr;

    // Start is called before the first frame update
    void Start()
    {
        playerss = GameObject.FindGameObjectWithTag("Player");
        darahmc = playerss.GetComponent<PlayerHealth>();
        akarr = GameObject.FindGameObjectWithTag("Boss");
        Destroy(gameObject, 1.3f);
    }

    // Update is called once per frame
    void Update()
    {
        if (akarr == null)
        {
            Destroy(this.gameObject);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (darahmc.currentHealth > 0)
            {
                darahmc.TakeDamage(attackDamage);
            }
        }


    }


    public void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
    void destruts()
    {
        Destroy(this.gameObject);
    }


}
