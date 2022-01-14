using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dewa : MonoBehaviour
{
    [SerializeField]
    public Animator animator;
    Rigidbody2D rb;
    [SerializeField]
    public GameObject ef1;
    public GameObject ef2;
    private GameObject ef3;

    [SerializeField]
    public Transform spwn;
    public Transform spwn1;
    [SerializeField]
    public Transform spwn2;


   private Transform target;
    GameObject players;
    PlayerHealth darahmca;
    DewaHealth dh1;
    GameObject dws;
    public bool isatt;
    public bool attnow;
    public bool cantt;
    private float timeat;
    public float cd = 10;
    public float cdd = 20;
    public bool isdal1;
    public bool isdal2;
    public float timespwn;
    private float currspwn;
    private void Start()
    {
        players = GameObject.FindGameObjectWithTag("Player");
        darahmca = players.GetComponent<PlayerHealth>();
        dws = GameObject.FindGameObjectWithTag("Boss");
        dh1 = dws.GetComponent<DewaHealth>();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (cantt == true)
        {
            attc1();
        }
        if (isdal1 == true)
        {
           
            attc4();
        }
        look();
    }

    public void attc1()
    {
        if (!isatt)
        {
            timeat += Time.deltaTime;
        }
        if (timeat >= cd)
        {
            isatt = true;
        }
        if (isatt == true)
        {
            isatt = false;
            timeat = 0;
           animator.SetTrigger("Attack1");
        }
    }

    public void attc2()
    {
        if (!isatt)
        {
            timeat += Time.deltaTime;
        }
        if (timeat >= cd)
        {
            isatt = true;
        }
        if (isatt == true)
        {
            isatt = false;
            timeat = 0;
           animator.SetTrigger("Attack2");
        }
    }

    public void attc3()
    {
        if (!isatt)
        {
            timeat += Time.deltaTime;
        }
        if (timeat >= cd)
        {
            isatt = true;
        }
        if (isatt == true)
        {
            isatt = false;
            timeat = 0;
            animator.SetTrigger("Attack3");
            
        }
    }
    public void attc4()
    {
        if (currspwn > 0)
        {
            currspwn -= Time.deltaTime;
        }
        else
        {
            Instantiate(ef2, spwn1.position, Quaternion.identity);

            currspwn = timespwn;





        }
    }
    public void fx1()
    {
        GameObject tembak = Instantiate(ef1, spwn.position, Quaternion.identity);
        Vector3 arah = new Vector3(transform.localPosition.x, 0);
        tembak.GetComponent<Fx1>().Setup(arah);
    }

    

    public void fx3()
    {
        GameObject tembak = Instantiate(ef3, spwn2.position, Quaternion.identity);
        Vector3 arah = new Vector3(transform.localPosition.x, 0);
        tembak.GetComponent<Projectile>().Setup(arah);
    }
    


    private void look()
    {
        if (target != null)
        {
            Vector3 scale = transform.localScale;
            scale.x = target.transform.position.x < transform.position.x ? 0.4f : -0.4f;
            transform.localScale = scale;
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (darahmca.currentHealth > 0)
            {
                darahmca.TakeDamage(10);
            }

        }
    }
}
