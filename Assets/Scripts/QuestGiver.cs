using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestGiver : MonoBehaviour
{
    public Quest quest;

    public GameObject questInfo;
    public Text titleText;
    public Text descriptionText;

    private void Start()
    {
        questInfo.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown("t"))
        {
            DisplayQuestWindow();
        }
    }

    public void DisplayQuestWindow()
    {
        questInfo.SetActive(true);
        titleText.text = quest.title;
        descriptionText.text = quest.description;

    }

    public void AcceptQuest()
    {
        questInfo.SetActive(false);
        quest.isActive = true;
    }

    public void DeclineQuest()
    {
        questInfo.SetActive(false);
    }
}
