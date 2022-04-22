using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
//you will need to change Scenes
using UnityEngine.SceneManagement;

public class CustomisationSet : MonoBehaviour
{

    #region Variables
    [Header("Texture List")]
    //Texture2D List for skin, hair, mouth, eyes, clothes, armour
    public List<Texture2D> skin = new List<Texture2D>();
    public List<Texture2D> eyes = new List<Texture2D>();
    public List<Texture2D> mouth = new List<Texture2D>();
    public List<Texture2D> hair = new List<Texture2D>();
    public List<Texture2D> clothes = new List<Texture2D>();
    public List<Texture2D> armour = new List<Texture2D>();

    [Header("Index")]
    //index numbers for our current skin, hair, mouth, eyes textures
    public int skinIndex;
    public int hairIndex, mouthIndex, eyesIndex, clothesIndex, armourIndex;

    [Header("Renderer")]
    //renderer for our character mesh so we can reference a material list
    public Renderer rend;

    [Header("Max Index")]
    //max amount of skin, hair, mouth, eyes textures that our lists are filling with
    public int skinIndexMax;
    public int hairIndexMax, mouthIndexMax, eyesIndexMax, clothesIndexMax, armourIndexMax;

    [Header("Character Name")]
    //name of our character that the user is making
    public string characterName = "Videk";

    //save path
    static string path = Path.Combine(Application.streamingAssetsPath, "Character Saves/Character.txt");


    #endregion

    #region Start
    //in start we need to set up the following
    private void Start()
    {
        GameManager.scr.x = Screen.width / 16;
        GameManager.scr.y = Screen.height / 9;

        #region for loop to pull textures from file
        //for loop looping from 0 to less than the max amount of textures we need
        for (int i = 0; i < skinIndexMax; i++)
        {
            //creating a temp Texture2D that it grabs using Resources.Load from the Character File looking for Texture_#
            Texture2D temp = Resources.Load("Character/Skin_" + i) as Texture2D;
            //add our temp texture that we just found to the List
            skin.Add(temp);
        }

        //for loop looping from 0 to less than the max amount of textures we need
        for (int i = 0; i < hairIndexMax; i++)
        {
            //creating a temp Texture2D that it grabs using Resources.Load from the Character File looking for Texture_#
            Texture2D temp = Resources.Load("Character/Hair_" + i) as Texture2D;
            //add our temp texture that we just found to the skin List
            hair.Add(temp);
        }

        //for loop looping from 0 to less than the max amount of textures we need
        for (int i = 0; i < mouthIndexMax; i++)
        {
            //creating a temp Texture2D that it grabs using Resources.Load from the Character File looking for Texture_#
            Texture2D temp = Resources.Load("Character/Mouth_" + i) as Texture2D;
            //add our temp texture that we just found to the List
            mouth.Add(temp);
        }

        //for loop looping from 0 to less than the max amount of textures we need
        for (int i = 0; i < eyesIndexMax; i++)
        {
            //creating a temp Texture2D that it grabs using Resources.Load from the Character File looking for Texture_#
            Texture2D temp = Resources.Load("Character/Eyes_" + i) as Texture2D;
            //add our temp texture that we just found to the List
            eyes.Add(temp);
        }

        //for loop looping from 0 to less than the max amount of textures we need
        for (int i = 0; i < clothesIndexMax; i++)
        {
            //creating a temp Texture2D that it grabs using Resources.Load from the Character File looking for Texture_#
            Texture2D temp = Resources.Load("Character/Clothes_" + i) as Texture2D;
            //add our temp texture that we just found to the List
            clothes.Add(temp);
        }

        //for loop looping from 0 to less than the max amount of textures we need
        for (int i = 0; i < armourIndexMax; i++)
        {
            //creating a temp Texture2D that it grabs using Resources.Load from the Character File looking for Texture_#
            Texture2D temp = Resources.Load("Character/Armour_" + i) as Texture2D;
            //add our temp texture that we just found to the List
            armour.Add(temp);
        }

        #endregion
        //connect and find the SkinnedMeshRenderer thats in the scene to the variable we made for Renderer
        rend = GameObject.Find("Mesh").GetComponent<Renderer>();
        #region do this after making the function SetTexture
        SetTexture("Skin", 0);
        SetTexture("Eyes", 0);
        SetTexture("Mouth", 0);
        SetTexture("Hair", 0);
        SetTexture("Clothes", 0);
        SetTexture("Armour", 0);
        //SetTexture skin, hair, mouth, eyes to the first texture 0
        #endregion
    }

