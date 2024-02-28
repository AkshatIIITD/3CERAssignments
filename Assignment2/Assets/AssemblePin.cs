using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class AssemblePin : MonoBehaviour, IPointerUpHandler, IPointerDownHandler {
    
    bool start = false;
    public GameObject pin1;
    public GameObject pin2;
    public float translationSpeed = 0.04f; // Adjust this value to control the speed of translation

    void Update()
    {
        if (start) {
            MoveObjectTowardsTarget(pin1, new Vector3(0, 0, -0.2f));
            MoveObjectTowardsTarget(pin2, new Vector3(0, 0.2f, 0));
        }
    }

    public void OnPointerDown(PointerEventData eventData) {
        start = true;
    }

    public void OnPointerUp(PointerEventData eventData) {
    }

    void MoveObjectTowardsTarget(GameObject obj, Vector3 targetPosition) {
        float step = translationSpeed * Time.deltaTime;
        obj.transform.position = Vector3.MoveTowards(obj.transform.position, targetPosition, step);

        if (obj.transform.position == targetPosition) {
            start = false;
        }
    }
}
