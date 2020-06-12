using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Potion", menuName = "ScriptableObjects/Potion")]
public class SOS_Potion : ScriptableObject
{
    public int Coloum;
    public int Row;
    public Potions.Potion_Type PotionType;
    public string ItemName;
    public string Description;
    public int BuyingPrice;
    public int SellingPrice;
    public Texture2D ItemSprite;
    public float HealthPlus;
    public float ManaPlus;
    public float StaminaPlus;
    public bool isItstackable;
    public int Amount;


}
