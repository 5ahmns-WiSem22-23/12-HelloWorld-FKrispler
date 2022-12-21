using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloVerzweigung : MonoBehaviour
{
    int tempInd = 32;

    int grade = 49;

    int hour = 16;

    // Start is called before the first frame update
    void Start()
    {
        //Weterbericht
        if (tempInd > 30)
        {
            Debug.Log("Es ist heiß draußen!");
        }

        //Noten
        if (grade >= 50)
        {
            Debug.Log("Du hast bestanden!");
        }
        else
        {
            Debug.Log("Nicht bestanden.");
        }

        Debug.Log("Ternär: " + ((grade>=50)? "Du hast bestanden!": "Nicht bestanden."));

        if (hour < 12)
        {
            Debug.Log("Guten Morgen!");
        }
        else if (hour < 18)
        {
            Debug.Log("Guten Nachmittag!");
        }
        else
        {
            Debug.Log("Guten Abend!");
        }

    }
}
