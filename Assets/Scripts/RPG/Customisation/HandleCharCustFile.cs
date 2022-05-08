using System;
using System.IO;
using UnityEngine;
using UnityEditor;

public static class HandleCharCustFile
{
    static string path = Path.Combine(Application.streamingAssetsPath, "Character Saves/Character.txt");

    [MenuItem("Tool/Save/Write File/Character")]
    public static void WriteSaveFile(CustomisationSet set)
    {
        StreamWriter saveWrite = new StreamWriter(path, false);

        saveWrite.WriteLine(set.skinIndex.ToString());
        saveWrite.WriteLine(set.eyesIndex.ToString());
        saveWrite.WriteLine(set.mouthIndex.ToString());
        saveWrite.WriteLine(set.hairIndex.ToString());
        saveWrite.WriteLine(set.clothesIndex.ToString());
        saveWrite.WriteLine(set.armourIndex.ToString());
        saveWrite.WriteLine(set.characterName);

        saveWrite.Close();
    }

    [MenuItem("Tool/Save/Read File/Character")]
    public static void ReadSaveFile(CustomisationGet get)
    {
        StreamReader saveRead = new StreamReader(path);
        get.skinIndex = int.Parse(saveRead.ReadLine());
        get.eyesIndex = int.Parse(saveRead.ReadLine());
        get.mouthIndex = int.Parse(saveRead.ReadLine());
        get.hairIndex = int.Parse(saveRead.ReadLine());
        get.clothesIndex = int.Parse(saveRead.ReadLine());
        get.armourIndex = int.Parse(saveRead.ReadLine());
        get.charName = saveRead.ReadLine();
        saveRead.Close();

    }
}
