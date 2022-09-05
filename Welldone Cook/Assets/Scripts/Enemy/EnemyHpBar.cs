using UnityEngine;
using UnityEngine.UI;

public class EnemyHpBar : MonoBehaviour
{
    #region -Declare Variables-
    [SerializeField] private Slider slider;
    
    #endregion

    #region -Custom Medthod-

    public void SetMaxHealth(int hp)
    {
        slider.maxValue = hp;
        slider.value = hp;
    }
    
    public void SetHealth(int hp)
    {
        slider.value = hp;
    }
    
    #endregion
}
