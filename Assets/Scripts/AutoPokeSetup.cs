using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AutoPokeSetup : MonoBehaviour
{
    public Pokemon pokemon;
    public void Start()
    {
        TMP_Text text = GetComponentInChildren<TMP_Text>();
        if (text != null) text.text = pokemon.name;
        Image icon = GetComponentInChildren<Image>();
        if (icon != null) icon.sprite = pokemon.icon;
    }
}
