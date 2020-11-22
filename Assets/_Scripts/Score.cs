using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int score=0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectable"))
        {
            score++;
            other.gameObject.SetActive(false);
            gameObject.GetComponentInChildren<AudioSource>().Play();
        }
    }
}
