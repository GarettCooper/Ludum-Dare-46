using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;

public class Character : MonoBehaviour
{

    [SerializeField]
    private float maxSpeed = 1f;
    [SerializeField]
    private float jumpForce = 10f;
    [SerializeField]
    private float popupHeight = 10f;


    private ControlsSchemes controls;
    private Animator animator;

    [SerializeField]
    private GroundDetector groundDetector;

    private new Rigidbody2D rigidbody;

    private float horizontalInput;

    private float airTime = 0f;

    [UsedImplicitly]
    private void Awake() {
        controls = new ControlsSchemes();
        controls.Primary.Jump.performed += Jump;
    }

    // Start is called before the first frame update
    [UsedImplicitly]
    private void Start() {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    [UsedImplicitly]
    private void Update() {
        rigidbody.velocity = new Vector2(controls.Primary.HorizontalMovement.ReadValue<float>() * maxSpeed, rigidbody.velocity.y);

        animator.SetFloat("Horizontal Speed", Mathf.Abs(rigidbody.velocity.x));
        animator.SetFloat("Vertical Speed", rigidbody.velocity.y);

        if (groundDetector.OnGround) {
            airTime = 0f;
        } else {
            airTime += Time.deltaTime;
        }
    }

    [UsedImplicitly]
    private void OnEnable() {
        controls.Enable();
    }

    [UsedImplicitly]
    private void OnDisable() {
        controls.Disable();
    }

    private void Jump(InputAction.CallbackContext ctx) {
        if (groundDetector.OnGround || airTime < 0.25f) {
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, rigidbody.velocity.y + jumpForce);

            if (airTime < 0.01) {
                animator.SetTrigger("Jump");
            }
        }
    }

    private ContactPoint2D[] contactPoints =  new ContactPoint2D[10];
    private void OnCollisionStay2D(Collision2D collision) {
        int contactsCount = collision.GetContacts(contactPoints);

        for (int i = 0; i < contactsCount; i++) {

            if (contactPoints[i].normal.x < 0 && contactPoints[i].normal.y == 0 && (contactPoints[i].point - (Vector2) transform.position).y < popupHeight) {
                Debug.Log("Popup");
                transform.Translate(Vector2.up * 0.05f);
            }
        }
    }
}
