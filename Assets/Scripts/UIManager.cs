using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    private UIDocument uiDocument;

    private void Start()
    {
        // Find the UIDocument in the scene
        uiDocument = GetComponent<UIDocument>();

        // Ensure the UIDocument is found
        if (uiDocument != null)
        {
            // Find the root VisualElement of the UIDocument
            VisualElement root = uiDocument.rootVisualElement;

            // Find the start button VisualElement by name
            Button buttonStart = root.Q<Button>("ButtonStart");

            // Attach a click event listener to the start button
            buttonStart.RegisterCallback<ClickEvent>(evt => StartGame());

            // Find the quit button VisualElement by name
            Button buttonQuit = root.Q<Button>("ButtonQuit");

            // Attach a click event listener to the quit button
            buttonQuit.RegisterCallback<ClickEvent>(evt => QuitGame());
        }
        else
        {
            Debug.LogError("UIDocument not found.");
        }
    }

    // Function to start the game
    private void StartGame()
    {
        // Load the "Main" scene
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main");
    }

    // Function to quit the application
    private void QuitGame()
    {
        // Quit the application
        Application.Quit();
    }
}