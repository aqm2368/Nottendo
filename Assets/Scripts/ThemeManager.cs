using System;
using System.ComponentModel;
using UnityEngine;

public class ThemeManager : MonoBehaviour
{
    public static ThemeManager Instance { get; private set;}
    public static ColorTheme currentTheme { get; private set; }
    public static event Action OnThemeChanged;

    void Awake()
    {
        if(Instance != null || Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    public static void SetInstance(ColorTheme theme)
    {
        
    }

    public static void SetTheme(ColorTheme theme)
    {
        currentTheme = theme;
        OnThemeChanged?.Invoke();
    }
}