using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hanteiUp : MonoBehaviour
{
    public int _7Up;
    public int _tyeryUp;
    public int _budouUp;
    public int _suikaUp;
    public int _beruUp;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.S))
        {
            _7Up = 0;
            _tyeryUp = 0;
            _budouUp = 0;
            _suikaUp = 0;
            _beruUp = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "7")
        {
            _7Up += 1;
        }
        if (collision.tag == "tyery")
        {
            _tyeryUp += 1;
        }
        if (collision.tag == "suika")
        {
            _suikaUp += 1;
        }
        if (collision.tag == "budou")
        {
            _budouUp += 1;
        }
        if (collision.tag == "beru")
        {
            _beruUp += 1;
        }

    }
}
