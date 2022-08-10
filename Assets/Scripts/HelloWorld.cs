using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{

    [SerializeField] MyVector myFirstVector = new MyVector(2, 3);
    [SerializeField] MyVector mySecondVector = new MyVector(3, 4);
    [Range(0, 1)][SerializeField] float scalar = 0;

    private void Update()
    {

        //MyVector diff = (mySecondVector - myFirstVector) * scalar;
        MyVector diff = (mySecondVector  - myFirstVector);
        MyVector final = myFirstVector + diff;


        myFirstVector.Draw(Color.red);
        mySecondVector.Draw(myFirstVector, Color.green);
        diff.Draw(Color.yellow);
        diff.Draw(mySecondVector, Color.yellow);
        final.Draw(Color.blue);
    }
}

  
