using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int startingHealth = 100;
    public int currentHealth;
    public Slider healthSlider;
    public Image damageImage;
    public float flashSpeed = 5f;
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f);

    CharaMovement cm;
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
        cm = GetComponent<CharaMovement>();
    }


    void Update()
    {
        //jika mendapatkan Damage
        if (damaged)
        {
            //Merubah warna gambar menjadi value dari flashColour
            damageImage.color = flashColour;

            anim.SetBool("IsHurt", true);
        }
        else
        {
            //Fade out damage image
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
            anim.SetBool("IsHurt", false);
        }
        if (currentHealth <= 0)
        {
            anim.SetBool("IsDead", true);
            UIFlow.Instance.GameOver();
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
        healthSlider.value = currentHealth;

        

        //Memainkan suara ketika terkena damage

    }

    public void Death()
    {
        isDead = true;
        cm.enabled = false;
    }


}
