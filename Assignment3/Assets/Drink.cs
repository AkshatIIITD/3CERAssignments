using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drink : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    bool start = false;
    public Transform sipper;
    public float rotationSpeed = 30.0f;
    public float maxRotationAngle = 90.0f;

    void Update()
    {
        if (start)
        {
            float rotation = rotationSpeed * Time.deltaTime;
            sipper.Rotate(Vector3.right, rotation);

            if (sipper.localEulerAngles.x >= maxRotationAngle)
            {
                start = false;
            }
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        start = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        // Additional logic when the pointer is released (if needed)
    }
}
