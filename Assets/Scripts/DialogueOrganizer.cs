﻿using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Objects/Dialogue Organizer")]
public class DialogueOrganizer : ScriptableObject
{
    [SerializeField] List<DialoguePerDay> dialoguesPerDays = default;

    [System.Serializable]
    public class DialoguePerDay
    {
        [SerializeField] YarnProgram morningDialogue;
        [SerializeField] string morningLocation;
        [SerializeField] string morningStartNode;
        [SerializeField] YarnProgram eveningDialogue;
        [SerializeField] string eveningLocation;
        [SerializeField] string eveningStartNode;

        public YarnProgram MorningDialogue { get => morningDialogue; set => morningDialogue = value; }
        public string MorningLocation { get => morningLocation; set => morningLocation = value; }
        public YarnProgram EveningDialogue { get => eveningDialogue; set => eveningDialogue = value; }
        public string EveningLocation { get => eveningLocation; set => eveningLocation = value; }
        public string MorningStartNode { get => morningStartNode; set => morningStartNode = value; }
        public string EveningStartNode { get => eveningStartNode; set => eveningStartNode = value; }
    }

    public void UpdateDialogueForDay(int day, YarnProgram dialogue, string time, string location, string startNode)
    {
        DialoguePerDay dialoguePerDay = dialoguesPerDays[day];
        if (time == "morning")
        {
            dialoguePerDay.MorningDialogue = dialogue;
            dialoguePerDay.MorningLocation = location;
            dialoguePerDay.MorningStartNode = startNode;
        }
        else if (time == "evening")
        {
            dialoguePerDay.EveningDialogue = dialogue;
            dialoguePerDay.EveningLocation = location;
            dialoguePerDay.EveningStartNode = startNode;
        }
        else
        {
            Debug.LogError("DialogueForDay not updated with proper time");
        }
    }
}
