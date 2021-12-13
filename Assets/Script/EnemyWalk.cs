using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWalk : MonoBehaviour
{
    public float spd = 2;
    public bool movee;
    SpriteRenderer sprites;
    GameObject players;
    public int attck = 10;

    PlayerHealth daramc;


    // Update is called once per frame
    void Start()
    {
        sprites = GetComponent<SpriteRenderer>();
        players = GameObject.FindGameObjectWithTag("Player");
        daramc = players.GetComponent<PlayerHealth>();
    }
    void Update()
    {
        if (movee)
        {
            transform.Translate(2 * Time.deltaTime * spd, 0, 0);
            sprites.flipX = true;
        }
        else
        {
            transform.Translate(-2 * Time.deltaTime * spd, 0, 0);
            sprites.flipX = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Batas"))
        {
            if (movee)
            {
                movee = false;
            }
            else
            {
                movee = true;
            }
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                if (daramc.currentHealth > 0)
                {
                    daramc.TakeDamage(attck);
                }
            }
        }
    }

}
