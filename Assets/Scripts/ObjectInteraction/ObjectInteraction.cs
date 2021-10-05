using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class ObjectInteraction : MonoBehaviour
{
   public PlayableDirector timeline;
    private void OnTriggerEnter2D(Collider2D hit) {
        if(hit.CompareTag("Player")){
            timeline.Play();
            PlayerPrefs.SetString("Inventory", "book");
        }
    }
}
