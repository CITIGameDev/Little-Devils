using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniBoss : MonoBehaviour
{
    Transform player;
    GameObject mcs;
    public Animator anims;
    PlayerHealth darahmcc;
    Rigidbody2D rb;
    public float spd = 3f;
    public float attackrang = 3f;
    public bool isdet;
    public bool isatt;
    private float cd = 4;
    private float timeat;
    // Start is called before the first frame update
    void Start()
    {
        anims = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        rb = GetComponent<Rigidbody2D>();
        mcs = GameObject.FindGameObjectWithTag("Player");
        darahmcc = mcs.GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isdet == true)
        {
            maju();
        }
        else
        {
            anims.SetBool("IsRun", false);
        }
        
        looks();
        
    }
    
    public void looks()
    {
        Vector3 scale = transform.localScale;
        scale.x = player.transform.position.x < transform.position.x ? -1f : 1f;
        transform.localScale = scale;
    }

    public void maju()
    {
        anims.SetBool("IsRun", true);
        Vector2 target = new Vector2(player.position.x, rb.position.y);
        Vector2 newpos = Vector2.MoveTowards(rb.position, target, spd * Time.fixedDeltaTime);
        rb.MovePosition(newpos);

        
        
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (darahmcc.currentHealth > 0)
            {
                darahmcc.TakeDamage(10);
            }

        }
    }

}
