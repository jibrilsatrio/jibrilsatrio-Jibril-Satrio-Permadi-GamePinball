using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerzoom : MonoBehaviour
{
  public Collider bola;
  public cameracontroller cameraController;
  public float length;

  private void OnTriggerEnter(Collider other)
  {
    if (other == bola)
    {
        cameraController.FollowTarget(bola.transform, length);
    }
  }
}
