using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerramp : MonoBehaviour
{
  public float score;

  public Collider bola;
  public scoremanager scoreManager;

  private void OnTriggerEnter(Collider other)
  {
    if (other == bola)
    {
      scoreManager.AddScore(score);
    }
  }
}