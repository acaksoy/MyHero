using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slots
{
    public Item itemOnSlot;
    public Rect position;
    public bool isItFull = false;
    public float posX;
    public float posY;
    public float SlotWidth = 71.5f;
    public float SlotHeight = 72;


    public Slots(float posX, float posY)
    {
        this.posX = posX;
        this.posY = posY;
        position.Set(this.posX, this.posY, SlotWidth, SlotHeight);
    }

    public void draw()
    {       
        position.width = itemOnSlot.Coloum * SlotWidth;
        position.height = itemOnSlot.Row * SlotHeight;
        GUI.DrawTexture(position, itemOnSlot.Item_Sprite);
    }

    public void EmptySlot()
    {
        itemOnSlot = null;
        isItFull = false;
    }
}
