using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Book")]
public class BookScript : ScriptableObject
{
    public List<PageClass> page = new List<PageClass>();



}
