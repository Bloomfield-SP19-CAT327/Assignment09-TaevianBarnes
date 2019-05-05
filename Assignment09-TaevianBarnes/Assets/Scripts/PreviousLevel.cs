using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreviousLevel : MonoBehaviour
{
    void ONTriggerEnter()
    {
        GameManager gm = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
        gm.PreviousLevel();
    }

}
