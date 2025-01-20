using UnityEngine;
using System.Collections.Generic;
using System;

public class LocalizationManager : MonoBehaviour
{
    public static LocalizationManager Instance { get; private set; }

    [SerializeField]
    private Language[] availableLanguages;

    private Language currentLanguage;
    public event Action OnLanguageChanged;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        if (availableLanguages != null && availableLanguages.Length > 0)
        {
            SetLanguage(availableLanguages[0]);
        }
        else
        {
            Debug.LogError("No available languages assigned in the LocalizationManager.");
        }
    }

    public void SetLanguage(Language language)
    {
        if (language == null)
        {
            Debug.LogError("Attempted to set a null language in LocalizationManager.");
            return;
        }

        // Force deserialization
        language.OnAfterDeserialize();

        currentLanguage = language;

        Debug.Log($"Language set to: {currentLanguage.languageName}");

        // Debug translations
        foreach (var translation in currentLanguage.translations)
        {
            Debug.Log($"Key: {translation.Key}, Value: {translation.Value}");
        }

        OnLanguageChanged?.Invoke();
    }

    public string GetTranslation(string key)
    {
        if (currentLanguage == null)
        {
            Debug.LogError("No language is currently set in LocalizationManager.");
            return $"Missing translation: {key}";
        }

        if (!currentLanguage.translations.ContainsKey(key))
        {
            Debug.LogWarning($"Translation for key '{key}' is missing in the current language '{currentLanguage.languageName}'.");
            return $"Missing translation: {key}";
        }

        return currentLanguage.translations[key];
    }

    public Language[] GetAvailableLanguages()
    {
        return availableLanguages;
    }

    public Language GetCurrentLanguage()
    {
        return currentLanguage;
    }
}
