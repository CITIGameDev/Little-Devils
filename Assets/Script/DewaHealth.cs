using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DewaHealth : MonoBehaviour
{
    public int startingHealth = 500;
    public int currentHealth;
    public Slider healthSlider;
    public Image damageImage;
    public Animator anim;
    GameObject ply;
    CharaMovement crs;
    public GameObject partic;
    public DialogTrigger2 dg2;
    GameObject dgdw;
    Dewa dw;
    DialogManager2 dg22;

    public AudioClip bgover;
    AudioManager1 amr;
    AudioSource playerAudio;
    public bool isDead;
    bool damaged;
    // Start is called before the first frame update
    void Start()
    {
        //get reference component
        anim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
        currentHealth = startingHealth;
        ply = GameObject.FindGameObjectWithTag("Player");
        crs = ply.GetComponent<CharaMovement>();
        dgdw = GameObject.FindGameObjectWithTag("DwDiag");
        amr = FindObjectOfType<AudioManager1>();
        dw = GetComponent<Dewa>();
        

    }


    void Update()
    {
        //jika mendapatkan Damage
        if (damaged)
        {
            //Merubah warna gambar menjadi value dari flashColour

            anim.SetBool("IsHurtsz", true);
        }
        else
        {
            //Fade out damage image

            anim.SetBool("IsHurtsz", false);
        }
        if (currentHealth <= 0)
        {

            if (bgover != null)
            {
                amr.chgbgm(bgover);
            }
            Death();
                
            SceneManager.LoadScene("Outro");

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

        healthSlider.value = currentHealth;

        //Merubah tampilan dari health slider




        //Memainkan suara ketika terkena damage

    }

    public void Death()
    {
        isDead = true;
        UIFlow.Instance.dewas();

        crs.enabled = false;
        dw.enabled = false;
        Instantiate(partic, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
        
        

    }
}
