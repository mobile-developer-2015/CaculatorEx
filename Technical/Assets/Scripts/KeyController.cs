using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class KeyController : MonoBehaviour
{
    public KeyType keyType;
    public Text keyText;
    public string keyContent;

    private void ChangeKeyText()
    {
        keyText.text = keyContent;
    }

    public void OnKeyPressed()
    {
        switch (keyType)
        {
            case KeyType.NUMBER_KEY: case KeyType.OPERATOR_KEY: case KeyType.CHARACTER_KEY: case KeyType.FUNC_KEY:
                {
                    if (keyContent.Equals("="))
                    {
                        //Thuc hien phep tinh
                    }
                    else
                    {
                        AppController.Instance.resultController.Add(keyContent);
                        AppController.Instance.resultController.Show();
                    }
                    break;

                }
            case KeyType.APPFUNC_KEY:
                {
                    switch (keyContent)
                    {
                        case "SHIFT":
                            {
                                break;
                            }
                        case "ON":
                            {
                                break;
                            }
                        case "OFF":
                            {
                                break;
                            }
                    }
                    break;
                }
        }
    }


}
