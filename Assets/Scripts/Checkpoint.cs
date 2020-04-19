using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Requires attached trigger collider
public class Checkpoint : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log($"Triggered by {collision.tag}");
        if (collision.tag == "Player") {
            Character character = collision.gameObject.GetComponent<Character>();
            Debug.Log($"Set Checkpoint to {name}");
            character.SetCheckpoint(this);
        }
    }

}
