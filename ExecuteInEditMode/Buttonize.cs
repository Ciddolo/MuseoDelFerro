using UnityEngine;
using UnityEngine.UI;
using TMPro;

[ExecuteInEditMode]
public class Buttonize : MonoBehaviour
{
    public bool ButtonizeMe;
    public TMP_FontAsset Font;
    public Sprite BackBar;
    public Sprite GreenBar;
    public Sprite QuestionTag;
    public Sprite AnswerTag;
    public Sprite AnswerTagFlip;

    void Update()
    {
        if (ButtonizeMe)
        {
            int childCount = transform.childCount;

            for (int i = 0; i < childCount; i++)
            {
                for (int y = 0; y < 6; y++)
                {
                    if (y == 5)
                    {
                        transform.GetChild(i).transform.GetChild(y).gameObject.GetComponent<Image>().sprite = BackBar;
                        transform.GetChild(i).transform.GetChild(y).gameObject.GetComponent<Image>().color = Color.white;
                        transform.GetChild(i).transform.GetChild(y).gameObject.GetComponent<RectTransform>().localPosition = new Vector3(0.0f, 229.0f, 0.0f);
                        transform.GetChild(i).transform.GetChild(y).gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(1400.0f, 180.0f);
                        transform.GetChild(i).transform.GetChild(y).transform.GetChild(0).GetComponent<Image>().sprite = GreenBar;
                        transform.GetChild(i).transform.GetChild(y).transform.GetChild(0).GetComponent<Image>().color = Color.white;
                        transform.GetChild(i).transform.GetChild(y).transform.GetChild(0).GetComponent<RectTransform>().localPosition = new Vector3(-445.0f, 0.0f, 0.0f);
                        transform.GetChild(i).transform.GetChild(y).transform.GetChild(0).GetComponent<RectTransform>().sizeDelta = new Vector2(1100.0f, 80.0f);
                    }
                    else if (y == 0)
                    {
                        transform.GetChild(i).transform.GetChild(y).gameObject.GetComponent<Image>().sprite = QuestionTag;
                        transform.GetChild(i).transform.GetChild(y).gameObject.GetComponent<Image>().color = Color.white;
                        transform.GetChild(i).transform.GetChild(y).gameObject.GetComponent<RectTransform>().localPosition = new Vector3(0.0f, -8.5f, 0.0f);
                        transform.GetChild(i).transform.GetChild(y).gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(1600.0f, 280.0f);
                        transform.GetChild(i).transform.GetChild(y).transform.GetChild(0).GetComponent<TextMeshProUGUI>().font = Font;
                        transform.GetChild(i).transform.GetChild(y).transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = Color.white;
                        transform.GetChild(i).transform.GetChild(y).transform.GetChild(0).GetComponent<TextMeshProUGUI>().fontStyle = FontStyles.SmallCaps;
                    }
                    else
                    {
                        transform.GetChild(i).transform.GetChild(y).transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().fontStyle = FontStyles.SmallCaps;
                        transform.GetChild(i).transform.GetChild(y).transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().font = Font;
                        transform.GetChild(i).transform.GetChild(y).transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().fontSize = 64.0f;
                        transform.GetChild(i).transform.GetChild(y).transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().alignment = TextAlignmentOptions.Center;
                        transform.GetChild(i).transform.GetChild(y).transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().color = Color.white;
                        transform.GetChild(i).transform.GetChild(y).gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(750.0f, 280.0f);

                        if (y == 1)
                        {
                            transform.GetChild(i).transform.GetChild(y).gameObject.GetComponent<Image>().sprite = AnswerTag;
                            transform.GetChild(i).transform.GetChild(y).gameObject.GetComponent<RectTransform>().localPosition = new Vector3(100.0f, -55.5f, 0.0f);
                        }
                        else if (y == 2)
                        {
                            transform.GetChild(i).transform.GetChild(y).gameObject.GetComponent<Image>().sprite = AnswerTagFlip;
                            transform.GetChild(i).transform.GetChild(y).gameObject.GetComponent<RectTransform>().localPosition = new Vector3(-100.0f, -55.5f, 0.0f);
                        }
                        else if (y == 3)
                        {
                            transform.GetChild(i).transform.GetChild(y).gameObject.GetComponent<Image>().sprite = AnswerTag;
                            transform.GetChild(i).transform.GetChild(y).gameObject.GetComponent<RectTransform>().localPosition = new Vector3(100.0f, 20.0f, 0.0f);
                        }
                        else
                        {
                            transform.GetChild(i).transform.GetChild(y).gameObject.GetComponent<Image>().sprite = AnswerTagFlip;
                            transform.GetChild(i).transform.GetChild(y).gameObject.GetComponent<RectTransform>().localPosition = new Vector3(-100.0f, 20.0f, 0.0f);
                        }
                    }
                }
            }

            ButtonizeMe = false;
        }
    }
}
