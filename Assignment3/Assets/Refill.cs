using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Refill : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {
    
    bool start = false;
    public GameObject player;
    float delay = 0.0f;
    // Update is called once per frame
    void Update() {
        if (start) {
            player.transform.Translate(0, 0.0001f, 0);
            player.transform.Rotate(0, -6f, 0);
            delay += Time.deltaTime;
            if (delay > 10f) {
                start = false;
            }
        }
    }

    public void OnPointerDown(PointerEventData eventData) {
        start = true;
    }

    public void OnPointerUp(PointerEventData eventData) {
        
    }
}