using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AkarColli : MonoBehaviour
{
    GameObject players;
    PlayerHealth darahmc;
    // Start is called before the first frame update
    void Start()
    {
        players = GameObject.FindGameObjectWithTag("Player");
        darahmc = players.GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        
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
