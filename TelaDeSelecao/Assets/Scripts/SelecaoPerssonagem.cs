using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelecaoPerssonagem : MonoBehaviour
{
    public Sprite spriteSelecionado;

    public Sprite spriteNaoSelecionado;

    public Sprite personagemFoto;

    public int hp;
    public int xp;
    public int atk;

    public bool selecionado;

    void Start()
    {
        var spritePersonagem = transform.GetChild(2).GetComponent<Image>();
        spritePersonagem.sprite = personagemFoto;

        var slideHP = transform.GetChild(0).GetComponentInChildren<Slider>();
        slideHP.value = hp;

        var sliderXP = transform.GetChild(1).GetComponentInChildren<Slider>();
        sliderXP.value = xp;

        var sliderATK = transform.GetChild(3).GetComponentInChildren<Slider>();
        sliderATK.value = atk;

        if (selecionado)
            AtivarBotao();
        else
            DesativarBotao();
    }
   
    public void AtivarBotao()
    {
        selecionado = true;
        GetComponent<Image>().sprite = spriteSelecionado;
    }
    public void DesativarBotao()
    {
        selecionado = true;
        GetComponent<Image>().sprite = spriteNaoSelecionado;
    }
    public void Clicou()
    {
        var listaBotoes = FindObjectsOfType<SelecaoPerssonagem>();
            foreach(var botao in listaBotoes)
        {
            botao.DesativarBotao();
        }
        AtivarBotao();
    }

}
