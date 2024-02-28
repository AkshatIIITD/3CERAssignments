using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class AssembleCollar : MonoBehaviour, IPointerUpHandler, IPointerDownHandler {
    
    bool start = false;
    public GameObject collar1;
    public GameObject collar2;
    public float translationSpeed = 0.02f; // Adjust this value to control the speed of translation

    void Update()
    {
        if (start) {
            MoveObjectTowardsTarget(collar1, new Vector3(0, 0, 0.04f));
            MoveObjectTowardsTarget(collar2, new Vector3(0, -0.04f, 0));
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
