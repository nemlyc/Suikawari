using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerGageHandler : MonoBehaviour
{
    [SerializeField]
    Image gageImage;

    [SerializeField]
    GameObject gagePrefab;

    readonly Color low = new Color(0.3f, 0.4f, 0.9f);
    readonly Color mid = new Color(0.3f, 0.9f, 0.4f);
    readonly Color high = new Color(0.9f, 0.4f, 0.3f);

    [SerializeField]
    float lowValue, midValue, highValue;

    bool ReverseFlag;
    bool isRunning = false;

    // Start is called before the first frame update
    void Start()
    {
        gagePrefab.SetActive(false);
        ReverseFlag = true;
        gageImage.fillAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (isRunning)
        {
            if (ReverseFlag)
            {
                IncreaceGage();
            } else
            {
                DecreaceGage();
            }

            if (gageImage.fillAmount >= 1 || gageImage.fillAmount <= 0)
            {
                ReverseFlag = !ReverseFlag;
            }

            ChangeColor(gageImage.fillAmount);

        }
    }

    public float GetGageValue()
    {
        return gageImage.fillAmount;
    }
    public void StartGage()
    {
        gagePrefab.SetActive(true);
        isRunning = true;
    }

    public void StopGage()
    {
        isRunning = false;
    }

    public void DeactivateGage()
    {
        gagePrefab.SetActive(false);
    }

    void IncreaceGage()
    {
        gageImage.fillAmount += Time.deltaTime;
    }

    void DecreaceGage()
    {
        gageImage.fillAmount -= Time.deltaTime;
    }

    void ChangeColor(float value)
    {
        gageImage.color = high;
        //if (value > midValue)
        //{
        //    gageImage.color = mid;
        //    if (value > highValue)
        //    {
        //        gageImage.color = high;
        //    }
        //}
    }
}
