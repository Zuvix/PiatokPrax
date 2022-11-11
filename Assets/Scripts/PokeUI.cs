using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PokeUI : MonoBehaviour
{
    public GameObject pokemonPanel;
    private Pokemon selectedPokemon;
    public TMP_Text nameTxt, typeTxt, levelTxt, HPTxt, attackTxt, defenseTxt;
    public Image icon;
    public Image background;
    public Image nextEvolutionImage;
    public TMP_Text nextEvolutionText;

    public void SelectPokemon(Pokemon pokemon)
    {
        if (pokemonPanel != null) pokemonPanel.gameObject.SetActive(true);
        selectedPokemon = pokemon;
        if (nameTxt != null) nameTxt.text = pokemon.name;
        if (typeTxt != null)
        {
            typeTxt.text = ""; 
            if (pokemon.pokeTypes != null)
            {
                foreach (Type pokeType in pokemon.pokeTypes)
                {
                    typeTxt.text += pokeType+" ";
                }
            }
            
        }
        if (levelTxt != null) levelTxt.text = pokemon.level.ToString();
        if (attackTxt != null) attackTxt.text = pokemon.attack.ToString();
        if (HPTxt != null) HPTxt.text = pokemon.HP.ToString();
        if (defenseTxt != null) defenseTxt.text = pokemon.defense.ToString();
        if (background != null) background.color = pokemon.color;
        if (icon != null &&pokemon.icon!=null) icon.sprite = pokemon.icon;
        if (pokemon.nextEvolution != null)
        {
            if (nextEvolutionImage != null) nextEvolutionImage.sprite = pokemon.nextEvolution.icon;
            if (nextEvolutionText != null) nextEvolutionText.text = pokemon.nextEvolution.name;
        }

    }
}
