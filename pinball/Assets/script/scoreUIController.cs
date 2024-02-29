using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    public TMP_Text scoreText;
	
    public scoremanager scoreManager;

    private void Update()
    {
        scoreText.text = scoreManager.score.ToString();
    }
}