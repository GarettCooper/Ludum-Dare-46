using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    [SerializeField] private Transform targetPosition;
    [SerializeField] private float cameraMovementSpeed;
    [SerializeField] private float minimumHeight;
    [SerializeField] private bool chaseCamera = false;
    [SerializeField] private float timeToStart = 10f;


    void Start() {
    }

    // Update is called once per frame
    void Update() {

        if (chaseCamera) {
            transform.Translate((targetPosition.position - transform.position) * cameraMovementSpeed * Time.deltaTime);
            if (transform.position.y < minimumHeight) transform.position = new Vector3(transform.position.x, minimumHeight, transform.position.z);
        }

        if (timeToStart > 0) timeToStart -= Time.deltaTime;
        else chaseCamera = true;
    }
}
