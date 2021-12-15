using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAiming : MonoBehaviour
{
    public Vector3 AimDirection { get; private set; }
    public float AimAngle { get; private set; }

    // Update is called once per frame
    void Update()
    {
        var worldMousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0f));
        var facingDirection = worldMousePosition - transform.position;
        AimAngle = Mathf.Atan2(facingDirection.y, facingDirection.x);
        if (AimAngle < 0f)
        {
            AimAngle = Mathf.PI * 2 + AimAngle;
        }

        AimDirection = Quaternion.Euler(0, 0, AimAngle * Mathf.Rad2Deg) * Vector2.right;
    }
}
