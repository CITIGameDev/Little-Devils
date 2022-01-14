using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon : MonoBehaviour, ICollisionHandler
{
    [SerializeField]
    private Animator animator;

    [SerializeField]
    private GameObject bullet;

    [SerializeField]
    private Transform spwn;

    private Transform target;
    GameObject players;
    PlayerHealth darahmc;

    public float cooldown = 10;

    private bool CanAtt = true;

    private float timeatt;

    private void Start()
    {
        players = GameObject.FindGameObjectWithTag("Player");
        darahmc = players.GetComponent<PlayerHealth>();
    }

    private void Update()
    {
        att();
        look();
    }

    public void stopatt()
    {
        animator.SetBool("Attack", false);
    }
        
    public void Shoot()
    {
        GameObject tembak = Instantiate(bullet, spwn.position, Quaternion.identity);
        Vector3 arah = new Vector3(transform.localPosition.x, 0);
        tembak.GetComponent<Projectile>().Setup(arah);
    }

    private void att()
    {
        if (!CanAtt)
        {
            timeatt += Time.deltaTime;
        }
        if(timeatt >= cooldown)
        {
            CanAtt = true;
        }
        if (CanAtt && target != null)
        {
            CanAtt = false;
            timeatt = 0;
            animator.SetBool("Attack", true);
        }
        
        
    }
    private void look()
    {
        if (target != null)
        {
            Vector3 scale = transform.localScale;
            scale.x = target.transform.position.x < transform.position.x ? 0.04f : -0.04f;
            transform.localScale = scale;
        }
    }
    public void CollisionEnter(string colli, GameObject other)
    {
        if (colli == "Damage" && other.CompareTag("Player"))
        {
            //
        }
        if (colli == "Detect" && other.tag == "Player")
        {
          
                this.target = other.transform;
                animator.SetBool("Attack", true);
            
        }

    }

    public void CollisionExit(string colli, GameObject other)
    {
        if (colli == "Detect" && other.tag == "Player")
        {
            this.target = null;
            animator.SetBool("Attack", false);
            
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {   
            if (darahmc.currentHealth > 0)
            {
                darahmc.TakeDamage(10);
            }
        }
    }


}
