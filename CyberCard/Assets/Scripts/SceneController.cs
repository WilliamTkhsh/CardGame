using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    private Scene currentScene;
    private Scene deckScene;
    public GameObject deck;

    public void Start()
    {
        currentScene = SceneManager.GetSceneByName("CenaEditor");
        deckScene = SceneManager.GetSceneByName("DeckEditor");
    }
    public void MoveToDeckScene()
    {
        StartCoroutine(LoadYourAsyncScene());
    }
    IEnumerator LoadYourAsyncScene()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("DeckEditor", LoadSceneMode.Additive);

        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        SceneManager.MoveGameObjectToScene(deck, deckScene);

        SceneManager.UnloadSceneAsync(currentScene);
    }
}
