using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animal_Manager : MonoBehaviour
{
    public Animals Animal;
    public Text animalName;
    public Sprite Itemicon;
    public GameObject prefab;

    private void Start()
    {
        animalName.text = Animal.animalName;
        Itemicon = Animal.icon;
    }

}
