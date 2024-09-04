using COMMANDS;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TESTING
{
    public class CommandTesting : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(Running());
        }

        IEnumerator Running()
        {
            yield return CommandManager.instance.Execute("print");
            yield return CommandManager.instance.Execute("print_1p", "helloworld");
            yield return CommandManager.instance.Execute("print_mp", "line1", "line2", "line3");

            yield return CommandManager.instance.Execute("lambda");
            yield return CommandManager.instance.Execute("lambda1p", "helloworld");
            yield return CommandManager.instance.Execute("lambdamp", "sdagdg", "sdfg", "sdfg");

            yield return CommandManager.instance.Execute("process");
            yield return CommandManager.instance.Execute("process1p", "10");
            yield return CommandManager.instance.Execute("processmp", " process sdagdg", "process sdfg", "process sdfgsdfg");
        }
    }
}