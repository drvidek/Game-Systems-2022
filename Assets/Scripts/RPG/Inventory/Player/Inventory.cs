using System.Collections.Generic;   //for Lists and Dictionaries
using UnityEngine;
namespace Inventory.Player
{
    public class Inventory : MonoBehaviour
    {
        #region Variables
        //Items and our inventory
        public static List<Item> playerInv = new List<Item>();
        public Item selectedItem;
        public static bool showInv;
        public static int money;

        //scrolling and sorting
        public Vector2 scrollPos;
        public string sortType = "All";
        public string[] enumTypesForItems = { "All", "Food", "Weapon", "Apparel", "Crafting", "Ingredient", "Potion", "Scroll", "Quest", "Money" };

        //Equipment and dropping
        public Transform dropLocation;
        [System.Serializable]
        public struct Equipment
        {
            public string slotName; public Transform equipmentLocation;
            public GameObject currentShop;
        }

        public Equipment[] equipmentSlots;

        //Other inventories
        public static Chest.Inventory currentChest;
        public static Shop.Inventory currentShop;


        #endregion

        // Start is called before the first frame update
        void Start()
        {
#if UNITY_EDITOR
            playerInv.Add(ItemData.CreateItem(0));
            playerInv.Add(ItemData.CreateItem(1));
            playerInv.Add(ItemData.CreateItem(100));
            playerInv.Add(ItemData.CreateItem(101));
            playerInv.Add(ItemData.CreateItem(102));
            playerInv.Add(ItemData.CreateItem(200));
            playerInv.Add(ItemData.CreateItem(300));
            playerInv.Add(ItemData.CreateItem(400));
            playerInv.Add(ItemData.CreateItem(500));
            playerInv.Add(ItemData.CreateItem(600));
            playerInv.Add(ItemData.CreateItem(700));
#endif
        }

        // Update is called once per frame
        void Update()
        {
#if UNITY_EDITOR
            if (Input.GetKeyDown(KeyCode.KeypadPlus))
            {
                playerInv.Add(ItemData.CreateItem(0));
                playerInv.Add(ItemData.CreateItem(1));
                playerInv.Add(ItemData.CreateItem(100));
                playerInv.Add(ItemData.CreateItem(101));
                playerInv.Add(ItemData.CreateItem(102));
                playerInv.Add(ItemData.CreateItem(200));
                playerInv.Add(ItemData.CreateItem(300));
                playerInv.Add(ItemData.CreateItem(400));
                playerInv.Add(ItemData.CreateItem(500));
                playerInv.Add(ItemData.CreateItem(600));
                playerInv.Add(ItemData.CreateItem(700));
            }
#endif

            if (Input.GetKeyDown(KeyBinds.keys["Inventory"]))
            {
                showInv = !showInv;
                GameManager.gamePlayState = showInv ? GamePlayStates.MenuPause : GamePlayStates.Game;
            }
        }

