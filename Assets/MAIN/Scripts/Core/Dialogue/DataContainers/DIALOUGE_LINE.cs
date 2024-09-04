using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DIALOGUE
{

    public class DIALOUGE_LINE
    {
        public DL_SPEAKER_DATA speakerData;
        public DL_DIALOGUE_DATA dialogueData;
        public DL_COMMAND_DATA commandData;
        public bool hasDialogue => dialogueData != null; //dialogue != string.Empty;
        public bool hasCommands => commandData != null;
        public bool hasSpeaker => speakerData != null;//speaker != string.Empty;

        public DIALOUGE_LINE(string speaker, string dialogue, string commands) { 
            this.speakerData = (string.IsNullOrWhiteSpace(speaker) ? null:  new DL_SPEAKER_DATA(speaker));
            this.dialogueData = (string.IsNullOrWhiteSpace(dialogue) ? null : new DL_DIALOGUE_DATA(dialogue));
            this.commandData = (string.IsNullOrWhiteSpace(commands) ? null : new DL_COMMAND_DATA(commands));
        }
    }
}

