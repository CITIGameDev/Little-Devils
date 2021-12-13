using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTrigger : MonoBehaviour
{
    private ICollisionHandler handler;
    // Start is called before the first frame update
    private void Start()
    {
        handler = GetComponentInParent<ICollisionHandler>();

    }

    private void OnTriggerEnter2D(Collider2D colli)
    {
        handler.CollisionEnter(gameObject.name, colli.gameObject);

    }

    private void OnTriggerExit2D(Collider2D colli)
    {
        handler.CollisionExit(gameObject.name, colli.gameObject);
    }

}
