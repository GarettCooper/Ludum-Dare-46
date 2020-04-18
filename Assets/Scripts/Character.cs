﻿using System;
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


    private ControlsSchemes controls;

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
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    [UsedImplicitly]
    private void Update() {
        rigidbody.velocity = new Vector2(controls.Primary.HorizontalMovement.ReadValue<float>() * maxSpeed, rigidbody.velocity.y);

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
        Debug.Log("Jump!");
        if (groundDetector.OnGround || airTime < 0.25f) {
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, rigidbody.velocity.y + jumpForce);
        }
    }

}