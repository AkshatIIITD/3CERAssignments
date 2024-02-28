using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NutAssembly : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {
    
    bool ispressed = false;
    public GameObject player;

    // Update is called once per frame
    void Update() {
        if (ispressed) {
            player.transform.Translate(0, 0.2f, 0);
            player.transform.Rotate(0, 5f, 0);
        }
    }

    public void OnPointerDown(PointerEventData eventData) {
        ispressed = true;
    }

    public void OnPointerUp(PointerEventData eventData) {
        ispressed = false;
    }
}
