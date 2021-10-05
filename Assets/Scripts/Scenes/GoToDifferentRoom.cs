using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToDifferentRoom : MonoBehaviour
{
    public string connectedRoom;
    private void OnTriggerEnter2D(Collider2D hit) {
        if(hit.CompareTag("Player")){
            SceneManager.LoadScene(connectedRoom);
        }
    }
}