    #endregion

    #region SetTexture
    //Create a function that is called SetTexture it should contain a string and int
    //the string is the name of the material we are editing, the int is the direction we are changing
    void SetTexture(string type, int dir)
    {
        //we need variables that exist only within this function
        //these are ints index numbers, max numbers, material index and Texture2D array of textures
        int index = 0, max = 0, matIndex = 0;
        Texture2D[] textures = new Texture2D[0];
        //inside a switch statement that is swapped by the string name of our material
        #region Switch Material
        switch (type)
        {
            case "Skin":
                {
                    //index is the same as our skin index
                    index = skinIndex;
                    //max is the same as our skin max
                    max = skinIndexMax;
                    //textures is our skin list .ToArray()
                    textures = skin.ToArray();
                    //material index element number
                    matIndex = 1;
                }
                break;
            case "Eyes":
                {
                    //index is the same as our eyes index
                    index = eyesIndex;
                    //max is the same as our eyes max
                    max = eyesIndexMax;
                    //textures is our eyes list .ToArray()
                    textures = eyes.ToArray();
                    //material index element number
                    matIndex = 2;
                }
                break;
            case "Mouth":
                {
                    //index is the same as our mouth index
                    index = mouthIndex;
                    //max is the same as our mouth max
                    max = mouthIndexMax;
                    //textures is our mouth list .ToArray()
                    textures = mouth.ToArray();
                    //material index element number
                    matIndex = 3;
                }
                break;
            case "Hair":
                {
                    //index is the same as our hair index
                    index = hairIndex;
                    //max is the same as our hair max
                    max = hairIndexMax;
                    //textures is our hair list .ToArray()
                    textures = hair.ToArray();
                    //material index element number
                    matIndex = 4;
                }
                break;
            case "Clothes":
                {
                    //index is the same as our clothes index
                    index = clothesIndex;
                    //max is the same as our clothes max
                    max = clothesIndexMax;
                    //textures is our clothes list .ToArray()
                    textures = clothes.ToArray();
                    //material index element number
                    matIndex = 5;
                }
                break;
            case "Armour":
                {
                    //index is the same as our armour index
                    index = armourIndex;
                    //max is the same as our armour max
                    max = armourIndexMax;
                    //textures is our armour list .ToArray()
                    textures = armour.ToArray();
                    //material index element number
                    matIndex = 6;
                }
                break;

            default:
                break;
        }

        #endregion
        #region OutSide Switch
        //outside our switch statement
        //index plus equals our direction
        while (dir != 0)
        {
            index += dir;
            //cap our index to loop back around if is is below 0 or above max take one
            if (index < 0)
            {
                index = max - 1;
            }
            if (index > max - 1)
            {
                index = 0;
            }
            dir -= (int)Mathf.Sign(dir);
        }
        //Material array is equal to our characters material list
        Material[] materials = rend.materials;
        //our material arrays current material index's main texture is equal to our texture arrays current index
        materials[matIndex].mainTexture = textures[index];
        //our characters materials are equal to the material array
        rend.materials = materials;
        //create another switch that is goverened by the same string name of our material
        #endregion
        #region Set Material Switch
        switch (type)
        {
            case "Skin":
                skinIndex = index;
                break;
            case "Eyes":
                eyesIndex = index;
                break;
            case "Mouth":
                mouthIndex = index;
                break;
            case "Hair":
                hairIndex = index;
                break;
            case "Clothes":
                clothesIndex = index;
                break;
            case "Armour":
                armourIndex = index;
                break;
            default:
                break;
        }
        //case skin
        //skin index equals our index
        //break
        //case hair
        //index equals our index
        //break
        //case mouth
        //index equals our index
        //break
        //case eyes
        //index equals our index
        //break
        #endregion
    }
    #endregion

