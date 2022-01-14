using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger1 : MonoBehaviour
{
    public Messagess[] messages;
    public Actorss[] actors;


    public void StartDialog()
    {
        UIFlow.Instance.startdial();
        FindObjectOfType<DialogManager1>().OpenDialog(messages, actors);

    }
}

[System.Serializable]
public class Messagess
{
    public int actorid;
    public string message;
}

[System.Serializable]
public class Actorss
{
    public string name;
    public Sprite sprite;
}
