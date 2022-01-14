using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogManager2 : MonoBehaviour
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
    Messagesz[] curmsg;
    Actorsz[] curactors;
    public int actmsgs = 0;
    public bool isact;

    public void OpenDialog(Messagesz[] messagese, Actorsz[] actorse)
    {
        curmsg = messagese;
        curactors = actorse;
        actmsgs = 0;
        isact = true;
        
        
        cm.enabled = false;
    }

    void DisplayMsg()
    {
        Messagesz msgtodisplays = curmsg[actmsgs];
        msgtext.text = msgtodisplays.message;
        Actorsz actortodisplays = curactors[msgtodisplays.actoridd];
        actorname.text = actortodisplays.name;
        actorimage.sprite = actortodisplays.sprite;
    }

    public void NextMsgs()
    {
        actmsgs++;
        if (actmsgs < curmsg.Length)
        {
            DisplayMsg();
        }
        else
        {
            UIFlow.Instance.stopdial();
            isact = false;
            if (isact == false)
            {

                
               

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
       

    }
}
