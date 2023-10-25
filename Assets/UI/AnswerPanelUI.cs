using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class AnswerPanelUI : MonoBehaviour
{
    [SerializeField] private List<TabButton> buttons = new List<TabButton>();
    [SerializeField] private List<TextMeshProUGUI> buttonTexts;

    public TabButton GetButtonByIndex(int index)
    {
        return buttons[index];
    }

    public TextMeshProUGUI GetButtonTextByIndex(int index)
    {
        return buttonTexts[index];
    }

    public void AddButtonOnClickListener(int index, UnityAction action)
    {
        buttons[index].onClick.AddListener(action);
    }

    public void EnableCertainAmountOfButtons(int amount)
    {
        if (buttons.Count == 0)
        {
            Debug.LogWarning("Please assign button list!");
            return;
        }

        for (int i = 0; i < amount; i++)
        {
            buttons[i].gameObject.SetActive(true);
        }
    }

    public void DisalbleAllButtons()
    {
        foreach (TabButton button in buttons)
        {
            button.gameObject.SetActive(false);
        }
    }
}
