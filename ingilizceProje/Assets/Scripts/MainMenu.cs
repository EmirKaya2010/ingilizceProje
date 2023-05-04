using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LoadVocabularyScene()
    {
        SceneManager.LoadScene("VocabularyScene");
    }
    public void LoadListeningScene()
    {
        SceneManager.LoadScene("ListeningScene");
    }
    public void LoadWritingScene()
    {
        SceneManager.LoadScene("WritingScene");
    }
    public void LoadReadingScene()
    {
        SceneManager.LoadScene("ReadingScene");
    }
    public void LoadGrammarScene()
    {
        SceneManager.LoadScene("GrammarScene");
    }
    public void LoadBlankScene()
    {
        SceneManager.LoadScene("BlankScene");
    }
    public void LoadTestScene()
    {
        SceneManager.LoadScene("TestScene");
    }
}