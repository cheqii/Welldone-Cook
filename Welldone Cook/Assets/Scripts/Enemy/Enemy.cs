using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    #region -Declare Variables-

    private GameController gm;

    #endregion

    #region -Unity Event Method-

    private void Start()
    {
        GameObject gameObject = GameObject.FindGameObjectWithTag("GameController");
        gm = gameObject.GetComponent<GameController>();
    }
    

    #endregion

    #region -Custom Method-

    

    #endregion
}
