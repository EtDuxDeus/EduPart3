using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ItemsList
{
    [System.Serializable]
    public class Item : MonoBehaviour
    {
        public string ItemName = "NewItem";
        public int ItemCost = 0;
        public float ItemWeight = 0;
    }
}
