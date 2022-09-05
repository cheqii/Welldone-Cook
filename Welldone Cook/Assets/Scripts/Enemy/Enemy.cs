using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    #region -Declare Variables-

    //[SerializeField] private TextMeshProUGUI hpText;

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
