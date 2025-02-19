using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Excercise : MonoBehaviour
{

    public InputField inputfield1;
    public InputField inputfield2;
    public Text resultText;

    public void CompareNumbers()
    {
        if (float.TryParse(inputfield1.text, out float number1)
            && float.TryParse(inputfield2.text, out float number2)) 
        {
            if(number1 > number2)
            {
                resultText.text = "First Number is Greater";
            } else if (number1 < number2)
            {
                resultText.text = "Second Number is Greater";
            }
            else
            {
                resultText.text = "Both are equal";
            }
        }
        else
        {
            resultText.text = "Please Enter Valid Number";
        }


        {








        }
    }
}
