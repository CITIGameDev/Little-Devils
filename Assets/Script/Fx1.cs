using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fx1 : MonoBehaviour
{
    [SerializeField]
    private float spd;
    private Vector2 arah;
    public int attackDamage = 10;
    UIFlow flow;
    GameObject players;
    Rigidbody2D rb;
    private Transform player;

    PlayerHealth darahmc;

    [SerializeField]
    private string tags;

    // Start is called before the first frame update
    // Update is called once per frame
    private void Start()
    {
        players = GameObject.FindGameObjectWithTag("Player");
        player = GameObject.FindGameObjectWithTag("Player").transform;
        darahmc = players.GetComponent<PlayerHealth>();
        rb = GetComponent<Rigidbody2D>();
        arah = new Vector2(player.position.x, rb.position.y);

    }
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, arah, spd * Time.deltaTime);
        if (transform.position.x == arah.x && transform.position.y == arah.y )
        {
            DestroyBullet();

        }





    }

    public void Attack()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (darahmc.currentHealth > 0)
            {
                darahmc.TakeDamage(attackDamage);

            }

        }
    }
    void DestroyBullet()
    {
        Destroy(gameObject);
    }
    public void Setup(Vector2 arah)
    {
        this.arah = arah;



    }



    public void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
