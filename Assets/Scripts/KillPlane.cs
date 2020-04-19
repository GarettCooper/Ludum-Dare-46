using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlane : MonoBehaviour {

    [SerializeField] private Character player;
    [SerializeField] private List<string> resetTags;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (resetTags.Contains(collision.tag)) {
            player.ResetPlayer();
        }
    }

}
