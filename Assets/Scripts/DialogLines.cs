using UnityEngine;
using TMPro;

public class DialogLines : MonoBehaviour
{
    [SerializeField] string[] timelineTextlines;
    [SerializeField] TMP_Text dialogueText;
    int currentline = 0;
   public void NextDialogueLine()
    {
         currentline++;
        dialogueText.text = timelineTextlines[currentline];

    }
}
