using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CHARACTERS
{
    public class Character_Sprite : Character
    {
        public Character_Sprite(string name, CharacterConfigData config, GameObject prefab) : base(name, config, prefab)
        {
            Debug.Log($"Created a sprite character {name}");
        }
    }
}