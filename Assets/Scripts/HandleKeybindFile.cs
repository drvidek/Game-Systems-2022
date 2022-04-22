using System;
using System.IO;
using UnityEngine;
using UnityEditor;

public class HandleKeybindFile
{
    static string path = "Assets/Resources/Save/Keybinds.txt";
    [MenuItem("Tool/Save/Write File")]
    public static void WriteSaveFile()
    {
        StreamWriter saveWrite = new StreamWriter(path, false);

        foreach (var keyEntry in KeyBinds.keys)
        {
            saveWrite.WriteLine(keyEntry.Key + ":" + keyEntry.Value.ToString());
        }

        saveWrite.Close();
    }

    [MenuItem("Tool/Save/Read File")]
    public static void ReadSaveFile()
    {
        StreamReader saveRead = new StreamReader(path);
        string line;

        while ((line = saveRead.ReadLine()) != null)
        {
            string[] parts = line.Split(':');
            //if we have keys and we are just updating them
            if (KeyBinds.keys.Count > 0)
            {
                KeyBinds.keys[parts[0]] = (KeyCode)System.Enum.Parse(typeof(KeyCode), parts[1]);
            }
            else
            {
                KeyBinds.keys.Add(parts[0], (KeyCode)System.Enum.Parse(typeof(KeyCode), parts[1]));
            }

        }
        saveRead.Close();

    }
}
