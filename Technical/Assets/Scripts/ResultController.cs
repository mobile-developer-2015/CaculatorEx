using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ResultController : MonoBehaviour {

    public Text resultText;
    public System.Text.StringBuilder resultValue;
    public int indexOfCharacter;
    //
    private float timeSpeed = 0.2f;
    private float timeCurrent = 0.0f;

    void Start()
    {
        resultValue = new System.Text.StringBuilder();
        resultValue.Insert(resultValue.Length, ".");
    }

    public void Show()
    {
        resultText.text = resultValue.ToString();
    }

    public void Add(string character)
    {
        resultValue.Insert(resultValue.Length - 1,character);
    }

    public void Clear()
    {
        resultText.text = "";
    }

    void Update()
    {
        timeCurrent += Time.deltaTime;
        if (timeCurrent >= timeSpeed)
        {
            timeCurrent = 0.0f;
            resultValue.Replace('.', '|', resultValue.Length - 1, 1);
            this.Show();
        }
        else
        {
            resultValue.Replace('|', '.', resultValue.Length - 1, 1);
            this.Show();
        }
    }
}
