using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameManager : MonoBehaviour
{
    public InputField inputField;

    public void ChangeName()
    {
        if(GameManager.Instance != null)
        {
            GameManager.Instance.currentName = inputField.text;
        }
    }
}
