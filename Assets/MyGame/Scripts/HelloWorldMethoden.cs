using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorldMethoden : MonoBehaviour
{
    private int startValue = 0;
    private int startValue3= 0;

    private int statValue4 = 10;

    //5 return

    private int startValue5 = 20;

    void Start()
    {
        Debug.Log("Hello Methode");
        Debug.Log("before Start" + startValue);
        InciByOne();
        Debug.Log("afer start Value" + startValue);
        

        //3

        Debug.Log("before startValue3" + startValue3);
        InciByX(Random.Range(1, 10));
        Debug.Log("after startValue3" + startValue3);


        //4
        Debug.Log("before startValue4" + statValue4);
        DecriByOne(statValue4);
        Debug.Log("after StartValue4" + statValue4);


        //5

        Debug.Log("before startValue5" + startValue5);
        DecriByX(startValue5, 2);
        Debug.Log("after StartValue5" + startValue5);
        
    }

    private void InciByOne()
    {
        startValue++;
    }

    private void InciByX(int valToAdd)
    {
        startValue3 += valToAdd;
    }

    private void DecriByOne(int val)
    {
        val++;
        Debug.Log("val" + val);
    }

    private int DecriByX(int start, int valToSub)
    {
        return start - valToSub;

    }
}
