using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxController : MonoBehaviour {

    [SerializeField] private Camera targetCamera;
    [Range(0, 1)]
    [SerializeField] private float distanceFromCamera;

    private Vector3 previousCameraPosition;

    // Start is called before the first frame update
    void Start() {
        previousCameraPosition = targetCamera.transform.position;
    }

    // Update is called once per frame
    void Update() {
        transform.Translate((targetCamera.transform.position - previousCameraPosition) * distanceFromCamera);
        previousCameraPosition = targetCamera.transform.position;
    }
}
