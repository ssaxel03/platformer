using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collider) {
        if(collider.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("level2");
        }
    }
}
