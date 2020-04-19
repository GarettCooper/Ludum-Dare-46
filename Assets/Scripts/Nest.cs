using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nest : MonoBehaviour {

    [SerializeField]
    private float eggTime = 2.0f;

    private bool eggPresent;

    private void Update() {
        if (eggPresent) {
            Debug.Log("Egg Present");
            eggTime -= Time.deltaTime;
        }

        if (eggTime <= 0) {
            Debug.Log("Victory!");
            // TODO: Trigger win condition
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Egg") {
            eggPresent = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        if (collision.tag == "Egg") {
            eggPresent = false;
        }
    }


}
