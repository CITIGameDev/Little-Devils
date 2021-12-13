using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICollisionHandler
{
    void CollisionEnter(string colli, GameObject other);
    void CollisionExit(string Colli, GameObject other);
}

