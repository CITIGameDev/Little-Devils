using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int startingHealth = 40;
    public int currentHealth;


    EnemyWalk ew1;
    public Animator anim;
    AudioSource playerAudio;
    bool isDead;
    public GameObject partic;
    bool damaged;
    public AudioClip bgover;
    AudioManager1 amr;

    void Awake()
    {
        //get reference component
        anim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
        currentHealth = startingHealth;
        amr = FindObjectOfType<AudioManager1>();
    }


    void Update()
    {
        //jika mendapatkan Damage
        if (damaged)
        {
            //Merubah warna gambar menjadi value dari flashColour

            anim.SetBool("IsHurts", true);
        }
        else
        {
            //Fade out damage image
            
            anim.SetBool("IsHurts", false);
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
