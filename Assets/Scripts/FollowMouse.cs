using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    private Camera _camera = null;  // cached because Camera.main is slow, so we only call it once.
    void Start()
    {
        _camera = Camera.main;
    }
    
    void Update () {
        var eyePosition = _camera.WorldToScreenPoint(transform.position);
        var mousePosition = Input.mousePosition - eyePosition + new Vector3(0, 0, -50);
        transform.LookAt(mousePosition);
    }

}
