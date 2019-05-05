using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreviousLevel : MonoBehaviour
{
    void OnTriggerEnter()
    {
        GameController gc = GameObject.FindWithTag("GameController").GetComponent<GameController>();
        gc.PreviousLevel();
    }

}
