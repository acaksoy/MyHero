using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Item
{
    public int Coloum;
    public int Row;
    public string Item_Name;
    public string Description;
    public int Buying_Price;
    public int Selling_Price;
    public Texture2D Item_Sprite;
    public bool isItStackable;
    public int Amount;

    public abstract void performAction();
    
   
}
