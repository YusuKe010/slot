using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hanteiCenter : MonoBehaviour
{
    public int _7Center;
    public int _tyeryCenter;
    public int _budouCenter;
    public int _suikaCenter;
    public int _beruCenter;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.S))
        {
            _7Center = 0;
            _tyeryCenter = 0;
            _budouCenter = 0;
            _suikaCenter = 0;
            _beruCenter = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "7")
        {
            _7Center += 1;
        }
        if (collision.tag == "tyery")
        {
            _tyeryCenter += 1;
        }
        if (collision.tag == "suika")
        {
            _suikaCenter += 1;
        }
        if (collision.tag == "budou")
        {
            _budouCenter += 1;
        }
        if (collision.tag == "beru")
        {
            _beruCenter += 1;
        }
    }
}
