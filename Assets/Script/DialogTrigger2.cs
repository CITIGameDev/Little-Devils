using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger2 : MonoBehaviour
{
    public Messagesz[] messagese;
    public Actorsz[] actorse;
    public void StartDialog()
    {
        UIFlow.Instance.startdial();
        FindObjectOfType<DialogManager2>().OpenDialog(messagese, actorse);

    }
}

[System.Serializable]
public class Messagesz
{
    public int actoridd;
    public string message;
}

[System.Serializable]
public class Actorsz
{
    public string name;
    public Sprite sprite;
}
