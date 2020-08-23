using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 



public class NameTransfer : MonoBehaviour
{

    public string theName;
    public GameObject inputField;
    public GameObject textDisplay;

    public void StoreName()
    {
        theName = inputField.GetComponent<Text>().text;
        textDisplay.GetComponent<Text>().text = "안녕하세요 " + theName + "님 게임을 플레이해주셔서 감사합니다.";
    }



}
