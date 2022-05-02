using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameUIHundler : MonoBehaviour
{
    public Text titleName;

    // Start is called before the first frame update
    void Start()
    {
        titleName.text = MenuUIHandler.playerName + "! Click on gems !!";
    }
}
