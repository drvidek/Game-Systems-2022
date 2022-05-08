using UnityEngine;

public static class ItemData
{
    public static Item CreateItem(int _itemId)
    {
        string _name = "";
        string _desc = "";
        ItemTypes _type = ItemTypes.Food;
        int _value = 0;
        string _icon = "";
        string _prefab = "";
        int _amount = 0;
        int _damage = 0;
        int _armour = 0;
        int _heal = 0;

        switch (_itemId)
        {
            #region Food 0-99
            case 0:
                _name =     "Apple";
                _desc =     "Doctors are mysteriously absent when these are around.";
                _type =     ItemTypes.Food;
                _value =    1;
                _icon =     "Food/Apple";
                _prefab =   "Food/Apple";
                _amount =   1;
                _damage =   0;
                _armour =   0;
                _heal =     5;
                break;
            case 1:
                _name =     "Meat";
                _desc =     "They're made of meat.";
                _type =     ItemTypes.Food;
                _value =    5;
                _icon =     "Food/Meat";
                _prefab =   "Food/Meat";
                _amount =   1;
                _damage =   0;
                _armour =   0;
                _heal =     15;
                    break;
            #endregion
            #region Weapon 100-199
                #region Swords 100-109
                case 100:
                    _name =     "Common Sword";
                    _desc =     "Just a normal sword.";
                    _type =     ItemTypes.Weapon;
                    _value =    10;
                    _icon = "Weapon/Common Sword";
                    _prefab = "Weapon/Common Sword";
                    _amount =   1;
                    _damage =   2;
                    _armour =   0;
                    _heal =     0;
                        break;
                case 101:
                    _name = "Great Sword";
                    _desc = "A big ol' sword.";
                    _type = ItemTypes.Weapon;
                    _value = 40;
                    _icon = "Weapon/Great Sword";
                    _prefab = "Weapon/Great Sword";
                    _amount = 1;
                    _damage = 4;
                    _armour = 0;
                    _heal = 0;
                    break;
                #endregion
                #region Clubs 110-119
            case 110:
                _name = "Common Club";
                _desc = "A crude club.";
                _type = ItemTypes.Weapon;
                _value = 30;
                _icon = "Weapon/Common Club";
                _prefab = "Weapon/Common Club";
                _amount = 1;
                _damage = 4;
                _armour = 0;
                _heal = 0;
                break;
            case 111:
                _name = "Great Club";
                _desc = "A giant, crushing club.";
                _type = ItemTypes.Weapon;
                _value = 50;
                _icon = "Weapon/Great Club";
                _prefab = "Weapon/Great Club";
                _amount = 1;
                _damage = 6;
                _armour = 0;
                _heal = 0;
                break;
            #endregion
                #region Bows 120-129
            case 120:
                _name = "Common Bow";
                _desc = "A standard bow.";
                _type = ItemTypes.Weapon;
                _value = 25;
                _icon = "Weapon/Common Bow";
                _prefab = "Weapon/Common Bow";
                _amount = 1;
                _damage = 1;
                _armour = 0;
                _heal = 0;
                break;
            case 121:
                _name = "Great Bow";
                _desc = "A large, powerful bow.";
                _type = ItemTypes.Weapon;
                _value = 60;
                _icon = "Weapon/Great Bow";
                _prefab = "Weapon/Great Bow";
                _amount = 1;
                _damage = 3;
                _armour = 0;
                _heal = 0;
                break;
            #endregion
                #region Axes 130-139
            case 130:
                _name = "Common Axe";
                _desc = "For chopping wood, and limbs.";
                _type = ItemTypes.Weapon;
                _value = 30;
                _icon = "Weapon/Common Axe";
                _prefab = "Weapon/Common Axe";
                _amount = 1;
                _damage = 3;
                _armour = 0;
                _heal = 0;
                break;
            case 131:
                _name = "Great Axe";
                _desc = "A two sided axe.";
                _type = ItemTypes.Weapon;
                _value = 50;
                _icon = "Weapon/Great Axe";
                _prefab = "Weapon/Great Axe";
                _amount = 1;
                _damage = 5;
                _armour = 0;
                _heal = 0;
                break;
            #endregion
                #region Staff 140-149
            case 140:
                _name = "Common Staff";
                _desc = "Made from Mysticwood.";
                _type = ItemTypes.Weapon;
                _value = 10;
                _icon = "Weapon/Common Staff";
                _prefab = "Weapon/Common Staff";
                _amount = 1;
                _damage = 1;
                _armour = 0;
                _heal = 0;
                break;
            case 141:
                _name = "Great Staff";
                _desc = "Carries a Moonstone at the tip.";
                _type = ItemTypes.Weapon;
                _value = 40;
                _icon = "Weapon/Great Staff";
                _prefab = "Weapon/Great Staff";
                _amount = 1;
                _damage = 2;
                _armour = 0;
                _heal = 0;
                break;
            #endregion
            #endregion
            #region Apparel 200-299
                #region Common Gear 200-204
            case 200:
                _name =     "Common Helm";
                _desc =     "A crude helmet.";
                _type =     ItemTypes.Apparel;
                _value =    10;
                _icon = "Apparel/Common Helm";
                _prefab = "Apparel/Common Helm";
                _amount =   1;
                _damage =   0;
                _armour =   2;
                _heal =     0;
                    break;
            case 201:
                _name = "Common Breastplate";
                _desc = "A crude breastplate.";
                _type = ItemTypes.Apparel;
                _value = 25;
                _icon = "Apparel/Common Breastplate";
                _prefab = "Apparel/Common Breastplate";
                _amount = 1;
                _damage = 0;
                _armour = 3;
                _heal = 0;
                break;
            case 202:
                _name = "Common Gloves";
                _desc = "Crude gloves.";
                _type = ItemTypes.Apparel;
                _value = 15;
                _icon = "Apparel/Common Gloves";
                _prefab = "Apparel/Common Gloves";
                _amount = 1;
                _damage = 0;
                _armour = 1;
                _heal = 0;
                break;
            case 203:
                _name = "Common Pants";
                _desc = "Crude pants.";
                _type = ItemTypes.Apparel;
                _value = 20;
                _icon = "Apparel/Common Pants";
                _prefab = "Apparel/Common Pants";
                _amount = 1;
                _damage = 0;
                _armour = 2;
                _heal = 0;
                break;
            case 204:
                _name = "Common Boots";
                _desc = "Crude boots.";
                _type = ItemTypes.Apparel;
                _value = 15;
                _icon = "Apparel/Common Boots";
                _prefab = "Apparel/Common Boots";
                _amount = 1;
                _damage = 0;
                _armour = 1;
                _heal = 0;
                break;
            #endregion
                #region Soldier Gear 205-209
            case 205:
                _name = "Soldier Helm";
                _desc = "A standard issue helmet.";
                _type = ItemTypes.Apparel;
                _value = 30;
                _icon = "Apparel/Soldier Helm";
                _prefab = "Apparel/Soldier Helm";
                _amount = 1;
                _damage = 0;
                _armour = 3;
                _heal = 0;
                break;
            case 206:
                _name = "Soldier Breastplate";
                _desc = "A standard issue breastplate.";
                _type = ItemTypes.Apparel;
                _value = 50;
                _icon = "Apparel/Soldier Breastplate";
                _prefab = "Apparel/Soldier Breastplate";
                _amount = 1;
                _damage = 0;
                _armour = 5;
                _heal = 0;
                break;
            case 207:
                _name = "Soldier Gloves";
                _desc = "Standard issue gloves.";
                _type = ItemTypes.Apparel;
                _value = 20;
                _icon = "Apparel/Soldier Gloves";
                _prefab = "Apparel/Soldier Gloves";
                _amount = 1;
                _damage = 0;
                _armour = 2;
                _heal = 0;
                break;
            case 208:
                _name = "Soldier Pants";
                _desc = "Standard issue pants.";
                _type = ItemTypes.Apparel;
                _value = 40;
                _icon = "Apparel/Soldier Pants";
                _prefab = "Apparel/Soldier Pants";
                _amount = 1;
                _damage = 0;
                _armour = 4;
                _heal = 0;
                break;
            case 209:
                _name = "Soldier Boots";
                _desc = "Standard issue boots.";
                _type = ItemTypes.Apparel;
                _value = 20;
                _icon = "Apparel/Soldier Boots";
                _prefab = "Apparel/Soldier Boots";
                _amount = 1;
                _damage = 0;
                _armour = 2;
                _heal = 0;
                break;
            #endregion
                #region Misc Belts 290-299
            case 290:
                _name =     "Thick Belt";
                _desc =     "For thick bellies.";
                _type =     ItemTypes.Apparel;
                _value =    25;
                _icon =     "Apparel/Thick Belt";
                _prefab =   "Apparel/Thick Belt";
                _amount =   1;
                _damage =   0;
                _armour =   2;
                _heal =     0;
                    break;
            case 291:
                _name = "Moonlight Belt";
                _desc = "The power of the moon heals the wearer over time.";
                _type = ItemTypes.Apparel;
                _value = 60;
                _icon = "Apparel/Moonlight Belt";
                _prefab = "Apparel/Moonlight Belt";
                _amount = 1;
                _damage = 0;
                _armour = 2;
                _heal = 1;
                break;
            #endregion
            #endregion
            #region Crafting 300-399
            case 300:
                _name = "Gem";
                _desc = "Ooh, shiny!";
                _type = ItemTypes.Crafting;
                _value = 30;
                _icon = "Crafting/Gem";
                _prefab = "Crafting/Gem";
                _amount = 1;
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            case 301:
                _name = "Ingot";
                _desc = "Metal to make stuff with.";
                _type = ItemTypes.Crafting;
                _value = 10;
                _icon = "Crafting/Ingot";
                _prefab = "Crafting/Ingot";
                _amount = 1;
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            #endregion
            #region Ingredients 400-499
            case 400:
                _name = "Animal Fat";
                _desc = "Used for making potions.";
                _type = ItemTypes.Ingredient;
                _value = 5;
                _icon = "Ingredients/Animal Fat";
                _prefab = "Ingredients/Animal Fat";
                _amount = 1;
                _damage = 0;
                _armour = 0;
                _heal = 2;
                break;
            case 401:
                _name = "Blackfruit";
                _desc = "Used for making potions.";
                _type = ItemTypes.Ingredient;
                _value = 5;
                _icon = "Ingredients/Blackfruit";
                _prefab = "Ingredients/Blackfruit";
                _amount = 1;
                _damage = 3;
                _armour = 0;
                _heal = 0;
                break;
            case 402:
                _name = "Bone";
                _desc = "Used for making potions.";
                _type = ItemTypes.Ingredient;
                _value = 5;
                _icon = "Ingredients/Bone";
                _prefab = "Ingredients/Bone";
                _amount = 1;
                _damage = 5;
                _armour = 0;
                _heal = 0;
                break;
            case 403:
                _name = "Bottlebush";
                _desc = "Used for making potions.";
                _type = ItemTypes.Ingredient;
                _value = 5;
                _icon = "Ingredients/Bottlebush";
                _prefab = "Ingredients/Bottlebush";
                _amount = 1;
                _damage = 0;
                _armour = 0;
                _heal = 7;
                break;
            case 404:
                _name = "Charcoal";
                _desc = "Used for making potions.";
                _type = ItemTypes.Ingredient;
                _value = 5;
                _icon = "Ingredients/Charcoal";
                _prefab = "Ingredients/Charcoal";
                _amount = 1;
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            case 405:
                _name = "Copperseed";
                _desc = "Used for making potions.";
                _type = ItemTypes.Ingredient;
                _value = 5;
                _icon = "Ingredients/Copperseed";
                _prefab = "Ingredients/Copperseed";
                _amount = 1;
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            case 406:
                _name = "Groundsprout";
                _desc = "Used for making potions.";
                _type = ItemTypes.Ingredient;
                _value = 5;
                _icon = "Ingredients/Groundsprout";
                _prefab = "Ingredients/Groundsprout";
                _amount = 1;
                _damage = 0;
                _armour = 0;
                _heal = 3;
                break;
            case 407:
                _name = "Mushroom";
                _desc = "Used for making potions.";
                _type = ItemTypes.Ingredient;
                _value = 5;
                _icon = "Ingredients/Mushroom";
                _prefab = "Ingredients/Mushroom";
                _amount = 1;
                _damage = 0;
                _armour = 0;
                _heal = 5;
                break;
            case 408:
                _name = "Prickly Pear";
                _desc = "Used for making potions.";
                _type = ItemTypes.Ingredient;
                _value = 5;
                _icon = "Ingredients/Prickly Pear";
                _prefab = "Ingredients/Prickly Pear";
                _amount = 1;
                _damage = 2;
                _armour = 0;
                _heal = 0;
                break;
            case 409:
                _name = "Trilleaf";
                _desc = "Used for making potions.";
                _type = ItemTypes.Ingredient;
                _value = 5;
                _icon = "Ingredients/Trilleaf";
                _prefab = "Ingredients/Trilleaf";
                _amount = 1;
                _damage = 0;
                _armour = 0;
                _heal = 3;
                break;
            #endregion
            #region Potion 500-599
            case 500:
                _name = "Health Potion";
                _desc = "Restores HP.";
                _type = ItemTypes.Potion;
                _value = 20;
                _icon = "Potions/Health Potion";
                _prefab = "Potions/Health Potion";
                _amount = 1;
                _damage = 0;
                _armour = 0;
                _heal = 30;
                break;
            case 501:
                _name = "Mana Potion";
                _desc = "Restores mana.";
                _type = ItemTypes.Potion;
                _value = 20;
                _icon = "Potions/Mana Potion";
                _prefab = "Potions/Mana Potion";
                _amount = 1;
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            #endregion
            #region Scroll 600-699
                #region Books 600-610
            case 600:
                _name = "Book of Ancients";
                _desc = "Contains knowledge of an ancient place.";
                _type = ItemTypes.Scroll;
                _value = 120;
                _icon = "Scrolls/Book of Ancients";
                _prefab = "Scrolls/Book of Ancients";
                _amount = 1;
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            case 601:
                _name = "Book of Demeter";
                _desc = "Contains knowledge of plants and animals.";
                _type = ItemTypes.Scroll;
                _value = 120;
                _icon = "Scrolls/Book of Demeter";
                _prefab = "Scrolls/Book of Demeter";
                _amount = 1;
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            case 602:
                _name = "Book of Secrets";
                _desc = "Contains knowledge of hidden places and treasures.";
                _type = ItemTypes.Scroll;
                _value = 120;
                _icon = "Scrolls/Book of Demeter";
                _prefab = "Scrolls/Book of Demeter";
                _amount = 1;
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            #endregion
            #endregion
            #region Quest 700-799
                #region Rings 700-709
            case 700:
                _name = "Blood Ring";
                _desc = "Dark magic heals the user when they damage their enemies.";
                _type = ItemTypes.Quest;
                _value = 100;
                _icon = "Quest/Blood Ring";
                _prefab = "Quest/Blood Ring";
                _amount = 1;
                _damage = 0;
                _armour = 0;
                _heal = 5;
                break;
            case 701:
                _name = "Crimson Ring";
                _desc = "Uses Dragonstone to conjure fire.";
                _type = ItemTypes.Quest;
                _value = 100;
                _icon = "Quest/Blood Ring";
                _prefab = "Quest/Blood Ring";
                _amount = 1;
                _damage = 6;
                _armour = 0;
                _heal = 0;
                break;
            case 702:
                _name = "Verdant Ring";
                _desc = "A connection to nature heals the wearer over time.";
                _type = ItemTypes.Quest;
                _value = 100;
                _icon = "Quest/Verdant Ring";
                _prefab = "Quest/Verdant Ring";
                _amount = 1;
                _damage = 0;
                _armour = 0;
                _heal = 3;
                break;
            case 703:
                _name = "Violet Ring";
                _desc = "Grants bonus attack power to the wearer.";
                _type = ItemTypes.Quest;
                _value = 100;
                _icon = "Quest/Violet Ring";
                _prefab = "Quest/Violet Ring";
                _amount = 1;
                _damage = 2;
                _armour = 0;
                _heal = 0;
                break;
            case 704:
                _name = "Watcher Ring";
                _desc = "Watcher magic allows the wearer to move undetected.";
                _type = ItemTypes.Quest;
                _value = 100;
                _icon = "Quest/Watcher Ring";
                _prefab = "Quest/Watcher Ring";
                _amount = 1;
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            #endregion
                #region Necklaces 710-719
            case 710:
                _name = "Amethyst Necklace";
                _desc = "Boost the wearer's defense.";
                _type = ItemTypes.Quest;
                _value = 100;
                _icon = "Quest/Amethyst Necklace";
                _prefab = "Quest/Amethyst Necklace";
                _amount = 1;
                _damage = 0;
                _armour = 2;
                _heal = 0;
                break;
            case 711:
                _name = "Ancient Necklace";
                _desc = "No obvious effect when worn.";
                _type = ItemTypes.Quest;
                _value = 100;
                _icon = "Quest/Ancient Necklace";
                _prefab = "Quest/Ancient Necklace";
                _amount = 1;
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            case 712:
                _name = "Bloodrot Necklace";
                _desc = "Inflicts Bloodrot on those who attack the wearer.";
                _type = ItemTypes.Quest;
                _value = 100;
                _icon = "Quest/Bloodrot Necklace";
                _prefab = "Quest/Bloodrot Necklace";
                _amount = 1;
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            case 713:
                _name = "Emerald Necklace";
                _desc = "Increases the effect of healing items.";
                _type = ItemTypes.Quest;
                _value = 100;
                _icon = "Quest/Emerald Necklace";
                _prefab = "Quest/Emerald Necklace";
                _amount = 1;
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            case 714:
                _name = "Helios Necklace";
                _desc = "Shines brightly in darkness.";
                _type = ItemTypes.Quest;
                _value = 100;
                _icon = "Quest/Helios Necklace";
                _prefab = "Quest/Helios Necklace";
                _amount = 1;
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            #endregion
            #endregion
            #region Misc 800-899
            case 800:
                _name = "Money";
                _desc = "Make it rain!";
                _type = ItemTypes.Money;
                _value = 1;
                _icon = "Money/Money";
                _prefab = "Money/Money";
                _amount = 1;
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            #endregion

            #region Default
            default:
                _itemId = 0;
                _name = "Apple";
                _desc = "Doctors are mysteriously absent when these are around";
                _type = ItemTypes.Food;
                _value = 1;
                _icon = "Food/Apple";
                _prefab = "Food/Apple";
                _amount = 1;
                _damage = 0;
                _armour = 0;
                _heal = 10;
                break;
            #endregion
        }

        Item temp = new Item()
        {
            Id = _itemId,
            Name = _name,
            Desc = _desc,
            Type = _type,
            Value = _value,
            Icon = Resources.Load("Icon/" + _icon) as Texture2D,
            Prefab = Resources.Load("Prefab/" + _prefab) as GameObject,
            Amount = _amount,
            Damage = _damage,
            Armour = _armour,
            Heal = _heal,
        };
        return temp;
    }
}
