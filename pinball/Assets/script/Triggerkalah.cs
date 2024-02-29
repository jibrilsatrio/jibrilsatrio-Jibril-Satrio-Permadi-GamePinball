using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Triggerkalah : MonoBehaviour
{
  public Collider bola;
  public GameObject gameoverOverCanvas;

  private void OnTriggerEnter(Collider other)
  {
    if (other == bola)
    {
        gameoverOverCanvas.SetActive(true);
    }
  }
}
