using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CursorAim : MonoBehaviour
{
    public Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnLookDirection(InputValue value)
    {
        var position = value.Get<Vector2>();
        Ray ray = cam.ScreenPointToRay(position);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            transform.LookAt(hit.point); // Look at the point
            transform.rotation = Quaternion.Euler(new Vector3(0, transform.rotation.eulerAngles.y, 0)); // Clamp the x and z rotation
        }
    }

    void OnLookAtController(InputValue value)
    {
        var v2 = value.Get<Vector2>();
        // Look at a Vector2 value
        Vector3 direction = new Vector3(v2.x, 0, v2.y);
        transform.rotation = Quaternion.LookRotation(direction);
    }


}
