using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorldMethoden : MonoBehaviour
{
    private int currentIncrementValue = 0;
    private int currentIncrementValue2 = 0;

    private int currentDecrementValue = 10;

    //5 return

    private int getDifference = 20;

    void Start()
    {
        Debug.Log("Hello Methode");
        Debug.Log("before Start" + currentIncrementValue);
        IncrementByOne();
        Debug.Log("afer start Value" + currentIncrementValue);


        //3

        Debug.Log("before currentValue3" + currentIncrementValue2);
        IncrementByValue(Random.Range(1, 10));
        Debug.Log("after currentValue3" + currentIncrementValue2);


        //4
        Debug.Log("before currentValue4" + currentDecrementValue);
        DecrementByOne(currentDecrementValue);
        Debug.Log("after currentValue4" + currentDecrementValue);


        //5

        Debug.Log("before currentValue5" + getDifference);
        DecrementByValue(getDifference, 2);
        Debug.Log("after currentValue5" + getDifference);

    }

    private void IncrementByOne()
    {
        currentIncrementValue++;
    }

    private void IncrementByValue(int increment)
    {
        currentIncrementValue2 += increment;
    }

    private void DecrementByOne(int currentValue)
    {
        currentValue--;
        Debug.Log("val" + currentValue);
    }

    private int DecrementByValue(int start, int decrement)
    {
        return start - decrement;

    }
}
