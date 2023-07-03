using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
/// <summary>
/// Transform.RotateAround‚ğ—p‚¢‚½‰~‰^“®
/// </summary>
public class mawasu : MonoBehaviour
{
    /// <summary> ’†S“_/// </summary>
    [SerializeField] private Vector3 _center = Vector3.zero;
    /// <summary> ‰ñ“]²/// </summary>
    [SerializeField] private Vector3 _axis = Vector3.up;
    // ‰~‰^“®üŠú
    [SerializeField] private float _period = 2;

    bool _Right = false;
    bool _Center = false;
    bool _Left = false;
    GameObject _leftRotate = null;
    GameObject _rightRotate = null;
    [SerializeField] float[] list = { 0, 18, 36, 54, 72, 90, 108, 126, 144, 162, 180, -180, -162, -144, -126, -108, -90, -72, -54, -36, -18 };

    void Start()
    {
        


    }


    private void Update()
    {
        _leftRotate = GameObject.FindWithTag("left");
        _rightRotate = GameObject.FindWithTag("right");
        // ’†S“_center‚Ìü‚è‚ğA²axis‚ÅAperiodüŠú‚Å‰~‰^“®
        if (Input.GetKeyDown(KeyCode.S) && !_Right && !_Center && !_Left)
        {
            _Left = true;
            _Center = true;
            _Right = true;
        }


        if (_Left)
        {
            _leftRotate.transform.RotateAround(_center, _axis, 360 / _period * Time.deltaTime);
        }
        if (_Center)
        {
            transform.RotateAround(_center, _axis, 360 / _period * Time.deltaTime);
        }
        if (_Right)
        {
            _rightRotate.transform.RotateAround(_center, _axis, 360 / _period * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            _Left = false;
            foreach (var RotationLeft in list)
            {

                if (_leftRotate.transform.rotation.x >= RotationLeft - 9f && _leftRotate.transform.rotation.x < RotationLeft + 9f)
                {
                    Debug.Log(RotationLeft);
                    _leftRotate.transform.RotateAround(_center, _axis, RotationLeft);
                    break;
                }



            }

        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            _Center = false;
            foreach (var RotationCenter in list)
            {
                if (transform.rotation.x >= RotationCenter - 9 && transform.rotation.x < RotationCenter + 9)
                {
                    Debug.Log(RotationCenter);
                    transform.RotateAround(_center, _axis, RotationCenter);
                    break;
                }
            }
        }


        if (Input.GetKeyDown(KeyCode.G))
        {
            _Right = false;
            foreach (var RotationRight in list)
            {

                if (_rightRotate.transform.rotation.x >= RotationRight - 9 && _rightRotate.transform.rotation.x < RotationRight + 9)
                {
                    Debug.Log(RotationRight);
                    _rightRotate.transform.RotateAround(_center, _axis, RotationRight);
                    break;
                }
            }

        }



    }
}
