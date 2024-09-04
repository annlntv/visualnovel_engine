using DIALOGUE;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TESTING
{
    public class TestParcing : MonoBehaviour
    {
        [SerializeField] private TextAsset file;
        // Start is called before the first frame update
        void Start()
        { 
            SendFileToParse();
        }

        void SendFileToParse()
        {
            List<string> lines = FileManager.ReadTextAsset("test", false);
            foreach (string line in lines)
            {
                DIALOUGE_LINE dl = DialogueParser.Parse(line);
            }
        }
    }
}