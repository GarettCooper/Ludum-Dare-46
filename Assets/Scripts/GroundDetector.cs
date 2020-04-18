using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDetector : MonoBehaviour {

    [SerializeField] private float capsuleWidth = 0.5f;
    [SerializeField] private float capsuleHeight = 0.5f;


    public bool OnGround {
        get {
            if (isDirty) {
                onGround = Physics2D.OverlapCapsule(transform.position, new Vector2(capsuleWidth, capsuleHeight), CapsuleDirection2D.Horizontal, 360f, LayerMask.GetMask("Ground")) != null;
            }

            return onGround;
        }
    }

    private bool isDirty = true;

    private bool onGround;

    void Update() {
        isDirty = true;
    }

}
