using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
namespace Inventory
{
    [CreateAssetMenu(fileName = "New Item", menuName = "Invontory/New Item")]
    public class Item : ScriptableObject
    {
        //一个物品的属性
        public int id;
        public string itemName;
        public Sprite itemImage;
        [TextArea]
        public string itemInfo;
        public GameObject itemPrefab;
        public ArmorType armorType;



    }
}
