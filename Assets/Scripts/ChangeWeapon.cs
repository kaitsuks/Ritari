using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeWeapon : MonoBehaviour
{
    public GameObject spriteObjekti;
    Dropdown dd;
    SpriteRenderer m_SpriteRenderer;
    Sprite sword;
    Sprite axe;
    Sprite lasergun;
    Color color;
    int selected;

    /*
     * Tee Dropdown
Tee skenelle sprite-objekti, jonka kuvaa tullaan vaihtamaan
Liitä Dropdowniin seuraava koodi:
Tee Assets-kansion alle Resources-niminen kansio
Tee sen alle Weapons-kansio – tai mikä tahansa, mitä haluat käyttää
Tallenna sinne ko. Spritet, ja vaihda koodissa nimet vastaaviksi 
Liitä ChangeWeapon-koodi valintalistaan (Dropdown)
On Value Changed (Int32) -kohtaan lisää (+) ja valitse objektiksi valintalista itse
Hae metodi ChangeWeapon.Vaihda
Hae Sprite objekti ChangeWeapon-skriptiin
Jos kaikki hyvin, valintalistasta voi valita näytettävän spriten
Laita vielä sopivat tekstit valintalistan Optionsiin
     */

    void Start()
    {
        dd = GetComponent<Dropdown>();
        m_SpriteRenderer = spriteObjekti.GetComponent<SpriteRenderer>();
        sword = Resources.Load<UnityEngine.Sprite>("Weapons/Sword");
        axe = Resources.Load<UnityEngine.Sprite>("Weapons/Axe");
        lasergun = Resources.Load<UnityEngine.Sprite>("Weapons/Lasergun");
    }

    public void Vaihda()
    {
        selected = dd.value;
        Debug.Log("Valittu " + selected);

        if (selected == 0) m_SpriteRenderer.sprite = sword;
        if (selected == 1) m_SpriteRenderer.sprite = axe;
        if (selected == 2) m_SpriteRenderer.sprite = lasergun;
    }
}