        void Display()
        {
            //if we want to display the whole inventory
            if (sortType == "All")
            {
                //if we have 34 or less (space at top/bottom)
                if (playerInv.Count <= 34)
                {
                    for (int i = 0; i < playerInv.Count; i++)
                    {
                        if (GUI.Button(new Rect(0.5f * GameManager.scr.x, 0.25f * GameManager.scr.y + i * (0.25f * GameManager.scr.y), 3 * GameManager.scr.x, 0.25f * GameManager.scr.y), playerInv[i].Name))
                        {
                            selectedItem = playerInv[i];
                        }
                    }
                }
                else //more than 34 items
                {
                    //our movable scroll position
                    scrollPos =
                        //the start of our viewable area
                        GUI.BeginScrollView(
                        //our view window
                        new Rect(0, 0.25f * GameManager.scr.y, 3.75f * GameManager.scr.x, 8.5f * GameManager.scr.y),
                        //our current position in that window
                        scrollPos,
                        //scroll zone (extra space) we can move within the view window
                        new Rect(0, 0, 0, playerInv.Count * 0.25f * GameManager.scr.y),
                        //can we see horizontal/vertical bar?
                        false, true);

                    for (int i = 0; i < playerInv.Count; i++)
                    {
                        if (GUI.Button(new Rect(0.5f * GameManager.scr.x, i * (0.25f * GameManager.scr.y), 3 * GameManager.scr.x, 0.25f * GameManager.scr.y), playerInv[i].Name))
                        {
                            selectedItem = playerInv[i];
                        }
                    }

                    GUI.EndScrollView();
                }
            }
            else //display based on type
            {
                ItemTypes type = (ItemTypes)System.Enum.Parse(typeof(ItemTypes), sortType);
                // amount of that type
                int a = 0;
                //slot position
                int s = 0;
                //search our list and if we find a match
                for (int i = 0; i < playerInv.Count; i++)
                {
                    if (playerInv[i].Type == type)
                    {
                        a++;
                    }
                }

                if (a <= 34)
                {
                    for (int i = 0; i < playerInv.Count; i++)
                    {
                        if (playerInv[i].Type == type)
                        {
                            if (GUI.Button(new Rect(0.5f * GameManager.scr.x, 0.25f * GameManager.scr.y + s * (0.25f * GameManager.scr.y), 3 * GameManager.scr.x, 0.25f * GameManager.scr.y), playerInv[i].Name))
                            {
                                selectedItem = playerInv[i];
                            }
                            s++;
                        }
                    }
                }
                else //more than 34 items
                {
                    //our movable scroll position
                    scrollPos =
                        //the start of our viewable area
                        GUI.BeginScrollView(
                        //our view window
                        new Rect(0, 0.25f * GameManager.scr.y, 3.75f * GameManager.scr.x, 8.5f * GameManager.scr.y),
                        //our current position in that window
                        scrollPos,
                        //scroll zone (extra space) we can move within the view window
                        new Rect(0, 0, 0, a * 0.25f * GameManager.scr.y),
                        //can we see horizontal/vertical bar?
                        false, true);

                    for (int i = 0; i < playerInv.Count; i++)
                    {
                        if (playerInv[i].Type == type)
                        {
                            if (GUI.Button(new Rect(0.5f * GameManager.scr.x, s * (0.25f * GameManager.scr.y), 3 * GameManager.scr.x, 0.25f * GameManager.scr.y), playerInv[i].Name))
                            {
                                selectedItem = playerInv[i];
                            }
                            s++;
                        }
                    }

                    GUI.EndScrollView();
                }
            }
        }

        void UseItem()
        {
            //empty box - 4/0.25/3.5/7
            GUI.Box(new Rect(4f * GameManager.scr.x, 1f * GameManager.scr.y, 3.5f * GameManager.scr.x, 7f * GameManager.scr.y), "");
            //icon - 4.25/0.5/3/3
            GUI.Box(new Rect(4.25f * GameManager.scr.x, 1.25f * GameManager.scr.y, 3f * GameManager.scr.x, 3f * GameManager.scr.y), selectedItem.Icon);
            //name - 4.55/3.5/2.5/0.5
            GUI.Box(new Rect(4.55f * GameManager.scr.x, 4.25f * GameManager.scr.y, 2.5f * GameManager.scr.x, 0.5f * GameManager.scr.y), selectedItem.Name);
        }

        private void OnGUI()
        {
            if (showInv)
            {
                GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "Inventory");
                for (int i = 0; i < enumTypesForItems.Length; i++)
                {
                    if (GUI.Button(new Rect(4f * GameManager.scr.x + i * GameManager.scr.x, GameManager.scr.y * 0.5f, GameManager.scr.x, 0.25f * GameManager.scr.y), enumTypesForItems[i]))
                    {
                        sortType = enumTypesForItems[i];
                        scrollPos = Vector2.zero;
                    }
                }
                Display();
                if (selectedItem != null)
                {
                    UseItem();
                }
            }
        }
    }

}
