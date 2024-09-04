using COMMANDS;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

namespace TESTING
{
    public class CMD_DatabaseExtension_Examples : CMD_DatabaseExtension
    {
        new public static void Extend(CommandDatabase database)
        {
            database.AddCommand("print", new Action(PrintDefaultMessage));
            database.AddCommand("print_1p", new Action<string>(PrintUserMessage));
            database.AddCommand("print_mp", new Action<string[]>(PrintLines));

            database.AddCommand("lambda", new Action(() => { Debug.Log("printing default message to console from lambda command."); }));
            database.AddCommand("lambda1p", new Action<string>((arg) => { Debug.Log($"log user lambda message: {arg}"); }));
            database.AddCommand("lambdamp", new Action<string[]>((args) => { Debug.Log(string.Join(", ", args)); }));

            database.AddCommand("process", new Func<IEnumerator>(SimpleProcess));
            database.AddCommand("process1p", new Func<string, IEnumerator>(LineProcess));
            database.AddCommand("processmp", new Func<string[], IEnumerator>(MultiLineProcess));
        }

        private static void PrintDefaultMessage()
        {
            Debug.Log("printing default message to console.");
        }

        private static void PrintUserMessage(string message)
        {
            Debug.Log(message);
        }

        private static void PrintLines(string[] lines)
        {
            int i = 1;
            foreach (string line in lines)
            {
                Debug.Log($"{i++}. '{line}'");
            }

        }

        private static IEnumerator SimpleProcess()
        {
            for (int i = 1; i <= 5; i++)
            {
                Debug.Log($"process running {i}");
                yield return new WaitForSeconds(1);
            }
        }

        private static IEnumerator LineProcess(string data)
        {
            if (int.TryParse(data, out int num))
            {
                for (int i = 1; i <= num; i++)
                {
                    Debug.Log($"process running {i}");
                    yield return new WaitForSeconds(1);
                }
            }

        }

        private static IEnumerator MultiLineProcess(string[] data)
        {
            foreach (string line in data)
            {
                Debug.Log(line);
                yield return new WaitForSeconds(0.5f);
            }

        }
    }
}