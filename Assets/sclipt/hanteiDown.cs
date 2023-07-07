using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hanteiDown : MonoBehaviour
{
    public int _7Down;
    public int _tyeryDown;
    public int _budouDown;
    public int _suikaDown;
    public int _beruDown;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.S))
        {
            _7Down = 0;
            _tyeryDown = 0;
            _budouDown = 0;
            _suikaDown = 0;
            _beruDown = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "7")
        {
            _7Down += 1;
        }
        if (collision.tag == "tyery")
        {
            _tyeryDown += 1;
        }
        if (collision.tag == "suika")
        {
            _suikaDown += 1;
        }
        if (collision.tag == "budou")
        {
            _budouDown += 1;
        }
        if (collision.tag == "beru")
        {
            _beruDown += 1;
        }

    }
}
