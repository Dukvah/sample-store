using UnityEngine;

[CreateAssetMenu(fileName = "ClickableItem", menuName = "Scriptable/Item")] 
public class SCItem : ScriptableObject
{
    public int itemIndex;
    public string itemName;
    public int price;
    public int weight;
}
