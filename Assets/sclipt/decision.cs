using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class decision : MonoBehaviour
{
    [SerializeField]
    hanteiUp hanteiUp;
    [SerializeField]
    hanteiCenter hanteiCenter;
    [SerializeField]
    hanteiDown hanteiDown;
    [SerializeField]
    mawasu _mawasu;

    [SerializeField] Text _text;
    [SerializeField] score score;
    float _timer = 0;

    bool _Score;
    bool _Timer;
    // Start is called before the first frame update
    void Start()
    {
        _text.text = score._score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (!_Score &&(hanteiUp._7Up == 3 || hanteiCenter._7Center == 3 || hanteiDown._7Down == 3))
        {
            score._score *= 7;
            _Score = true;
            _text.text = score._score.ToString();

        }
        else if(!_Score && (hanteiUp._beruUp == 3 || hanteiCenter._beruCenter == 3 || hanteiDown._beruDown == 3))
        {
            score._score += 100;
            _Score = true;
            _text.text = score._score.ToString();
        }
        else if (!_Score && (hanteiUp._suikaUp == 3 || hanteiCenter._suikaCenter == 3 || hanteiDown._suikaDown == 3))
        {
            score._score += 500;
            _Score = true;
            _text.text = score._score.ToString();
        }
        else if (!_Score && (hanteiUp._budouUp == 3 || hanteiCenter._budouCenter == 3 || hanteiDown._budouDown == 3))
        {
            score._score += 300;
            _Score = true;
            _text.text = score._score.ToString();
        }
        else if (!_Score && (hanteiUp._tyeryUp == 3 || hanteiCenter._tyeryCenter == 3 || hanteiDown._tyeryDown == 3))
        {
            score._score += 700;
            _Score = true;
            _text.text = score._score.ToString();
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            _Timer = true;
        }
        if(_Timer && _timer > 0.3f)
        {
            _Score = false;
            _Timer = false;
            _timer = 0.0f;
        }
        else if(_Timer)
        { _timer += Time.deltaTime; }
        

    }
}
