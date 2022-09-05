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
        int tackleDmg = 20;
        Debug.Log("Enemy Get Damage");
        if (gm.eCurrentHealth > 0)
        {
            TakeDamage(tackleDmg);
        }
    }

    private void TakeDamage(int damage)
    {
        gm.eCurrentHealth -= damage;
        gm.UpdateEnemyHealth();
    }
    

    #endregion
}
