using System;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

public class GameStartCountdownUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI countdownText;
    [SerializeField] private GameObject chalkBoard;

    private void Start()
    {
        GameManager.Instance.OnStateChanged += GameManager_OnStateChanged;
        chalkBoard.SetActive(false);
        Hide();
    }

    private void Update()
    {
        countdownText.text = Mathf.Ceil(GameManager.Instance.GetCountdownToStartTimer()).ToString();
    }

    private void GameManager_OnStateChanged(object sender, EventArgs e)
    {
        if(GameManager.Instance.IsCountdownToStartActive())
        {
            Show();
        }
        else
        {
            Hide();
        }
    }

    private void Show()
    {
        gameObject.SetActive(true);
        chalkBoard.SetActive(true);
    }

    private void Hide()
    {
        gameObject.SetActive(false);
        chalkBoard.SetActive(false);
    }
}
