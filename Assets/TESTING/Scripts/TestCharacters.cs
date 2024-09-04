using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CHARACTERS;
using DIALOGUE;
using TMPro;

namespace TESTING
{
    public class TestCharacters : MonoBehaviour
    {
        public TMP_FontAsset fontAsset;
        // Start is called before the first frame update
        void Start()
        {
            Character Jenna = CharacterManager.instance.CreateCharacter("Jenna");
            //Character Elen = CharacterManager.instance.CreateCharacter("Elen");
            //Character Adam = CharacterManager.instance.CreateCharacter("Adam");
            StartCoroutine(Test());
        }

        IEnumerator Test()
        {

            return null;

            //
            //Character Adam = CharacterManager.instance.CreateCharacter("Adam");
            //Character Ben = CharacterManager.instance.CreateCharacter("Ben");


            //List<string> lines = new List<string>()
            //{
            //    "\"HI!\"",
            //    "This is a line. My name is Jenna.",
            //    "And another.",
            //    "And a last one.{wa 1} wait noo lool"
            //};
            //yield return Jenna.Say(lines);
            //Jenna.SetNameColor(Color.red);
            //Jenna.SetDialogueColor(Color.green);
            //Jenna.SetNameFont(fontAsset);
            //Jenna.SetDialogueFont(fontAsset);
            //yield return Jenna.Say(lines);
            //Jenna.ResetConfigurationData();
            //yield return Jenna.Say(lines);

            //lines = new List<string>()
            //{
            //    "I am Adam.",
            //    "more lines{c} here"
            //};

            //yield return Adam.Say(lines);

            //yield return Ben.Say("this is a line that i want to say...{a}it is a simple line");

            Debug.Log("finished");
        }
    }
}