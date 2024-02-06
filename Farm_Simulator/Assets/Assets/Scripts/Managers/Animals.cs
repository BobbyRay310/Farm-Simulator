using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "Animals", menuName ="Animals/Create new Animals")]
public class Animals : ScriptableObject
{
    public int id;
    public string animalName;
    public Sprite icon;
    public GameObject prefab;

}
