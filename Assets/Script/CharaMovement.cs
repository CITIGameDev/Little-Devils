using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaMovement : MonoBehaviour
{
    Animator anim;
    Rigidbody2D rb;
    SpriteRenderer spriteren;
    bool isGround;
    public float spd = 6;
    public int combo;
    public float jmp = 9;
    public bool canatt;
    private Vector3 respawnpo;
    public GameObject fall;
    GameObject plyr;
    GameObject ehe;
    public float dashforce;
    public float startdashtime;
    float currentdashtimer;
    CharaMovement cr;
    float dashdirection;
    bool isdash;
    float movx;
    public UIFlow floww;
    float horizon;
    PlayerHealth ph;
    Zoom zm;
    public AudioSource asz;
    public AudioClip[] acz;
    [SerializeField]
    Transform groundcheck;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        plyr = GameObject.FindGameObjectWithTag("Player");
        ehe = GameObject.FindGameObjectWithTag("Enemy");
        ph = plyr.GetComponent<PlayerHealth>();
        rb = GetComponent<Rigidbody2D>();
        spriteren = GetComponent<SpriteRenderer>();
        respawnpo = transform.position;
        cr = GetComponent<CharaMovement>();
        asz = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (Physics2D.Linecast(transform.position, groundcheck.position, 1 << LayerMask.NameToLayer("Ground")))
        {
            isGround = true;
        }
        else
        {
            isGround = false;
            
        }
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb.velocity = new Vector2(spd, rb.velocity.y);
           
                anim.SetBool("IsWalk", true);

            spriteren.flipX = true;

        }
       
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb.velocity = new Vector2(-spd, rb.velocity.y);

            anim.SetBool("IsWalk", true);
            Vector3 scales = transform.localScale;
            scales.x *= -1;
            transform.localScale = scales;
            spriteren.flipX = false;
        }
      
        else
        {
            anim.SetBool("IsWalk", false);
            rb.velocity = new Vector2(0, rb.velocity.y);
            if (spriteren.flipX == false)
            {
                Vector3 scales = transform.localScale;
                scales.x *= -1;
                transform.localScale = scales;
            }
            
        }
        
        if (Input.GetKey("space") || Input.GetKey("w"))
        {
            if (isGround)
            {
                anim.SetBool("IsJump", true);
                rb.velocity = new Vector2(rb.velocity.x, jmp);
            }
            
            
            
        }
        else
        {
            anim.SetBool("IsJump", false);
        }
        combos();
        skill();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Falls"))
        {

            
            if (ph.currentHealth > 0)
            {
                ph.TakeDamage(10);
            }
            transform.position = respawnpo;
        }
        else if (collision.gameObject.CompareTag("Checkpoint"))
        {
            respawnpo = transform.position;
            
        }
        
        else if (collision.gameObject.CompareTag("End"))
        {
            UIFlow.Instance.winn();
            cr.enabled = false;

        }
        else if (collision.gameObject.CompareTag("areamini"))
        {
            if (ph.currentHealth > 0)
            {
                ph.damaged = false;
            }

        }


    }
    public void combos()
    {
        if (Input.GetKey("q") && !canatt)
        {
            canatt = true;
            anim.SetTrigger("" + combo);
            asz.clip = acz[combo];
            asz.Play();
            anim.SetBool("CanAtt", true);
        }
    }

    public void skill()
    {
        if (Input.GetKey("e") && !canatt)
        {
            canatt = true;
            anim.SetTrigger("2");
        }
    }
    public void startcombos()
    {
        canatt = false;
        if (combo < 1)
        {
            combo++;
        }
    }
    public void finishcombo()
    {
        canatt = false;
        combo = 0;
        anim.SetBool("CanAtt", false);
    }

}
