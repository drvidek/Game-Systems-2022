using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class CustomisationGet : MonoBehaviour
{
    public Renderer characterRend;
    public GameObject player;
    [Header("Index")]
    //index numbers for our current skin, hair, mouth, eyes textures
    public int skinIndex;
    public int hairIndex, mouthIndex, eyesIndex, clothesIndex, armourIndex;
    public string charName;

    static string path = Path.Combine(Application.streamingAssetsPath, "Character Saves/Character.txt");


    // Start is called before the first frame update
    void Start()
    {
        characterRend = GetComponent<Renderer>();
        player = GameObject.FindGameObjectWithTag("Player");
        //load from save file
        HandleCharCustFile.ReadSaveFile(this);
        LoadSkins();
    }

    // Update is called once per frame
    void LoadSkins()
    {
        SetTexture("Skin", skinIndex);
        SetTexture("Eyes", eyesIndex);
        SetTexture("Mouth", mouthIndex);
        SetTexture("Hair", hairIndex);
        SetTexture("Clothes", clothesIndex);
        SetTexture("Armour", armourIndex);
    }

    void SetTexture(string type, int index)
    {
        Texture2D text = null;
        int matIndex = 0;
        switch (type)
        {
            case "Skin":
                text = Resources.Load("Character/Skin_" + skinIndex) as Texture2D;
                matIndex = 1;
                break;
            case "Eyes":
                text = Resources.Load("Character/Eyes_" + eyesIndex) as Texture2D;
                matIndex = 2;
                break;
            case "Mouth":
                text = Resources.Load("Character/Mouth_" + mouthIndex) as Texture2D;
                matIndex = 3;
                break;
            case "Hair":
                text = Resources.Load("Character/Hair_" + hairIndex) as Texture2D;
                matIndex = 4;
                break;
            case "Clothes":
                text = Resources.Load("Character/Clothes_" + clothesIndex) as Texture2D;
                matIndex = 5;
                break;
            case "Armour":
                text = Resources.Load("Character/Armour_" + armourIndex) as Texture2D;
                matIndex = 6;
                break;
            default:
                break;
        }
        Material[] mats = characterRend.materials;
        mats[matIndex].mainTexture = text;
        characterRend.materials = mats;
    }
}
