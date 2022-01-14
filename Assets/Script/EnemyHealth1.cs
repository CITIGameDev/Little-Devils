using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth1 : MonoBehaviour
{
    public int startingHealth = 40;
    public int currentHealth;


    EnemyWalk ew1;
    public Animator anim;
    AudioSource playerAudio;
    bool isDead;
    bool damaged;
    Akars kars;
    public GameObject partic;

    void Awake()
    {
        //get reference component
        anim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
        currentHealth = startingHealth;
        kars = GetComponent<Akars>();
        
        
    }


    void Update()
    {
        //jika mendapatkan Damage
        if (damaged)
        {
            //Merubah warna gambar menjadi value dari flashColour

            anim.SetBool("IsHurtss", true);
        }
        else
        {
            //Fade out damage image
            
            anim.SetBool("IsHurtss", false);
        }
        if (currentHealth <= 0)
        {
        
            
            Death();
            
        }
        //Set damage to false
        damaged = false;

    }

    //fungsi untuk mendapatkan damage
    public void TakeDamage(int amount)
    {
        damaged = true;

        //mengurangi health
        currentHealth -= amount;

        //Merubah tampilan dari health slider



        //Memainkan suara ketika terkena damage

    }

    public void Death()
    {
        isDead = true;
        Instantiate(partic, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
        
        
    }


}
