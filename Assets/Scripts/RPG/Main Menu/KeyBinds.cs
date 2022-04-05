using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyBinds : MonoBehaviour
{
    [SerializeField]
    public static Dictionary<string, KeyCode> keys = new Dictionary<string, KeyCode>();
    [System.Serializable]
    public struct KeyUISetup
    {
        public string keyName;
        public Text keyDisplayText;
        public string defaultKey;
        public GameObject buttonObject;
    }

    public KeyUISetup[] baseSetup;
    public GameObject currentKeyButton;
    public Color32 changedKeyCol = new Color32(39, 171, 249, 255);
    public Color32 selectedKeyCol = new Color32(239, 116, 36, 255);

    // Start is called before the first frame update
    void Start()
    {
        HandleKeybindFile.ReadSaveFile();
        if (PlayerPrefs.HasKey("FirstLoad"))
        {
            for (int i = 0; i < baseSetup.Length; i++)
            {
                //add key according to the saved string
                keys.Add(baseSetup[i].keyName, (KeyCode)System.Enum.Parse(typeof(KeyCode), baseSetup[i].defaultKey));
            }
            HandleKeybindFile.WriteSaveFile();
            PlayerPrefs.SetString("FirstLoad", "");
        }
        else
        {
            HandleKeybindFile.WriteSaveFile();
        }
        for (int i = 0; i < baseSetup.Length; i++)
        {
            baseSetup[i].keyDisplayText.text = keys[baseSetup[i].keyName].ToString();

        }
        ///add the keys to the dictionary on start
       
    }

    public void SaveKeys()
    {
        /*foreach (var keyEntry in keys)
        {
            PlayerPrefs.SetString(keyEntry.Key, keyEntry.Value.ToString());
        }
        PlayerPrefs.Save();*/
        HandleKeybindFile.WriteSaveFile();
    }

    public void ChangeKey(GameObject clickedKey)
    {
        currentKeyButton = clickedKey;
        //if we have a key selected
        if (clickedKey != null)
        {
            //change the colour of the button to the "select a key" colour
            clickedKey.GetComponent<Image>().color = selectedKeyCol;
        }
    }

    private void OnGUI()    ///run events such as key press
    {
        //temp reference to the string value of our keycode
        string newKey = "";

        //temp reference to a current event
        Event e = Event.current;
        if (currentKeyButton != null)
        {

            //if the event is a keypress
            if (e.isKey)
            {
                //our temp key reference is the event key that was pressed
                newKey = e.keyCode.ToString();

            }
            //issue in Unity getting left and right shift keys??? WHAT
            //the following part fixes this issue
            if (Input.GetKey(KeyCode.LeftShift))
            {
                newKey = "LeftShift";
            }
            if (Input.GetKey(KeyCode.RightShift))
            {
                newKey = "RightShift";
            }
            if (e.isMouse)
            {
                newKey = e.button.ToString();
            }

            //if we have pressed a new key
            if (newKey != "")
            {

                for (int i = 0; i < baseSetup.Length; i++)
                {
                    string keyString = PlayerPrefs.GetString(baseSetup[i].keyName, baseSetup[i].defaultKey);

                    if (keyString == newKey && baseSetup[i].buttonObject != currentKeyButton)
                    {
                        //change the key value in the dictionary
                        keys[baseSetup[i].buttonObject.name] = keys[currentKeyButton.name];
                        //change display text to match the new key
                        baseSetup[i].buttonObject.GetComponentInChildren<Text>().text = currentKeyButton.GetComponentInChildren<Text>().text;
                        //change the colour of the button to blue
                        baseSetup[i].buttonObject.GetComponent<Image>().color = changedKeyCol;
                        break;
                    }

                }

                //change the key value in the dictionary
                keys[currentKeyButton.name] = (KeyCode)System.Enum.Parse(typeof(KeyCode), newKey);
                //change display text to match the new key
                currentKeyButton.GetComponentInChildren<Text>().text = newKey;
                //change the colour of the button to blue
                currentKeyButton.GetComponent<Image>().color = changedKeyCol;
                //forget the object we were editing
                currentKeyButton = null;
            }
            SaveKeys();

        }
    }

}
