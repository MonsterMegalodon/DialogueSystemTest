using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SentencePanelUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI dialogNameText;
    [SerializeField] private TextMeshProUGUI dialogText;

    private void Start()
    {
        dialogText.text = string.Empty;
    }

    public void ResetDialogText()
    {
        dialogText.text = string.Empty;
    }

    public void AddCharToDialogText(char textChar)
    {
        dialogText.text += textChar;
    }
}
