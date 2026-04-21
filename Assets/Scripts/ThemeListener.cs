using UnityEngine;
[System.Serializable]

/// <summary>
/// 
/// </summary>
public abstract class ThemeListener
{
    virtual public void OnEnable()
    {
        ThemeManager.OnThemeChanged += ApplyTheme;
    }
    virtual public void OnDisable()
    {
        ThemeManager.OnThemeChanged -= ApplyTheme;
    }
    abstract public void ApplyTheme();
}
