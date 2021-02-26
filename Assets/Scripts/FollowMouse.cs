using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    private Camera _camera = null;  // cached because Camera.main is slow, so we only call it once.
    void Start()
    {
        _camera = Camera.main;
    }
    
    void Update () {
        var mouseWorld = _camera.ScreenToWorldPoint(Input.mousePosition + new Vector3(0,0, 0));
        transform.LookAt(mouseWorld);
    }

}
