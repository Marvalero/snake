using UnityEngine;

public static class DataController
{
    private const string VulvaTypeKey = "vulvatype";

    public static void SetVulvaType(int intValue, bool saveImmediately)
    {
        PlayerPrefs.SetInt(VulvaTypeKey, intValue);
        if (saveImmediately) { Save(); }
    }

    public static int GetVulvaType ()
    {
        int intValue = PlayerPrefs.GetInt(VulvaTypeKey);
        return intValue;
    }

    public static bool HasKey(string key)
    {
        return PlayerPrefs.HasKey(key);
    }

    public static void DeleteAll()
    {
        PlayerPrefs.DeleteAll();
    }

    public static void DeleteKey(string key)
    {
        PlayerPrefs.DeleteKey(key);
    }

    #region private
    private static void Save()
    {
        PlayerPrefs.Save();
    }
    #endregion
}
