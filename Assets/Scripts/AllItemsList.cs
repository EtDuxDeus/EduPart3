using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ItemsList
{
    [CreateAssetMenu(fileName = "ItemList", menuName = "CreateItemList", order = 1)]
    public class AllItemsList : ScriptableObject
    {
        public List<Items> ItemList;
    }
}
