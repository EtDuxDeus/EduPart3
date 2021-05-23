using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadAssetBundle : MonoBehaviour
{
    private Image _imageHolder;


    private void Awake()
    {
        _imageHolder = GetComponent<Image>();
    }


    private void Start()
    {
        LoadTextureFromFile();
    }


    private void LoadTextureFromFile()
    {
        AssetBundle loadedAssetBundle = AssetBundle.LoadFromFile(Application.dataPath + "/AssetBundles/nekospritebundle.sprites");
        Texture2D spriteForImageHolder = loadedAssetBundle.LoadAsset<Texture2D>("53f98a6b76f60356b2b4c261963377e6");
        _imageHolder.sprite = Sprite.Create(spriteForImageHolder, new Rect(0.0f, 0.0f, spriteForImageHolder.width, spriteForImageHolder.height), new Vector2(0.5f, 0.5f), 100.0f);
    }
}
