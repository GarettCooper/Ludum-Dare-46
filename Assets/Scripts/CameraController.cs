using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    [SerializeField] private Transform targetPosition;
    [SerializeField] private float cameraMovementSpeed;

    // Update is called once per frame
    void Update() {
        transform.Translate((targetPosition.position - transform.position) * cameraMovementSpeed * Time.deltaTime);
    }
}
