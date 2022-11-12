using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake()
    {
        if (GameManager.instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        SceneManager.sceneLoaded += LoadState;
        DontDestroyOnLoad(gameObject);
    }

    // Resources
    public List<Sprite> playerSprites;
    public List<Sprite> weaponSprites;
    public List<int> weaponPrices;
    public List<int> xpTable;

    // References
    public player player;
    // public Weapon weapon

    // Logic
    public int gold;
    public int exp;
    // Save state
    // int preferedSkin
    // int gold
    // exp
    // weaponLevel
    public void SaveState()
    {
        string save = "";

        save += "0" + "|";
        save += gold.ToString() + "|";
        save += exp.ToString() + "|";
        save += "0";

        PlayerPrefs.SetString("SaveState", save);
    }
    public void LoadState(Scene save,LoadSceneMode mode)
    {
        if(!PlayerPrefs.HasKey("SaveState"))
        {
            return;
        }
        string[] data = PlayerPrefs.GetString("SaveState").Split('|');
        
        // change player skin

        // change gold
        gold = int.Parse(data[1]);
        // change exp
        exp = int.Parse(data[2]);
        // change weaponLevel

        Debug.Log("LoadState");
    }
}
