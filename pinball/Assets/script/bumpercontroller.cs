using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bbumpercontroller : MonoBehaviour
{
   public Collider bola;
   public float multiplier;
   public Color color;
   public float score;

   public audiomanager audioManager;
   public VFXManager vfxmanager;
   public scoremanager scoreManager;

   private Renderer renderer;
   private Animator animator;

   private void Start()
   {
          renderer = GetComponent<Renderer>();
          animator = GetComponent<Animator>();

          renderer.material.color = color;  
   }
   
   private void OnCollisionEnter(Collision collision)
   {
        if (collision.collider == bola)
        {
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplier;

          animator.SetTrigger("hit");

          audioManager.PlaySFX(collision.transform.position);

          vfxmanager.PlayVFX(collision.transform.position);

          scoreManager.AddScore(score);
        }
   }
}
