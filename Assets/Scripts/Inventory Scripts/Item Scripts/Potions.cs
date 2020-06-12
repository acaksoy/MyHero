using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Potions : Item
{
    public enum Potion_Type { Health_Potion, Mana_Potion, Stamina_Potion };
    public Potion_Type PotionType;
    public float HealthPlus;
    public float ManaPlus;
    public float StaminaPlus;
    

    public Potions(SOS_Potion PotionSO)
    {
        Coloum = PotionSO.Coloum;
        Row = PotionSO.Row;
        Item_Name = PotionSO.ItemName;
        Description = PotionSO.Description;
        Buying_Price = PotionSO.BuyingPrice;
        Selling_Price = PotionSO.SellingPrice;
        Item_Sprite = PotionSO.ItemSprite;
        HealthPlus = PotionSO.HealthPlus;
        ManaPlus = PotionSO.ManaPlus;
        StaminaPlus = PotionSO.StaminaPlus;
        PotionType = PotionSO.PotionType;
        isItStackable = PotionSO.isItstackable;
        Amount = PotionSO.Amount;
    }
    public override void performAction()
    {

    }
    public string ITEMNAME
    {
        get
        {
            return Item_Name;
        }
    }
}
