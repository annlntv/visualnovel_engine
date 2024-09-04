using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DIALOGUE;

namespace TESTING
{
    public class Testing_Architect : MonoBehaviour
    {
        DialogueSystem ds;
        TextArchitect architect;

        public TextArchitect.BuildMethod bm = TextArchitect.BuildMethod.instant;

        string[] lines = new string[5]
        {
            "hello",
            "this is a start of dialogue",
            "happy to see you pookie",
            "ive got nothing to do today",
            "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"
        };
        string longLine = "What do you want? I have a lot to do. I have to go. There's a lot of text here. Blah blah blah. What do you want? I have a lot to do. I have to go. There's a lot of text here. Blah blah blah. What do you want? I have a lot to do. I have to go.";

        // Start is called before the first frame update
        void Start()
        {
            ds = DialogueSystem.instance;
            architect = new TextArchitect(ds.dialogueContainer.dialogueText);
            architect.buildMethod = TextArchitect.BuildMethod.fade;
            architect.speed = 0.5f;
        }

        // Update is called once per frame
        void Update()
        {
            if (bm != architect.buildMethod)
            {
                architect.buildMethod = bm;
                architect.Stop();
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (architect.isBuilding)
                {
                    if(!architect.hurryUp) { 
                        architect.hurryUp = true;
                    }
                }
                else
                {
                    architect.hurryUp = false;
                    architect.Build(longLine);  
                }
            }
        }
    }
}

