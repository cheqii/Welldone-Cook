using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    #region -Declare Variables-

    [Header("About Enemy")]
    public int eMaxHealth;
    public int eCurrentHealth;

    [SerializeField] private GameObject _enemy;
    [SerializeField] private EnemyHpBar _enemyHpBar;
    [SerializeField] private TextMeshProUGUI enemyHpText;

    [Header("About Player")] 
    private PlayerAction _playerAction;

    #endregion

    #region -Unity Event Method-

    private void Start()
    {
        // About Enemy Health
        eCurrentHealth = eMaxHealth;
        _enemyHpBar.SetMaxHealth(eMaxHealth);
        enemyHpText.text = "HP : " + eCurrentHealth + " / " + eMaxHealth;;
    }

    private void Update()
    {
    }

    #endregion

    #region -Custom Method-
    
    public void UpdateEnemyHealth()
    {
        _enemyHpBar.SetHealth(eCurrentHealth);
        UpdateEnemyHealthText();
        if (eCurrentHealth <= 0)
        {
            Destroy(_enemy);
        }
    }

    private void UpdateEnemyHealthText()
    {
        enemyHpText.text = "HP : " + eCurrentHealth + " / " + eMaxHealth;
    }

    public void RestartGame()
    {
        SceneManager.LoadSceneAsync("BattleScene");
    }

    #endregion
}
