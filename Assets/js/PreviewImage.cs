using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PreviewImage : MonoBehaviour {

    public Camera _camera;
    public GameObject previewPanel;
    public Image _image;
    
    private Rect rect;
    // Use this for initialization
    void Start () {
        rect = new Rect(0, 0, Screen.width, Screen.height);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void CaptureShot()
    {
        StartCoroutine(Shot());
    }

    IEnumerator Shot()
    {
        yield return new WaitForEndOfFrame();
        RenderTexture rt = new RenderTexture((int)rect.width, (int)rect.height, 0);
        _camera.targetTexture = rt;
        _camera.Render();
        RenderTexture.active = rt;
        Texture2D t2d = new Texture2D((int)rect.width, (int)rect.height, TextureFormat.RGB24, false);
        t2d.ReadPixels(rect, 0, 0);
        t2d.Apply();        
        _image.sprite = Sprite.Create(t2d, rect, new Vector2(0.5f, 0.5f));
        _camera.targetTexture = null;
        RenderTexture.active = null;
        Destroy(rt);
        previewPanel.SetActive(true);
    }

    public void Back()
    {
        previewPanel.SetActive(false);
    }

    public void Share()
    {

    }
}
