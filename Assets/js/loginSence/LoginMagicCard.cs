using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoginMagicCard : MonoBehaviour {

    public GameObject firstPanel;
    public GameObject loadingPanel;
    public UISlider slider;
    public UILabel label;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void PressButton()
    {
        firstPanel.SetActive(false);
        loadingPanel.SetActive(true);
        StartCoroutine(StartLoadingScene());
    }

    IEnumerator StartLoadingScene()
    {
        int displayProgress = 0;
        int toProgress = 0;
        AsyncOperation op = SceneManager.LoadSceneAsync(1);
        op.allowSceneActivation = false;
        while (op.progress < 0.9f)
        {
            toProgress = (int)op.progress * 100;
            while (displayProgress < toProgress)
            {
                ++displayProgress;
                UpdatePrgress(displayProgress);
                yield return new WaitForEndOfFrame();
            }
        }

        toProgress = 100;
        while (displayProgress < toProgress)
        {
            ++displayProgress;
            UpdatePrgress(displayProgress);
            yield return new WaitForEndOfFrame();
        }
        op.allowSceneActivation = true;
    }

    private void UpdatePrgress(int progress)
    {
        slider.value = progress / 100.0f;
        label.text = progress + "%";
    }
}
