using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaMovement : MonoBehaviour
{
    Animator anim;
    Rigidbody2D rb;
    SpriteRenderer spriteren;
    bool isGround;
    private float spd = 6;
    public int combo;
    private float jmp = 9;
    public bool canatt;
    private Vector3 respawnpo;
    public GameObject fall;
    GameObject plyr;
    public float dashforce;
    public float startdashtime;
    float currentdashtimer;
    CharaMovement cr;
    float dashdirection;
    bool isdash;
    float movx;
    public UIFlow floww;
    PlayerHealth ph;
    [SerializeField]
    Transform groundcheck;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        plyr = GameObject.FindGameObjectWithTag("Player");
        ph = plyr.GetComponent<PlayerHealth>();
        rb = GetComponent<Rigidbody2D>();
        spriteren = GetComponent<SpriteRenderer>();
        respawnpo = transform.position;
        cr = GetComponent<CharaMovement>();
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

            spriteren.flipX = false;
        }
      
        else
        {
            anim.SetBool("IsWalk", false);
            rb.velocity = new Vector2(0, rb.velocity.y);
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
            spd = 6;
            jmp = 9;
        }
        else if (collision.gameObject.CompareTag("Cp1"))
        {
            spd = 9;
        }
        else if (collision.gameObject.CompareTag("Cp2"))
        {
            spd = 9;
            jmp = 12;
        }
        else if (collision.gameObject.CompareTag("CpEnd"))
        {
            spd = 7;
            jmp = 8;
        }
        else if (collision.gameObject.CompareTag("End"))
        {
            UIFlow.Instance.winn();
            cr.enabled = false;

        }

    }
    public void combos()
    {
        if (Input.GetKey("q"))
        {
            canatt = true;
            anim.SetTrigger("" + combo);
        }
    }
    public void startcombos()
    {
        canatt = false;
        if (combo < 3)
        {
            combo++;
        }
    }
    public void finishcombo()
    {
        canatt = false;
        combo = 0;
    }

}
