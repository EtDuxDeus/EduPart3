using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ItemsList
{
    [System.Serializable]
    public class Items
    {
        [SerializeField]
        private int ItemId;

        public string ItemName = "NewItem";
        public int ItemCost = 0;
        public float ItemWeight = 0;
        public Texture2D ItemTexture;
        public Material ItemMaterial;
    }
}
