using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager1 : MonoBehaviour
{
    public Image actorimage;
    public Text actorname;
    public Text msgtext;
    public RectTransform bgbox;
    public GameObject partic;
    PlayerHealth phh;
    CharaMovement cm;
    GameObject play;
    GameObject pl;
    GameObject atp;
    AttackPoint tp;

    Messagess[] curmsg;
    Actorss[] curactors;
    int actmsg = 0;
    public bool isact;

    public void OpenDialog(Messagess[] messages, Actorss[] actors)
    {
        curmsg = messages;
        curactors = actors;
        actmsg = 0;
        isact = true;
        DisplayMsg();
        cm.enabled = false;
    }

    void DisplayMsg()
    {
        Messagess msgtodisplay = curmsg[actmsg];
        msgtext.text = msgtodisplay.message;
        Actorss actortodisplay = curactors[msgtodisplay.actorid];
        actorname.text = actortodisplay.name;
        actorimage.sprite = actortodisplay.sprite;
    }

    public void NextMsg()
    {
        actmsg++;
        if (actmsg < curmsg.Length)
        {
            DisplayMsg();
        }
        else
        {
            UIFlow.Instance.stopdial();
            isact = false;
            if (isact == false)
            {
                if (phh.currentHealth > 0)
                {
                    if (phh.currentHealth <= 50)
                    {
                        phh.TakeHealth(50);
                        tp.attackDamage = 100;
                    }
                    else if (phh.currentHealth < 90)
                    {
                        phh.TakeHealth(20);
                        tp.attackDamage = 100;
                    }
                    Instantiate(partic, transform.position, Quaternion.identity);
                    Destroy(this.gameObject);

                }
                cm.enabled = true;

            }

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        play = GameObject.FindGameObjectWithTag("Player");
        phh = play.GetComponent<PlayerHealth>();
        pl = GameObject.FindGameObjectWithTag("Player");
        cm = pl.GetComponent<CharaMovement>();
        atp = GameObject.FindGameObjectWithTag("htp");
        tp = atp.GetComponent<AttackPoint>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isact == true)
        {
            NextMsg();
        }

    }
}
