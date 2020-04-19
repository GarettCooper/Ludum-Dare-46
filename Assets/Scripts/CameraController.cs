using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    [SerializeField] private Transform targetPosition;
    [SerializeField] private float cameraMovementSpeed;
    [SerializeField] private float minimumHeight;

    // Update is called once per frame
    void Update() {
        transform.Translate((targetPosition.position - transform.position) * cameraMovementSpeed * Time.deltaTime);
        if (transform.position.y < minimumHeight) transform.position = new Vector3(transform.position.x, minimumHeight, transform.position.z);
    }
}
