using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class AsyncLoadScene : MonoBehaviour
{
    [SerializeField]
    Text HelpText_UI;
    [SerializeField]
    [TextArea]
    string[] helpText;

    [SerializeField]
    private Text m_Text;

    void Start()
    {
        LoadScene();
        ShowHelptext();
    }

    void ShowHelptext()
    {
        StartCoroutine(Show());
    }

    void LoadScene()
    {       
        StartCoroutine(Load());
    }

    IEnumerator Show()
    {
        while (true)
        {
            //show random helptext
            HelpText_UI.text = helpText[Random.Range(0, helpText.Length)];
            yield return new WaitForSeconds(3.0f);
        }
    }

    IEnumerator Load()
    {
        yield return null;

        //Begin to load the Scene you specify
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync("MainScene");
        //Don't let the Scene activate until you allow it to
        asyncOperation.allowSceneActivation = false;
        Debug.Log("Pro :" + asyncOperation.progress);
        //When the load is still in progress, output the Text and progress bar
        while (!asyncOperation.isDone)
        {
            //Output the current progress
            m_Text.text = "Loading progress: " + (asyncOperation.progress * 100) + "%";

            // Check if the load has finished
            if (asyncOperation.progress >= 0.9f)
            {
                //Change the Text to show the Scene is ready
                m_Text.text = "Press the space bar to continue";
                //Activate the Scene
                yield return new WaitForSeconds(7.0f);
                asyncOperation.allowSceneActivation = true;
            }

           
        }
    }
}
