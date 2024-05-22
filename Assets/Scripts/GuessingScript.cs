using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class GuessingScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI amountRolled;
    private int rollCount = 0;

    [SerializeField] TMP_InputField inputField;

    [SerializeField] Image background;

    // Start is called before the first frame update
    void Start()
    {
        amountRolled.text = "You have rolled " + rollCount + " times so far!";
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            Roll();
            amountRolled.text = "You have rolled " + rollCount + " times so far!";
        }
    }

    void Roll()
    {
        int realValue = UnityEngine.Random.Range(1, 100);
        rollCount++;
        Debug.Log(realValue);
        if(Int32.Parse(inputField.text) == realValue)
        {
            background.color = Color.green;
        }
        else
        {
            background.color = Color.red;
        }
    }

}
