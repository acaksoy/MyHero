using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Armor : Item
{
    public enum Armor_Part { Helmet, Body_Armor, Bracer, Leg_Armor };

    private float ArmorRate;
    private Armor_Part ArmorPart;

    public Armor(SOS_Armor ArmorSO)
    {
        Coloum = ArmorSO.Coloum;
        Row = ArmorSO.Row;
        Item_Name = ArmorSO.ItemName;
        Description = ArmorSO.Description;
        Buying_Price = ArmorSO.BuyingPrice;
        Selling_Price = ArmorSO.SellingPrice;
        Item_Sprite = ArmorSO.ItemSprite;
        ArmorRate = ArmorSO.ArmorRate;
        ArmorPart = ArmorSO.ArmorPart;
    }
    public override void performAction()
    {
        
    }
    public string DESCR
    {
        get
        {
            return Description;
        }
    }

}
