using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloOperatoren : MonoBehaviour
{
    
    //Zuweisungs Operatoren
    int x = 3;
    int y = 4;

    bool t;
    void Start()
    {
        Debug.Log("Variable x ist:" + x);
        Debug.Log("Variable y ist:" + y);

        //arithmetische Operatoren
        Debug.Log("ADDITION x+y:" + (x + y));
        Debug.Log("SUBTRAKTION x-y:" + (x - y));
        Debug.Log("MULTIPLIKATION x*y:" + (x * y));
        Debug.Log("DIVISION x/y:" + (x / y));
        Debug.Log("MODULOOPERATOR x%y:" + (x % y));


        //Vergleichsoperatoren

        if (x < y)
        {
            Debug.Log("x ist kleiner als y");
        }

        if (x != y)
        {
            Debug.Log("x ist nicht y");
        }

        //Inkrement - und Dekrementoperatoren
        Debug.Log("Inkrementoperator(x++ Plus eins):" + (x++));
        Debug.Log("Dekrementoperator(x-- Minus eins):" + (x--));
    }

}
