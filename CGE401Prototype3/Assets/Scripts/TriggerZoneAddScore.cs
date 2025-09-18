using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Matthew Schoen
 * Prototype 3
 * Trigger zones above the obstacles to increment the score 
 * 
 */

public class TriggerZoneAddScore : MonoBehaviour
{
    private UIManager uIManager;

    private bool triggered = false;

    // Start is called before the first frame update
    void Start()
    {
        uIManager = GameObject.FindObjectOfType<UIManager>();
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            uIManager.score++;

        }

    }

}
