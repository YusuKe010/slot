using UnityEngine;
/// <summary>
/// Transform.RotateAround‚ğ—p‚¢‚½‰~‰^“®
/// </summary>
public class mawasu : MonoBehaviour
{
    // ’†S“_
    [SerializeField] private Vector3 _center = Vector3.zero;
    // ‰ñ“]²
    [SerializeField] private Vector3 _axis = Vector3.up;
    // ‰~‰^“®üŠú
    [SerializeField] private float _period = 2;

    bool _rightRotate = false;
    private void Update()
    {
        // ’†S“_center‚Ìü‚è‚ğA²axis‚ÅAperiodüŠú‚Å‰~‰^“®
        if (Input.GetKeyDown(KeyCode.S))
        {
            _rightRotate = true;
        }
        if(_rightRotate )
        {
            transform.RotateAround(
                _center,
                _axis,
                360 / _period * Time.deltaTime
            );
        }
        
    }
}