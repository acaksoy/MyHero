using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public List<Item> Item_List = new List<Item>();
    private All_SOS_Classes All_SOS;

    public Slots[,] slots = new Slots[5, 8];
    private float SlotPosX = 24;
    private float SlotPosY = 835;
    private float spaceBetweenSlotsX = 14.5f;
    private float spaceBetweenSlotsY = 14.5f;
    public Text[] slotText;   
    
    private void Awake()
    {
        All_SOS = GetComponent<All_SOS_Classes>();
        setSlots();
        AddItem(new Potions(All_SOS.HealthPotion));
        AddItem(new Potions(All_SOS.HealthPotion));
        AddItem(new Potions(All_SOS.HealthPotion));
        AddItem(new Potions(All_SOS.HealthPotion));
        AddItem(new Potions(All_SOS.HealthPotion));
        AddItem(new Potions(All_SOS.HealthPotion));
        AddItem(new Potions(All_SOS.HealthPotion));
        AddItem(new Potions(All_SOS.HealthPotion));

        AddItem(new Armor(All_SOS.IronArmor));
        AddItem(new Armor(All_SOS.IronArmor));
        AddItem(new Armor(All_SOS.IronArmor));

        AddItem(new Potions(All_SOS.HealthPotion));
        AddItem(new Potions(All_SOS.HealthPotion));
        AddItem(new Potions(All_SOS.HealthPotion));
        AddItem(new Potions(All_SOS.HealthPotion));

        AddItem(new Armor(All_SOS.IronArmor));
        AddItem(new Armor(All_SOS.IronArmor));
        AddItem(new Armor(All_SOS.IronArmor));

        AddItem(new Armor(All_SOS.IronArmor));
        AddItem(new Armor(All_SOS.IronArmor));
        AddItem(new Armor(All_SOS.IronArmor));

        AddItem(new Potions(All_SOS.HealthPotion));
        AddItem(new Potions(All_SOS.HealthPotion));
        AddItem(new Potions(All_SOS.HealthPotion));
        AddItem(new Potions(All_SOS.HealthPotion));
        AddItem(new Potions(All_SOS.HealthPotion));
        AddItem(new Potions(All_SOS.HealthPotion));
        AddItem(new Potions(All_SOS.HealthPotion));
        AddItem(new Potions(All_SOS.HealthPotion));

    }
    private void OnGUI()
    {
        drawSlots();
    }
    private void Update()
    {
       //ttps://answers.unity.com/questions/542356/touching-a-gui-texture.html

    }
    public void AddItem(Item NewItem)
    {
        if (NewItem.isItStackable) // Text arrayi ile yapilabilir.
        {
            for(int i=0; i < Item_List.Count; i++)
            {
                if(Item_List[i].Item_Name == NewItem.Item_Name && Item_List[i].Amount < 5) // En son Amount 4 olarak giriyor ama satir 48´de 1 aarttiriyor. Bu yüzden 5 oluyor.
                {
                    Item_List[i].Amount++;
                    for (int Row = 0; Row < 5; Row++) //Checking for free slots
                    {
                        for (int Coloum = 0; Coloum < 8; Coloum++)
                        {
                            if(Item_List[i] == slots[Row, Coloum].itemOnSlot)
                            {
                                slotText[((Row + 1) * 8 - (8 - Coloum))].gameObject.SetActive(true); // (Row+1)*8 - (8-Coloum) örnek= (2,4) slotundaki textin index numarasi = (2+1)*8 - (8-4) = 20 (0 ile basliyarak soldan saga numaralandirildinga (2,4)slotta 20 text var)
                                slotText[((Row + 1) * 8 - (8 - Coloum))].text = Item_List[i].Amount.ToString(); // Sanirim Coloum ve Rowu karistirdim :D isimleri degistir
                                return;
                            }
                        }
                    }
                            //return;  
                }
            }
        }
        for (int Row = 0; Row < 5; Row++) //Checking for free slots
        {
            for (int Coloum = 0; Coloum < 8; Coloum++) //Checking for free slots
            {
                if (!slots[Row, Coloum].isItFull && SlotConditionCheck(Row,Coloum,NewItem.Row,NewItem.Coloum)) //Checking for free slots
                {
                    Item_List.Add(NewItem);
                    slots[Row, Coloum].itemOnSlot = NewItem;
                    for (int i = Row; i < Row + NewItem.Row; i++)
                    {                     
                        for (int j = Coloum; j < Coloum + NewItem.Coloum; j++)
                        {
                            slots[i, j].isItFull = true;

                        }
                    }
                    return;
                }
            }
        }

    }
    bool SlotConditionCheck(int Row, int Coloum, int itemRow, int itemColoum)
    {
        bool isItFree = true;
        for(int i=Row; i< Row + itemRow; i++)
        {   
            if(Row+itemRow   > 5)
            {
                return false;
            }
            for(int j=Coloum; j < Coloum + itemColoum; j++)
            {
                if (Coloum + itemColoum > 8 || slots[i,j].isItFull)
                {
                    return false;
                }
                

            }
        }
        return isItFree;
    }
   
    void setSlots()
    {
        int TempColoum = 0;
        int TempRow = 0;
        for (int Row = 0; Row < 5; Row++)
        {
            TempRow = Row;
            for(int Coloum = 0; Coloum < 8; Coloum++)
            {
                TempColoum = Coloum;
                slots[TempRow, TempColoum] = new Slots(SlotPosX, SlotPosY);
                SlotPosX += spaceBetweenSlotsX + slots[TempRow, TempColoum].SlotWidth; 
            }
            SlotPosX = 24;
            SlotPosY += spaceBetweenSlotsY + slots[TempRow, TempColoum].SlotHeight;

        }

    }
   
    void drawSlots()
    {
        for (int Row = 0; Row < 5; Row++)
        {
            for (int Coloum = 0; Coloum < 8; Coloum++)
            {
                if (slots[Row, Coloum].isItFull && slots[Row,Coloum].itemOnSlot != null)
                {
                    slots[Row, Coloum].draw();
                   
                }
            }
        }
    }

    void deleteItem()
    {

    }
 
}
