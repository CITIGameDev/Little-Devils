using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth2 : MonoBehaviour
{
    public int startingHealth = 40;
    public int currentHealth;
    PlayerHealth ph;
    CharaMovement cm;
    GameObject play;
    public GameObject partic;
    EnemyWalk ew1;
    public Animator anim;
    AudioSource playerAudio;
    bool isDead;
    bool damaged;

    void Awake()
    {
        //get reference component
        anim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
        currentHealth = startingHealth;
        play = GameObject.FindGameObjectWithTag("Player");
        ph = play.GetComponent<PlayerHealth>();
        cm = play.GetComponent<CharaMovement>();

    }


    void Update()
    {
        //jika mendapatkan Damage
        if (damaged)
        {
            //Merubah warna gambar menjadi value dari flashColour

            anim.SetBool("IsHurttz", true);
        }
        else
        {
            //Fade out damage image

            anim.SetBool("IsHurttz", false);
        }
        if (currentHealth <= 0)
        {
            cm.spd = 10;
            cm.jmp = 11;
            if(ph.currentHealth > 0)
            {
                if(ph.currentHealth <= 50)
                {
                    ph.TakeHealth(50);
                }
                else
                {
                    ph.TakeHealth(30);
                }
            }

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
