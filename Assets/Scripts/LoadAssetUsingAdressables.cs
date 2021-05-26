using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AddressableAssets;


namespace Tools
{
    public class LoadAssetUsingAdressables : MonoBehaviour
    {
        private Image _imageHolder;


        private void Awake()
        {
            _imageHolder = GetComponent<Image>();
        }


        private void Update()
        {
            OverloadTexture();
        }


        private void OverloadTexture()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Texture2D texture = new Texture2D(0, 0);
                texture = Addressables.LoadAssetAsync<Texture2D>("Wall-E").Result;
                if (texture == null) return;
                _imageHolder.sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100.0f);
            }
        }
    }
}
