using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom1 : MonoBehaviour
{
    public bool zomin;
    public bool zomout;
    public bool zoomact;
    public Camera cams;
    public float spd;
    // Start is called before the first frame update
    void Start()
    {
        cams = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (zomin == true)
        {
            zoomin();

        }
        if (zomout == true)
        {
            zoomout();

        }
    }

    public void zoomin()
    {
        cams.orthographicSize = Mathf.Lerp(cams.orthographicSize, 4, spd);
    }
    public void zoomout()
    {
        cams.orthographicSize = Mathf.Lerp(cams.orthographicSize, 7, spd);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            zomin = true;

        }
    }
}
