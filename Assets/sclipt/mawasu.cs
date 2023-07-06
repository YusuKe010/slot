using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mawasu : MonoBehaviour
{

    [SerializeField] GameObject reel1;
    [SerializeField] GameObject reel2;
    [SerializeField] GameObject reel3;
    BoxCollider2D _colliderUp;
    BoxCollider2D _colliderCenter;
    BoxCollider2D _colliderDown;
    [SerializeField] GameObject hanteiUp;
    [SerializeField] GameObject hanteiCenter;
    [SerializeField] GameObject hanteiUnder;

    Vector3 initialpos;
    Vector3 initialpos2;
    Vector3 initialpos3;

    float speed1;
    float speed2;
    static float speed3;

    bool stopflag1 = false;//ボタンが押されたかどうか
    bool stopflag2 = false;
    bool stopflag3 = false;
    
    // Start is called before the first frame update
    void Start()
    {
        initialpos = reel1.transform.position;
        initialpos2 = reel2.transform.position;
        initialpos3 = reel3.transform.position;
        _colliderUp = hanteiUp.GetComponent<BoxCollider2D>();
        _colliderCenter = hanteiCenter.GetComponent<BoxCollider2D>();
        _colliderDown = hanteiUnder.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
            this.reel1.transform.Translate(0, speed1, 0);
            this.reel2.transform.Translate(0, speed2, 0);
            this.reel3.transform.Translate(0, speed3, 0);
        
        if (reel1.transform.position.y < -50f)
        {
            Debug.Log("aaa");
            reel1.transform.position = initialpos;
        }
        if (reel2.transform.position.y < -50f)
        {
            reel2.transform.position = initialpos2;
        }
        if (reel3.transform.position.y < -50f)
        {
            reel3.transform.position = initialpos3;
        }

        if (stopflag1 && 0f <= Mathf.Abs(reel1.transform.position.y % 2f) && Mathf.Abs(reel1.transform.position.y % 2f) < 0.2f)
        {
            speed1 = 0;
            _colliderUp.enabled = true;
        }
        if (stopflag2 && 0f <= Mathf.Abs(reel2.transform.position.y % 2f) && Mathf.Abs(reel2.transform.position.y % 2f) < 0.2f)
        {
            speed2 = 0;
            _colliderCenter.enabled = true;
        }
        if (stopflag3 && 0f <= Mathf.Abs(reel3.transform.position.y % 2f) && Mathf.Abs(reel3.transform.position.y % 2f) < 0.2f)
        {
            speed3 = 0;
            _colliderDown.enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.S)&& speed1 == 0 && speed2 == 0 && speed3 == 0)
        {
            stopflag1 = false;
            stopflag2 = false;
            stopflag3 = false;

            speed1 = -0.2f;
            speed2 = -0.2f;
            speed3 = -0.2f;

            _colliderUp.enabled = false;
            _colliderCenter.enabled=false;
            _colliderDown.enabled = false;
        }
        

        if(Input.GetKeyDown(KeyCode.F))
        {
            if (stopflag1 != true)//ボタンがまだ押されてない場合
            {
                speed1 = -0.03f;//リールをゆっくりにする
            }
            stopflag1 = true;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            if (stopflag2 != true)//ボタンがまだ押されてない場合
            {
                speed2 = -0.03f;//リールをゆっくりにする
            }
            stopflag2 = true;
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            if (stopflag3 != true)//ボタンがまだ押されてない場合
            {
                speed3 = -0.03f;//リールをゆっくりにする
            }
            stopflag3 = true;
        }
        
    }
}
