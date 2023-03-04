using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UX;
using TMPro;

public class FovCreater : MonoBehaviour
{
    public Camera camera; //For test FOV calculated correct
    public RectTransform canvas;
    public TextMeshProUGUI info;
    public float distance = 100;

    [Space]
    public int minFov=20, maxFov=80;

    [Space]
    public Slider H_slider;
    public TextMeshProUGUI display_Hfov;

    [Space]
    public Slider V_slider;
    public TextMeshProUGUI display_Vfov;

    private float Hfov, Vfov;
    private float currentRatio;
    private bool fixedRatio = false;
    private string currentRatio_text;

    public void Set_Hfov()
    {
        Hfov = ToRange(H_slider.Value, 0, 1, minFov, maxFov);
        display_Hfov.text = "Horizontal FOV: " + Hfov.ToString("f2") + "бу";
        if (fixedRatio)
        {
            Vfov = Hfov / currentRatio;
            display_Vfov.text = "Vertical FOV: " + Vfov.ToString("f2") + "бу";

            canvas.sizeDelta = new Vector2(Mathf.Tan(Hfov * Mathf.Deg2Rad / 2) * distance * 2.0f, Mathf.Tan(Vfov * Mathf.Deg2Rad / 2) * distance * 2.0f);
            float diagonalFOV = Mathf.Sqrt(Hfov * Hfov + Vfov * Vfov);
            info.text = "Aspect Ratio: " + currentRatio_text + "    Diagonal FOV: " + diagonalFOV.ToString("f2") + "бу";
        }
        else
        {
            canvas.sizeDelta = new Vector2(Mathf.Tan(Hfov * Mathf.Deg2Rad / 2) * distance * 2.0f, Mathf.Tan(Vfov * Mathf.Deg2Rad / 2) * distance * 2.0f);
            currentRatio = Hfov / Vfov;
            float diagonalFOV = Mathf.Sqrt(Hfov * Hfov + Vfov * Vfov);
            info.text = "Aspect Ratio: " + currentRatio.ToString("f2") + "    Diagonal FOV: " + diagonalFOV.ToString("f2") + "бу";
        }
    }
    public void Set_Vfov()
    {
        Vfov = ToRange(V_slider.Value, 0, 1, minFov, maxFov);
        display_Vfov.text = "Vertical FOV: " + Vfov.ToString("f2") + "бу";
        if (fixedRatio)
        {
            Hfov = Vfov * currentRatio;
            display_Hfov.text = "Horizontal FOV: " + Hfov.ToString("f2") + "бу";

            canvas.sizeDelta = new Vector2(Mathf.Tan(Hfov * Mathf.Deg2Rad / 2) * distance * 2.0f, Mathf.Tan(Vfov * Mathf.Deg2Rad / 2) * distance * 2.0f);
            float diagonalFOV = Mathf.Sqrt(Hfov * Hfov + Vfov * Vfov);
            info.text = "Aspect Ratio: " + currentRatio_text + "    Diagonal FOV: " + diagonalFOV.ToString("f2") + "бу";
        }
        else
        {
            canvas.sizeDelta = new Vector2(Mathf.Tan(Hfov * Mathf.Deg2Rad / 2) * distance * 2.0f, Mathf.Tan(Vfov * Mathf.Deg2Rad / 2) * distance * 2.0f);
            currentRatio = Hfov / Vfov;
            float diagonalFOV = Mathf.Sqrt(Hfov * Hfov + Vfov * Vfov);
            info.text = "Aspect Ratio: " + currentRatio.ToString("f2") + "    Diagonal FOV: " + diagonalFOV.ToString("f2") + "бу";
        }
        camera.fieldOfView = Vfov + 0.5f; //For test FOV calculated correct
    }
    public void SetRatio_11()
    {
        fixedRatio = true;
        currentRatio = 1.0f;
        currentRatio_text = "1:1";
        Set_Hfov();
    }
    public void SetRatio_43()
    {
        fixedRatio = true;
        currentRatio = 4.0f / 3.0f;
        currentRatio_text = "4:3";
        Set_Hfov();
    }
    public void SetRatio_169()
    {
        fixedRatio = true;
        currentRatio = 16.0f / 9.0f;
        currentRatio_text = "16:9";
        Set_Hfov();
    }
    public void SetRatio_free()
    {
        fixedRatio = false;
        Set_Hfov();
    }

    private float ToRange(float var, float input_start, float input_end, float output_start, float output_end)
    {
        return output_start + ((output_end - output_start) / (input_end - input_start)) * (var - input_start);
    }
}
