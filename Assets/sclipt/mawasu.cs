using UnityEngine;
/// <summary>
/// Transform.RotateAround��p�����~�^��
/// </summary>
public class mawasu : MonoBehaviour
{
    // ���S�_
    [SerializeField] private Vector3 _center = Vector3.zero;
    // ��]��
    [SerializeField] private Vector3 _axis = Vector3.up;
    // �~�^������
    [SerializeField] private float _period = 2;

    bool _rightRotate = false;
    private void Update()
    {
        // ���S�_center�̎�����A��axis�ŁAperiod�����ŉ~�^��
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