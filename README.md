# Unity Editor Tool - Localization Editor

Welcome to the **Localization Editor Tool**, a custom Unity Editor tool for managing language localization in your Unity projects. This tool simplifies the process of adding, editing, and managing translations for in-game text, ensuring a seamless experience for multilingual audiences.

---

## Features

### Custom Editor Window
- Access the **Localization Editor** via `Window > Localization Editor` in the Unity Editor.
- Add new languages, keys, and translations directly from the editor.
- Edit or delete existing keys and translations effortlessly.

### Dynamic Localization System
- Real-time in-game language switching via a dropdown menu.
- Dynamically updates text elements in the game based on the selected language.

### Modular Data Storage
- Uses Unity's `ScriptableObject` to store key-value pairs for translations, ensuring easy scalability and modularity.

### UI Integration
- In-game text boxes linked to localization keys, demonstrating live language updates.
- A sample scene showcasing the functionality with phrases like "Hello", "Bye!", and "How are you?".

---

## How to Use

### In the Unity Editor
1. Open the **Localization Editor** window by navigating to `Window > Localization Editor`.
2. **Add a New Language**:
   - Enter the language name (e.g., Gujarati) and click "Create New Language".
3. **Add a New Translation**:
   - Enter a unique key and provide translations for all existing languages.
   - Click "Add Translation" to save.
4. **Edit Existing Translations**:
   - Modify translations in the existing list and save your changes.

### In the Sample Scene
1. Link the `LocalizationManager` in the hierarchy to the appropriate `ScriptableObject` asset.
2. Run the game and use the **dropdown menu** to switch between languages.
3. Watch text elements update dynamically to reflect the selected language.

---

## Development Highlights

### Requirements Fulfilled
- Custom Editor Window created using the Unity Editor API.
- `ScriptableObject` classes defined for managing multiple languages and keys.
- Consistent key management across all languages.
- A dynamic in-game language selection system for seamless localization.

### Tutorials Referenced
- [Localization Tool in Unity](https://www.youtube.com/watch?v=c-dzg4M20wY)
- [Dynamic Localization System](https://www.youtube.com/watch?v=E-PR0d0Jb5A)
---

## How to Contribute
Feel free to fork the repository and submit pull requests for improvements or additional features. Contributions are always welcome!

---

## Contact
For any questions or feedback, feel free to reach out to [Aarish Lakhani](https://github.com/aarishlakhani).
