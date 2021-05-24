using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ItemsList
{
    [System.Serializable]
    public class Items
    {
        [SerializeField]
        private int _ID;

        public string name = "NewItem";
        public int cost = 0;
        public float weight = 0;
        public Texture2D texture;
        public Material material;
    }
}
