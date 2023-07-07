using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public static int _score = 0;
    [SerializeField] Text text;
    // Start is called before the first frame update
    void Start()
    {
        text.text = _score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
