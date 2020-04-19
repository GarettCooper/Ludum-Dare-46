using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour {

    [SerializeField] private LayerMask loseCollisionMask;
    [SerializeField] private Character character;
    private void OnCollisionEnter2D(Collision2D collision) {
        if (loseCollisionMask == (loseCollisionMask | (1 << collision.gameObject.layer))) {
            Debug.Log("Egg Cracked!");
            character.ResetPlayer();
        }
    }



}
