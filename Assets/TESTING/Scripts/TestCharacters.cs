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
            //Character Elen = CharacterManager.instance.CreateCharacter("Elen");
            //Character Adam = CharacterManager.instance.CreateCharacter("Adam");
            StartCoroutine(Test());
        }

        IEnumerator Test()
        {
            Character_Sprite Jenna = CharacterManager.instance.CreateCharacter("Lady") as Character_Sprite;
            Character_Sprite Ben = CharacterManager.instance.CreateCharacter("Lord") as Character_Sprite;

            yield return new WaitForSeconds(1);

            Jenna.Animate("Hop");

            yield return null;

        }
    }
}