using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPoint : MonoBehaviour
{
    EnemyHealth ehh,eh5, eh6, eh7, eh8, eh9, eh10, eh11, eh12,  eh14, eh15, eh16, eh17,eh18,eh19,eh20,eh21;
    PokeHealth ah,poke8,poke11,poke17,poke20,poke22,poke23,poke24,poke25,poke26,poke27;
    EnemyHealth1 eh1,eh2,eh3;
    EnemyHealth2 eh13;
    MiniHealth mh1;
    GameObject mh;
    GameObject ehh1;
    public int attackDamage = 20;
    GameObject enemysz;
    DewaHealth dh;
    GameObject dewas;
    GameObject enms;
    public float timer;
    GameObject em5, em6, em7, em8, em9, em10, em11, em12, em13, em14, em15, em16, em17, em18, em19, em20, em21, em22, em23, em24, em25, em26, em27, em28, em29, em30, em31, em32, em33;    // Start is called before the first frame update
    void Start()
    {
        enemysz = GameObject.FindGameObjectWithTag("Enemy3");
        enms = GameObject.FindGameObjectWithTag("Enemy2");
        ehh1 = GameObject.FindGameObjectWithTag("Enemy4");
        mh = GameObject.FindGameObjectWithTag("Minibos");
        dewas = GameObject.FindGameObjectWithTag("Boss");
        em5 = GameObject.FindGameObjectWithTag("Enemy5");
        em6 = GameObject.FindGameObjectWithTag("Enemy6");
        em7 = GameObject.FindGameObjectWithTag("Enemy7");
        em8 = GameObject.FindGameObjectWithTag("Enemy8");
        em9 = GameObject.FindGameObjectWithTag("Enemy9");
        em10 = GameObject.FindGameObjectWithTag("Enemy10");
        em11 = GameObject.FindGameObjectWithTag("Enemy11");
        em12 = GameObject.FindGameObjectWithTag("Enemy12");
        em13 = GameObject.FindGameObjectWithTag("Enemy13");
        em14 = GameObject.FindGameObjectWithTag("Enemy14");
        em15 = GameObject.FindGameObjectWithTag("Enemy15");
        em16 = GameObject.FindGameObjectWithTag("Enemy16");
        em17 = GameObject.FindGameObjectWithTag("Enemy17");
        em18 = GameObject.FindGameObjectWithTag("Enemy18");
        em19 = GameObject.FindGameObjectWithTag("Enemy19");
        em20 = GameObject.FindGameObjectWithTag("Enemy20");
        em21 = GameObject.FindGameObjectWithTag("Enemy21");
        em22 = GameObject.FindGameObjectWithTag("Enemy22");
        em23 = GameObject.FindGameObjectWithTag("Enemy23");
        em24 = GameObject.FindGameObjectWithTag("Enemy24");
        em25 = GameObject.FindGameObjectWithTag("Enemy25");
        em26 = GameObject.FindGameObjectWithTag("Enemy26");
        em27 = GameObject.FindGameObjectWithTag("Enemy27");
        em28 = GameObject.FindGameObjectWithTag("Enemy28");
        em29 = GameObject.FindGameObjectWithTag("Enemy29");
        em30 = GameObject.FindGameObjectWithTag("Enemy30");
        em31 = GameObject.FindGameObjectWithTag("Enemy31");
        em32 = GameObject.FindGameObjectWithTag("Enemy32");
        em33 = GameObject.FindGameObjectWithTag("Enemy33");
        dh = dewas.GetComponent<DewaHealth>();
        mh1 = mh.GetComponent<MiniHealth>();
        ehh = enemysz.GetComponent<EnemyHealth>();
        eh5 = em5.GetComponent<EnemyHealth>();
        eh6 = em6.GetComponent<EnemyHealth>();
        eh7 = em7.GetComponent<EnemyHealth>();
        eh8 = em9.GetComponent<EnemyHealth>();
        eh9 = em10.GetComponent<EnemyHealth>();
        eh10 = em12.GetComponent<EnemyHealth>();
        eh11 = em13.GetComponent<EnemyHealth>();
        eh12 = em14.GetComponent<EnemyHealth>();
        eh13 = em15.GetComponent<EnemyHealth2>();
        eh14 = em16.GetComponent<EnemyHealth>();
        eh15 = em18.GetComponent<EnemyHealth>();
        eh16 = em19.GetComponent<EnemyHealth>();
        eh17 = em29.GetComponent<EnemyHealth>();
        eh18 = em30.GetComponent<EnemyHealth>();
        eh19 = em31.GetComponent<EnemyHealth>();
        eh20 = em32.GetComponent<EnemyHealth>();
        eh21 = em33.GetComponent<EnemyHealth>();
        eh1 = ehh1.GetComponent<EnemyHealth1>();
        eh2 = em21.GetComponent<EnemyHealth1>();
        eh3 = em28.GetComponent<EnemyHealth1>();
        ah = enms.GetComponent<PokeHealth>();
        poke8 = em8.GetComponent<PokeHealth>();
        poke11 = em11.GetComponent<PokeHealth>();
        poke17 = em17.GetComponent<PokeHealth>();
        poke20 = em20.GetComponent<PokeHealth>();
        poke22 = em22.GetComponent<PokeHealth>();
        poke23 = em23.GetComponent<PokeHealth>();
        poke24 = em24.GetComponent<PokeHealth>();
        poke25 = em25.GetComponent<PokeHealth>();
        poke26 = em26.GetComponent<PokeHealth>();
        poke27 = em27.GetComponent<PokeHealth>();
        
    }

    // Update is called once per frame
    void Update()
    {



    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        
        
        if (collision.gameObject.CompareTag("Enemy2"))
        {
            if (ah.currentHealth > 0)
            {
                ah.TakeDamage(attackDamage);
            }

        }
        else if (collision.gameObject.CompareTag("hitbox"))
        {
            if (ehh.currentHealth > 0)
            {
                ehh.TakeDamage(attackDamage);
            }
        }
        else if (collision.gameObject.CompareTag("hitbox1"))
        {
            if (eh5.currentHealth > 0)
            {
                eh5.TakeDamage(attackDamage);
            }
        }
        else if (collision.gameObject.CompareTag("hitbox2"))
        {
            if (eh6.currentHealth > 0)
            {
                eh6.TakeDamage(attackDamage);
            }
        }
        else if (collision.gameObject.CompareTag("hitbox3"))
        {
            if (eh7.currentHealth > 0)
            {
                eh7.TakeDamage(attackDamage);
            }
        }
        else if (collision.gameObject.CompareTag("hitbox4"))
        {
            if (eh8.currentHealth > 0)
            {
                eh8.TakeDamage(attackDamage);
            }
        }
        else if (collision.gameObject.CompareTag("hitbox5"))
        {
            if (eh9.currentHealth > 0)
            {
                eh9.TakeDamage(attackDamage);
            }
        }
        else if (collision.gameObject.CompareTag("hitbox6"))
        {
            if (eh10.currentHealth > 0)
            {
                eh10.TakeDamage(attackDamage);
            }
        }
        else if (collision.gameObject.CompareTag("hitbox7"))
        {
            if (eh11.currentHealth > 0)
            {
                eh11.TakeDamage(attackDamage);
            }
        }
        else if (collision.gameObject.CompareTag("hitbox8"))
        {
            if (eh12.currentHealth > 0)
            {
                eh12.TakeDamage(attackDamage);
            }
        }
        else if (collision.gameObject.CompareTag("hitbox9"))
        {
            if (eh13.currentHealth > 0)
            {
                eh13.TakeDamage(attackDamage);
            }
        }
        
        else if (collision.gameObject.CompareTag("hitbox10"))
        {
            if (eh14.currentHealth > 0)
            {
                eh14.TakeDamage(attackDamage);
            }
        }
        else if (collision.gameObject.CompareTag("hitbox11"))
        {
            if (eh15.currentHealth > 0)
            {
                eh15.TakeDamage(attackDamage);
            }
        }
        else if (collision.gameObject.CompareTag("hitbox12"))
        {
            if (eh16.currentHealth > 0)
            {
                eh16.TakeDamage(attackDamage);
            }
        }
        else if (collision.gameObject.CompareTag("hitbox13"))
        {
            if (eh17.currentHealth > 0)
            {
                eh17.TakeDamage(attackDamage);
            }
        }
        else if (collision.gameObject.CompareTag("hitbox14"))
        {
            if (eh18.currentHealth > 0)
            {
                eh18.TakeDamage(attackDamage);
            }
        }
        else if (collision.gameObject.CompareTag("hitbox15"))
        {
            if (eh19.currentHealth > 0)
            {
                eh19.TakeDamage(attackDamage);
            }
        }
        else if (collision.gameObject.CompareTag("hitbox16"))
        {
            if (eh20.currentHealth > 0)
            {
                eh20.TakeDamage(attackDamage);
            }
        }
        else if (collision.gameObject.CompareTag("hitbox17"))
        {
            if (eh21.currentHealth > 0)
            {
                eh21.TakeDamage(attackDamage);
            }
        }
        
        else if (collision.gameObject.CompareTag("Enemy8"))
        {
            if (poke8.currentHealth > 0)
            {
                poke8.TakeDamage(attackDamage);
            }
        }
        else if (collision.gameObject.CompareTag("Enemy11"))
        {
            if (poke11.currentHealth > 0)
            {
                poke11.TakeDamage(attackDamage);
            }
        }
        else if (collision.gameObject.CompareTag("Enemy17"))
        {
            if (poke17.currentHealth > 0)
            {
                poke17.TakeDamage(attackDamage);
            }
        }
        else if (collision.gameObject.CompareTag("Enemy20"))
        {
            if (poke20.currentHealth > 0)
            {
                poke20.TakeDamage(attackDamage);
            }
        }
        else if (collision.gameObject.CompareTag("Enemy22"))
        {
            if (poke22.currentHealth > 0)
            {
                poke22.TakeDamage(attackDamage);
            }
        }
        else if (collision.gameObject.CompareTag("Enemy23"))
        {
            if (poke23.currentHealth > 0)
            {
                poke23.TakeDamage(attackDamage);
            }
        }
        else if (collision.gameObject.CompareTag("Enemy24"))
        {
            if (poke24.currentHealth > 0)
            {
                poke24.TakeDamage(attackDamage);
            }
        }
        else if (collision.gameObject.CompareTag("Enemy25"))
        {
            if (poke25.currentHealth > 0)
            {
                poke25.TakeDamage(attackDamage);
            }
        }
        else if (collision.gameObject.CompareTag("Enemy26"))
        {
            if (poke26.currentHealth > 0)
            {
                poke26.TakeDamage(attackDamage);
            }
        }
        else if (collision.gameObject.CompareTag("Enemy27"))
        {
            if (poke27.currentHealth > 0)
            {
                poke27.TakeDamage(attackDamage);
            }
        }
        else if (collision.gameObject.CompareTag("box"))
        {
            if (eh1.currentHealth > 0)
            {
                eh1.TakeDamage(attackDamage);
            }
        }
        else if (collision.gameObject.CompareTag("box2"))
        {
            if (eh2.currentHealth > 0)
            {
                eh2.TakeDamage(attackDamage);
            }
        }
        else if (collision.gameObject.CompareTag("box3"))
        {
            if (eh3.currentHealth > 0)
            {
                eh3.TakeDamage(attackDamage);
            }
        }
        else if (collision.gameObject.CompareTag("Minibox"))
        {
            if (mh1.currentHealth > 0)
            {
                mh1.TakeDamage(attackDamage);
            }
        }
        else if (collision.gameObject.CompareTag("boxdewa"))
        {
            if (dh.currentHealth > 0)
            {
                dh.TakeDamage(attackDamage);
            }
        }
    }
}