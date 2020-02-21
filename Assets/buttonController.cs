using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Calculation3;

public class buttonController : MonoBehaviour
{
    public InputField num1;
    public InputField num2;
    public Text result;
    public Button addButton;
    public Button subButton;
    public Button mulButton;
    public Button divButton;

    // Start is called before the first frame update
    void Start()
    {
        addButton.onClick.AddListener(addition);
        subButton.onClick.AddListener(subtraction);
        mulButton.onClick.AddListener(multiplication);
        divButton.onClick.AddListener(division);

    }

    public void addition()
    {
        int a = int.Parse(num1.text);
        int b = int.Parse(num2.text);        
        Calculate cal = new Calculate();
        result.text = cal.Add(a, b).ToString();
    }

    public void subtraction()
    {
        int a = int.Parse(num1.text);
        int b = int.Parse(num2.text);        
        Calculate cal = new Calculate();
        result.text = cal.Sub(a, b).ToString();
    }

    public void multiplication()
    {
        int a = int.Parse(num1.text);
        int b = int.Parse(num2.text);
        Calculate cal = new Calculate();
        result.text = cal.Multiply(a, b).ToString();
    }

    public void division()
    {
        
        int a = int.Parse(num1.text);
        int b = int.Parse(num2.text);

        if (b == 0)
        {
            result.text = "Division not possible";
        }
        Calculate cal = new Calculate();
        result.text = cal.Divide(a, b).ToString();
    }

    // Update is called once per frame
    void Update()
    {   
    }
}
