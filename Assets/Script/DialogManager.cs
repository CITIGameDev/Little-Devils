using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    [SerializeField]
    public Text msgtxt;
    public GameObject boxx;

    Message[] curmsg;
    int actmsg;

    public void StartsDialog(Message[] msg)
    {
        curmsg = msg;
        actmsg = 0;
        DisplayMsg();

    }

    public void actives()
    {
        boxx.SetActive(true);
    }

    public void nonact()
    {
        boxx.SetActive(false);
    }

    void DisplayMsg()
    {
        Message msgtodisplay = curmsg[actmsg];
        msgtxt.text = msgtodisplay.message;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
