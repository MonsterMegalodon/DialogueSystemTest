using DS.Data;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueDisplayer : MonoBehaviour
{
    //[SerializeField] private SentencePanelUI dialogueSentencePanel;
    //[SerializeField] private AnswerPanelUI dialogAnswerPanel;
    //[SerializeField] private DialogueBehavior dialogBehaviour;

    //private void OnEnable()
    //{
    //    DialogueBehavior.AddListenerToOnDialogFinished(DisableDialogPanel);

    //    DialogueBehavior.OnAnswerButtonSetUp += SetUpAnswerButtonsClickEvent;

    //    DialogueBehavior.OnDialogSentenceEnd += dialogueSentencePanel.ResetDialogText;

    //    DialogueBehavior.OnDialogTextCharWrote += dialogueSentencePanel.AddCharToDialogText;

    //    DialogueBehavior.OnSentenceNodeActive += EnableDialogSentencePanel;
    //    DialogueBehavior.OnSentenceNodeActive += DisableDialogAnswerPanel;
    //    DialogueBehavior.OnSentenceNodeActiveWithParameter += dialogueSentencePanel.AssignDialogNameText;

    //    DialogueBehavior.OnAnswerNodeActive += EnableDialogAnswerPanel;
    //    DialogueBehavior.OnAnswerNodeActive += DisableDialogSentencePanel;

    //    DialogueBehavior.OnAnswerNodeActiveWithParameter += dialogAnswerPanel.EnableCertainAmountOfButtons;

    //    DialogueBehavior.OnAnswerNodeSetUp += SetUpAnswerDialogPanel;
    //}

    //private void OnDisable()
    //{
    //    DialogueBehavior.OnAnswerButtonSetUp -= SetUpAnswerButtonsClickEvent;

    //    DialogueBehavior.OnDialogSentenceEnd -= dialogueSentencePanel.ResetDialogText;

    //    DialogueBehavior.OnDialogTextCharWrote -= dialogueSentencePanel.AddCharToDialogText;

    //    DialogueBehavior.OnSentenceNodeActive -= EnableDialogSentencePanel;
    //    DialogueBehavior.OnSentenceNodeActive -= DisableDialogAnswerPanel;

    //    DialogueBehavior.OnSentenceNodeActiveWithParameter -= dialogueSentencePanel.AssignDialogNameText;

    //    DialogueBehavior.OnAnswerNodeActive -= EnableDialogAnswerPanel;
    //    DialogueBehavior.OnAnswerNodeActive -= DisableDialogSentencePanel;

    //    DialogueBehavior.OnAnswerNodeActiveWithParameter -= dialogAnswerPanel.EnableCertainAmountOfButtons;

    //    DialogueBehavior.OnAnswerNodeSetUp -= SetUpAnswerDialogPanel;
    //}

    //public void DisableDialogPanel()
    //{
    //    DisableDialogAnswerPanel();
    //    DisableDialogSentencePanel();
    //}

    //public void EnableDialogAnswerPanel()
    //{
    //    ActiveGameObject(dialogAnswerPanel.gameObject, true);
    //    dialogAnswerPanel.DisalbleAllButtons();
    //}

    //public void DisableDialogAnswerPanel()
    //{
    //    ActiveGameObject(dialogAnswerPanel.gameObject, false);
    //}

    //public void EnableDialogSentencePanel()
    //{
    //    ActiveGameObject(dialogSentensePanel.gameObject, true);
    //}

    //public void DisableDialogSentencePanel()
    //{
    //    ActiveGameObject(dialogSentensePanel.gameObject, false);
    //}

    //public void ActiveGameObject(GameObject gameObject, bool isActive)
    //{
    //    if (gameObject == null)
    //    {
    //        Debug.LogWarning("Game object is null");
    //        return;
    //    }

    //    gameObject.SetActive(isActive);
    //}

    //public void SetUpAnswerButtonsClickEvent(int index, DSDialogueChoiceData answerNode)
    //{
    //    dialogAnswerPanel.GetButtonByIndex(index).onClick.AddListener(() =>
    //    {
    //        dialogBehaviour.SetCurrentNodeAndHandleDialogGraph(answerNode.childSentenceNodes[index]);
    //    });
    //}

    //public void SetUpAnswerDialogPanel(int index, string answerText)
    //{
    //    dialogAnswerPanel.GetButtonTextByIndex(index).text = answerText;
    //}
}

