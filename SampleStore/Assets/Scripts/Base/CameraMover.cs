using UnityEngine;
using Cinemachine;
public class CameraMover : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera virtualCamera;
    [SerializeField] private float moveSpeedMultiply = 1f;
    
    private CinemachineTrackedDolly _trackedDolly;
    private Joystick _joystick;
    
    private float _speed = 0.05f;
    private void Awake()
    {
        //Assignments
        _joystick = GameObject.FindGameObjectWithTag("Joystick").GetComponent<Joystick>();
        _trackedDolly = virtualCamera.GetCinemachineComponent<CinemachineTrackedDolly>();
    }
    public void FixedUpdate()
    {
        //Camera movement
        
        float vertical = _joystick.Vertical;
        
        if (vertical > 0.1f)
        {
            _trackedDolly.m_PathPosition += _speed * moveSpeedMultiply;
        }
        else if (vertical < -0.1f)
        {
            _trackedDolly.m_PathPosition -= _speed * moveSpeedMultiply;
        }
    }
}
