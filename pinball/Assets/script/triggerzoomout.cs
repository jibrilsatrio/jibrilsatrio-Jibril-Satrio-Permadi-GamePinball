using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerzoomout : MonoBehaviour
{
  public Collider bola;
  public cameracontroller cameraController;

  private void OnTriggerEnter(Collider other)
  {
    if (other == bola)
    {
        cameraController.GoBackToDefault();
    }
	}
}
