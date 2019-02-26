using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HPBarManagement : MonoBehaviour
{
    public Image currentHealthbar;
    public Text HPText;

    public playerStats player;

    private void Start()
    {
        UpdateHealthbar();
    }

    public void UpdateHealthbar()
    {
        float ratio = player.health;
        currentHealthbar.rectTransform.localScale = new Vector3(ratio/100, 1, 1);
        HPText.text = ratio.ToString() + '%';
    }

}
