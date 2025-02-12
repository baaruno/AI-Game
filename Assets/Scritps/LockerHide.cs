using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockerHide : MonoBehaviour
{
   // public GameObject hideText, stopHideText;
    public GameObject normalPlayer, hidingPlayer;
    public ChasingEnemy EnemyScript;
    public Transform EnemyTransform;
    bool interactable, hiding;
    public float loseDistance;

    void Start()
    {
        interactable = false;
        hiding = false;
    }
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            //hideText.SetActive(true);
            interactable = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            //hideText.SetActive(false);
            interactable = false;
        }
    }
    void Update()
    {
        if (interactable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                //hideText.SetActive(false);
                hidingPlayer.SetActive(true);
                float distance = Vector3.Distance(EnemyTransform.position, normalPlayer.transform.position);
                if (distance > loseDistance)
                {
                    if (EnemyScript.chasing == true)
                    {
                        EnemyScript.chasing = false;
                    }
                }
                //stopHideText.SetActive(true);
                hiding = true;
                normalPlayer.SetActive(false);
                interactable = false;
            }
        }
        if (hiding == true)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                //stopHideText.SetActive(false);
                normalPlayer.SetActive(true);
                hidingPlayer.SetActive(false);
                hiding = false;
            }
        }
    }
}
