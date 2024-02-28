using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class AssembleTaper : MonoBehaviour, IPointerUpHandler, IPointerDownHandler {
    
    bool start = false;
    public GameObject taper1;
    public GameObject taper2;
    public float translationSpeed = 0.02f; // Adjust this value to control the speed of translation

    void Update()
    {
        if (start) {
            MoveObjectTowardsTarget(taper1, new Vector3(0, 0.1f, 0));
            MoveObjectTowardsTarget(taper2, new Vector3(0, 0, -0.1f));
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
