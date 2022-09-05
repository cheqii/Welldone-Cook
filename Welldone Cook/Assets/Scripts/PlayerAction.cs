using System;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    #region -Declare Variables-

    [SerializeField] private int atkDamage;

    private GameController gm;
    private EnemyHpBar _enemyHpBar;

    #endregion

    #region -Unity Event Method-

    private void Start()
    {
        GameObject gameObject = GameObject.FindGameObjectWithTag("GameController");
        gm = gameObject.GetComponent<GameController>();
    }

    #endregion
    #region -Custom Method-

    public void Tackle()
    {
        //gm.EnemyTakeDamage(20);
        Debug.Log("Enemy Get Damage");
        TakeDamage(20);
    }

    private void TakeDamage(int damage)
    {
        gm.eCurrentHealth -= damage;
        gm.UpdateEnemyHealth();
    }
    

    #endregion
}
