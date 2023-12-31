using DS;
using DS.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Events;

public class DialogueBehavior : MonoBehaviour
{
    //[SerializeField] private float dialogCharDelay;
    //[SerializeField] private KeyCode nextSentenceKeyCode;

    //[SerializeField] private UnityEvent onDialogStart;
    //[SerializeField] private UnityEvent onDialogFinished;

    //private DSDialogueChoiceData currentNodeGraph;
    //private Node currentNode;

    //public static event Action OnSentenceNodeActive;

    //public static event Action OnDialogSentenceEnd;

    //public static event Action<string, Sprite> OnSentenceNodeActiveWithParameter;

    //public static event Action OnAnswerNodeActive;

    //public static event Action<int, DSDialogueChoiceData> OnAnswerButtonSetUp;

    //public static event Action<int> OnAnswerNodeActiveWithParameter;

    //public static event Action<int, string> OnAnswerNodeSetUp;

    //public static event Action<char> OnDialogTextCharWrote;

    //public void StartDialog(DSDialogue dialogNodeGraph)
    //{
    //    if (dialogNodeGraph.Choices == null)
    //    {
    //        Debug.LogWarning("Dialog Graph's node list is empty");
    //        return;
    //    }

    //    onDialogStart?.Invoke();

    //    currentNodeGraph = dialogNodeGraph;
    //    currentNode = currentNodeGraph.nodesList[0];

    //    HandleDialogGraphCurrentNode(currentNode);
    //}

    //private void HandleDialogGraphCurrentNode(Node currentNode)
    //{
    //    StopAllCoroutines();

    //    if (currentNode.GetType() == typeof(SentenceNode))
    //    {
    //        SentenceNode sentenceNode = (SentenceNode)currentNode;

    //        OnSentenceNodeActive?.Invoke();
    //        OnSentenceNodeActiveWithParameter?.Invoke(sentenceNode.GetSentenceCharacterName(),
    //            sentenceNode.GetCharacterSprite());

    //        WriteDialogText(sentenceNode.GetSentenceText());
    //    }
    //    else if (currentNode.GetType() == typeof(DSDialogueChoiceData))
    //    {
    //        DSDialogueChoiceData answerNode = (DSDialogueChoiceData)currentNode;
    //        int amountOfActiveButtons = 0;

    //        OnAnswerNodeActive?.Invoke();

    //        for (int i = 0; i < answerNode.childSentenceNodes.Length; i++)
    //        {
    //            if (answerNode.childSentenceNodes[i] != null)
    //            {
    //                OnAnswerNodeSetUp?.Invoke(i, answerNode.answers[i]);
    //                OnAnswerButtonSetUp?.Invoke(i, answerNode);

    //                amountOfActiveButtons++;
    //            }
    //            else
    //            {
    //                break;
    //            }
    //        }

    //        if (amountOfActiveButtons == 0)
    //        {
    //            onDialogFinished?.Invoke();
    //            return;
    //        }

    //        OnAnswerNodeActiveWithParameter?.Invoke(amountOfActiveButtons);
    //    }
    //}

    //public void SetCurrentNodeAndHandleDialogGraph(Node node)
    //{
    //    currentNode = node;
    //    HandleDialogGraphCurrentNode(this.currentNode);
    //}

    //private void WriteDialogText(string text)
    //{
    //    StartCoroutine(WriteDialogTextRoutine(text));
    //}

    //private IEnumerator WriteDialogTextRoutine(string text)
    //{
    //    foreach (char textChar in text)
    //    {
    //        yield return new WaitForSeconds(dialogCharDelay);
    //        OnDialogTextCharWrote?.Invoke(textChar);
    //    }

    //    yield return new WaitUntil(() => Input.GetKeyDown(nextSentenceKeyCode));

    //    OnDialogSentenceEnd?.Invoke();
    //    CheckForDialogNextNode();
    //}

    //private void CheckForDialogNextNode()
    //{
    //    if (currentNode.GetType() == typeof(SentenceNode))
    //    {
    //        SentenceNode sentenceNode = (SentenceNode)currentNode;

    //        if (sentenceNode.childNode != null)
    //        {
    //            currentNode = sentenceNode.childNode;
    //            HandleDialogGraphCurrentNode(currentNode);
    //        }
    //        else
    //        {
    //            onDialogFinished?.Invoke();
    //        }
    //    }
    //}

    //public void AddListenerToOnDialogFinished(UnityAction action)
    //{
    //    onDialogFinished.AddListener(action);
    //}
}
