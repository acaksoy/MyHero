using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Armor", menuName = "ScriptableObjects/Armor")]
public class SOS_Armor : ScriptableObject
{
    public int Coloum;
    public int Row;
    public string ItemName;
    public string Description;
    public int BuyingPrice;
    public int SellingPrice;
    public Texture2D ItemSprite;
    public float ArmorRate;
    public Armor.Armor_Part ArmorPart;
    public bool isItstackable;
}
