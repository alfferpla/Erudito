using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*Este script me permite crear ScriptableObjects (objetos de información) quito monobehabior y lo sustituyo*/

[CreateAssetMenu(fileName = "Question", menuName = "Preguntas")]
public class ScriptableQuestion : ScriptableObject
{
    public Sprite questionImage;
    public string questionTitle;

    public string[] answers;
    public int rightAnswer;
}
