using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokeHealth : MonoBehaviour
{
    public int startingHealth = 40;
    public int currentHealth;


    EnemyWalk ew1;
    public Animator anims;
    AudioSource playerAudio;
    bool isDead;
    bool damaged;
    public GameObject partic;

    void Awake()
    {
        //get reference component
        anims = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
        currentHealth = startingHealth;

    }


    void Update()
    {
        //jika mendapatkan Damage
        if (damaged)
        {
            //Merubah warna gambar menjadi value dari flashColour

            anims.SetBool("IsHurts", true);
        }
        else
        {
            //Fade out damage image

            anims.SetBool("IsHurts", false);
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
