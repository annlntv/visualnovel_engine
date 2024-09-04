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

            yield return new WaitForSeconds(1);

            Sprite bodySprite= Jenna.GetSprite("lady_smile");
            Sprite bodyySprite = Jenna.GetSprite("lady_angry");

            yield return Jenna.TransitionSprite(bodySprite);

            yield return new WaitForSeconds(2);

            Jenna.TransitionSprite(bodyySprite);

            yield return null;

        }
    }
}