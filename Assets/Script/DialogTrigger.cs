using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public Message[] msg;

    public void GasDialog()
    {
        FindObjectOfType<DialogManager>().StartsDialog(msg);
    }
}
[System.Serializable]
public class Message
{
    public string message;
}
