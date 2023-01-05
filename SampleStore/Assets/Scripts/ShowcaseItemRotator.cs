using UnityEngine;

public class ShowcaseItemRotator : MonoBehaviour
{
    public float RotationSpeed = 100f;
    
    void Update () 
    {
        if (Input.GetMouseButton(0))
        {
            var rotX = Input.GetAxis("Mouse X") * RotationSpeed * Time.deltaTime;

            transform.Rotate(0, rotX, 0, Space.Self);
        }
        
    }
}
