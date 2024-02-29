using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherController : MonoBehaviour
{
  public Collider bola;
  public KeyCode input;
  public float maxTimeHold;
  public float maxForce;
  public Material onMaterial;
  public Material offMaterial;
  private bool isHold = false;

  private Renderer renderer;

  private void Start()
  {
    renderer = GetComponent<Renderer>();
    renderer.material = offMaterial;
  }

  private void OnCollisionStay(Collision collision)
  {
    if (collision.collider == bola)
    {
      ReadInput(bola);
    }
  }

  private void ReadInput(Collider collider)
  {
    if (Input.GetKey(input) && !isHold)
    {
      StartCoroutine(StartHold(collider));
    }
    else if (!Input.GetKey(input) && isHold)
    {
      StopHold();
    }
  }

  private IEnumerator StartHold(Collider collider)
  {
    isHold = true;

    float force = 0.0f;
    float timeHold = 0.0f;

    while (Input.GetKey(input) && timeHold < maxTimeHold)
    {
      force = Mathf.Lerp(0, maxForce, timeHold/maxTimeHold);
      timeHold += Time.deltaTime;

      renderer.material = onMaterial;

      yield return null;
    }

    collider.GetComponent<Rigidbody>().AddForce(transform.forward * force);
    isHold = false;

    renderer.material = offMaterial;
  }

  private void StopHold()
  {
    StopAllCoroutines();

    renderer.material = offMaterial;

    isHold = false;
  }
}
