using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageManager : MonoBehaviour
{

    int index = 0;

    string[] messages = {
        "\"You can navigate the menu by clicking on it.\"",
        "\"Before eating a muffin, try removing the paper. It tastes much better that way!\"",
        "\"To pour water out of a boot, look for instructions on the heel.\"",
        "\"Hot chocolate mix! Hot not included.\"",
        "\"Hot chocolate mix! Mix not included.\"",
        "\"When your opponent has a high ping, show no mercy.\" -Sun Tzu",
        "\"You miss 100% of the shots you miss.\"",
        "\"If you can find Waldo hidden on this start screen, you'll win a special prize!\""
    };

    // Start is called before the first frame update
    void Start()
    {
        index = Random.Range(0,messages.Length);
        GetComponent<TMPro.TextMeshProUGUI>().text = messages[index];
    }
}