    #region OnGUI
    private void OnGUI()
    {

        //Function for our GUI elements
        //create the floats scrW and scrH that govern our 16:9 ratio
        //create an int that will help with shuffling your GUI elements under eachother
        int i = 0;
        #region Skin
        //GUI button on the left of the screen with the contence <
        if (GUI.Button(new Rect(0.25f * GameManager.scr.x, GameManager.scr.y + i * (0.5f * GameManager.scr.y), GameManager.scr.x * 0.5f, GameManager.scr.y * 0.5f), "<"))
        {
            //when pressed the button will run SetTexture and grab the Skin Material and move the texture index in the direction  -1
            SetTexture("Skin", -1);
        }

        //GUI Box or Lable on the left of the screen with the contence Skin
        GUI.Box(new Rect(0.75f * GameManager.scr.x, GameManager.scr.y + i * (0.5f * GameManager.scr.y), GameManager.scr.x, GameManager.scr.y * 0.5f), "Skin");

        //GUI button on the left of the screen with the contence >
        if (GUI.Button(new Rect(1.75f * GameManager.scr.x, GameManager.scr.y + i * (0.5f * GameManager.scr.y), GameManager.scr.x * 0.5f, GameManager.scr.y * 0.5f), ">"))
        {
            //when pressed the button will run SetTexture and grab the Skin Material and move the texture index in the direction  -1
            SetTexture("Skin", 1);
        }
        //move down the screen with the int using ++ each grouping of GUI elements are moved using this
        i++;

        #endregion
        //set up same things for Hair, Mouth and Eyes
        #region Eyes
        ///GUI button on the left of the screen with the contence <
        if (GUI.Button(new Rect(0.25f * GameManager.scr.x, GameManager.scr.y + i * (0.5f * GameManager.scr.y), GameManager.scr.x * 0.5f, GameManager.scr.y * 0.5f), "<"))
        {
            //when pressed the button will run SetTexture and grab the Skin Material and move the texture index in the direction  -1
            SetTexture("Eyes", -1);
        }

        //GUI Box or Lable on the left of the screen with the contence Skin
        GUI.Box(new Rect(0.75f * GameManager.scr.x, GameManager.scr.y + i * (0.5f * GameManager.scr.y), GameManager.scr.x, GameManager.scr.y * 0.5f), "Eyes");

        //GUI button on the left of the screen with the contence >
        if (GUI.Button(new Rect(1.75f * GameManager.scr.x, GameManager.scr.y + i * (0.5f * GameManager.scr.y), GameManager.scr.x * 0.5f, GameManager.scr.y * 0.5f), ">"))
        {
            //when pressed the button will run SetTexture and grab the Skin Material and move the texture index in the direction  -1
            SetTexture("Eyes", 1);
        }
        //move down the screen with the int using ++ each grouping of GUI elements are moved using this
        i++;
        #endregion
        #region Mouth
        //GUI button on the left of the screen with the contence <
        if (GUI.Button(new Rect(0.25f * GameManager.scr.x, GameManager.scr.y + i * (0.5f * GameManager.scr.y), GameManager.scr.x * 0.5f, GameManager.scr.y * 0.5f), "<"))
        {
            //when pressed the button will run SetTexture and grab the Mouth Material and move the texture index in the direction  -1
            SetTexture("Mouth", -1);
        }

        //GUI Box or Lable on the left of the screen with the contence Mouth
        GUI.Box(new Rect(0.75f * GameManager.scr.x, GameManager.scr.y + i * (0.5f * GameManager.scr.y), GameManager.scr.x, GameManager.scr.y * 0.5f), "Mouth");

        //GUI button on the left of the screen with the contence >
        if (GUI.Button(new Rect(1.75f * GameManager.scr.x, GameManager.scr.y + i * (0.5f * GameManager.scr.y), GameManager.scr.x * 0.5f, GameManager.scr.y * 0.5f), ">"))
        {
            //when pressed the button will run SetTexture and grab the Mouth Material and move the texture index in the direction  -1
            SetTexture("Mouth", 1);
        }
        //move down the screen with the int using ++ each grouping of GUI elements are moved using this
        i++;
        #endregion
        #region Hair
        //GUI button on the left of the screen with the contence <
        if (GUI.Button(new Rect(0.25f * GameManager.scr.x, GameManager.scr.y + i * (0.5f * GameManager.scr.y), GameManager.scr.x * 0.5f, GameManager.scr.y * 0.5f), "<"))
        {
            //when pressed the button will run SetTexture and grab the Hair Material and move the texture index in the direction  -1
            SetTexture("Hair", -1);
        }

        //GUI Box or Lable on the left of the screen with the contence Hair
        GUI.Box(new Rect(0.75f * GameManager.scr.x, GameManager.scr.y + i * (0.5f * GameManager.scr.y), GameManager.scr.x, GameManager.scr.y * 0.5f), "Hair");

        //GUI button on the left of the screen with the contence >
        if (GUI.Button(new Rect(1.75f * GameManager.scr.x, GameManager.scr.y + i * (0.5f * GameManager.scr.y), GameManager.scr.x * 0.5f, GameManager.scr.y * 0.5f), ">"))
        {
            //when pressed the button will run SetTexture and grab the Hair Material and move the texture index in the direction  -1
            SetTexture("Hair", 1);
        }
        //move down the screen with the int using ++ each grouping of GUI elements are moved using this
        i++;
        #endregion

        #region Clothes
        //GUI button on the left of the screen with the contence <
        if (GUI.Button(new Rect(0.25f * GameManager.scr.x, GameManager.scr.y + i * (0.5f * GameManager.scr.y), GameManager.scr.x * 0.5f, GameManager.scr.y * 0.5f), "<"))
        {
            //when pressed the button will run SetTexture and grab the Clothes Material and move the texture index in the direction  -1
            SetTexture("Clothes", -1);
        }

        //GUI Box or Lable on the left of the screen with the contence Clothes
        GUI.Box(new Rect(0.75f * GameManager.scr.x, GameManager.scr.y + i * (0.5f * GameManager.scr.y), GameManager.scr.x, GameManager.scr.y * 0.5f), "Clothes");

        //GUI button on the left of the screen with the contence >
        if (GUI.Button(new Rect(1.75f * GameManager.scr.x, GameManager.scr.y + i * (0.5f * GameManager.scr.y), GameManager.scr.x * 0.5f, GameManager.scr.y * 0.5f), ">"))
        {
            //when pressed the button will run SetTexture and grab the Clothes Material and move the texture index in the direction  -1
            SetTexture("Clothes", 1);
        }
        //move down the screen with the int using ++ each grouping of GUI elements are moved using this
        i++;
        #endregion

        #region Skin
        //GUI button on the left of the screen with the contence <
        if (GUI.Button(new Rect(0.25f * GameManager.scr.x, GameManager.scr.y + i * (0.5f * GameManager.scr.y), GameManager.scr.x * 0.5f, GameManager.scr.y * 0.5f), "<"))
        {
            //when pressed the button will run SetTexture and grab the Armour Material and move the texture index in the direction  -1
            SetTexture("Armour", -1);
        }

        //GUI Box or Lable on the left of the screen with the contence Armour
        GUI.Box(new Rect(0.75f * GameManager.scr.x, GameManager.scr.y + i * (0.5f * GameManager.scr.y), GameManager.scr.x, GameManager.scr.y * 0.5f), "Armour");

        //GUI button on the left of the screen with the contence >
        if (GUI.Button(new Rect(1.75f * GameManager.scr.x, GameManager.scr.y + i * (0.5f * GameManager.scr.y), GameManager.scr.x * 0.5f, GameManager.scr.y * 0.5f), ">"))
        {
            //when pressed the button will run SetTexture and grab the Armour Material and move the texture index in the direction  -1
            SetTexture("Armour", 1);
        }
        //move down the screen with the int using ++ each grouping of GUI elements are moved using this
        i++;
        #endregion

        #region Random Reset
        //create 2 buttons one Random and one Reset
        //Random will feed a random amount to the direction 
        if (GUI.Button(new Rect(0.25f * GameManager.scr.x, GameManager.scr.y + i * (0.5f * GameManager.scr.y), GameManager.scr.x * 1f, GameManager.scr.y * 0.5f), "Random"))
        {
            //when pressed the button will run SetTexture and grab the Armour Material and move the texture index in the direction  -1
            SetTexture("Skin", Random.Range(0, skinIndexMax));
            SetTexture("Eyes", Random.Range(0, eyesIndexMax));
            SetTexture("Mouth", Random.Range(0, mouthIndexMax));
            SetTexture("Hair", Random.Range(0, hairIndexMax));
            SetTexture("Clothes", Random.Range(0, clothesIndexMax));
            SetTexture("Armour", Random.Range(0, armourIndexMax));
        }

        //reset will set all to 0, both use SetTexture
        if (GUI.Button(new Rect(1.25f * GameManager.scr.x, GameManager.scr.y + i * (0.5f * GameManager.scr.y), GameManager.scr.x * 1f, GameManager.scr.y * 0.5f), "Reset"))
        {
            //when pressed the button will run SetTexture and grab the Armour Material and move the texture index in the direction  -1
            SetTexture("Skin", skinIndex = 0);
            SetTexture("Eyes", eyesIndex = 0);
            SetTexture("Mouth", mouthIndex = 0);
            SetTexture("Hair", hairIndex = 0);
            SetTexture("Clothes", clothesIndex = 0);
            SetTexture("Armour", armourIndex = 0);
        }
        //move down the screen with the int using ++ each grouping of GUI elements are moved using this
        i++;
        #endregion

        #region Character Name and Save & Play
        //name of our character equals a GUI TextField that holds our character name and limit of characters
        //move down the screen with the int using ++ each grouping of GUI elements are moved using this
        characterName = GUI.TextField(new Rect(0.25f * GameManager.scr.x, GameManager.scr.y + i * (0.5f * GameManager.scr.y), GameManager.scr.x * 2f, GameManager.scr.y * 0.5f), characterName, 12);
        i++;
        //GUI Button called Save and Play
        //this button will run the save function and also load into the game level
        if (GUI.Button(new Rect(0.25f * GameManager.scr.x, GameManager.scr.y + i * (0.5f * GameManager.scr.y), GameManager.scr.x * 2f, GameManager.scr.y * 0.5f), "Start Game"))
        {
            HandleCharCustFile.WriteSaveFile(this);
            SceneManager.LoadScene(2);
        }
        i++;
        //GUI Button called Cancel
        //this button will return to the main menu and not save the character
        if (GUI.Button(new Rect(0.25f * GameManager.scr.x, GameManager.scr.y + i * (0.5f * GameManager.scr.y) + (GameManager.scr.y * 0.25f), GameManager.scr.x * 2f, GameManager.scr.y * 0.25f), "Cancel"))
        {
            SceneManager.LoadScene(0);
        }
        #endregion
    }

    #endregion
}
