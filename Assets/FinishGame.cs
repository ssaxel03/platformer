using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishGame : MonoBehaviour
{
    [SerializeField] private GameObject endingScreen;

    private void OnCollisionEnter2D(Collision2D collider) {
    if(collider.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0f;
            endingScreen.SetActive(true);
            Cursor.visible = true;
        }
    }
}
