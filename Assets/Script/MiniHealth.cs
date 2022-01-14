using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiniHealth : MonoBehaviour
{
    public int startingHealth = 100;
    public int currentHealth;
    public Slider healthSlider;
    public Image damageImage;
    public Animator anim;
    AudioSource playerAudio;
    bool isDead;
    public GameObject partic;
    bool damaged;
    // Start is called before the first frame update
    void Awake()
    {
        //get reference component
        anim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
        currentHealth = startingHealth;

    }


    void Update()
    {
        //jika mendapatkan Damage
        if (damaged)
        {
            //Merubah warna gambar menjadi value dari flashColour

            anim.SetBool("IsHurty", true);
        }
        else
        {
            //Fade out damage image

            anim.SetBool("IsHurty", false);
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
