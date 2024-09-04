using DIALOGUE;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TESTING
{
    public class TestDialogueFiles : MonoBehaviour
    {
        [SerializeField] private TextAsset fileToRead = null;
        void Start()
        {
            StartConversation();
        }

        void StartConversation()
        {
            List<string> lines = FileManager.ReadTextAsset(fileToRead);

            //foreach (string line in lines)
            //{
            //    if (string.IsNullOrWhiteSpace(line)) 
            //        continue;

            //    DIALOUGE_LINE dl = DialogueParser.Parse(line);
            //    for (int i = 0; i < dl.commandData.commands.Count; i++)
            //    {
            //        DL_COMMAND_DATA.Command command = dl.commandData.commands[i];
            //        Debug.Log($"Command [{i}] '{command.name}' has args [{string.Join(", ", command.arguments)}]");
            //    }
            //}

            DialogueSystem.instance.Say(lines);
        }
    }
}