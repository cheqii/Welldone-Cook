using System.Security.Cryptography;
using UnityEngine;

public class GameController : MonoBehaviour
{
    #region -Declare Variables-

    [Header("About Enemy")]
    public int eMaxHealth;
    public int eCurrentHealth;

    [SerializeField] private GameObject _enemy;
    [SerializeField] private EnemyHpBar _enemyHpBar;

    [Header("About Player")] 
    private PlayerAction _playerAction;

    #endregion

    #region -Unity Event Method-

    private void Start()
    {
        eCurrentHealth = eMaxHealth;
        _enemyHpBar.SetMaxHealth(eMaxHealth);
    }

    private void Update()
    {
    }

    #endregion

    #region -Custom Method-

    

    public void UpdateEnemyHealth()
    {
        _enemyHpBar.SetHealth(eCurrentHealth);
        if (eCurrentHealth <= 0)
        {
            Destroy(_enemy);
        }
    }

    #endregion
}
